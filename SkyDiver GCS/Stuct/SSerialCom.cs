using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyDiver_GCS
{
    public class SerialCOMs
    {
        public List<SerialCOM> serialCOM { set; get; }
    }
        public class SerialCOM
    {
        public String caption { set; get; }
        public String manufact { set; get; }
        public String deviceID { set; get; }
        public String regPath { set; get; }
        public String portName { set; get; }
    }
}
