using System;
using Kode.Interfaces;
using System.Xml.Linq;

namespace Kode.YamahaClient
{
    public class AVReceiver : IAVReceiver
    {
        private IYamahaCommand yamahaCommand;
        private ISoapCommand soapCommand;
        private IYamahaResponse yamahaResponse;

        public AVReceiver(IYamahaCommand yamahaCommand, ISoapCommand soapCommand, IYamahaResponse yamahaResponse)
        {
            this.yamahaCommand = yamahaCommand;
            this.soapCommand   = soapCommand;
            this.yamahaResponse = yamahaResponse;
        }

        public void PowerOn()
        {
            soapCommand.SendCommand(yamahaCommand.On);
        }

        public void PowerOff()
        {
            soapCommand.SendCommand(yamahaCommand.Off);
        }

        public void VolumeUp()
        {
            soapCommand.SendCommand(yamahaCommand.VolUp);
        }

        public void VolumeDown()
        {
            soapCommand.SendCommand(yamahaCommand.VolDown);
        }

        public void HDMI1()
        {
            soapCommand.SendCommand(yamahaCommand.HDMI1);
        }

        public void HDMI2()
        {
            soapCommand.SendCommand(yamahaCommand.HDMI2);
        }

        public void HDMI3()
        {
            soapCommand.SendCommand(yamahaCommand.HDMI3);
        }

        public void HDMI4()
        {
            soapCommand.SendCommand(yamahaCommand.HDMI4);
        }

        public void VAUX()
        {
            soapCommand.SendCommand(yamahaCommand.VAUX);
        }

        public bool GetPowerState()
        {
            soapCommand.SendCommand(yamahaCommand.GetPowerState);
            var power = yamahaResponse.CurrentPowerState(soapCommand.Response);
            return (power=="On")? true :false;
        }
    }
}