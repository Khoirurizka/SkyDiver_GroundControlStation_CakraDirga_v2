using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using GMap.NET.WindowsForms;
using GMap.NET.MapProviders;
using GMap.NET;

namespace SkyDiver_GCS
{
    static class EditStructGroupVar 
    {
        public static void BtnGroupInitializeListButton(BtnGroup btnGroup)
        {
            btnGroup.Actived = new List<Bitmap>();
            btnGroup.Disactived = new List<Bitmap>();
            btnGroup.activedId = -1;
            btnGroup.button = new List<Button>();
        }

        public static void SelectDeselectBtnOnGroup(BtnGroup btnGroup, int id, Color activeColor, Color disactiveColor)
        {
            if (btnGroup.activedId == -1)
            {
                btnGroup.activedId = id;
                btnGroup.button[btnGroup.activedId].BackColor = activeColor;
            }
            else if (btnGroup.activedId != id)
            {
                btnGroup.button[btnGroup.activedId].BackColor = disactiveColor;
                btnGroup.activedId = id;
                btnGroup.button[btnGroup.activedId].BackColor = activeColor;
            }
            else if (btnGroup.activedId == id)
            {
                btnGroup.button[btnGroup.activedId].BackColor = disactiveColor;
                btnGroup.activedId = -1;
            }
        }
        public static void SelectDeselectBtnOnGroup(BtnGroup btnGroup, int id)
        {
            if (btnGroup.activedId == -1)
            {
                btnGroup.activedId = id;
                btnGroup.button[btnGroup.activedId].BackgroundImage = btnGroup.Actived[btnGroup.activedId];
            }
            else if (btnGroup.activedId != id)
            {
                btnGroup.button[btnGroup.activedId].BackgroundImage = btnGroup.Disactived[btnGroup.activedId];
                btnGroup.activedId = id;
                btnGroup.button[btnGroup.activedId].BackgroundImage = btnGroup.Actived[btnGroup.activedId];
            }
            else if (btnGroup.activedId == id)
            {
                btnGroup.button[btnGroup.activedId].BackgroundImage = btnGroup.Disactived[btnGroup.activedId];
                btnGroup.activedId = -1;
            }
        }
        public static void AddBtnToGroup(BtnGroup btnGroup, Button btn)
        {
            btnGroup.button.Add(btn);
        }
        public static void AddBitmapToBtnGroup(BtnGroup btnGroup, Bitmap activedBitmap, Bitmap disactivedBitmap)
        {
            btnGroup.Actived.Add(activedBitmap);
            btnGroup.Disactived.Add(disactivedBitmap);
        }
        public static void MapPGroupInitializeListPointLatLng(MapPointGroup mapPointGroup)
        {
            mapPointGroup.EdgePoint = new List<PointLatLng>();
        }

        public static void AddMapPointToGroup(MapPointGroup mapPointGroup, PointLatLng pointLatLng)
        {
            mapPointGroup.EdgePoint.Add(pointLatLng);
        }
        public static void RemoveMapPointToGroup(MapPointGroup mapPointGroup, int selectedPointId)
        {
            mapPointGroup.EdgePoint.RemoveAt(selectedPointId);
        }
        
        public static void ResetMapPointToGroup(MapPointGroup mapPointGroup )
        {
            mapPointGroup.EdgePoint.Clear();
        }
    }
}
