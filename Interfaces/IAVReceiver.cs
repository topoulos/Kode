namespace Interfaces
{
    public interface IAVReceiver
    {
        void PowerOff();
        void PowerOn();
        void SendCommand(string command);
        void VolumeDown();
        void VolumeUp();
    }
}