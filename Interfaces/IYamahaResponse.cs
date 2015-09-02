namespace Kode.Interfaces
{
    public interface IYamahaResponse
    {
        string CurrentPowerState(string xmlResponse);
        string CurrentVolume(string xmlResponse);
    }
}