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

namespace SkyDiver_GCS
{
    public partial class PlanPanel : Form
    {
        private BtnGroup btnGroup = new BtnGroup();
        private PointLatLng CursorLatLang;

        private GMapOverlay flightZoneArea = new GMapOverlay("FlightZoneArea");
        private GMapOverlay flightZoneNode = new GMapOverlay("FlightZoneNode");
        private GMapOverlay waypointRoutes = new GMapOverlay("WaypointRoutes");
        private GMapOverlay waypointNode = new GMapOverlay("WaypointNodde");
        private GMapOverlay dropingZoneArea = new GMapOverlay("dropingZoneArea");
        private GMapOverlay dropingZoneNode = new GMapOverlay("dropingZoneNode");
        private GMapOverlay DpointNode = new GMapOverlay("DropingCandidateNode");
        private GMapOverlay PpointNode = new GMapOverlay("PoleNode");

        private GMapOverlay rulerLine = new GMapOverlay("ReulerLine");
        private GMapOverlay rulerPoint = new GMapOverlay("RulerPoint");
        private GMapOverlay rulerText = new GMapOverlay("RulerText");


        private bool movePoint = false;

        public PlanPanel()
        {
            InitializeComponent();
            InitializePanelSpliter();

            EditStructGroupVar.BtnGroupInitializeListButton(btnGroup);
            EditStructGroupVar.AddBtnToGroup(btnGroup, this.btnDrawFZ);
            EditStructGroupVar.AddBitmapToBtnGroup(btnGroup, Properties.Resources.BtnDrawFlightZoneActive_490, Properties.Resources.BtnDrawFlightZoneDisactive_490);
            EditStructGroupVar.AddBtnToGroup(btnGroup, this.btnDrawWP);
            EditStructGroupVar.AddBitmapToBtnGroup(btnGroup, Properties.Resources.BtnDrawWaypointActive_490, Properties.Resources.BtnDrawWaypointDisactive_490);
            EditStructGroupVar.AddBtnToGroup(btnGroup, this.btnDrawDZ);
            EditStructGroupVar.AddBitmapToBtnGroup(btnGroup, Properties.Resources.BtnDrawDropingZoneActive_490, Properties.Resources.BtnDrawDropingZoneDisactive_490);
            EditStructGroupVar.AddBtnToGroup(btnGroup, this.btnDPointCand);
            EditStructGroupVar.AddBitmapToBtnGroup(btnGroup, Properties.Resources.BtnDrawDropingPointActive_490, Properties.Resources.BtnDrawDropingPointDisactive_490);
            EditStructGroupVar.AddBtnToGroup(btnGroup, this.btnPole);
            EditStructGroupVar.AddBitmapToBtnGroup(btnGroup, Properties.Resources.BtnDrawPoleActive_490, Properties.Resources.BtnDrawPoleDisactive_490);
            EditStructGroupVar.AddBtnToGroup(btnGroup, this.btnMapRuler);
            EditStructGroupVar.AddBitmapToBtnGroup(btnGroup, Properties.Resources.BtnRulerActive_490, Properties.Resources.BtnRulerDisactive_490);

            MapSystem.InitializeMap(gMap,MapScaler, 2, 20, 15, cbMapMode, 1);
            MapSystem.GoToLatLang(gMap, MapsVar.InitializeMap);
            //gMap.Overlays.Add(vehicle);
            gMap.Overlays.Add(flightZoneArea);
            gMap.Overlays.Add(flightZoneNode);
            gMap.Overlays.Add(waypointRoutes);
            gMap.Overlays.Add(waypointNode);
            gMap.Overlays.Add(dropingZoneArea);
            gMap.Overlays.Add(dropingZoneNode); 
            gMap.Overlays.Add(DpointNode);
            gMap.Overlays.Add(PpointNode);
            gMap.Overlays.Add(rulerText);
            gMap.Overlays.Add(rulerLine);
            gMap.Overlays.Add(rulerPoint);

            toolTip.SetToolTip(this.cbMapMode, "Map Mode");
            toolTip.SetToolTip(this.labelLat, "Latitude");
            toolTip.SetToolTip(this.tbLatitude, "Latitude");
            toolTip.SetToolTip(this.labelLang, "Langitude");
            toolTip.SetToolTip(this.tbLongitude, "Langitude");
            toolTip.SetToolTip(this.cbMapMode, "Map Mode");
            toolTip.SetToolTip(this.btnFindLoc, "Find location by coordinate");
            toolTip.SetToolTip(this.btnFindPlane, "Find plane");

            toolTip.SetToolTip(this.btnDrawFZ, "Draw flight Zone");
            toolTip.SetToolTip(this.btnDrawWP, "Draw waypoint");
            toolTip.SetToolTip(this.btnDrawDZ, "Draw droping zone");
            toolTip.SetToolTip(this.btnDPointCand, "Draw droping point candidate");
            toolTip.SetToolTip(this.btnPole, "Draw pole");

            toolTip.SetToolTip(this.MapScaler, "Zoom scale");
        }

