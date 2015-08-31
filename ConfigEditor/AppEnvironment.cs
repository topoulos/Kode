using System.IO;

namespace Kode.ConfigEditor
{
    public class AppEnvironment
    {
        public AppEnvironment(string configFileName)
        {
            this.configFileName = configFileName;
        }

        private string configFileName;
        private const string COMPANYNAME = "Kode";
        private string IniTemplate
        {
            get
            {
                return File.ReadAllText("config.template");
            }

        }
        public string AppFolderPath
        {
            get
            {
                var dir = System.Environment.SpecialFolder.LocalApplicationData;
                var path = System.Environment.GetFolderPath(dir);

                if (!Directory.Exists(path)) Directory.CreateDirectory(path);
                path = Path.Combine(path, COMPANYNAME);
                if (!Directory.Exists(path)) Directory.CreateDirectory(path);
                path = Path.Combine(path, configFileName);
                if (!File.Exists(path))
                {
                    var template = IniTemplate;
                    File.WriteAllText(path,template);
                }
                return path;
            }
        }
    }
}