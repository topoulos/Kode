using Kode.Interfaces;
using System.Windows.Forms;
using Resx = Kode.Resource.Strings.Configuration;

namespace Kode.WF.Mediators
{
    internal class OptionsMediator
    {
        private IIniReader reader;
        private IIniWriter writer;
        public Button SaveButton;
        public Form OptionsForm;
        private TextBox txtKodiIP;
        private TextBox txtKodiPort;
        private TextBox txtYamahaIP;
        private TextBox txtHdmi1;
        private TextBox txtHdmi2;
        private TextBox txtHdmi3;
        private TextBox txtHdmi4;
        private TextBox txtVaux;

        public OptionsMediator(IIniWriter writer, IIniReader reader)
        {
            this.reader = reader;
            this.writer = writer;
        }

        public void Register(TextBox txt)
        {
            if (txt.Name == Resx.txtKodiIPName)
            {
                txtKodiIP = txt;
            }
            else if (txt.Name == Resx.txtKodiPortName)
            {
                txtKodiPort = txt;
            }
            else if (txt.Name == Resx.txtYamahaIPName)
            {
                txtYamahaIP = txt;
            }
            else if (txt.Name == Resx.txtHdmi1Name)
            {
                txtHdmi1 = txt;
            }
            else if (txt.Name == Resx.txtHdmi2Name)
            {
                txtHdmi2 = txt;
            }
            else if (txt.Name == Resx.txtHdmi3Name)
            {
                txtHdmi3 = txt;
            }
            else if (txt.Name == Resx.txtHdmi4Name)
            {
                txtHdmi4 = txt;
            }
            else if (txt.Name == Resx.txtVauxName)
            {
                txtVaux = txt;
            }
        }

        public void Register(Button btn)
        {
            SaveButton = btn;
        }

        public void Register(Form form)
        {
            OptionsForm = form;
        }

        public void SaveOptions()
        {
            writer.Set(Resx.ConfigurationSectionName, Resx.KodiIPKey, txtKodiIP.Text.Trim());
            writer.Set(Resx.ConfigurationSectionName, Resx.KodiPortKey, txtKodiPort.Text.Trim());
            writer.Set(Resx.ConfigurationSectionName, Resx.YamahaIPKey, txtYamahaIP.Text.Trim());
            writer.Set(Resx.ConfigurationSectionName, Resx.Hdmi1Key, txtHdmi1.Text.Trim());
            writer.Set(Resx.ConfigurationSectionName, Resx.Hdmi2Key, txtHdmi2.Text.Trim());
            writer.Set(Resx.ConfigurationSectionName, Resx.Hdmi3Key, txtHdmi3.Text.Trim());
            writer.Set(Resx.ConfigurationSectionName, Resx.Hdmi4Key, txtHdmi4.Text.Trim());
            writer.Set(Resx.ConfigurationSectionName, Resx.VAuxKey, txtVaux.Text.Trim());
        }

        public void LoadOptions()
        {
            txtKodiIP.Text = reader.GetString(Resx.ConfigurationSectionName, Resx.KodiIPKey);
            txtKodiPort.Text = reader.GetString(Resx.ConfigurationSectionName, Resx.KodiPortKey);
            txtYamahaIP.Text = reader.GetString(Resx.ConfigurationSectionName, Resx.YamahaIPKey);
            txtHdmi1.Text = reader.GetString(Resx.ConfigurationSectionName, Resx.Hdmi1Key);
            txtHdmi2.Text = reader.GetString(Resx.ConfigurationSectionName, Resx.Hdmi2Key);
            txtHdmi3.Text = reader.GetString(Resx.ConfigurationSectionName, Resx.Hdmi3Key);
            txtHdmi4.Text = reader.GetString(Resx.ConfigurationSectionName, Resx.Hdmi4Key);
            txtVaux.Text = reader.GetString(Resx.ConfigurationSectionName, Resx.VAuxKey);
        }
    }
}