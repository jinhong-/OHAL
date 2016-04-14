using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OHal
{
    public interface IOHalDevice
    {
        Guid Id { get; }
        Task<IOHalDeviceInfo> GetDeviceInfo();
        Task Send<T>(string commandName, T data);
        Task Send<T>(string commandName, IObservable<T> dataStream);
        IDisposable Subscribe(IObserver<IOHalDeviceEvent> subscriber);
    }
}
