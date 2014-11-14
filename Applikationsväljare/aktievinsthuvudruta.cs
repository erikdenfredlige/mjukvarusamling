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
 * Eventuell utbyggnad: 
 * Det går att bygga ut programmet så att det går att lägga till olika antal aktier som är köpta för olika pris.
 * Det blir en mer avancerad och mer korrekt uträkning då.
 */

namespace Applikationsväljare
{

    public partial class aktievinsthuvudruta : Form
    {

        int antalAktier; //Användarens input för antalet aktier som uträkningen baseras på.
        Double inköpspris; //Det av användaren angivna inköpspriset för aktierna.
        Double säljpris; //Säljpriset som användaren angett för aktierna.

        public aktievinsthuvudruta()
        {
            InitializeComponent();
        }

        public string räknaUtCourtage(int antalAktier, double inköpspris, double säljpris) {

            double summaCourtage = 0; //Används summera courtageavgifterna baserat på säljpriset och antalet aktier.
            string courtageSträng; //Sträng som används för att skriva ut courtagesumman.
            string nettoSträng; //Sträng som används för att skriva ut nettovinsten.
            string skattSträng; //Sträng som används för att skriva ut det totala skattebeloppet.
            double differens = ((antalAktier * säljpris) - (antalAktier * inköpspris)); //Differensen mellan inköpspriset för aktierna och säljpriset för aktierna.

            if ((antalAktier * inköpspris) <= 26000) {
            summaCourtage = 39; //Courtage är alltid 39 om uträkningen ovan är under eller lika med 26000.
            }

            else {
            summaCourtage = ((antalAktier * inköpspris) * 0.0015); //Om affären är värd mer än 26000 - då tas 0,15% i courtage istället.
            }

            if ((antalAktier * säljpris) <= 26000)
            {
                summaCourtage = summaCourtage + 39; //Samma uträkning som ovan genomförs även för säljpriset - och adderas med tidigare courtage.
            }

            else
            {
                summaCourtage = summaCourtage + ((antalAktier * säljpris) * 0.0015); //Samma uträkning som ovan genomförs även för säljpriset - och adderas med tidigare courtage.
            }

            courtageSträng = "Du betalade totalt " + summaCourtage.ToString() + "kr i courtage.\n" +
                "Du köpte ursprungligen aktier för " + (antalAktier * inköpspris).ToString() + "kr.\n" +
                "Och du sålde aktierna för ett värde av " + (antalAktier * säljpris).ToString() + "kr.\n"; //Detta är den grundläggande courtagesträngen. Den byggs vidare på
            //i nästkommande if och else-satser.

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

            return courtageSträng; //Courtagesträng är nu den grundläggande courtagesträngen plus eventuella tillägg i if/else satserna ovan.
            

        }

        private void knappRäknaUt_Click(object sender, EventArgs e)

        {
            //Samtliga inputrutor initierar nu variablernas värden och dessa värden används i metoden ovan.
            antalAktier = Convert.ToInt32(inputAntalAktier.Text);
            inköpspris = Convert.ToDouble(inputInköpspris.Text);
            säljpris = Convert.ToDouble(inputSäljpris.Text);
            MessageBox.Show(räknaUtCourtage(antalAktier, inköpspris, säljpris));
        }

        private void knappAvsluta_Click(object sender, EventArgs e)
        {
            //Återgår till programvalsrutan via knapp på GUI:t.
            Form återgå = new programvalsruta();
            återgå.Show();
            this.Hide();
        }

        private void huvudruta_Load(object sender, EventArgs e)
        {
            //Huvudrutan för Aktievinst.
            this.MaximizeBox = false;
            this.CenterToScreen(); 
        }

        private void avslutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Återgår till programvalsrutan via Arkiv-toolstripen.
            Form återgå = new programvalsruta();
            återgå.Show();
            this.Hide();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Visar informationsrutan för Aktievinst (åtkomligt via Arkiv).
            aktievinstinformationsruta informationsRuta = new aktievinstinformationsruta();
            informationsRuta.Show();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            //Avslutar hela applikationen om X trycks in.
            base.OnFormClosing(e);
            Application.Exit();
        }

    }

}
