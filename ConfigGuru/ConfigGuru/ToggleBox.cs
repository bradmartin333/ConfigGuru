using System.Xml.Linq;

namespace ConfigGuru
{
    public partial class ToggleBox : UserControl
    {
        readonly FormMain MAIN;

        public ToggleBox(FormMain formMain, bool state)
        {
            InitializeComponent();
            MAIN = formMain;
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
            config.Descendants().Elements(AccessibleName).Single().Value = CBX.Text.ToLower();
            config.Save(MAIN.PATH);
        }
    }
}
