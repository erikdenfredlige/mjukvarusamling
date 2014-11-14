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
    public partial class textcleanerinformationsruta : Form
    {
        public textcleanerinformationsruta()
        {
            InitializeComponent();
        }

        private void textcleanerinformationsruta_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.CenterToScreen(); 
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            this.Hide();
            Form huvudruta = new textcleanerhuvudruta();
            huvudruta.Show();
        }

    }
}
