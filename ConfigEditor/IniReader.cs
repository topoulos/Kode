using Nini.Config;
using Kode.Interfaces;
using System.IO;

namespace Kode.ConfigEditor
{
    public class IniReader : IIniReader
    {
        private static IConfigSource source;

        public IniReader(string configName)
        {
            var environment = new AppEnvironment(configName);
            source = new IniConfigSource(environment.AppFolderPath);
        }

        public string GetString(string sectionName, string keyName)
        {
            source.Reload();
            return source.Configs[sectionName].Get(keyName);
        }

        public bool GetBool(string sectionName, string keyName)
        {
            source.Reload();
            return source.Configs[sectionName].GetBoolean(keyName);
        }

        public int GetInt(string sectionName, string keyName)
        {
            source.Reload();
            return source.Configs[sectionName].GetInt(keyName);
        }

        public double GetDouble(string sectionName, string keyName)
        {
            source.Reload();
            return source.Configs[sectionName].GetDouble(keyName);
        }

        public float GetFloat(string sectionName, string keyName)
        {
            source.Reload();
            return source.Configs[sectionName].GetFloat(keyName);
        }

        public long GetLong(string sectionName, string keyName)
        {
            source.Reload();
            return source.Configs[sectionName].GetLong(keyName);
        }
    }
}