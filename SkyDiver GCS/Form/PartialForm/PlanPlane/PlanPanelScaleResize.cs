using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace SkyDiver_GCS
{
    public partial class PlanPanel : Form
    {
        //Utility
        public bool dynamicDysplay { set; get; } = true;

        //Panel Size
        public void InitializePanelSpliter() //Initialize value
        {
        }
        private void PlanPanel_Resize(object sender, EventArgs e)
        {
        }
    }
}
