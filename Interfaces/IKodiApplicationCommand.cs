namespace Interfaces
{
    public interface IKodiApplicationCommand
    {
        string GetVolume { get; set; }
        string SetVolumeFull { get; set; }
        string SetVolumeHalf { get; set; }
        string SetVolumeMute { get; set; }

        string SetVolumeAt(int level);
    }
}