using Nini.Config;
using Kode.Interfaces;


namespace Kode.ConfigEditor
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
