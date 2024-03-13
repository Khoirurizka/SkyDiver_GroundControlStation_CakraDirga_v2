using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET.WindowsForms;
using GMap.NET.MapProviders;
using GMap.NET;
using System.Drawing.Drawing2D;

namespace SkyDiver_GCS
{
    public partial class HomePanel : Form
    {
        CompassPOV compassPOV = new CompassPOV();
        Altimeter altimeter = new Altimeter();
        Gyro gyro = new Gyro();
       // StreamVar. += ChangeVideoDir;

        public HomePanel()
        {
            DoubleBuffered = true;

            InitializeComponent();
            InitializePanelSpliter();
            InitializeVarComponent();
            MapSystem.RefreshGmapOverlay += RefreshMap;

            MapSystem.InitializeMap(gMap,MapScaler,2,20,15,cbMapMode,1);
            MapSystem.GoToLatLang(gMap, MapsVar.InitializeMap);

            toolTip.SetToolTip(this.cbMapMode, "Map Mode");
            toolTip.SetToolTip(this.tbLatitude, "Latitude");
            toolTip.SetToolTip(this.tbLongitude, "Langitude");
            toolTip.SetToolTip(this.btnFindLoc, "Find location by coordinate");
            toolTip.SetToolTip(this.btnFindPlane, "Find plane");

            gMap.Overlays.Add(MapSystem.vehicle);
            gMap.Overlays.Add(MapSystem.flightZoneArea);
            gMap.Overlays.Add(MapSystem.flightZoneNode);
            gMap.Overlays.Add(MapSystem.waypointRoutes);
            gMap.Overlays.Add(MapSystem.waypointNode);
            gMap.Overlays.Add(MapSystem.vehicle);
            gMap.Overlays.Add(MapSystem.flightZoneArea);
            gMap.Overlays.Add(MapSystem.flightZoneNode);
            gMap.Overlays.Add(MapSystem.dropingZoneArea);
            gMap.Overlays.Add(MapSystem.dropingZoneNode);
            gMap.Overlays.Add(MapSystem.DpointNode);
            gMap.Overlays.Add(MapSystem.PpointNode);

            checkedListMarkerMap.Items.Clear();
            checkedListMarkerMap.Items.AddRange(MapsVar.MarkerType);
            InitualizeCheckedListMarkerMap();
        }

        private void cbMapType_SelectedIndexChanged(object sender, EventArgs e)
        {
            MapSystem.SelectMapMode(gMap, cbMapMode.SelectedIndex);
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            MapSystem.GoToLatLangTextBox(gMap, tbLatitude, tbLongitude);
        }
        private void gMap_MouseMove(object sender, MouseEventArgs e)
        {
            MapSystem.CursorLatLangToLabelText(gMap, MouseMapLatLangRaw, e);
        }
        private void MapScaler_ValueChanged(object sender, EventArgs e)
        {
            MapSystem.ZoomMap(gMap, MapScaler.Value);
        }
        private void gMap_OnMapZoomChanged()
        {
            MapSystem.ScalerMapGetZoomVal(gMap, MapScaler);
        }
        private void streamVideo_Paint(object sender, PaintEventArgs e)
        {
        }
        private void videoSourcePlayer_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.Clear(BackColor);

            DoubleBuffered = true;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Point compassPOVPosition = new Point(streamVideo.Width / 2, 15);//PositionOnCenterPoint
            Point altimeterPosition = new Point(streamVideo.Width - 50, streamVideo.Height / 2);//PositionOnCenterPoint
            Point gyroPosition = new Point(80, streamVideo.Height - 80);//PositionOnCenterPoint

            compassPOV.BG(e.Graphics, compassPOVPosition, streamVideo.Width);
            compassPOV.Scale(e.Graphics, compassPOVPosition, GyroVar.compass, (streamVideo.Width - 200) / 30, 31);
            compassPOV.Indicator(e.Graphics, compassPOVPosition, streamVideo.Width);

            altimeter.BG2(e.Graphics, altimeterPosition, streamVideo.Height - 100);
            altimeter.Scale(e.Graphics, altimeterPosition, PlaneLocationVar.altitude, streamVideo.Height - 100, (streamVideo.Width - 200) / 30);
            altimeter.Indicator2(e.Graphics, altimeterPosition, streamVideo.Height - 100);

            gyro.BG(e.Graphics, gyroPosition, 140, GyroVar.roll, GyroVar.pitch);
            gyro.PitchScale(e.Graphics, gyroPosition, 140, GyroVar.roll, GyroVar.pitch, 10);
            gyro.RollScale(e.Graphics, gyroPosition, 140, GyroVar.roll);
            gyro.Indicator(e.Graphics, gyroPosition, 140, GyroVar.roll);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           streamVideo.Invalidate();
        }
        private void InitualizeCheckedListMarkerMap()
        {
            for (int i = 0; i < checkedListMarkerMap.Items.Count; i++)
            {
                checkedListMarkerMap.SetItemChecked(i, true);
            }
        }
        private void checkedListMarkerMap_SelectedIndexChanged(object sender, EventArgs e)
        {
            MapSystem.OnRefreshGmapOverlay(null);
        }
        private void checkedListMarkerMap_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            MapSystem.OnRefreshGmapOverlay(null);
        }
        private void checkedListMarkerMap_MouseDown(object sender, MouseEventArgs e)
        {
            MapSystem.OnRefreshGmapOverlay(null);
        }
        private void RefreshMap(object sender, EventArgs e)
        {
            gMap.Overlays.Clear();
            if (checkedListMarkerMap.GetItemCheckState(0) == CheckState.Checked)
            {
                gMap.Overlays.Add(MapSystem.flightZoneArea);
                gMap.Overlays.Add(MapSystem.flightZoneNode);
            }
            if (checkedListMarkerMap.GetItemCheckState(1) == CheckState.Checked)
            {
                gMap.Overlays.Add(MapSystem.waypointRoutes);
                gMap.Overlays.Add(MapSystem.waypointNode);
            }
            if (checkedListMarkerMap.GetItemCheckState(2) == CheckState.Checked)
            {
                gMap.Overlays.Add(MapSystem.dropingZoneArea);
                gMap.Overlays.Add(MapSystem.dropingZoneNode);
            }
            if (checkedListMarkerMap.GetItemCheckState(3) == CheckState.Checked)
            {
                gMap.Overlays.Add(MapSystem.DpointNode);
            }
            if (checkedListMarkerMap.GetItemCheckState(4) == CheckState.Checked)
            {
                gMap.Overlays.Add(MapSystem.PpointNode);
            }
        }

        private void ChangeVideoDir(object sender, EventArgs e)
        {
            StreamVar.frameIsBusy = true;
            StreamVar.ValueChanged += streamChanged;
        }



    }
}
