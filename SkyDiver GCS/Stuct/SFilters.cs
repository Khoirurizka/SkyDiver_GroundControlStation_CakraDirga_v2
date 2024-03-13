using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyDiver_GCS
{
    public class BlinkFilterBool
    {
        public UInt16 byteData { set; get; }
    }
    public class BlinkFilterEnum
    {
        public UInt16 byteData { set; get; }
        public UInt16 lowIdEnum { set; get; }
        public UInt16 hightIdEnum { set; get; }
    }
}
