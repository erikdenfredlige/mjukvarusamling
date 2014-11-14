namespace Applikationsväljare
{
    partial class programvalsruta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(programvalsruta));
            this.aktievinst = new System.Windows.Forms.Button();
            this.textcleaner = new System.Windows.Forms.Button();
            this.avsluta = new System.Windows.Forms.Button();
            this.rubrik = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // aktievinst
            // 
            this.aktievinst.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aktievinst.Location = new System.Drawing.Point(12, 51);
            this.aktievinst.Name = "aktievinst";
            this.aktievinst.Size = new System.Drawing.Size(100, 30);
            this.aktievinst.TabIndex = 0;
            this.aktievinst.Text = "Aktievinst";
            this.aktievinst.UseVisualStyleBackColor = true;
            this.aktievinst.Click += new System.EventHandler(this.aktievinst_Click);
            // 
            // textcleaner
            // 
            this.textcleaner.Location = new System.Drawing.Point(12, 87);
            this.textcleaner.Name = "textcleaner";
            this.textcleaner.Size = new System.Drawing.Size(100, 30);
            this.textcleaner.TabIndex = 1;
            this.textcleaner.Text = "Textcleaner";
            this.textcleaner.UseVisualStyleBackColor = true;
            this.textcleaner.Click += new System.EventHandler(this.textcleaner_Click);
            // 
            // avsluta
            // 
            this.avsluta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avsluta.Location = new System.Drawing.Point(13, 227);
            this.avsluta.Name = "avsluta";
            this.avsluta.Size = new System.Drawing.Size(100, 30);
            this.avsluta.TabIndex = 2;
            this.avsluta.Text = "Avsluta";
            this.avsluta.UseVisualStyleBackColor = true;
            this.avsluta.Click += new System.EventHandler(this.avsluta_Click);
            // 
            // label1
            // 
            this.rubrik.AutoSize = true;
            this.rubrik.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.rubrik.Location = new System.Drawing.Point(63, 9);
            this.rubrik.Name = "label1";
            this.rubrik.Size = new System.Drawing.Size(157, 24);
            this.rubrik.TabIndex = 3;
            this.rubrik.Text = "Välj applikation:";
            // 
            // programvalsruta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.rubrik);
            this.Controls.Add(this.avsluta);
            this.Controls.Add(this.textcleaner);
            this.Controls.Add(this.aktievinst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "programvalsruta";
            this.Text = "Applikationsväljaren";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button aktievinst;
        private System.Windows.Forms.Button textcleaner;
        private System.Windows.Forms.Button avsluta;
        private System.Windows.Forms.Label rubrik;
    }
}

