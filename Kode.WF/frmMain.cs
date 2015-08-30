using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            IKodi kodi = new Kodi();
            IAVReceiver avReceiver = new AVReceiver();
            mediator = new Mediator(kodi, avReceiver);
            mediator.Register(btnBack);
            mediator.Register(btnUp);
            mediator.Register(btnLeft);
            mediator.Register(btnRight);
            mediator.Register(btnDown);
            mediator.Register(btnSelect);
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
    }
}
