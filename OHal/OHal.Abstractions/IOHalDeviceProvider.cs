using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OHal
{
    public interface IOHalDeviceProvider
    {
        IOHalDevice GetDevice(IConfiguration configuration);
    }
}
