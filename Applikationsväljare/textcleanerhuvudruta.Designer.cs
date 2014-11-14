namespace Applikationsväljare
{
    partial class textcleanerhuvudruta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(textcleanerhuvudruta));
            this.inputTextRuta = new System.Windows.Forms.TextBox();
            this.rensaknapp = new System.Windows.Forms.Button();
            this.avslutaknapp = new System.Windows.Forms.Button();
            this.bytUtMotRuta = new System.Windows.Forms.TextBox();
            this.vadSkallBytasUtRuta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arkivToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.omToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tillbakaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputTextRuta
            // 
            this.inputTextRuta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputTextRuta.Location = new System.Drawing.Point(92, 57);
            this.inputTextRuta.Name = "inputTextRuta";
            this.inputTextRuta.Size = new System.Drawing.Size(100, 20);
            this.inputTextRuta.TabIndex = 0;
            // 
            // rensaknapp
            // 
            this.rensaknapp.Location = new System.Drawing.Point(176, 210);
            this.rensaknapp.Name = "rensaknapp";
            this.rensaknapp.Size = new System.Drawing.Size(75, 23);
            this.rensaknapp.TabIndex = 4;
            this.rensaknapp.Text = "Rensa text!";
            this.rensaknapp.UseVisualStyleBackColor = true;
            this.rensaknapp.Click += new System.EventHandler(this.rensaknapp_Click);
            // 
            // avslutaknapp
            // 
            this.avslutaknapp.Location = new System.Drawing.Point(38, 210);
            this.avslutaknapp.Name = "avslutaknapp";
            this.avslutaknapp.Size = new System.Drawing.Size(75, 23);
            this.avslutaknapp.TabIndex = 5;
            this.avslutaknapp.Text = "Tillbaka";
            this.avslutaknapp.UseVisualStyleBackColor = true;
            this.avslutaknapp.Click += new System.EventHandler(this.avslutaknapp_Click);
            // 
            // bytUtMotRuta
            // 
            this.bytUtMotRuta.Location = new System.Drawing.Point(92, 135);
            this.bytUtMotRuta.Name = "bytUtMotRuta";
            this.bytUtMotRuta.Size = new System.Drawing.Size(100, 20);
            this.bytUtMotRuta.TabIndex = 3;
            this.bytUtMotRuta.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // vadSkallBytasUtRuta
            // 
            this.vadSkallBytasUtRuta.Location = new System.Drawing.Point(92, 96);
            this.vadSkallBytasUtRuta.Name = "vadSkallBytasUtRuta";
            this.vadSkallBytasUtRuta.Size = new System.Drawing.Size(100, 20);
            this.vadSkallBytasUtRuta.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Skriv in en mening.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Vilket ord ska bytas ut?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Vad ska order bytas ut mot?";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arkivToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arkivToolStripMenuItem
            // 
            this.arkivToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.omToolStripMenuItem,
            this.toolStripMenuItem1,
            this.tillbakaToolStripMenuItem});
            this.arkivToolStripMenuItem.Name = "arkivToolStripMenuItem";
            this.arkivToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.arkivToolStripMenuItem.Text = "Arkiv";
            // 
            // omToolStripMenuItem
            // 
            this.omToolStripMenuItem.Name = "omToolStripMenuItem";
            this.omToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.omToolStripMenuItem.Text = "Om...";
            this.omToolStripMenuItem.Click += new System.EventHandler(this.omToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // tillbakaToolStripMenuItem
            // 
            this.tillbakaToolStripMenuItem.Name = "tillbakaToolStripMenuItem";
            this.tillbakaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tillbakaToolStripMenuItem.Text = "Tillbaka";
            this.tillbakaToolStripMenuItem.Click += new System.EventHandler(this.tillbakaToolStripMenuItem_Click);
            // 
            // textcleanerhuvudruta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vadSkallBytasUtRuta);
            this.Controls.Add(this.bytUtMotRuta);
            this.Controls.Add(this.avslutaknapp);
            this.Controls.Add(this.rensaknapp);
            this.Controls.Add(this.inputTextRuta);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "textcleanerhuvudruta";
            this.Text = "TextCleaner v0.1a";
            this.Load += new System.EventHandler(this.huvudruta_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTextRuta;
        private System.Windows.Forms.Button rensaknapp;
        private System.Windows.Forms.Button avslutaknapp;
        private System.Windows.Forms.TextBox bytUtMotRuta;
        private System.Windows.Forms.TextBox vadSkallBytasUtRuta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arkivToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem omToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tillbakaToolStripMenuItem;
    }
}

