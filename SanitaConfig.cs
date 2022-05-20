using System;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Text.Json;

namespace Sanita_Ticket
{
    public class SanitaConfig
    {   
        public string lastTicketNumber { get; set; }
        public string lastSanitaPath { get; set; }

        public IConfigurationRoot config;

        public void SetConfig(IConfigurationRoot config)
        {
            this.config = config;
        }
        

        public static SanitaConfig LoadConfig()
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json").Build();


            var sanitaConfig = config.Get<SanitaConfig>();
            sanitaConfig.SetConfig(config);
            return sanitaConfig;
        }

        public bool Save()
        {
            try
            {
                var options = new JsonSerializerOptions { WriteIndented = true };
                var json = JsonSerializer.Serialize(this, options);
                File.WriteAllText("appsettings.json", json);

                return true;
            }
            catch (Exception exception)
            {
                return false;
            }
        }
    }
}
