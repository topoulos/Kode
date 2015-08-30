namespace KodiClient
{
    public interface IRpcCommand
    {
        IVolumeReturnEnvelope VolumeReturnMessage { get; set; }

        void SendCommand(string command);
    }
}