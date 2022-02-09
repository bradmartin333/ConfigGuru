using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ConfigGuru
{
    public partial class ComboConfig : UserControl
    {
        readonly FormMain MAIN;

        public ComboConfig(FormMain formMain)
        {
            InitializeComponent();
            MAIN = formMain;
            XDocument config = XDocument.Load(MAIN.PATH);
            COMBO.Text = config.Descendants().Elements("ChuckConfig").Single().Value.ToString();
        }

        private void COMBO_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (MAIN.LOADING) return;
            XDocument config = XDocument.Load(MAIN.PATH);
            config.Descendants().Elements("ChuckConfig").Single().Value = COMBO.Text;
            config.Save(MAIN.PATH);
        }
    }
}
