using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Applikationsväljare
{

    public partial class textcleanerhuvudruta : Form
    {

        String inputText;
        String vadSkallBytasUt;
        String bytUtMot;

        public textcleanerhuvudruta()
        {
            InitializeComponent();

        }

        private void huvudruta_Load(object sender, EventArgs e)
        {
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.CenterToScreen();
        }

        private void rensaknapp_Click(object sender, EventArgs e)
        {
            inputText = inputTextRuta.Text;
            vadSkallBytasUt = vadSkallBytasUtRuta.Text;
            bytUtMot = bytUtMotRuta.Text;

            if (inputText.Contains(vadSkallBytasUt))
            {
                inputText = inputText.Replace(vadSkallBytasUt, bytUtMot);
            }

            System.IO.File.WriteAllText(@"C:\Users\Erik\Desktop\WriteLines.txt", inputText);
            System.Windows.Forms.MessageBox.Show("Texten är utbytt!");
        }

        private void avslutaknapp_Click(object sender, EventArgs e)
        {
            Form återgå = new programvalsruta();
            återgå.Show();
            this.Hide();
        }

        private void tillbakaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form återgå = new programvalsruta();
            återgå.Show();
            this.Hide();
        }

        private void omToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form information = new textcleanerinformationsruta();
            information.Show();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }

    }
}
