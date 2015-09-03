namespace Kode.Interfaces
{
    public interface IKodi
    {
        void Back();
        void Down();
        void Left();
        void Right();
        void Select();
        void Home();
        void Up();
        void PlayPause();
        void VolumeToFull();
        void VolumeToHalf();
        void VolumeToMute();
        int GetVolumeLevel();
        void SetVolume(int level);
    }
}