        private void cbMapMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            MapSystem.SelectMapMode(gMap, cbMapMode.SelectedIndex);
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            MapSystem.GoToLatLangTextBox(gMap, tbLatitude, tbLongitude);
        }
        private void gMap_MouseMove(object sender, MouseEventArgs e)
        {
            CursorLatLang= MapSystem.CursorLatLangToLabelText(gMap, MouseMapLatLangRaw, e);
            if (movePoint) {
                if (e.Button == MouseButtons.Left)
                {
                    switch (btnGroup.activedId)
                    {
                        case 0:
                            MapSystem.MovePointOnMap(MapsVar.FZpointGroup, CursorLatLang);
                            break;
                        case 1:
                            MapSystem.MovePointOnMap(MapsVar.WpointGroup, CursorLatLang);
                            break;
                        case 2:
                            MapSystem.MovePointOnMap(MapsVar.DZpointGroup, CursorLatLang);
                            break;
                        case 3:
                            MapSystem.MovePointOnMap(MapsVar.DpointGroup, CursorLatLang);
                            break;
                        case 4:
                            MapSystem.MovePointOnMap(MapsVar.PpointGroup, CursorLatLang);
                            break;
                        case 5:
                            MapSystem.MovePointOnMap(MapsVar.RpointGroup, CursorLatLang);
                            break;
                    }
                    RefreshMap();
                }
            }
        }

