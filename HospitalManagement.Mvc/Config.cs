using HospitalManagement.Config;

namespace HospitalManagement.Mvc
{
    public class Config(IConfiguration config) : ICoreConfig
    {
        public string SQLConnectionString { get; set; } = config.GetValue<string>("config:sqlConnectionstring") ?? throw new Exception("Unable to locate connection string in appsettings.json");
    }
}
