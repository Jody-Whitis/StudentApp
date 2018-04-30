using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;
using System.Data.SqlClient;

namespace StudentApp_Windows_
{
    public partial class Maps : Form
    {
        public Maps()
        {
            InitializeComponent();
            txtBuilding.Text = "";
        }
       

        #region BuildingCoordinates
        PointLatLng utrgvBrownsville = new PointLatLng(25.8951, -97.4872);


        PointLatLng mainBuilding = new PointLatLng(25.8937, -97.4868);
        PointLatLng[] mainBuildingArea = new PointLatLng[4] {
            new PointLatLng(25.8934, -97.4874),new PointLatLng(25.8939, -97.4874),
            new PointLatLng(25.8940, -97.4862), new PointLatLng(25.8935, -97.4860) 
    };
        PointLatLng libary = new PointLatLng(25.8932, -97.4877);
        PointLatLng[] libaryArea = new PointLatLng[4] {
            new PointLatLng(25.8930, -97.4882),new PointLatLng(25.8932, -97.4882),
            new PointLatLng(25.8935, -97.4876), new PointLatLng(25.8931, -97.4876)
    };
        PointLatLng sabal = new PointLatLng(25.8928, -97.4878);
        PointLatLng[] sabalArea = new PointLatLng[4] {
            new PointLatLng(25.8926, -97.4881),new PointLatLng(25.8928, -97.4882),
            new PointLatLng(25.8929, -97.4876), new PointLatLng(25.8927, -97.4875)
    };
        PointLatLng recCenter = new PointLatLng(25.8932, -97.4909);
        PointLatLng[] recCenterArea = new PointLatLng[4] {
            new PointLatLng(25.8930, -97.4918),new PointLatLng(25.8938, -97.4910),
            new PointLatLng(25.8932, -97.4901), new PointLatLng(25.8925, -97.4911)
    };


        PointLatLng bookstore = new PointLatLng(25.8962, -97.4892);
        PointLatLng[] bookstoreArea = new PointLatLng[4] {
            new PointLatLng(25.8962, -97.4894),new PointLatLng(25.8964, -97.4893),
            new PointLatLng(25.8962, -97.4889), new PointLatLng(25.8959, -97.4891)
    };
        PointLatLng studentUnion = new PointLatLng(25.8960, -97.4880);
        PointLatLng[] studentUnionArea = new PointLatLng[4] {
            new PointLatLng(25.8957, -97.4884),new PointLatLng(25.8964, -97.4879),
            new PointLatLng(25.8962, -97.4876), new PointLatLng(25.8955, -97.4881)
    };


        PointLatLng lhsb = new PointLatLng(25.8964, -97.4872);
        PointLatLng[] lhsbArea = new PointLatLng[4] {
            new PointLatLng(25.8965, -97.4877),new PointLatLng(25.8967, -97.4872),
            new PointLatLng(25.8965, -97.4866), new PointLatLng(25.8961, -97.4871)
    };


        PointLatLng calvary = new PointLatLng(25.8965, -97.4886);
        PointLatLng[] calvaryArea = new PointLatLng[4] {
            new PointLatLng(25.8964, -97.4888),new PointLatLng(25.8969, -97.4884),
            new PointLatLng(25.8965, -97.4884), new PointLatLng(25.8963, -97.4887)
    };



        PointLatLng setB = new PointLatLng(25.8972, -97.4878);
        PointLatLng[] setBArea = new PointLatLng[6] {
            new PointLatLng(25.8969, -97.4883),
            new PointLatLng(25.8976,-97.4879),new PointLatLng(25.8979,-97.4883),new PointLatLng(25.8980, -97.4882),
            new PointLatLng(25.8974, -97.4873), new PointLatLng(25.8967, -97.4879)
    };


        PointLatLng rustenburg = new PointLatLng(25.8970, -97.4895);
        PointLatLng[] rustenburgArea = new PointLatLng[4] {
            new PointLatLng(25.8966, -97.4891),new PointLatLng(25.8971, -97.4899),
            new PointLatLng(25.8974, -97.4895), new PointLatLng(25.8967, -97.4887)
    };

