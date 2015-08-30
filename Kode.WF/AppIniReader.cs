using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Kode.WF
{
    public class AppIniReader 
    {
        IIniReader reader;
        public AppIniReader(IIniReader reader)
        {
            this.reader = reader;
        }
        
        public string KodiIP
        {
            get
            {
                return reader.GetString("Configuration","KodiIP");
            }
        }
        public string KodiPort
        {
            get
            {
                return reader.GetString("Configuration", "KodiPort");
            }
        }
        public string YamahaIP
        {
            get
            {
                return reader.GetString("Configuration", "YamahaIP");
            }
        }

}
}
