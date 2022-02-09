namespace ConfigGuru
{
    partial class ComboConfig
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.COMBO = new System.Windows.Forms.ComboBox();
            this.panel = new System.Windows.Forms.Panel();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // COMBO
            // 
            this.COMBO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.COMBO.FormattingEnabled = true;
            this.COMBO.Items.AddRange(new object[] {
            "Fortuna",
            "MX",
            "Legacy",
            "Despina",
            "10Zone"});
            this.COMBO.Location = new System.Drawing.Point(3, 3);
            this.COMBO.Name = "COMBO";
            this.COMBO.Size = new System.Drawing.Size(94, 21);
            this.COMBO.TabIndex = 0;
            this.COMBO.SelectedIndexChanged += new System.EventHandler(this.COMBO_SelectedIndexChanged);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.COMBO);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(100, 27);
            this.panel.TabIndex = 1;
            // 
            // ComboConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel);
            this.Name = "ComboConfig";
            this.Size = new System.Drawing.Size(100, 27);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox COMBO;
        private System.Windows.Forms.Panel panel;
    }
}
