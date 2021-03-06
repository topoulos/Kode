﻿using System;
using System.Windows.Forms;
using Kode.Interfaces;
using Kode.ConfigEditor;
using Kode.WF.Mediators;
using Resx = Kode.Resource.Strings.Configuration;
using System.Drawing;

namespace Kode.WF
{
    public partial class frmOptions : Form
    {
        private OptionsMediator mediator;
        public frmOptions()
        {
            InitializeComponent();
            IIniReader reader = new IniReader(Resx.iniFileName);
            IIniWriter writer = new IniWriter(Resx.iniFileName);
            mediator = new OptionsMediator(writer, reader);
            mediator.Register(this.txtKodiIP);
            mediator.Register(this.txtKodiPort);
            mediator.Register(this.txtYamahaIP);
            mediator.Register(this.btnSave);
            mediator.Register(this.txtHdmi1);
            mediator.Register(this.txtHdmi2);
            mediator.Register(this.txtHdmi3);
            mediator.Register(this.txtHdmi4);
            mediator.Register(this.txtVaux);
            mediator.Register(this.txtBackcolor);
            mediator.Register(this.txtForecolor);
        }

        private void frmOptions_Load(object sender, EventArgs e)
        {
            mediator.LoadOptions();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            mediator.SaveOptions();
            this.Close();

        }

        private void txtForecolor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtForecolor_DoubleClick(object sender, EventArgs e)
        {
            var result = cdColor.ShowDialog();
            {
                var color = cdColor.Color;
                txtForecolor.Text = ColorTranslator.ToHtml(color);
            }
        }

        private void txtBackcolor_DoubleClick(object sender, EventArgs e)
        {
            var result = cdBack.ShowDialog();
            {
                var color = cdBack.Color;
                txtBackcolor.Text = ColorTranslator.ToHtml(color);
            }
        }

        private void txtBackcolor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