        PointLatLng cortez = new PointLatLng(25.8976, -97.4890);
        PointLatLng[] cortezArea = new PointLatLng[4] {
            new PointLatLng(25.8972, -97.4888),new PointLatLng(25.8976, -97.4893),
            new PointLatLng(25.8979, -97.4892), new PointLatLng(25.8974, -97.4886)
    };

        PointLatLng biomedical = new PointLatLng(25.8955, -97.4860);
        PointLatLng[] biomedicalArea = new PointLatLng[4] {
            new PointLatLng(25.8955, -97.4864),new PointLatLng(25.8959, -97.4861),
            new PointLatLng(25.8956, -97.4856), new PointLatLng(25.8952, -97.4860)
    };

        PointLatLng regionacedemichealth = new PointLatLng(25.8970, -97.4869);
        PointLatLng[] regionacedemichealthArea = new PointLatLng[4] {
            new PointLatLng(25.8971, -97.4871),new PointLatLng(25.8974, -97.4869),
            new PointLatLng(25.8971, -97.4865), new PointLatLng(25.8968, -97.4869)
    };


        PointLatLng lhsbbiology = new PointLatLng(25.8960, -97.4867);
        PointLatLng[] lhsbbiologyArea = new PointLatLng[4] {
            new PointLatLng(25.8957, -97.4870),new PointLatLng(25.8963, -97.4866),
            new PointLatLng(25.8961, -97.4863), new PointLatLng(25.8956, -97.4869)
    };
        #endregion





        /*
          * bookbee
         * eidman
         * garza
         * gyn annex
         * music
         * 
         * */





