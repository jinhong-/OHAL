using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OHal
{
    public interface IOHalDevice
    {
        Task<IOHalDeviceInfo> GetDeviceInfo();
        Task Send<T>(string commandName, T payload);
        Task SendStream<T>(string commandName, IObservable<T> payloadStream);
    }
}
