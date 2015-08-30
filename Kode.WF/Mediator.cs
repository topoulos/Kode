using System.Windows.Forms;
using Interfaces;
using System.Collections.Generic;

namespace Kode.WF
{
    class Mediator
    {
        IKodi kodi;
        IAVReceiver avReceiver;
        TrackBar VolumeBar;

        public Mediator(IKodi kodi, IAVReceiver avReceiver)
        {
            this.kodi = kodi;
            this.avReceiver = avReceiver;

        }

        public void Register(TrackBar tb)
        {
            VolumeBar = tb;
        }
        public void UpButtonClick()
        {
            kodi.Up();
        }
        public void DownButtonClick()
        {
            kodi.Down();
        }
        public void LeftButtonClick()
        {
            kodi.Left();
        }
        public void RightButtonClick()
        {
            kodi.Right();
        }
        public void SelectButtonClick()
        {
            kodi.Select();
        }
        public void BackButtonClick()
        {
            kodi.Back();
        }
        public int GetVolumeLevel()
        {
            return kodi.GetVolumeLevel();
        }
        public void SetVolumeLevel(int level)
        {
            kodi.SetVolume(level);
        }
        public void GoHome()
        {
            kodi.Home();
        }
    }
}