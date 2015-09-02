using Kode.Interfaces;
using System.Xml.Linq;
using System;

namespace Kode.YamahaClient
{
    public class YamahaResponse : IYamahaResponse
    {
        public string CurrentPowerState(string xmlResponse)
        {
            var doc = XDocument.Parse(xmlResponse);
            var power = doc.Element("YAMAHA_AV").Element("Main_Zone").Element("Power_Control").Element("Power").Value;
            return power;
        }

        public string CurrentVolume(string xmlResponse)
        {
            var doc = XDocument.Parse(xmlResponse);
            var level = doc.Element("YAMAHA_AV").Element("Main_Zone").Element("Volume").Element("Lvl").Value;
            return level;
        }
    }
}