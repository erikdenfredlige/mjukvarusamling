namespace Applikationsväljare
{
    partial class aktievinsthuvudruta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aktievinsthuvudruta));
            this.inputAntalAktier = new System.Windows.Forms.TextBox();
            this.rubrikAngeAntalAktier = new System.Windows.Forms.Label();
            this.rubrikAngeInköpspris = new System.Windows.Forms.Label();
            this.inputInköpspris = new System.Windows.Forms.TextBox();
            this.knappRäknaUt = new System.Windows.Forms.Button();
            this.knappAvsluta = new System.Windows.Forms.Button();
            this.inputSäljpris = new System.Windows.Forms.TextBox();
            this.rubrikAngeSäljpris = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arkivToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.avslutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputAntalAktier
            // 
            this.inputAntalAktier.Location = new System.Drawing.Point(63, 45);
            this.inputAntalAktier.Name = "inputAntalAktier";
            this.inputAntalAktier.Size = new System.Drawing.Size(172, 20);
            this.inputAntalAktier.TabIndex = 2;
            this.inputAntalAktier.TextChanged += new System.EventHandler(this.inputAntalAktier_TextChanged);
            // 
            // rubrikAngeAntalAktier
            // 
            this.rubrikAngeAntalAktier.AutoSize = true;
            this.rubrikAngeAntalAktier.Location = new System.Drawing.Point(60, 29);
            this.rubrikAngeAntalAktier.Name = "rubrikAngeAntalAktier";
            this.rubrikAngeAntalAktier.Size = new System.Drawing.Size(90, 13);
            this.rubrikAngeAntalAktier.TabIndex = 1;
            this.rubrikAngeAntalAktier.Text = "Ange antal aktier:";
            this.rubrikAngeAntalAktier.Click += new System.EventHandler(this.label1_Click);
            // 
            // rubrikAngeInköpspris
            // 
            this.rubrikAngeInköpspris.AutoSize = true;
            this.rubrikAngeInköpspris.Location = new System.Drawing.Point(60, 92);
            this.rubrikAngeInköpspris.Name = "rubrikAngeInköpspris";
            this.rubrikAngeInköpspris.Size = new System.Drawing.Size(141, 13);
            this.rubrikAngeInköpspris.TabIndex = 3;
            this.rubrikAngeInköpspris.Text = "Ange inköpspris av aktierna:";
            // 
            // inputInköpspris
            // 
            this.inputInköpspris.Location = new System.Drawing.Point(63, 108);
            this.inputInköpspris.Name = "inputInköpspris";
            this.inputInköpspris.Size = new System.Drawing.Size(172, 20);
            this.inputInköpspris.TabIndex = 4;
            // 
            // knappRäknaUt
            // 
            this.knappRäknaUt.Location = new System.Drawing.Point(159, 227);
            this.knappRäknaUt.Name = "knappRäknaUt";
            this.knappRäknaUt.Size = new System.Drawing.Size(75, 23);
            this.knappRäknaUt.TabIndex = 7;
            this.knappRäknaUt.Text = "Räkna ut!";
            this.knappRäknaUt.UseVisualStyleBackColor = true;
            this.knappRäknaUt.Click += new System.EventHandler(this.knappRäknaUt_Click);
            // 
            // knappAvsluta
            // 
            this.knappAvsluta.Location = new System.Drawing.Point(63, 227);
            this.knappAvsluta.Name = "knappAvsluta";
            this.knappAvsluta.Size = new System.Drawing.Size(75, 23);
            this.knappAvsluta.TabIndex = 8;
            this.knappAvsluta.Text = "Tillbaka";
            this.knappAvsluta.UseVisualStyleBackColor = true;
            this.knappAvsluta.Click += new System.EventHandler(this.knappAvsluta_Click);
            // 
            // inputSäljpris
            // 
            this.inputSäljpris.Location = new System.Drawing.Point(63, 167);
            this.inputSäljpris.Name = "inputSäljpris";
            this.inputSäljpris.Size = new System.Drawing.Size(172, 20);
            this.inputSäljpris.TabIndex = 6;
            // 
            // rubrikAngeSäljpris
            // 
            this.rubrikAngeSäljpris.AutoSize = true;
            this.rubrikAngeSäljpris.Location = new System.Drawing.Point(60, 151);
            this.rubrikAngeSäljpris.Name = "rubrikAngeSäljpris";
            this.rubrikAngeSäljpris.Size = new System.Drawing.Size(115, 13);
            this.rubrikAngeSäljpris.TabIndex = 5;
            this.rubrikAngeSäljpris.Text = "Ange aktiernas säljpris:";
            this.rubrikAngeSäljpris.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arkivToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // arkivToolStripMenuItem
            // 
            this.arkivToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem,
            this.toolStripSeparator1,
            this.avslutaToolStripMenuItem});
            this.arkivToolStripMenuItem.Name = "arkivToolStripMenuItem";
            this.arkivToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.arkivToolStripMenuItem.Text = "Arkiv";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.infoToolStripMenuItem.Text = "Om...";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(112, 6);
            // 
            // avslutaToolStripMenuItem
            // 
            this.avslutaToolStripMenuItem.Name = "avslutaToolStripMenuItem";
            this.avslutaToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.avslutaToolStripMenuItem.Text = "Tillbaka";
            this.avslutaToolStripMenuItem.Click += new System.EventHandler(this.avslutaToolStripMenuItem_Click);
            // 
            // aktievinsthuvudruta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.rubrikAngeSäljpris);
            this.Controls.Add(this.inputSäljpris);
            this.Controls.Add(this.knappAvsluta);
            this.Controls.Add(this.knappRäknaUt);
            this.Controls.Add(this.inputInköpspris);
            this.Controls.Add(this.rubrikAngeInköpspris);
            this.Controls.Add(this.rubrikAngeAntalAktier);
            this.Controls.Add(this.inputAntalAktier);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "aktievinsthuvudruta";
            this.Text = "Aktievinstuträknaren v1.0";
            this.Load += new System.EventHandler(this.huvudruta_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputAntalAktier;
        private System.Windows.Forms.Label rubrikAngeAntalAktier;
        private System.Windows.Forms.Label rubrikAngeInköpspris;
        private System.Windows.Forms.TextBox inputInköpspris;
        private System.Windows.Forms.Button knappRäknaUt;
        private System.Windows.Forms.Button knappAvsluta;
        private System.Windows.Forms.TextBox inputSäljpris;
        private System.Windows.Forms.Label rubrikAngeSäljpris;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arkivToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avslutaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

    }
}

