using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nini.Config;
using Interfaces;


namespace ConfigEditor
{
    public class IniWriter : IIniWriter
    {
        private IConfigSource source;

        public IniWriter(string configName)
        {
            source = new IniConfigSource(configName);
        }

        public void Set(string sectionName, string keyName, object value)
        {
            source.Configs[sectionName].Set(keyName, value);
            source.Save();
        }
        public void AddSection(string sectionName)
        {
            source.AddConfig(sectionName);
        }
        public void RemoveKey(string sectionName, string keyName)
        {
            source.Configs[sectionName].Remove(keyName);
        }

    }
}
