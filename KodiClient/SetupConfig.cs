using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConfigEditor;

namespace KodiClient
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