        private void gMap_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                switch (btnGroup.activedId)
                {
                    case 0:
                        if (!MapSystem.CheckingDistancePointToMouse(gMap, MapsVar.FZpointGroup, CursorLatLang, 24))
                            MapSystem.AddPointOnMap(MapsVar.FZpointGroup, CursorLatLang);
                        break;
                    case 1:
                        if (!MapSystem.CheckingDistancePointToMouse(gMap, MapsVar.WpointGroup, CursorLatLang, 24))
                            MapSystem.AddPointOnMap(MapsVar.WpointGroup, CursorLatLang);
                        break;
                    case 2:
                        if (!MapSystem.CheckingDistancePointToMouse(gMap, MapsVar.DZpointGroup, CursorLatLang, 24))
                            MapSystem.AddPointOnMap(MapsVar.DZpointGroup, CursorLatLang);
                        break;
                    case 3:
                        if (!MapSystem.CheckingDistancePointToMouse(gMap, MapsVar.DpointGroup, CursorLatLang, 24))
                            MapSystem.AddPointOnMap(MapsVar.DpointGroup, CursorLatLang);
                        break;
                    case 4:
                        if (!MapSystem.CheckingDistancePointToMouse(gMap, MapsVar.PpointGroup, CursorLatLang, 24))
                            MapSystem.AddPointOnMap(MapsVar.PpointGroup, CursorLatLang);
                        break;
                    case 5:
                        if (!MapSystem.CheckingDistancePointToMouse(gMap, MapsVar.RpointGroup, CursorLatLang, 8))
                            MapSystem.AddRulerPointOnMap(MapsVar.RpointGroup, CursorLatLang);
                        break;
                }
                RefreshMap();
            }else if (e.Button == MouseButtons.Right)
            {
                switch (btnGroup.activedId)
                {
                    case 0:
                        if (MapSystem.CheckingDistancePointToMouse(gMap, MapsVar.FZpointGroup, CursorLatLang, 24))
                            MapSystem.RemovePointOnMap(MapsVar.FZpointGroup);
                        break;
                    case 1:
                        if (MapSystem.CheckingDistancePointToMouse(gMap, MapsVar.WpointGroup, CursorLatLang, 24))
                            MapSystem.RemovePointOnMap(MapsVar.WpointGroup);
                        break;
                    case 2:
                        if (MapSystem.CheckingDistancePointToMouse(gMap, MapsVar.DZpointGroup, CursorLatLang, 24))
                            MapSystem.RemovePointOnMap(MapsVar.DZpointGroup);
                        break;
                    case 3:
                        if (MapSystem.CheckingDistancePointToMouse(gMap, MapsVar.DpointGroup, CursorLatLang, 24))
                            MapSystem.RemovePointOnMap(MapsVar.DpointGroup);
                        break;
                    case 4:
                        if (MapSystem.CheckingDistancePointToMouse(gMap, MapsVar.PpointGroup, CursorLatLang, 24))
                            MapSystem.RemovePointOnMap(MapsVar.PpointGroup);
                        break;
                }
                RefreshMap();
            }
        }
        private void gMap_MouseDown(object sender, MouseEventArgs e)
        {
            movePoint = true;
            if (e.Button == MouseButtons.Left)
            {
                switch (btnGroup.activedId)
                {
                    case 0:
                        MapSystem.CheckingDistancePointToMouse(gMap, MapsVar.FZpointGroup, CursorLatLang, 12);
                        break;
                    case 1:
                        MapSystem.CheckingDistancePointToMouse(gMap, MapsVar.WpointGroup, CursorLatLang, 12);
                        break;
                    case 2:
                        MapSystem.CheckingDistancePointToMouse(gMap, MapsVar.DZpointGroup, CursorLatLang, 12);
                        break;
                    case 3:
                        MapSystem.CheckingDistancePointToMouse(gMap, MapsVar.DpointGroup, CursorLatLang, 12);
                        break;
                    case 4:
                        MapSystem.CheckingDistancePointToMouse(gMap, MapsVar.PpointGroup, CursorLatLang, 12);
                        break;
                    case 5:
                        MapSystem.CheckingDistancePointToMouse(gMap, MapsVar.RpointGroup, CursorLatLang, 8);
                        break;
                }
            }
        }

        private void btnDrawFZ_Click(object sender, EventArgs e)
        {
            EditStructGroupVar.SelectDeselectBtnOnGroup(btnGroup, 0);
        }

        private void btnDrawWP_Click(object sender, EventArgs e)
        {
            EditStructGroupVar.SelectDeselectBtnOnGroup(btnGroup, 1);
        }

        private void btnDrawDZ_Click(object sender, EventArgs e)
        {
            EditStructGroupVar.SelectDeselectBtnOnGroup(btnGroup, 2);
        }

        private void btnDPointCand_Click(object sender, EventArgs e)
        {
            EditStructGroupVar.SelectDeselectBtnOnGroup(btnGroup, 3);
        }

        private void btnPole_Click(object sender, EventArgs e)
        {
            EditStructGroupVar.SelectDeselectBtnOnGroup(btnGroup, 4);
        }
        private void btnMapRuler_Click(object sender, EventArgs e)
        {
            EditStructGroupVar.SelectDeselectBtnOnGroup(btnGroup, 5);
        }
        public void RefreshMap()
        {
            gMap.Overlays.Clear();
            switch (btnGroup.activedId)
            {
                case 0:
                    flightZoneArea.Polygons.Clear();
                    MapSystem.gMapOverlayAddPolygonArea(flightZoneArea, MapsVar.FZpointGroup, MapSystem.FZareaborderColor, MapSystem.FZareaFillColor);
                    flightZoneNode.Markers.Clear();
                    MapSystem.gMapOverlayAddPolygonCircleNode(flightZoneNode, MapsVar.FZpointGroup, 12, MapSystem.font, MapSystem.FZnodeborderColor, MapSystem.FZnodeFillColor, MapSystem.FZtextColor, "B", true);

                    MapSystem.flightZoneArea.Polygons.Clear();
                    MapSystem.gMapOverlayAddPolygonArea(MapSystem.flightZoneArea, MapsVar.FZpointGroup, MapSystem.FZareaborderColor, MapSystem.FZareaFillColor);
                    MapSystem.flightZoneNode.Markers.Clear();
                    MapSystem.gMapOverlayAddPolygonCircleNode(MapSystem.flightZoneNode, MapsVar.FZpointGroup, 12, MapSystem.font, MapSystem.FZnodeborderColor, MapSystem.FZnodeFillColor, MapSystem.FZtextColor, "B", true);

                    break;
                case 1:
                    waypointRoutes.Clear();
                    MapSystem.gMapOverlayAddRoutes(waypointRoutes, MapsVar.WpointGroup, MapSystem.WroutesColor);
                    waypointNode.Markers.Clear();
                    MapSystem.gMapOverlayAddRoutesCircleNode(waypointNode, MapsVar.WpointGroup, 12, MapSystem.font, MapSystem.WborderColor, MapSystem.WfillColor, MapSystem.WtextColor, true);

                    MapSystem.waypointRoutes.Clear();
                    MapSystem.gMapOverlayAddRoutes(MapSystem.waypointRoutes, MapsVar.WpointGroup, MapSystem.WroutesColor);
                    MapSystem.waypointNode.Markers.Clear();
                    MapSystem.gMapOverlayAddRoutesCircleNode(MapSystem.waypointNode, MapsVar.WpointGroup, 12, MapSystem.font, MapSystem.WborderColor, MapSystem.WfillColor, MapSystem.WtextColor, true);

                    break;
                case 2:
                    dropingZoneArea.Polygons.Clear();
                    MapSystem.gMapOverlayAddPolygonArea(dropingZoneArea, MapsVar.DZpointGroup, MapSystem.DZareaborderColor, MapSystem.DZareaFillColor);
                    dropingZoneNode.Markers.Clear();
                    MapSystem.gMapOverlayAddPolygonCircleNode(dropingZoneNode, MapsVar.DZpointGroup, 12, MapSystem.font, MapSystem.DZnodeborderColor, MapSystem.DZnodeFillColor, MapSystem.DZtextColor, "D", true);

                    MapSystem.dropingZoneArea.Polygons.Clear();
                    MapSystem.gMapOverlayAddPolygonArea(MapSystem.dropingZoneArea, MapsVar.DZpointGroup, MapSystem.DZareaborderColor, MapSystem.DZareaFillColor);
                    MapSystem.dropingZoneNode.Markers.Clear();
                    MapSystem.gMapOverlayAddPolygonCircleNode(MapSystem.dropingZoneNode, MapsVar.DZpointGroup, 12, MapSystem.font, MapSystem.DZnodeborderColor, MapSystem.DZnodeFillColor, MapSystem.DZtextColor, "D", true);
                    break;
                case 3:
                    DpointNode.Markers.Clear();
                    MapSystem.gMapOverlayAddPolygonCircleNode(DpointNode, MapsVar.DpointGroup, 12, MapSystem.font, MapSystem.DborderColor, MapSystem.DfillColor, MapSystem.DtextColor, "D", true);

                    MapSystem.DpointNode.Markers.Clear();
                    MapSystem.gMapOverlayAddPolygonCircleNode(MapSystem.DpointNode, MapsVar.DpointGroup, 12, MapSystem.font, MapSystem.DborderColor, MapSystem.DfillColor, MapSystem.DtextColor, "D", true);
                    break;
                case 4:
                    PpointNode.Markers.Clear();
                    MapSystem.gMapOverlayAddPolygonCircleNode(PpointNode, MapsVar.PpointGroup, 12, MapSystem.font, MapSystem.PborderColor, MapSystem.PfillColor, MapSystem.PtextColor, "P", true);

                    MapSystem.PpointNode.Markers.Clear();
                    MapSystem.gMapOverlayAddPolygonCircleNode(MapSystem.PpointNode, MapsVar.PpointGroup, 12, MapSystem.font, MapSystem.PborderColor, MapSystem.PfillColor, MapSystem.PtextColor, "P", true);
                    break;
                case 5:
                    double distance = 0;
                    string distanceText;
                    rulerLine.Clear();
                    distance=MapSystem.gMapOverlayRoutesDistance(rulerLine, MapsVar.RpointGroup, MapSystem.RroutesColor);
                    if(distance<1000)
                        distanceText = distance.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture) + "m";
                    else
                        distanceText = (distance/1000).ToString("0.00", System.Globalization.CultureInfo.InvariantCulture) + "km";
                    rulerText.Clear();
                    MapSystem.gMapOverlayAddTextNode(rulerText, MapsVar.RpointGroup, distanceText, MapSystem.font, MapSystem.RborderColor, MapSystem.RfillColor, MapSystem.RtextColor);
                    rulerPoint.Markers.Clear();
                    MapSystem.gMapOverlayAddRoutesCircleNode(rulerPoint, MapsVar.RpointGroup, 6, MapSystem.font, MapSystem.RborderColor, MapSystem.RfillColor, MapSystem.RtextColor, false);
                    break;
            }
            gMap.Overlays.Add(flightZoneArea);
            gMap.Overlays.Add(flightZoneNode);
            gMap.Overlays.Add(waypointRoutes);
            gMap.Overlays.Add(waypointNode);
            gMap.Overlays.Add(dropingZoneArea);
            gMap.Overlays.Add(dropingZoneNode);
            gMap.Overlays.Add(DpointNode);
            gMap.Overlays.Add(PpointNode);
            gMap.Overlays.Add(rulerText);
            gMap.Overlays.Add(rulerLine);
            gMap.Overlays.Add(rulerPoint);
        }

        private void btnResetFZ_Click(object sender, EventArgs e)
        {
            MapSystem.ResetPointOnMap(MapsVar.FZpointGroup);
            MapSystem.gMapOverlayResetPolygonArea(MapSystem.flightZoneArea, MapsVar.FZpointGroup);
            MapSystem.gMapOverlayResetNode(MapSystem.flightZoneNode, MapsVar.FZpointGroup);
            RefreshMap();
        }

        private void btnResetW_Click(object sender, EventArgs e)
        {
            MapSystem.ResetPointOnMap(MapsVar.WpointGroup);
            MapSystem.gMapOverlayResetRoutes(MapSystem.waypointRoutes, MapsVar.WpointGroup);
            MapSystem.gMapOverlayResetNode(MapSystem.waypointNode, MapsVar.WpointGroup);
            RefreshMap();
        }

        private void btnResetDZ_Click(object sender, EventArgs e)
        {
            MapSystem.ResetPointOnMap(MapsVar.DZpointGroup);
            MapSystem.gMapOverlayResetPolygonArea(MapSystem.dropingZoneArea, MapsVar.DZpointGroup);
            MapSystem.gMapOverlayResetNode(MapSystem.dropingZoneNode, MapsVar.DZpointGroup);
            RefreshMap();
        }

        private void btnResetDC_Click(object sender, EventArgs e)
        {
            MapSystem.ResetPointOnMap(MapsVar.DpointGroup);
            MapSystem.gMapOverlayResetNode(MapSystem.DpointNode, MapsVar.DpointGroup);
            RefreshMap();
        }

        private void btnResetP_Click(object sender, EventArgs e)
        {
            MapSystem.ResetPointOnMap(MapsVar.PpointGroup);
            MapSystem.gMapOverlayResetNode(MapSystem.PpointNode, MapsVar.PpointGroup);
            RefreshMap();
        }

        private void MapScaler_ValueChanged(object sender, EventArgs e)
        {
            MapSystem.ZoomMap(gMap, MapScaler.Value);
        }

        private void gMap_OnMapZoomChanged()
        {
            MapSystem.ScalerMapGetZoomVal(gMap, MapScaler);
        }
    }
}
