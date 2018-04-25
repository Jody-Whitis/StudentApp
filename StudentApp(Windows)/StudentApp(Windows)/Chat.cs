using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentApp_Windows_
{
    public partial class Chat : Form
    {

        UdpClient udpClient;
        Random sRan = new Random();
        int newSocket;
        string homeIP;

        string friendName;
        string friendlastName;
        string friendIP;
        int friendPort;

        public Chat()
        {
            InitializeComponent();




        }

        private void Chat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentAppDataSet.StudentTable' table. You can move, or remove it, as needed.
            this.studentTableTableAdapter.Fill(this.studentAppDataSet.StudentTable);

            newSocket = sRan.Next(1030, 65000);
            CurrentUser.NewPort = newSocket;
            txtNewSocket.Text = newSocket.ToString();
          
            homeIP = GetLocalIP();
            IPSocketDatabase(homeIP, newSocket, CurrentUser.Sid);
            Listening();

        }

        public string GetLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {

                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    homeIP = ip.ToString();
                    return ip.ToString();

                }
            }


            //return "127.0.01";
            return string.Empty;
        }

        public async void Listening()
        {

            udpClient = new UdpClient(newSocket);

            while (true)
            {
                var result = await udpClient.ReceiveAsync();


                var message = Encoding.ASCII.GetString(result.Buffer);
                string[] ops = new string[4];
                ops = message.Split('/');
                lstMessage.Items.Add("Friend: " + ops[0]+"\n");


                
 
            }
        }

        public void IPSocketDatabase(string ip,int port,int sid)
        {

            try
            {
            using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename
=C:\Users\Jcomp\Documents\College\Senior Project\StudentApp(Windows)\StudentApp(Windows)\StudentApp.mdf;Integrated Security=True"))
            {
                SqlCommand userMatch = new SqlCommand("INSERT INTO [NetworkTable] (sId,portNumber,ipAddress) VALUES (@sid,@port,@ip)", conn);
                conn.Open();
                userMatch.Parameters.AddWithValue("@ip",ip);
                userMatch.Parameters.AddWithValue("@sid", sid);
                userMatch.Parameters.AddWithValue("@port", port);
                SqlDataReader reader = userMatch.ExecuteReader();
                 
                conn.Close();

            }

            }
            catch(Exception ex)
            {


                using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename
=C:\Users\Jcomp\Documents\College\Senior Project\StudentApp(Windows)\StudentApp(Windows)\StudentApp.mdf;Integrated Security=True"))
                {
                    SqlCommand userMatch = new SqlCommand("UPDATE [NetworkTable] SET portNumber=@port, ipAddress=@ip WHERE sId = @sid", conn);
                    conn.Open();
                    userMatch.Parameters.AddWithValue("@ip", ip);
                    userMatch.Parameters.AddWithValue("@sid", sid);
                    userMatch.Parameters.AddWithValue("@port", port);
                    SqlDataReader reader = userMatch.ExecuteReader();

                    conn.Close();

                }
                Console.WriteLine("UPDATED PORT for" + CurrentUser.Fname);
            }



        }

        public void StartSending(object sender, EventArgs e)
        {
            try
            {
                System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
                byte[] msg = new byte[1500];
               // string totalmsg = "/" + ipHost.Text + "/" + socketNumber.Text;


                msg = enc.GetBytes(txtSendMessage.Text/*+ totalmsg*/);
               
                udpClient.Send(msg, msg.Length, homeIP, Convert.ToInt32(txtSocketSend.Text));
                lstMessage.Items.Add("YOU: " + txtSendMessage.Text+"\n");
                txtSendMessage.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            HomePage home = new HomePage();
            home.Tag = this;

            home.Show(this);
            Hide();

        }


        private string SearchFriendIP(string friendName,string friendLastnames)
        {

            using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename
=C:\Users\Jcomp\Documents\College\Senior Project\StudentApp(Windows)\StudentApp(Windows)\StudentApp.mdf;Integrated Security=True"))
            {
                SqlCommand userMatch = new SqlCommand("SELECT s.id,s.firstname,s.lastname,n.ipAddress FROM StudentTable s INNER JOIN NetworkTable n ON " +
                    "n.sid= s.id WHERE s.firstname = @firstName AND s.lastname = @lastname", conn);
                conn.Open();
                userMatch.Parameters.AddWithValue("@firstname", friendName);
                userMatch.Parameters.AddWithValue("@lastname", friendLastnames);

                SqlDataReader reader = userMatch.ExecuteReader();
                 while (reader.Read())
                {
                   friendIP = reader[3].ToString();
                }

                conn.Close();

            }
            Console.WriteLine("FRIENDS IP: " + friendIP);
            return friendIP;
        }


        private int SearchFriendPort(string friendName,string friendlastNames)
        {

            using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename
=C:\Users\Jcomp\Documents\College\Senior Project\StudentApp(Windows)\StudentApp(Windows)\StudentApp.mdf;Integrated Security=True"))
            {
                SqlCommand userMatch = new SqlCommand("SELECT s.id,s.firstname,s.lastname,n.portNumber FROM StudentTable s INNER JOIN NetworkTable n ON n.sid = s.id WHERE s.firstname = @firstName AND s.lastname = @lastname", conn);
                conn.Open();
                userMatch.Parameters.AddWithValue("@firstname", friendName);
                userMatch.Parameters.AddWithValue("@lastname", friendlastNames);

                SqlDataReader reader = userMatch.ExecuteReader();
 
                while (reader.Read())
                {
                   friendPort =  Convert.ToInt32(reader[3]);
                }

                conn.Close();
                Console.WriteLine("FRIENDS PORT: " + friendPort.ToString());
            }

            return friendPort;

         }
        
        private void lstMessage_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in gdNames.SelectedRows)
            {
                friendName = row.Cells[0].Value.ToString();
                friendlastName = row.Cells[1].Value.ToString();
                friendIP = SearchFriendIP(friendName,friendlastName);
                friendPort = SearchFriendPort(friendName,friendlastName);

                Console.WriteLine(friendName + " " + friendlastName + "SELECED");
            }


            txtIP.Text = friendIP;
            txtSocketSend.Text = friendPort.ToString();
        }
    }
}
