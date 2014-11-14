using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* 
 * Det går att bygga ut programmet så att det går att lägga till fler och fler olika antal aktier som är köpta för olika pris.
 * Det blir en mer avancerad och mer korrekt uträkning då.
 * 
 * Vad sägs om att lägga till ett antal rader text ovan som visar grunderna för uträkningen. Säljpriset, differensen mellan K/S i kr, köppriset och total vinst
 * samt totala kostnader.
 */

namespace Applikationsväljare
{

    

    public partial class aktievinsthuvudruta : Form
    {

        int antalAktier;
        Double inköpspris;
        Double säljpris;

        public aktievinsthuvudruta()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        public string räknaUtCourtage(int antalAktier, double inköpspris, double säljpris) {

            double summaCourtage = 0;
            string courtageSträng;
            string nettoSträng;
            string skattSträng;
            double differens = ((antalAktier * säljpris) - (antalAktier * inköpspris));

            if ((antalAktier * inköpspris) <= 26000) {
            summaCourtage = 39;
            }

            else {
            summaCourtage = ((antalAktier * inköpspris) * 0.0015);
            }

            if ((antalAktier * säljpris) <= 26000)
            {
                summaCourtage = summaCourtage + 39;
            }

            else
            {
                summaCourtage = summaCourtage + ((antalAktier * säljpris) * 0.0015);
            }

            courtageSträng = "Du betalade totalt " + summaCourtage.ToString() + "kr i courtage.\n" +
                "Du köpte ursprungligen aktier för " + (antalAktier * inköpspris).ToString() + "kr.\n" +
                "Och du sålde aktierna för ett värde av " + (antalAktier * säljpris).ToString() + "kr.\n" 
                ;

            if ((antalAktier * säljpris) - (antalAktier * inköpspris) >= 0)
            {
               courtageSträng = courtageSträng + "Det ger en positiv differens om " + ((antalAktier * säljpris) - (antalAktier * inköpspris)).ToString() + "kr.\n";
            }
            else
            {
                courtageSträng = courtageSträng + "Det ger en negativ differens om " + ((antalAktier * säljpris) - (antalAktier * inköpspris)).ToString() + "kr.\n";
            }

            if ((differens - summaCourtage) < 0) {
                nettoSträng = "Efter avdraget courtage blev affären en förlust om " + (differens - summaCourtage).ToString() + "kr. (" + summaCourtage.ToString() + "kr i courtage)";
                courtageSträng = courtageSträng + nettoSträng;
            }
            else
            {
                nettoSträng = "Efter avdraget courtage blev affären en vinst om " + (differens - summaCourtage).ToString() + "kr. (" + summaCourtage.ToString() + "kr i courtage.)\n";
                skattSträng = "Utöver det betalade du " + ((differens - summaCourtage) * 0.3).ToString() + "kr i skatt. (30% av resterande summa efter courtage.) \nDet ger en total nettovinst om "
                    +((differens - summaCourtage) * 0.7).ToString() + "kr.";
                courtageSträng = courtageSträng + nettoSträng + skattSträng;
            }

            return courtageSträng;
            

        }


        private void knappRäknaUt_Click(object sender, EventArgs e)
        {
            antalAktier = Convert.ToInt32(inputAntalAktier.Text);
            inköpspris = Convert.ToDouble(inputInköpspris.Text);
            säljpris = Convert.ToDouble(inputSäljpris.Text);
            MessageBox.Show(räknaUtCourtage(antalAktier, inköpspris, säljpris));
        }

        private void inputAntalAktier_TextChanged(object sender, EventArgs e)
        {

        }

        private void knappAvsluta_Click(object sender, EventArgs e)
        {
            Form återgå = new programvalsruta();
            återgå.Show();
            this.Hide();
        }

        private void huvudruta_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.CenterToScreen(); 
        }

        private void avslutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form återgå = new programvalsruta();
            återgå.Show();
            this.Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aktievinstinformationsruta informationsRuta = new aktievinstinformationsruta();
            informationsRuta.Show();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }
    }
}
