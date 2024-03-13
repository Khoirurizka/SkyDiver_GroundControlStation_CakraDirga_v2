using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using GMap.NET.WindowsForms;
using GMap.NET.MapProviders;
using GMap.NET;

namespace SkyDiver_GCS
{
   static class MapSystem
    {
        private static int selectedPointId = -1;

        //DrawingPlan
        public static Font font = new Font(new FontFamily("Times New Roman"), 14, FontStyle.Bold, GraphicsUnit.Pixel);

        public static GMapOverlay vehicle = new GMapOverlay("Vehicle");

        public static GMapOverlay flightZoneArea = new GMapOverlay("FlightZoneArea");
        public static GMapOverlay flightZoneNode = new GMapOverlay("FlightZoneNode");
        public static Color FZnodeborderColor = Color.FromArgb(255, 12, 69, 59);
        public static Color FZnodeFillColor = Color.FromArgb(175, 10, 119, 102);
        public static Color FZareaborderColor = Color.FromArgb(255, 9, 133, 113);
        public static Color FZareaFillColor = Color.FromArgb(25, 51, 163, 145);
        public static Color FZtextColor = Color.White;

        public static GMapOverlay waypointRoutes = new GMapOverlay("WaypointRoutes");
        public static GMapOverlay waypointNode = new GMapOverlay("WaypointNodde");
        public static Color WborderColor = Color.FromArgb(255, 242, 102, 0);
        public static Color WfillColor = Color.FromArgb(175, 242, 102, 0);
        public static Color WroutesColor = Color.FromArgb(255, 242, 110, 0);
        public static Color WtextColor = Color.White;

        public static GMapOverlay dropingZoneArea = new GMapOverlay("dropingZoneArea");
        public static GMapOverlay dropingZoneNode = new GMapOverlay("dropingZoneNode");
        public static Color DZnodeborderColor = Color.FromArgb(255, 113, 6, 6);
        public static Color DZnodeFillColor = Color.FromArgb(175, 113, 6, 6);
        public static Color DZareaborderColor = Color.FromArgb(255, 154, 6, 6);
        public static Color DZareaFillColor = Color.FromArgb(25, 154, 6, 6);
        public static Color DZtextColor = Color.White;

        public static GMapOverlay DpointNode = new GMapOverlay("DropingCandidateNode");
        public static Color DborderColor = Color.FromArgb(255, 125, 21, 21);//(255, 252, 253, 21);
        public static Color DfillColor = Color.FromArgb(175, 253, 27, 27);//(175, 230, 230, 12);
        public static Color DtextColor = Color.White;

        public static GMapOverlay PpointNode = new GMapOverlay("PoleNode");
        public static Color PborderColor = Color.FromArgb(255, 10, 52, 78);
        public static Color PfillColor = Color.FromArgb(175, 0, 149, 243);
        public static Color PtextColor = Color.White;

        /// <summary>
        /// Ruler
        /// </summary>
        public static Color RborderColor = Color.FromArgb(255, 255, 255, 255);
        public static Color RfillColor = Color.FromArgb(175, 200, 200, 200);
        public static Color RroutesColor = Color.FromArgb(255, 255, 255, 255);
        public static Color RtextColor = Color.Snow;

        public static event EventHandler RefreshGmapOverlay;
        public static void OnRefreshGmapOverlay(EventArgs e)
        {
            EventHandler handler = RefreshGmapOverlay;
            if (handler != null)// Raise the event
                handler(RefreshGmapOverlay, e);
        }

        public static void InitializeMap(GMapControl gMap, TrackBar ZoomScaler, int minZoom, int maxZoom, int Zoom, ComboBox cb, int SelectIndex = 0)
        {
            string[] mapType = { "Map", "Satellit", "Terrain", "Hybrid"};

            gMap.MinZoom = minZoom;
            gMap.MaxZoom = maxZoom;
            gMap.Zoom = Zoom;
            ZoomScaler.Value= Zoom;
            cb.Items.AddRange(mapType);
            cb.SelectedIndex = SelectIndex;//MapType
            SelectMapMode(gMap, cb.SelectedIndex);
        }

        public static void ZoomMap(GMapControl gMap, int Zoom)
        {
            gMap.Zoom = Zoom;
        }
        public static void ScalerMapGetZoomVal(GMapControl gMap, TrackBar MapScaler)
        {
            MapScaler.Value = (int)gMap.Zoom;
        }
        public static void SelectMapMode(GMapControl gMap, int Index)
        {
            if (Index == 0)
            {
                gMap.MapProvider = GMapProviders.GoogleMap;
            }
            else if (Index == 1)
            {
                gMap.MapProvider = GMapProviders.GoogleSatelliteMap;
            }
            else if (Index == 2)
            {
                gMap.MapProvider = GMapProviders.GoogleTerrainMap;
            }
            else if (Index == 3)
            {
                gMap.MapProvider = GMapProviders.GoogleHybridMap;
            }
        }