        private void Maps_Load(object sender, EventArgs e)
        {
            gMap.MapProvider = GoogleMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            gMap.Position = utrgvBrownsville;
            gMap.Zoom = 15;
            gMap.ShowCenter = false;
 

            #region Polygons
            GMapOverlay mainPolygon = new GMapOverlay("mainPolygon");
            List<PointLatLng> points = new List<PointLatLng>();
            foreach(var coord in mainBuildingArea)
            {
            points.Add(coord);

            }

            GMapOverlay libaryPolygon = new GMapOverlay("libraryPolygon");
            List<PointLatLng> libaryPoints = new List<PointLatLng>();
            foreach (var coord in libaryArea)
            {
                libaryPoints.Add(coord);

            }

            GMapOverlay sabalPolygon = new GMapOverlay("sabalPolygon");
            List<PointLatLng> sabalPoints = new List<PointLatLng>();
            foreach (var coord in sabalArea)
            {
                sabalPoints.Add(coord);

            }

            GMapOverlay recPolygon = new GMapOverlay("recPolygon");
            List<PointLatLng> recPoints = new List<PointLatLng>();
            foreach (var coord in recCenterArea)
            {
                recPoints.Add(coord);

            }

            GMapOverlay bookstorePolygon = new GMapOverlay("bookstorePolygon");
            List<PointLatLng> bookstorePoints = new List<PointLatLng>();
            foreach (var coord in bookstoreArea)
            {
                bookstorePoints.Add(coord);

            }

            GMapOverlay studentUnionPolygon = new GMapOverlay("studentUnionPolygon");
            List<PointLatLng> studentUnionPoints = new List<PointLatLng>();
            foreach (var coord in studentUnionArea)
            {
                studentUnionPoints.Add(coord);

            }

            GMapOverlay lhsbPolygon = new GMapOverlay("lhsbPolygon");
            List<PointLatLng> lhsbPoints = new List<PointLatLng>();
            foreach (var coord in lhsbArea)
            {
                lhsbPoints.Add(coord);

            }

            GMapOverlay calvaryPolygon = new GMapOverlay("calvaryPolygon");
            List<PointLatLng> calvaryPoints = new List<PointLatLng>();
            foreach (var coord in calvaryArea)
            {
                calvaryPoints.Add(coord);

            }

            GMapOverlay setbPolygon = new GMapOverlay("setbPolygon");
            List<PointLatLng> setbPoints = new List<PointLatLng>();
            foreach (var coord in setBArea)
            {
                setbPoints.Add(coord);

            }

            GMapOverlay rustenburgPolygon = new GMapOverlay("rustenburgPolygon");
            List<PointLatLng> rustenburgPoints = new List<PointLatLng>();
            foreach (var coord in rustenburgArea)
            {
                rustenburgPoints.Add(coord);

            }

            GMapOverlay cortezPolygon = new GMapOverlay("cortezPolygon");
            List<PointLatLng> cortezPoints = new List<PointLatLng>();
            foreach (var coord in cortezArea)
            {
                cortezPoints.Add(coord);

            }

            GMapOverlay biomedicalPolygon = new GMapOverlay("biomedicalPolygon");
            List<PointLatLng> biomedicalPoints = new List<PointLatLng>();
            foreach (var coord in biomedicalArea)
            {
                biomedicalPoints.Add(coord);

            }

            GMapOverlay regionalacedmichealthPolygon = new GMapOverlay("regionalacedmichealthPolygon");
            List<PointLatLng> regionalacedmichealthPoints = new List<PointLatLng>();
            foreach (var coord in regionacedemichealthArea)
            {
                regionalacedmichealthPoints.Add(coord);

            }

            GMapOverlay lhsbbiologyPolygon = new GMapOverlay("lhsbbiologyPolygon");
            List<PointLatLng> lhsbbiologyhealthPoints = new List<PointLatLng>();
            foreach (var coord in lhsbbiologyArea)
            {
                lhsbbiologyhealthPoints.Add(coord);

            }


            GMapPolygon polygon = new GMapPolygon(points, "MAIN");
            mainPolygon.Polygons.Add(polygon);
            gMap.Overlays.Add(mainPolygon);
            polygon.Fill = new SolidBrush(Color.FromArgb(50,Color.Orange));
            polygon.Stroke = new Pen(Color.Orange);

            GMapPolygon libraryPolygon = new GMapPolygon(libaryPoints, "LIBRARY");
            libaryPolygon.Polygons.Add(libraryPolygon);
            gMap.Overlays.Add(libaryPolygon);
            polygon.Fill = new SolidBrush(Color.FromArgb(50, Color.Orange));
            polygon.Stroke = new Pen(Color.Orange);

            GMapPolygon SabalPolygon = new GMapPolygon(sabalPoints, "SABAL");
            sabalPolygon.Polygons.Add(SabalPolygon);
            gMap.Overlays.Add(sabalPolygon);
            polygon.Fill = new SolidBrush(Color.FromArgb(50, Color.Orange));
            polygon.Stroke = new Pen(Color.Orange);

            GMapPolygon recCenterPolygon = new GMapPolygon(recPoints, "REC");
            recPolygon.Polygons.Add(recCenterPolygon);
            gMap.Overlays.Add(recPolygon);
            polygon.Fill = new SolidBrush(Color.FromArgb(50, Color.Orange));
            polygon.Stroke = new Pen(Color.Orange);


            GMapPolygon bookStorePolygon = new GMapPolygon(bookstorePoints, "Bookstore");
            bookstorePolygon.Polygons.Add(bookStorePolygon);
            gMap.Overlays.Add(bookstorePolygon);
            polygon.Fill = new SolidBrush(Color.FromArgb(50, Color.Orange));
            polygon.Stroke = new Pen(Color.Orange);

            GMapPolygon StudentUnionPolygon = new GMapPolygon(studentUnionPoints, "Student Union");
            studentUnionPolygon.Polygons.Add(StudentUnionPolygon);
            gMap.Overlays.Add(studentUnionPolygon);
            polygon.Fill = new SolidBrush(Color.FromArgb(50, Color.Orange));
            polygon.Stroke = new Pen(Color.Orange);


            GMapPolygon LhsbPolygon = new GMapPolygon(lhsbPoints, "LHSB");
            lhsbPolygon.Polygons.Add(LhsbPolygon);
            gMap.Overlays.Add(lhsbPolygon);
            polygon.Fill = new SolidBrush(Color.FromArgb(40, Color.Orange));
            polygon.Stroke = new Pen(Color.Orange);

            GMapPolygon CalvaryPolygon = new GMapPolygon(calvaryPoints, "Calvary");
            calvaryPolygon.Polygons.Add(CalvaryPolygon);
            gMap.Overlays.Add(calvaryPolygon);
            polygon.Fill = new SolidBrush(Color.FromArgb(40, Color.Orange));
            polygon.Stroke = new Pen(Color.Orange);

            GMapPolygon SetbPolygon = new GMapPolygon(setbPoints, "SetB");
            setbPolygon.Polygons.Add(SetbPolygon);
            gMap.Overlays.Add(setbPolygon);
            polygon.Fill = new SolidBrush(Color.FromArgb(40, Color.Orange));
            polygon.Stroke = new Pen(Color.Orange);

            GMapPolygon RustenburgPolygon = new GMapPolygon(rustenburgPoints, "Rustenburg");
            rustenburgPolygon.Polygons.Add(RustenburgPolygon);
            gMap.Overlays.Add(rustenburgPolygon);
            polygon.Fill = new SolidBrush(Color.FromArgb(40, Color.Orange));
            polygon.Stroke = new Pen(Color.Orange);

            GMapPolygon CortezPolygon = new GMapPolygon(cortezPoints, "Cortez");
            cortezPolygon.Polygons.Add(CortezPolygon);
            gMap.Overlays.Add(cortezPolygon);
            polygon.Fill = new SolidBrush(Color.FromArgb(40, Color.Orange));
            polygon.Stroke = new Pen(Color.Orange);

            GMapPolygon BiomedicalPolygon = new GMapPolygon(biomedicalPoints, "Biomedical");
            biomedicalPolygon.Polygons.Add(BiomedicalPolygon);
            gMap.Overlays.Add(biomedicalPolygon);
            polygon.Fill = new SolidBrush(Color.FromArgb(40, Color.Orange));
            polygon.Stroke = new Pen(Color.Orange);

            GMapPolygon RegionalacedemicPolygon = new GMapPolygon(regionalacedmichealthPoints, "RegionalAcademic");
            regionalacedmichealthPolygon.Polygons.Add(RegionalacedemicPolygon);
            gMap.Overlays.Add(regionalacedmichealthPolygon);
            polygon.Fill = new SolidBrush(Color.FromArgb(40, Color.Orange));
            polygon.Stroke = new Pen(Color.Orange);

            GMapPolygon LhsbbiologyPolygon = new GMapPolygon(lhsbbiologyhealthPoints, "LhsbBiology");
            lhsbbiologyPolygon.Polygons.Add(LhsbbiologyPolygon);
            gMap.Overlays.Add(lhsbbiologyPolygon);
            polygon.Fill = new SolidBrush(Color.FromArgb(40, Color.Orange));
            polygon.Stroke = new Pen(Color.Orange);

            #endregion

            #region PINS

            GMapOverlay markets = new GMapOverlay("markers");
            GMapMarker marker = new GMarkerGoogle(mainBuilding,
                GMarkerGoogleType.orange);
            markets.Markers.Add(marker);
            marker.ToolTipText = "Main Building";
            marker.ToolTip.Stroke = Pens.Orange;
            gMap.Overlays.Add(markets);

            GMapOverlay markersLibrary = new GMapOverlay("markersLibrary");
            GMapMarker markerLibrary = new GMarkerGoogle(libary,
                GMarkerGoogleType.orange);
            markersLibrary.Markers.Add(markerLibrary);
            markerLibrary.ToolTipText = "Library\nThe Grid";
            markerLibrary.ToolTip.Stroke = Pens.Orange;
            gMap.Overlays.Add(markersLibrary);

            GMapOverlay markersSabal = new GMapOverlay("markersLibrary");
            GMapMarker markerSabal = new GMarkerGoogle(sabal,
                GMarkerGoogleType.orange);
            markersSabal.Markers.Add(markerSabal);
            markerSabal.ToolTipText = "Sabal";
            markerSabal.ToolTip.Stroke = Pens.Orange;
            gMap.Overlays.Add(markersSabal);


            GMapOverlay markersRec = new GMapOverlay("recCenter");
            GMapMarker markerRec = new GMarkerGoogle(recCenter,
                GMarkerGoogleType.orange);
            markersRec.Markers.Add(markerRec);
            markerRec.ToolTipText = "Rec Center";
            markerRec.ToolTip.Stroke = Pens.Orange;
            gMap.Overlays.Add(markersRec);



            GMapOverlay markersBookstore = new GMapOverlay("bookstore");
            GMapMarker markerBookstore = new GMarkerGoogle(bookstore,
                GMarkerGoogleType.orange);
            markersBookstore.Markers.Add(markerBookstore);
            markerBookstore.ToolTipText = "Bookstore\nStarbucks";
            markerBookstore.ToolTip.Stroke = Pens.Orange;
            gMap.Overlays.Add(markersBookstore);

            GMapOverlay markersstudentUnion = new GMapOverlay("studentUnion");
            GMapMarker markerstudentUnion = new GMarkerGoogle(studentUnion,
                GMarkerGoogleType.orange);
            markersstudentUnion.Markers.Add(markerstudentUnion);
            markerstudentUnion.ToolTipText = "Student Union\nComedor";
            markerstudentUnion.ToolTip.Stroke = Pens.Orange;
            gMap.Overlays.Add(markersstudentUnion);

            GMapOverlay markerslhsb = new GMapOverlay("lhsb");
            GMapMarker markerlhsb = new GMarkerGoogle(lhsb,
                GMarkerGoogleType.orange);
            markerslhsb.Markers.Add(markerlhsb);
            markerlhsb.ToolTipText = "LHSB";
            markerlhsb.ToolTip.Stroke = Pens.Orange;
            gMap.Overlays.Add(markerslhsb);

            GMapOverlay markerscalvary = new GMapOverlay("calvary");
            GMapMarker markercalvary = new GMarkerGoogle(calvary,
                GMarkerGoogleType.orange);
            markerscalvary.Markers.Add(markercalvary);
            markercalvary.ToolTipText = "Calvary";
            markercalvary.ToolTip.Stroke = Pens.Orange;
            gMap.Overlays.Add(markerscalvary);


            GMapOverlay markerssetb = new GMapOverlay("setb");
            GMapMarker markersetb = new GMarkerGoogle(setB,
                GMarkerGoogleType.orange);
            markerssetb.Markers.Add(markersetb);
            markersetb.ToolTipText = "SetB";
            markersetb.ToolTip.Stroke = Pens.Orange;
            gMap.Overlays.Add(markerssetb);

            GMapOverlay markersrustenburg= new GMapOverlay("rustenburg");
            GMapMarker markerrustenburg = new GMarkerGoogle(rustenburg,
                GMarkerGoogleType.orange);
            markersrustenburg.Markers.Add(markerrustenburg);
            markerrustenburg.ToolTipText = "Rustenburg";
            markerrustenburg.ToolTip.Stroke = Pens.Orange;
            gMap.Overlays.Add(markersrustenburg);

            GMapOverlay markerscortez = new GMapOverlay("cortez");
            GMapMarker markercortez = new GMarkerGoogle(cortez,
                GMarkerGoogleType.orange);
            markerscortez.Markers.Add(markercortez);
            markercortez.ToolTipText = "Cortex";
            markercortez.ToolTip.Stroke = Pens.Orange;
            gMap.Overlays.Add(markerscortez);

            GMapOverlay markersbiomedical = new GMapOverlay("biomedical");
            GMapMarker markerbiomedical = new GMarkerGoogle(biomedical,
                GMarkerGoogleType.orange);
            markersbiomedical.Markers.Add(markerbiomedical);
            markerbiomedical.ToolTipText = "Biomedical";
            markerbiomedical.ToolTip.Stroke = Pens.Orange;
            gMap.Overlays.Add(markersbiomedical);

            GMapOverlay markersregionalacademic = new GMapOverlay("regionalacademic");
            GMapMarker markerregionalacademic = new GMarkerGoogle(regionacedemichealth,
                GMarkerGoogleType.orange);
            markersregionalacademic.Markers.Add(markerregionalacademic);
            markerregionalacademic.ToolTipText = "Regional Academic Health";
            markerregionalacademic.ToolTip.Stroke = Pens.Orange;
            gMap.Overlays.Add(markersregionalacademic);

            GMapOverlay markerslhsbbiology = new GMapOverlay("lhsbbiology");
            GMapMarker markerlhsbbiology = new GMarkerGoogle(lhsbbiology,
                GMarkerGoogleType.orange);
            markerslhsbbiology.Markers.Add(markerlhsbbiology);
            markerlhsbbiology.ToolTipText = "LHSB Biology";
            markerlhsbbiology.ToolTip.Stroke = Pens.Orange;
            gMap.Overlays.Add(markerslhsbbiology);
            #endregion





        }


         

