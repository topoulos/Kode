using Nini.Config;
using Kode.Interfaces;
using System;
using System.IO;

namespace Kode.ConfigEditor
{
    public class IniWriter : IIniWriter
    {
        private static IConfigSource source;

        public IniWriter(string configName)
        {
            var environment = new AppEnvironment(configName);
            source = new IniConfigSource(environment.AppFolderPath);
            source.AutoSave = true;
        }

        public void Set(string sectionName, string keyName, object value)
        {
            source.Configs[sectionName].Set(keyName, value);
            source.Save();
            source.Reload();
        }
        public void AddSection(string sectionName)
        {
            source.AddConfig(sectionName);
            source.Save();
            source.Reload();
        }
        public void RemoveKey(string sectionName, string keyName)
        {
            source.Configs[sectionName].Remove(keyName);
            source.Save();
            source.Reload();
        }
    }
}
