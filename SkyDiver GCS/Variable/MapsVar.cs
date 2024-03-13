using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMap.NET.WindowsForms;
using GMap.NET.MapProviders;
using GMap.NET;

namespace SkyDiver_GCS
{
    static class MapsVar
    {
        public static PointLatLng InitializeMap { set; get; } = new PointLatLng(-7.97, 112.65);

        public static string[] MarkerType { set; get; } = { "Flight Area", "Waypoint", "Droping Area", "Droping Point Candidate", "Pole", "Plane", "Path" };
        public static MapPointGroup FZpointGroup { set; get; } = new MapPointGroup();
        public static MapPointGroup WpointGroup { set; get; } = new MapPointGroup();
        public static MapPointGroup DZpointGroup { set; get; } = new MapPointGroup();
        public static MapPointGroup DpointGroup { set; get; } = new MapPointGroup();
        public static MapPointGroup PpointGroup { set; get; } = new MapPointGroup();
        public static MapPointGroup RpointGroup { set; get; } = new MapPointGroup();
    }
}
