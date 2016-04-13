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
        Task Send<T>(string commandName, T payload);
        Task SendStream<T>(string commandName, IObservable<T> payloadStream);
        IDisposable Subscribe<T>(IObserver<T> subscriber);
        IDisposable OnEventReceived<T>(Action<T> onReceive);
        IDisposable OnStreamEventReceived<T>(Action<IObservable<T>> onReceive);
    }
}
