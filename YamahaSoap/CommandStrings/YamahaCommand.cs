﻿using System;
using Kode.Interfaces;

namespace Kode.YamahaClient.CommandStrings
{
    public class YamahaCommand : IYamahaCommand
    {
        public string HDMI1
        {
            get
            {
                return XmlTemplateHeader + @"<YAMAHA_AV cmd=""PUT""><Main_Zone><Input><Input_Sel>HDMI1</Input_Sel></Input></Main_Zone></YAMAHA_AV>";
            }
        }

        public string HDMI2
        {
            get
            {
                return XmlTemplateHeader + @"<YAMAHA_AV cmd=""PUT""><Main_Zone><Input><Input_Sel>HDMI2</Input_Sel></Input></Main_Zone></YAMAHA_AV>";
            }
        }

        public string HDMI3
        {
            get
            {
                return XmlTemplateHeader + @"<YAMAHA_AV cmd=""PUT""><Main_Zone><Input><Input_Sel>HDMI3</Input_Sel></Input></Main_Zone></YAMAHA_AV>";
            }
        }

        public string HDMI4
        {
            get
            {
                return XmlTemplateHeader + @"<YAMAHA_AV cmd=""PUT""><Main_Zone><Input><Input_Sel>HDMI4</Input_Sel></Input></Main_Zone></YAMAHA_AV>";
            }
        }

        public string Off
        {
            get
            {
                return XmlTemplateHeader + @"<YAMAHA_AV cmd=""PUT""><Main_Zone><Power_Control><Power>Standby</Power></Power_Control></Main_Zone></YAMAHA_AV>";
            }
        }
        public string GetPowerState
        {
            get
            {
                return XmlTemplateHeader + @"<YAMAHA_AV cmd=""GET""><Main_Zone><Power_Control><Power>GetParam</Power></Power_Control></Main_Zone></YAMAHA_AV>";
            }
        }

        public string On
        {
            get
            {
                return XmlTemplateHeader + @"<YAMAHA_AV cmd=""PUT""><Main_Zone><Power_Control><Power>On</Power></Power_Control></Main_Zone></YAMAHA_AV>";
            }
        }

        public string VAUX
        {
            get
            {
                return XmlTemplateHeader + @"<YAMAHA_AV cmd=""PUT""><Main_Zone><Input><Input_Sel>V-AUX</Input_Sel></Input></Main_Zone></YAMAHA_AV>";
            }
        }

        public string VolDown
        {
            get
            {
                return XmlTemplateHeader + @"<YAMAHA_AV cmd=""PUT""><Main_Zone><Volume><Lvl><Val>-10</Val><Exp>1</Exp><Unit>dB</Unit></Lvl></Volume></Main_Zone></YAMAHA_AV>";
            }
        }

        public string VolMute
        {
            get
            {
                return XmlTemplateHeader + @"<YAMAHA_AV cmd=""PUT""><Main_Zone><Volume><Mute>On</Mute></Volume></Main_Zone></YAMAHA_AV>";
            }
        }

        public string VolUp
        {
            get
            {
                return XmlTemplateHeader + @"<YAMAHA_AV cmd=""PUT""><Main_Zone><Volume><Lvl><Val>10</Val><Exp>1</Exp><Unit>dB</Unit></Lvl></Volume></Main_Zone></YAMAHA_AV>";
            }
        }

        public string CurrentVol
        {
            get
            {
                return XmlTemplateHeader + @"<YAMAHA_AV cmd=""GET""><Main_Zone><Volume><Lvl>GetParam</Lvl></Volume></Main_Zone></YAMAHA_AV>";
            }

        }

        private string XmlTemplateHeader = @"<?xml version =""1.0"" encoding=""utf-8""?>";

        public string SetVolume(int level)
        {
            var expanded = level * 10;
            var formattedVolume = expanded.ToString();
            //<?xml version ="1.0" encoding="utf-8"?><YAMAHA_AV cmd="PUT"><Main_Zone><Volume><Lvl><Val>45</Val><Exp>1</Exp><Unit>dB</Unit></Lvl></Volume></Main_Zone></YAMAHA_AV>
            var volumeXml =  XmlTemplateHeader + $@"<YAMAHA_AV cmd=""PUT""><Main_Zone><Volume><Lvl><Val>{formattedVolume}</Val><Exp>1</Exp><Unit>dB</Unit></Lvl></Volume></Main_Zone></YAMAHA_AV>";
            return volumeXml;
        }
    }
}