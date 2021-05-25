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
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace WindowsFormsApp1.Формы
{
    public partial class FormMap : Form
    {
        public FormMap()
        {
            InitializeComponent();
            Map();
        }
        private void Map()
        {
            gMapControl1.ShowCenter = false;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(53.6853984, 23.8377546);
            gMapControl1.MinZoom = 5;
            gMapControl1.MaxZoom = 100;
            gMapControl1.Zoom = 13;
            PointLatLng point1 = new PointLatLng(53.671150, 23.801034);
            PointLatLng point2 = new PointLatLng(53.6913889, 23.8255557);
            PointLatLng point3 = new PointLatLng(53.6828228, 23.8355456);
            PointLatLng point4 = new PointLatLng(53.6749424, 23.8480601);          
            GMapMarker marker1 = new GMarkerGoogle(point1, GMarkerGoogleType.blue);
            GMapMarker marker2 = new GMarkerGoogle(point2, GMarkerGoogleType.blue);
            GMapMarker marker3 = new GMarkerGoogle(point3, GMarkerGoogleType.blue);
            GMapMarker marker4 = new GMarkerGoogle(point4, GMarkerGoogleType.blue);
            GMapOverlay markers = new GMapOverlay("markers");
            markers.Markers.Add(marker1);
            markers.Markers.Add(marker2);
            markers.Markers.Add(marker3);
            markers.Markers.Add(marker4);          
            gMapControl1.Overlays.Add(markers);
        }
        private void FormMultfilm_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
        }

       
    }
}
