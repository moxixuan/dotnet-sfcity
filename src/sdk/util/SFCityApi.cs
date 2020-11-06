using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace sdk.util
{
    public class SFCityApi : ISFCityApi
    {
        private readonly IConfiguration _configuration;
        private SFCityOptions sFCityOptions { get; set; }

        public SFCityApi(IConfiguration configuration)
        {
            _configuration = configuration;
            sFCityOptions = _configuration.GetSection(nameof(SFCityOptions)).Get<SFCityOptions>();
        }

        public string Get()
        {
            return "hello SFCity!"  + sFCityOptions.dev_id + sFCityOptions.dev_key;
        }
    }
}
