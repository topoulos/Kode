using Kode.Interfaces;
using System;
using System.Windows.Forms;
using Resx = Kode.Resource.Strings.Configuration;

namespace Kode.WF.Mediators
{
    public class Mediator
    {
        private IKodi kodi;
        private IAVReceiver avReceiver;
        private TrackBar KodiVolume;
        private TrackBar YamahaVolume;
        
        private Button btnHdmi1;
        private Button btnHdmi2;
        private Button btnHdmi3;
        private Button btnHdmi4;
        private Button btnVAux;
        private Button btnYamahaPower;
        private IIniReader iniReader;

        public Mediator(IKodi kodi, IAVReceiver avReceiver, IIniReader iniReader)
        {
            this.kodi = kodi;
            this.avReceiver = avReceiver;
            this.iniReader = iniReader;
        }

        public void Register(Button btn)
        {
            if (btn.Name == Resx.btnHdmi1Name)
            {
                btnHdmi1 = btn;
            }
            else if (btn.Name == Resx.btnHdmi2Name)
            {
                btnHdmi2 = btn;
            }
            else if (btn.Name == Resx.btnHdmi3Name)
            {
                btnHdmi3 = btn;
            }
            else if (btn.Name == Resx.btnHdmi4Name)
            {
                btnHdmi4 = btn;
            }
            else if (btn.Name == Resx.btnVauxName)
            {
                btnVAux = btn;
            }
            else if (btn.Name == Resx.btnYamahaPowerName)
            {
                btnYamahaPower = btn;
            }
        }

        public void Register(TrackBar tb)
        {
            if (tb.Name == Resx.tbKodiVolumeName)
            {
                KodiVolume = tb;
            }
            else if (tb.Name == Resx.tbYamahaVolumeName)
            {
                YamahaVolume = tb;
            }
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

        public int GetKodiVolumeLevel()
        {
            return kodi.GetVolumeLevel();
        }
        public int GetYamahaVolumeLevel()
        {
            var trueAmount = avReceiver.GetCurrentVolume();
            var forRounding = ((float)trueAmount) / 100;
            var rounded = Math.Round(forRounding, 0);
            var forControl = (int)(rounded );
            return forControl;
        }
        public void SetYamahaVolume(int level)
        {
            avReceiver.SetVolume(level);
        }
        public void SetKodiVolumeLevel(int level)
        {
            kodi.SetVolume(level);
        }

        public void GoHome()
        {
            kodi.Home();
        }

        public void SetInputLabels()
        {
            btnHdmi1.Text = iniReader.GetString(Resx.ConfigurationSectionName, Resx.Hdmi1Key);
            btnHdmi2.Text = iniReader.GetString(Resx.ConfigurationSectionName, Resx.Hdmi2Key);
            btnHdmi3.Text = iniReader.GetString(Resx.ConfigurationSectionName, Resx.Hdmi3Key);
            btnHdmi4.Text = iniReader.GetString(Resx.ConfigurationSectionName, Resx.Hdmi4Key);
            btnVAux.Text  = iniReader.GetString(Resx.ConfigurationSectionName, Resx.VAuxKey);
        }

        public void ReceiverPowerOn()
        {
            avReceiver.PowerOn();
        }

        public void ReceiverPowerOff()
        {
            avReceiver.PowerOff();
        }

        public void HDMI1()
        {
            avReceiver.HDMI1();
        }

        public void HDMI2()
        {
            avReceiver.HDMI2();
        }

        public void HDMI3()
        {
            avReceiver.HDMI3();
        }

        public void HDMI4()
        {
            avReceiver.HDMI4();
        }

        public void VAUX()
        {
            avReceiver.VAUX();
        }

        public bool GetPowerState()
        {
            return avReceiver.GetPowerState();
        }

        public void TogglePower()
        {
            bool isOn = GetPowerState();
            if (isOn)
            {
                ReceiverPowerOff();
                isOn = GetPowerState();
                if (!isOn)
                    btnYamahaPower.BackColor = System.Drawing.Color.FromKnownColor(System.Drawing.KnownColor.ControlDarkDark);
            }
            else
            {
                ReceiverPowerOn();
                isOn = GetPowerState();
                if (isOn)
                    btnYamahaPower.BackColor = System.Drawing.Color.LimeGreen;
            }
        }

        public void SetInitialPowerColor()
        {
            bool isOn = GetPowerState();
            btnYamahaPower.BackColor = isOn
                ? System.Drawing.Color.LimeGreen
                : System.Drawing.Color.FromKnownColor(System.Drawing.KnownColor.ControlDarkDark);
        }

    }
}