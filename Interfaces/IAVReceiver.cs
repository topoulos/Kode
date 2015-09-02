namespace Kode.Interfaces
{
    public interface IAVReceiver
    {
        void PowerOff();
        void HDMI1();
        void HDMI2();
        void HDMI3();
        void HDMI4();
        void VAUX();
        void PowerOn();
        bool GetPowerState();
        int GetCurrentVolume();
        void SetVolume(int level);
    }
}