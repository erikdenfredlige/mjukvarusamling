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
    public partial class aktievinstinformationsruta : Form
    {
        public aktievinstinformationsruta()
        {
            InitializeComponent();
        }

        private void informationsruta_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.CenterToScreen(); 
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            this.Hide();
            Form huvudruta = new aktievinsthuvudruta();
            huvudruta.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
