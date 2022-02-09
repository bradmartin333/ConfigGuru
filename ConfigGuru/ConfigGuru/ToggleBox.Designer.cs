namespace ConfigGuru
{
    partial class ToggleBox
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
            this.CBX = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // CBX
            // 
            this.CBX.Appearance = System.Windows.Forms.Appearance.Button;
            this.CBX.AutoSize = true;
            this.CBX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CBX.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CBX.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            this.CBX.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.CBX.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.CBX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBX.Location = new System.Drawing.Point(0, 0);
            this.CBX.Name = "CBX";
            this.CBX.Size = new System.Drawing.Size(100, 30);
            this.CBX.TabIndex = 0;
            this.CBX.Text = "False";
            this.CBX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CBX.UseVisualStyleBackColor = true;
            this.CBX.CheckedChanged += new System.EventHandler(this.CBX_CheckedChanged);
            // 
            // ToggleBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CBX);
            this.Name = "ToggleBox";
            this.Size = new System.Drawing.Size(100, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox CBX;
    }
}
