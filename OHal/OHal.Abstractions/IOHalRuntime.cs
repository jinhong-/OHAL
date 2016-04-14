using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OHal
{
    public interface IOHalRuntime
    {
        IOHalDeviceManager DeviceManager { get; }
        void Init(IOHalDeviceProvider[] deviceProviders);
    }
}
