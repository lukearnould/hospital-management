using HospitalManagement.Config;

namespace HospitalManagement.Web
{
    public class Config(IConfiguration config) : ICoreConfig
    {
        public string ConnectionString { get; set; } = config.GetValue<string>("config:connectionstring")
            + " Password=" + config["Database__Password"] + ";"
            ?? throw new Exception("Unable to locate connection string and/or database user secret in appsettings.json/secrets.json");
    }
}
