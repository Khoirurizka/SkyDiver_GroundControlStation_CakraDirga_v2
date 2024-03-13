using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyDiver_GCS
{
   public  class Filters
    {
        public bool blinkFilter(bool data, BlinkFilterBool blinkFilterBool)
        {
            if (data)
            {
                blinkFilterBool.byteData = 0xFF;
            }
            blinkFilterBool.byteData = (UInt16)(blinkFilterBool.byteData << 1);
            if (blinkFilterBool.byteData != 0x00)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public UInt16 blinkFilter(UInt16 data, BlinkFilterEnum blinkFilterEnum, bool PriorityhightIdenum = true)
        {
            if (blinkFilterEnum.lowIdEnum != blinkFilterEnum.hightIdEnum)
            {
                if (blinkFilterEnum.hightIdEnum <= data)
                {
                    blinkFilterEnum.hightIdEnum = data;
                    blinkFilterEnum.byteData = 0xFF;
                }
                else
                {
                    blinkFilterEnum.lowIdEnum = data;
                }
            }
            else
            {
                blinkFilterEnum.hightIdEnum = data;
            }
            blinkFilterEnum.byteData = (UInt16)(blinkFilterEnum.byteData << 1);
            if (PriorityhightIdenum)
            {
                if (blinkFilterEnum.byteData != 0x00)
                {
                    return blinkFilterEnum.hightIdEnum;
                }
                else
                {
                    return blinkFilterEnum.lowIdEnum;
                }
            }
            else
            {
                if (blinkFilterEnum.byteData == 0x00)
                {
                    return blinkFilterEnum.hightIdEnum;
                }
                else
                {
                    return blinkFilterEnum.lowIdEnum;
                }
            }
        }
    }
}
