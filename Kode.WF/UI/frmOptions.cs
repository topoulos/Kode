using System;
using System.Windows.Forms;
using Interfaces;
using ConfigEditor;


namespace Kode.WF
{
    public partial class frmOptions : Form
    {
        private OptionsMediator mediator;
        public frmOptions()
        {
            InitializeComponent();
            IIniReader reader = new IniReader("setup.ini");
            IIniWriter writer = new IniWriter("setup.ini");
            mediator = new OptionsMediator(writer, reader);
            mediator.Register(this.txtKodiIP);
            mediator.Register(this.txtKodiPort);
            mediator.Register(this.txtYamahaIP);
            mediator.Register(this.btnSave);
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
    }
}
