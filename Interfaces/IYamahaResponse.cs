namespace Kode.Interfaces
{
    public interface IYamahaResponse
    {
        string CurrentPowerState(string xmlResponse);
    }
}