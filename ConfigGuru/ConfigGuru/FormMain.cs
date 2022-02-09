using System.Xml.Linq;

namespace ConfigGuru
{
    public partial class FormMain : Form
    {
        public bool LOADING = true;
        public string PATH = @"C:\XferPrint\XferPrintConfig.xml";

        public FormMain()
        {
            InitializeComponent();

            if (!File.Exists(PATH))
            {
                MessageBox.Show($"{PATH} Not Found", "ConfigGuru");
                Close();
                return;
            }

            XDocument config = XDocument.Load(PATH);
            foreach (XElement element in config.Descendants())
            {
                if ((new string[] { "true", "false" }).Contains(element.Value.ToLower()))
                {
                    TLP.RowCount += 1;
                    TLP.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
                    TLP.Controls.Add(new Label()
                        {
                            Text = element.Name.ToString(),
                            Dock = DockStyle.Fill,
                            TextAlign = ContentAlignment.MiddleLeft,
                            AutoSize = true,
                        }, 
                        0, TLP.RowCount - 1);
                    TLP.Controls.Add(
                        new ToggleBox(this, Convert.ToBoolean(element.Value)) { AccessibleName = element.Name.ToString() }, 
                        1, TLP.RowCount - 1);
                }
            }

            TLP.RowCount += 1;
            TLP.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            Label footer = new()
            {
                Text = "github.com/bradmartin333/ConfigGuru",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.BottomLeft,
                AutoSize = true,
            };
            TLP.SetColumnSpan(footer, 2);
            TLP.Controls.Add(footer, 0, TLP.RowCount - 1);

            LOADING = false;
        }
    }
}