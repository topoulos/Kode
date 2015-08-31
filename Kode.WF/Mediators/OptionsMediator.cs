using System.Collections.Generic;
using System.Windows.Forms;
using Kode.Interfaces;

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
            writer.Set("Configuration", "KodiIP",   TextBoxes["txtKodiIP"].Text.Trim());
            writer.Set("Configuration", "KodiPort", TextBoxes["txtKodiPort"].Text.Trim());
            writer.Set("Configuration", "YamahaIP", TextBoxes["txtYamahaIP"].Text.Trim());
        }
        public void LoadOptions()
        {
            TextBoxes["txtKodiIP"].Text   = reader.GetString("Configuration", "KodiIP");
            TextBoxes["txtKodiPort"].Text = reader.GetString("Configuration", "KodiPort");
            TextBoxes["txtYamahaIP"].Text = reader.GetString("Configuration", "YamahaIP");
        }

    }
}
