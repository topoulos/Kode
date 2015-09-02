namespace Kode.Interfaces
{
    public interface IYamahaCommand
    {
        string GetPowerState { get; }
        string HDMI1 { get; }
        string HDMI2 { get; }
        string HDMI3 { get; }
        string HDMI4 { get; }
        string Off { get; }
        string On { get; }
        string VAUX { get; }
        string VolDown { get; }
        string VolMute { get; }
        string VolUp { get; }
        string SetVolume(int level);
        string CurrentVol { get; }
    }
}