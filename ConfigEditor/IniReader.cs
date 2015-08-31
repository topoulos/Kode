using Nini.Config;
using Kode.Interfaces;

namespace Kode.ConfigEditor
{
    public class IniReader : IIniReader
    {
        private IConfigSource source;

        public IniReader(string configName)
        {
            source = new IniConfigSource(configName);
        }

        public string GetString(string sectionName, string keyName)
        {
            return source.Configs[sectionName].Get(keyName);
        }

        public bool GetBool(string sectionName, string keyName)
        {
            return source.Configs[sectionName].GetBoolean(keyName);
        }

        public int GetInt(string sectionName, string keyName)
        {
            return source.Configs[sectionName].GetInt(keyName);
        }

        public double GetDouble(string sectionName, string keyName)
        {
            return source.Configs[sectionName].GetDouble(keyName);
        }

        public float GetFloat(string sectionName, string keyName)
        {
            return source.Configs[sectionName].GetFloat(keyName);
        }

        public long GetLong(string sectionName, string keyName)
        {
            return source.Configs[sectionName].GetLong(keyName);
        }
    }
}