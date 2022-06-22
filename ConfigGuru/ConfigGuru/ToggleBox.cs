using System;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ConfigGuru
{
    public partial class ToggleBox : UserControl
    {
        readonly FormMain MAIN;
        private bool RGBW;
        private string RGBWport = "192.168.1.11";

        public ToggleBox(FormMain formMain, bool state = false, bool rgbw = false)
        {
            InitializeComponent();
            MAIN = formMain;
            RGBW = rgbw;
            if (RGBW)
            {
                XDocument config = XDocument.Load(MAIN.PATH);
                Toggle(!string.IsNullOrEmpty(config.Descendants().Elements("RGBCOMPort").Single().Value));
            }
            else
                Toggle(state);  
        }

        private void Toggle(bool toggle)
        {
            CBX.Checked = toggle;
            CBX.Text = toggle ? "True" : "False";
        }

        private void CBX_CheckedChanged(object sender, EventArgs e)
        {
            Toggle(CBX.Checked);
            UpdateAndSave();
        }

        private void UpdateAndSave()
        {
            if (MAIN.LOADING) return;
            XDocument config = XDocument.Load(MAIN.PATH);
            if (RGBW)
                config.Descendants().Elements("RGBCOMPort").Single().Value = CBX.Checked ? RGBWport : string.Empty;
            else
                config.Descendants().Elements(AccessibleName).Single().Value = CBX.Text.ToLower();
            config.Save(MAIN.PATH);
        }

        public void Reload()
        {
            XDocument config = XDocument.Load(MAIN.PATH);
            if (RGBW)
                Toggle(!string.IsNullOrEmpty(config.Descendants().Elements("RGBCOMPort").Single().Value));
            else
                Toggle(Convert.ToBoolean(config.Descendants().Elements(AccessibleName).Single().Value));
        }
    }
}
