﻿namespace Interfaces
{
    public interface IKodi
    {
        void Back();
        void Down();
        void Left();
        void Right();
        void Select();
        void Home();
        void SendCommand(string command);
        void Up();
        void VolumeToFull();
        void VolumeToHalf();
        void VolumeToMute();
        int GetVolumeLevel();
        void SetVolume(int level);
    }
}