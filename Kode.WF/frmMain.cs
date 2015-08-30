using System;
using System.Windows.Forms;
using Interfaces;
using KodiClient;
using YamahaClient;

namespace Kode.WF
{
    public partial class frmMain : Form
    {
        Mediator mediator;
        public frmMain()
        {
            InitializeComponent();

            IKodi kodi                   = new Kodi();
            IYamahaCommand yamahaCommand = new YamahaCommand();
            ISoapCommand soapCommand     = new SoapCommand();
            IAVReceiver avReceiver       = new AVReceiver(yamahaCommand,soapCommand);
            mediator                     = new Mediator(kodi, avReceiver);

            mediator.Register(tbVolume);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbVolume.Value = mediator.GetVolumeLevel();
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
            mediator.SetVolumeLevel(tbVolume.Value);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            mediator.GoHome();
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            Form frmOptions = new frmOptions();
            frmOptions.ShowDialog();
        }
    }
}
