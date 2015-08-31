using System.Collections.Generic;
using System.Windows.Forms;
using Kode.Interfaces;
using Resx = Kode.Resource.Strings.Configuration;

namespace Kode.WF.Mediators
{
    class OptionsMediator
    {
        IIniReader reader;
        IIniWriter writer;
        public Button SaveButton;
        public Form OptionsForm;
        IDictionary<string, TextBox> TextBoxes
        {
            get; set;
        } 
        public OptionsMediator(IIniWriter writer, IIniReader reader)
        {
            this.reader = reader;
            this.writer = writer;
        }

        public void Register (TextBox txt)
        {
            if (TextBoxes == null) TextBoxes = new Dictionary<string, TextBox>();
            TextBoxes.Add(txt.Name, txt);
        }
        public void Register (Button btn)
        {
            SaveButton = btn;
        }
        public void Register (Form form)
        {
            OptionsForm = form;
        }
        public void SaveOptions()
        {
            writer.Set(Resx.ConfigurationSectionName, Resx.KodiIPKey,   TextBoxes[Resx.txtKodiIPName].Text.Trim());
            writer.Set(Resx.ConfigurationSectionName, Resx.KodiPortKey, TextBoxes[Resx.txtKodiPortName].Text.Trim());
            writer.Set(Resx.ConfigurationSectionName, Resx.YamahaIPKey, TextBoxes[Resx.txtYamahaIPName].Text.Trim());
        }
        public void LoadOptions()
        {
            TextBoxes[Resx.txtKodiIPName].Text   = reader.GetString(Resx.ConfigurationSectionName, Resx.KodiIPKey);
            TextBoxes[Resx.txtKodiPortName].Text = reader.GetString(Resx.ConfigurationSectionName, Resx.KodiPortKey);
            TextBoxes[Resx.txtYamahaIPName].Text = reader.GetString(Resx.ConfigurationSectionName, Resx.YamahaIPKey);
        }

    }
}
