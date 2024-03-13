using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkyDiver_GCS
{
   public static class CustomControl
    {
       public static int setWidthComboBox(ComboBox cb)
        {
            int maxWidth = 0, temp = 0;
            foreach (string s in cb.Items)
            {
                temp = TextRenderer.MeasureText(s, cb.Font).Width;
                if (temp > maxWidth)
                {
                    maxWidth = temp;
                }
            }
            return maxWidth + SystemInformation.VerticalScrollBarWidth;
        }
    }
}
