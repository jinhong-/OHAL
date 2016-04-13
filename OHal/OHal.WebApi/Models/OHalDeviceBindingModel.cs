using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OHal.WebApi.Models
{
    public class OHalDeviceBindingModel
    {
        public string ProviderName { get; set; }
        public JToken Configuration { get; set; }
    }
}
