using Kode.ConfigEditor;

namespace Kode.KodiClient.Configuration
{
    public class SetupConfig
    {
        private IniReader reader;
        private IniWriter writer;

        public SetupConfig()
        {
            reader = new IniReader("setup.ini");
            writer = new IniWriter("setup.ini");
        }
        public string GetKodiIP()
        {
            var ip = reader.GetString("Configuration", "KodiIP");
            var port = reader.GetString("Configuration", "KodiPort");
            return (ip ?? string.Empty) + ":" + (port ?? string.Empty);
        }
    }
}
