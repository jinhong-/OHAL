using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OHal
{
    public interface IOHalRuntime
    {
        void Init(IOHalDeviceProvider[] deviceProviders);
        IOHalDevice AddDevice(string providerName, IConfiguration configuration);
        void RemoveDevice(IOHalDevice device);
        IOHalDevice[] GetDevices();
    }
}
