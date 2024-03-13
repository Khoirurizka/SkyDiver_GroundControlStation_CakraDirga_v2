using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace SkyDiver_GCS
{
    public partial class MainWindow: Form
    {
        //Utility
        public bool dynamicDysplay { set; get; } = true;
        PanelScaller panelScaller = new PanelScaller();//Scaller
        //Screen
        private Size initScreenSize = new Size();
        //Panel Size
        private PanelRangeSize panelRangeSizePictureWidth = new PanelRangeSize() { MinSF = 1f, MaxSF = 1.03f };
        public void InitializePanelSpliter() //Initialize value
        {
            initScreenSize = PanelAndSpliterModify.InitializePanelSize(this.Width, this.Height);
            panelRangeSizePictureWidth = PanelAndSpliterModify.InitializePanelRangeSize(panelPicture.Width, panelRangeSizePictureWidth);
        }
        private void MainWindow_Resize(object sender, EventArgs e)
        {

            if (dynamicDysplay)
            {
                panelScaller = PanelAndSpliterModify.ScalerConstByWindow(this.Width, this.Height, initScreenSize.Width, initScreenSize.Height);
                panelPicture.Width = PanelAndSpliterModify.scaledPanelByResizeWindow(panelScaller, panelRangeSizePictureWidth, 0);
            }
        }
    }
}
