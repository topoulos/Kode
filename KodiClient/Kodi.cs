using Interfaces;

namespace KodiClient
{
    public class Kodi : IKodi
    {
        private KodiInputCommand input;
        private KodiApplicationCommand application;
        private IRpcCommand rpcCommand;

        public Kodi(IRpcCommand rpcCommand)
        {
            input = new KodiInputCommand();
            application = new KodiApplicationCommand();
            this.rpcCommand = rpcCommand;
        }

        public void VolumeToHalf()
        {
            rpcCommand.SendCommand(application.SetVolumeHalf);
        }

        public void VolumeToFull()
        {
            rpcCommand.SendCommand(application.SetVolumeFull);
        }

        public void Up()
        {
            rpcCommand.SendCommand(input.Up);
        }

        public void Down()
        {
            rpcCommand.SendCommand(input.Down);
        }

        public void Left()
        {
            rpcCommand.SendCommand(input.Left);
        }

        public void Right()
        {
            rpcCommand.SendCommand(input.Right);
        }

        public void Back()
        {
            rpcCommand.SendCommand(input.Back);
        }

        public void Select()
        {
            rpcCommand.SendCommand(input.Select);
        }

        public void VolumeToMute()
        {
            rpcCommand.SendCommand(application.SetVolumeMute);
        }

        public int GetVolumeLevel()
        {
            rpcCommand.SendCommand(application.GetVolume);
            return rpcCommand.VolumeReturnMessage.Result.Volume;
        }

        public void SetVolume(int level)
        {
            rpcCommand.SendCommand(application.SetVolumeAt(level));
        }

        public void Home()
        {
            rpcCommand.SendCommand(input.Home);
        }
    }
}