        public static void GoToLatLangTextBox(GMapControl gMap, TextBox Lat, TextBox Lang)
        {
            if (!string.IsNullOrWhiteSpace(Lat.Text) && !string.IsNullOrWhiteSpace(Lang.Text))
            {
                PointLatLng pointLatLng = new PointLatLng();
                pointLatLng.Lat = Convert.ToDouble(Lat.Text);
                pointLatLng.Lng = Convert.ToDouble(Lang.Text);
                gMap.Position = pointLatLng;
            }
        }
        public static void GoToLatLang(GMapControl gMap, PointLatLng pointLatLng)
        {
            gMap.Position = pointLatLng;
        }
        public static void GoToLatLang(GMapControl gMap, double Lat, double Lang)
        {
            PointLatLng pointLatLng = new PointLatLng();
            pointLatLng.Lat = Lat;
            pointLatLng.Lng = Lang;
            gMap.Position = pointLatLng;
        }
        public static PointLatLng CursorLatLangToLabelText(GMapControl gMap, Label lbl, MouseEventArgs e)
        {
            PointLatLng LatLngPoint = new PointLatLng();
            LatLngPoint.Lat = gMap.FromLocalToLatLng(e.X, e.Y).Lat;
            LatLngPoint.Lng = gMap.FromLocalToLatLng(e.X, e.Y).Lng;
            lbl.Text = "Lat= " + Convert.ToString(LatLngPoint.Lat) + ", Lng= " + Convert.ToString(LatLngPoint.Lng) + ";";
            return LatLngPoint;
        }
        public static PointLatLng GetCursorLatLang(GMapControl gMap, MouseEventArgs e)
        {
            PointLatLng LatLngPoint = new PointLatLng();
            LatLngPoint.Lat = gMap.FromLocalToLatLng(e.X, e.Y).Lat;
            LatLngPoint.Lng = gMap.FromLocalToLatLng(e.X, e.Y).Lng;
            return LatLngPoint;
        }
        public static void AddPointOnMap(MapPointGroup mapPointGroup, PointLatLng pointLatLng)
        {
            EditStructGroupVar.AddMapPointToGroup(mapPointGroup, pointLatLng);
        }
        public static void AddPointOnMap(MapPointGroup mapPointGroup,double Lat, double Lng)
        {
            PointLatLng Point= new PointLatLng();
            Point.Lat = Lat;
            Point.Lng = Lng;
            EditStructGroupVar.AddMapPointToGroup(mapPointGroup, Point);
        }
        public static void AddRulerPointOnMap(MapPointGroup mapPointGroup, PointLatLng pointLatLng)
        {
            if (mapPointGroup.EdgePoint.Count < 2)
                EditStructGroupVar.AddMapPointToGroup(mapPointGroup, pointLatLng);
            else
                mapPointGroup.EdgePoint.Clear();
        }
        public static void AddRulerPointOnMap(MapPointGroup mapPointGroup, double Lat, double Lng)
        {
            PointLatLng Point = new PointLatLng();
            Point.Lat = Lat;
            Point.Lng = Lng;
            if (mapPointGroup.EdgePoint.Count < 2)
                EditStructGroupVar.AddMapPointToGroup(mapPointGroup, Point);
            else
                mapPointGroup.EdgePoint.Clear();
        }
        public static void MovePointOnMap(MapPointGroup mapPointGroup, PointLatLng pointLatLng)
        {
            if (selectedPointId >= 0)
                mapPointGroup.EdgePoint[selectedPointId] = pointLatLng;
        }
        public static void MovePointOnMap(MapPointGroup mapPointGroup, double Lat, double Lng)
        {
            PointLatLng Point = new PointLatLng();
            Point.Lat = Lat;
            Point.Lng = Lng;
            if (selectedPointId >= 0)
                mapPointGroup.EdgePoint[selectedPointId] = Point;
        }
        public static void RemovePointOnMap(MapPointGroup mapPointGroup)
        {
            if (selectedPointId >= 0)
                EditStructGroupVar.RemoveMapPointToGroup(mapPointGroup, selectedPointId);
        }
        public static bool CheckingDistancePointToMouse(GMapControl gMap, MapPointGroup mapPointGroup,PointLatLng mousePoint, int radius)
        {
            double radiusInLatLng = gMap.FromLocalToLatLng(radius, radius).Lat - gMap.FromLocalToLatLng(0, 0).Lat;
            double radiusSquare = Math.Pow(radiusInLatLng, 2);

            //foreach (PointLatLng p in mapPointGroup.EdgePoint)
            for (int i = 0; i < mapPointGroup.EdgePoint.Count; i++)
            {
                double pointqkuation = Math.Pow(mousePoint.Lat - mapPointGroup.EdgePoint[i].Lat, 2) + Math.Pow(mousePoint.Lng - mapPointGroup.EdgePoint[i].Lng, 2);
                if (pointqkuation <= radiusSquare)
                {
                    selectedPointId = i;
                    return true;
                }
            }
            selectedPointId = -1;
            return false;
        }
        public static void ResetPointOnMap(MapPointGroup mapPointGroup)
        {
            EditStructGroupVar.ResetMapPointToGroup(mapPointGroup);
        }
        public static void gMapOverlayAddPolygonCircleNode(GMapOverlay gMapOverlay, MapPointGroup mapPointGroup, int radius, Font font,Color borderColor,
            Color fillColor,Color textColor,String Textid,bool showTextId)
        {
            for (int i = 0; i < mapPointGroup.EdgePoint.Count; i++)
            {
                gMapOverlay.Markers.Add(new CircleMarker(mapPointGroup.EdgePoint[i], radius, font, borderColor, fillColor, textColor, Textid, showTextId));
            }
        }

