using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OHal
{
    public interface IOHalDeviceInfo
    {
        string Version { get; }
        IOHalDeviceCommandInfo[] Commands { get; }
        IOHalDeviceEventInfo[] Events { get; }
    }
}
