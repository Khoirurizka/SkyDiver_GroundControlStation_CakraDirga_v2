using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyDiver_GCS
{
    public enum REQUEST_DATA : byte
    {
        STOP = 0,
        START = 1,
    }
    public enum RESPONSE_TARGET : uint
    {
        FLIGHT_STACK_DEFAULT = 0,
        ADDRESS_OF_REQUESTOR = 1,
        BROATCAST = 2,
    }
    public enum MESSAGE_INTERVAL : int
    {
        DISABLE = -1,
        DEFAULT_RATE = 0,
    }

}
