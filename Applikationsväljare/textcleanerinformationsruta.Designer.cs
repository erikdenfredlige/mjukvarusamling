namespace Applikationsväljare
{
    partial class textcleanerinformationsruta
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(textcleanerinformationsruta));
            this.användningsinstruktioner = new System.Windows.Forms.Label();
            this.copyright = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // användningsinstruktioner
            // 
            this.användningsinstruktioner.AutoSize = true;
            this.användningsinstruktioner.Location = new System.Drawing.Point(13, 13);
            this.användningsinstruktioner.Name = "användningsinstruktioner";
            this.användningsinstruktioner.Size = new System.Drawing.Size(244, 91);
            this.användningsinstruktioner.TabIndex = 0;
            this.användningsinstruktioner.Text = resources.GetString("användningsinstruktioner.Text");
            // 
            // label2
            // 
            this.copyright.AutoSize = true;
            this.copyright.Location = new System.Drawing.Point(13, 227);
            this.copyright.Name = "copyright";
            this.copyright.Size = new System.Drawing.Size(220, 26);
            this.copyright.TabIndex = 1;
            this.copyright.Text = resources.GetString("copyright.Text");
            // 
            // textcleanerinformationsruta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.copyright);
            this.Controls.Add(this.användningsinstruktioner);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "textcleanerinformationsruta";
            this.Text = "textcleanerinformationsruta";
            this.Load += new System.EventHandler(this.textcleanerinformationsruta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label användningsinstruktioner;
        private System.Windows.Forms.Label copyright;
    }
}