using Microsoft.Extensions.Configuration;
using SimpleCrm.Web;
using System;
using System.Collections.Generic;
using System.Text;


namespace SimpleCrm
{
    public class ConfigurationGreeter : IGreeter
    {
        public IConfiguration Configuration { get; }
        public ConfigurationGreeter(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public string GetGreeting()
        {
            return Configuration["Greeting"];
        }
    }
}