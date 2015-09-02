using Kode.KodiClient;
using System;
using System.Windows.Forms;
using Kode.YamahaClient;
using Kode.YamahaClient.CommandStrings;
using Kode.WF.Mediators;
using Kode.KodiClient.Configuration;
using Kode.ConfigEditor;
using Resx = Kode.Resource.Strings.Configuration;

namespace Kode.WF
{
    public partial class frmMain : Form
    {
        public Mediator mediator
        {
            get; set;
        }

        public frmMain()
        {
            InitializeComponent();
            var iniReader      = new IniReader(Resx.iniFileName);
            var config         = new SetupConfig();
            var rpcCommand     = new RpcCommand(config.GetKodiIP());
            var kodi           = new Kodi(rpcCommand);
            var yamahaCommand  = new YamahaCommand();
            var soapCommand    = new SoapCommand();
            var yamahaResponse = new YamahaResponse();
            var avReceiver     = new AVReceiver(yamahaCommand, soapCommand, yamahaResponse);
            mediator           = new Mediator(kodi, avReceiver, iniReader);

            RegisterButtons();
        }

        private void RegisterButtons()
        {
            mediator.Register(tbKodiVolume);
            mediator.Register(tbYamahaVolume);
            mediator.Register(btnHdmi1);
            mediator.Register(btnHdmi2);
            mediator.Register(btnHdmi3);
            mediator.Register(btnHdmi4);
            mediator.Register(btnVaux);
            mediator.Register(btnYamahaPower);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbKodiVolume.Value = mediator.GetKodiVolumeLevel();
            tbYamahaVolume.Value = mediator.GetYamahaVolumeLevel();
            lblYamahaVolume.Text = tbYamahaVolume.Value.ToString();

            mediator.SetInputLabels();
            mediator.SetInitialPowerColor();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            mediator.UpButtonClick();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            mediator.RightButtonClick();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            mediator.DownButtonClick();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            mediator.LeftButtonClick();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            mediator.SelectButtonClick();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            mediator.BackButtonClick();
        }

        private void tbVolume_Scroll(object sender, EventArgs e)
        {
            mediator.SetKodiVolumeLevel(tbKodiVolume.Value);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            mediator.GoHome();
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            var frmOptions = new frmOptions();
            frmOptions.ShowDialog();
            mediator.SetInputLabels();
            this.Refresh();
        }

        private void btnYamahaPower_Click(object sender, EventArgs e)
        {
            mediator.TogglePower();
        }

        private void btnHdmi1_Click(object sender, EventArgs e)
        {
            mediator.HDMI1();
        }

        private void btnHdmi2_Click(object sender, EventArgs e)
        {
            mediator.HDMI2();
        }

        private void btnHdmi3_Click(object sender, EventArgs e)
        {
            mediator.HDMI3();
        }

        private void btnHdmi4_Click(object sender, EventArgs e)
        {
            mediator.HDMI4();
        }

        private void btnVaux_Click(object sender, EventArgs e)
        {
            mediator.VAUX();
        }

        private void tbYamahaVolume_Scroll(object sender, EventArgs e)
        {
            var vol = tbYamahaVolume.Value;
            if (vol % 5 != 0) lblYamahaVolume.Text = vol.ToString();
        }

        private void tbYamahaVolume_MouseUp(object sender, MouseEventArgs e)
        {
            MoveYamahaVolume();
        }

        private void MoveYamahaVolume()
        {
            var vol = tbYamahaVolume.Value;
            if (vol % 5 != 0) vol = RoundByFive(vol);
            tbYamahaVolume.Value = vol;
            lblYamahaVolume.Text = vol.ToString();
            mediator.SetYamahaVolume(tbYamahaVolume.Value);
        }

        private int RoundByFive(int number)
        {
            var beforeRounding = (float)number / 10;
            var rounded = Math.Round(beforeRounding, 0);
            var expanded = rounded * 10;
            return (int)expanded;
        }

        private void tbYamahaVolume_KeyUp(object sender, KeyEventArgs e)
        {
            MoveYamahaVolume();
        }
    }
}