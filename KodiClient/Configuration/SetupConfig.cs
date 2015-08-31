using Kode.ConfigEditor;
using Resx = Kode.Resource.Strings.Configuration;

namespace Kode.KodiClient.Configuration
{
    public class SetupConfig
    {
        private IniReader reader;
        private IniWriter writer;

        public SetupConfig()
        {
            reader = new IniReader(Resx.iniFileName);
            writer = new IniWriter(Resx.iniFileName);
        }
        public string GetKodiIP()
        {
            var ip   = reader.GetString(Resx.ConfigurationSectionName, Resx.KodiIPKey);
            var port = reader.GetString(Resx.ConfigurationSectionName, Resx.KodiPortKey);
            return (ip ?? string.Empty) + ":" + (port ?? string.Empty);
        }
    }
}
