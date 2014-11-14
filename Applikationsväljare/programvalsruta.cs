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
    public partial class programvalsruta : Form
    {

        public programvalsruta()
        {
            InitializeComponent();
            this.CenterToScreen();
            MinimizeBox = true;
        }

        private void avsluta_Click(object sender, EventArgs e)
        {
            //Metod för att avsluta applikationen när knappen avsluta trycks in.
            Application.Exit();
        }

        private void aktievinst_Click(object sender, EventArgs e)
        {
            //Metod för att starta applikationen Aktievinst.
            Form startaAktievinst = new aktievinsthuvudruta();
            startaAktievinst.Show();
            this.Hide();

        }

        private void textcleaner_Click(object sender, EventArgs e)
        {
            //Metod för att starta applikationen Textcleaner.
            Form startaTextCleaner = new textcleanerhuvudruta();
            startaTextCleaner.Show();
            this.Hide();
        }
    }
}
