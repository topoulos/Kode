using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Interfaces;

namespace Kode.WF
{
    class Mediator
    {
        IKodi kodi;
        IAVReceiver avReceiver;

        public Mediator(IKodi kodi, IAVReceiver avReceiver)
        {
            this.kodi = kodi;
            this.avReceiver = avReceiver;
        }

        public Button UpButton;
        public Button DownButton;
        public Button LeftButton;
        public Button RightButton;
        public Button SelectButton;
        public Button BackButton;
        public Button HomeButton;
        public TrackBar VolumeBar;

        public void Register(Button btn)
        {
            switch (btn.Name)
            {
                case "btnUp":
                    UpButton = btn;
                    break;
                case "btnDown":
                    DownButton = btn;
                    break;
                case "btnLeft":
                    LeftButton = btn;
                    break;
                case "btnRight":
                    RightButton = btn;
                    break;
                case "btnBack":
                    BackButton = btn;
                    break;
                case "btnSelect":
                    SelectButton = btn;
                    break;
                case "btnHome":
                    HomeButton = btn;
                    break;
                default:
                    break;
            }

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