        private void gMap_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            txtBuilding.Text = item.ToolTipText;
            Console.WriteLine("Building " + item.ToolTipText);
          

            try
            {

            using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=
C:\Users\Jcomp\Documents\College\Senior Project\StudentApp(Windows)\StudentApp(Windows)\StudentApp.mdf;Integrated Security=True"))
            {




               
                SqlCommand userMatch = new SqlCommand("INSERT INTO [AppointmentTable] (aId,name,sid) VALUES (@aid,@name,@sid)", conn);
                conn.Open();
                userMatch.Parameters.AddWithValue("@name", txtBuilding.Text);
                userMatch.Parameters.AddWithValue("@sid", CurrentUser.Sid);
                userMatch.Parameters.AddWithValue("@aid", 4);
                userMatch.ExecuteNonQuery();
                MessageBox.Show(CurrentUser.Fname + " "+ CurrentUser.Lname + "SAVED at " +  item.ToolTipText );

                conn.Close();

                    Appointment appointment = new Appointment();
                    appointment.Tag = this;

                    appointment.Show(this);
                    Hide();

                }
            }
            catch(Exception ex)
            {


                using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename
=C:\Users\Jcomp\Documents\College\Senior Project\StudentApp(Windows)\StudentApp(Windows)\StudentApp.mdf;Integrated Security=True"))
                {
                    SqlCommand userMatch = new SqlCommand("UPDATE [AppointmentTable] SET name=@name, sid=@sid WHERE aId = @aid", conn);
                    conn.Open();
                    userMatch.Parameters.AddWithValue("@name", txtBuilding.Text);
                    userMatch.Parameters.AddWithValue("@sid", CurrentUser.Sid);
                    userMatch.Parameters.AddWithValue("@aid", 4);
                    SqlDataReader reader = userMatch.ExecuteReader();

                    conn.Close();
                    Appointment appointment = new Appointment();
                    appointment.Tag = this;

                    appointment.Show(this);
                    Hide();
                }
             

             }




        }

        private void gMap_OnPolygonClick(GMapPolygon item, MouseEventArgs e)
        {
            txtBuilding.Text = item.Name;
            Console.WriteLine("Building from Polygon: " + item.Name);
        }

        private void gMap_OnPolygonEnter(GMapPolygon item)
        {
            txtBuilding.Text = item.Name;
           
        }

        private void btnBack_Click(object sender, EventArgs e)
        {   
            HomePage home = new HomePage();
            home.Tag = this;

            home.Show(this);
            Hide();
         
        }
    }
}