        public static void gMapOverlayAddPolygonArea(GMapOverlay gMapOverlay, MapPointGroup mapPointGroup, Color borderColor, Color fillColor,int LineWidth=3)
        {

            GMapPolygon polygon = new GMapPolygon(mapPointGroup.EdgePoint, "Polygon")
            {
                Stroke = new Pen(borderColor, LineWidth),
                Fill = new SolidBrush(fillColor)// Color.FromArgb(25, Color.DarkRed))
            };
            gMapOverlay.Polygons.Add(polygon);
        }

        public static void gMapOverlayAddRoutesCircleNode(GMapOverlay gMapOverlay, MapPointGroup mapPointGroup, int radius, Font font, Color borderColor,
            Color fillColor, Color textColor, bool showTextId)
        {
            for (int i = 0; i < mapPointGroup.EdgePoint.Count; i++)
            {
                gMapOverlay.Markers.Add(new CircleMarker(mapPointGroup.EdgePoint[i], radius, font, borderColor, fillColor, textColor, i.ToString(), showTextId));
            }
        }
        public static void gMapOverlayAddRoutes(GMapOverlay gMapOverlay, MapPointGroup mapPointGroup, Color RoutesColor, int LineWidth=2)
        {
            GMapRoute routes = new GMapRoute(mapPointGroup.EdgePoint, "Routes")
            {
                Stroke = new Pen(RoutesColor, LineWidth),
            };
            gMapOverlay.Routes.Add(routes);
        }
        public static double gMapOverlayRoutesDistance(GMapOverlay gMapOverlay, MapPointGroup mapPointGroup, Color RoutesColor, int LineWidth = 2)
        {
            GMapRoute routes = new GMapRoute(mapPointGroup.EdgePoint, "Routes")
            {
                Stroke = new Pen(RoutesColor, LineWidth),
            };
            gMapOverlay.Routes.Add(routes);
            return (routes.Distance * 1000);
        }
        public static void gMapOverlayAddTextNode(GMapOverlay gMapOverlay, MapPointGroup mapPointGroup, string texts, Font font, Color borderColor,
            Color fillColor, Color textColor)
        {
            PointLatLng Point = new PointLatLng();
            if (mapPointGroup.EdgePoint.Count>1) {
                Point.Lat = (mapPointGroup.EdgePoint[1].Lat + mapPointGroup.EdgePoint[0].Lat)/2;
                Point.Lng = (mapPointGroup.EdgePoint[1].Lng + mapPointGroup.EdgePoint[0].Lng)/2;
                gMapOverlay.Markers.Add(new TextMarker(Point, font, borderColor, fillColor, textColor, texts));
            }
        }
        public static void gMapOverlayResetNode(GMapOverlay gMapOverlay, MapPointGroup mapPointGroup)
        {
            gMapOverlay.Markers.Clear();
        }
        public static void gMapOverlayResetPolygonArea(GMapOverlay gMapOverlay, MapPointGroup mapPointGroup)
        {
            gMapOverlay.Polygons.Clear();
        }
        public static void gMapOverlayResetRoutes(GMapOverlay gMapOverlay, MapPointGroup mapPointGroup)
        {
            gMapOverlay.Routes.Clear();
        }
    }
}
