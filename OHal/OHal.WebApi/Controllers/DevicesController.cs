using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Newtonsoft.Json.Linq;
using OHal.WebApi.Models;

namespace OHal.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class DevicesController : Controller
    {
        private readonly IOHalRuntime _runtime;

        public DevicesController(IOHalRuntime runtime)
        {
            _runtime = runtime;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var device = _runtime.GetDevices().FirstOrDefault(x => x.Id == id);
            if (device == null) return this.HttpNotFound();
            var deviceInfo = await device.GetDeviceInfo();
            return Ok(deviceInfo);
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var getDeviceInfoTasks = _runtime.GetDevices()
                .Select(x => x.GetDeviceInfo());
            var deviceInfoItems = await Task.WhenAll(getDeviceInfoTasks);
            return Ok(deviceInfoItems);
        }

        [HttpPost]
        public void Post([FromBody]OHalDeviceBindingModel model)
        {
            //TODO: Need to convert JToken into configuration
            //_runtime.AddDevice(model.ProviderName, model.Configuration);
        }

        //[HttpPut("{id}")]
        //public void Put(Guid id, [FromBody]string value)
        //{
        //}

        [HttpPut("{id}/Send/{commandName}")]
        public void Send(Guid id, string commandName, [FromBody]JToken command)
        {
            //_runtime.GetDevices().First()
        }

        //TODO: Need streaming api as well

        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _runtime.RemoveDevice(id);
        }
    }
}
