using Interfaces;

namespace YamahaClient
{
    public class AVReceiver : IAVReceiver
    {
        private IYamahaCommand yamahaCommand;
        private ISoapCommand soapCommand;

        public AVReceiver(IYamahaCommand yamahaCommand, ISoapCommand soapCommand)
        {
            this.yamahaCommand = yamahaCommand;
            this.soapCommand   = soapCommand;
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
    }
}