using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkyDiver_GCS
{
    public partial class GCSSetting : Form
    {
        private void InitializeVarComponent()
        {
            MassageAndCommandVar.ValueChanged += massageAndCommandOnChangedVal;
        }
        private void massageAndCommandOnChangedVal(object sender, EventArgs e)
        {
            //if (MassageAndCommandVar.selectedMenu == 3)
            // {
          /*  MavlinkTerminal.Invoke(new Action(() =>
            {
                MavlinkTerminal.Text = MassageAndCommandVar.massageReceived + "\n";
            }));
            //  }*/
        }
    }
}
