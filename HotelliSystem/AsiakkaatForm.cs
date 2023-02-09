using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace HotelliSystem
{
    public partial class AsiakkaatForm : Form
    {
        Yhdista yht = new Yhdista();
        Asiakas asiakas = new Asiakas();
        
        public AsiakkaatForm()
        {
            InitializeComponent();
        }

        private void AsiakkaatForm_FormClosing(object sender, FormClosingEventArgs e) //Kun ikkuna suljetaan, pääikkuna tulee näkyviin
        {
            PaaIkkuna  pikkuna = new PaaIkkuna();
            pikkuna.Show();
        }

        private void tyhjennaBT_Click(object sender, EventArgs e) //Tyhjentää eli asettaa jokaisen syöttöikkunan tyhjäksi
        {
            etunimiTB.Text = "";
            sukunimiTB.Text = "";
            osoiteTB.Text = "";
            pnumeroTB.Text = "";
            ptoimipaikkaTB.Text = "";
            ktunnusTB.Text = "";
            salasanaTB.Text = "";
        }

        private void lisaaBT_Click(object sender, EventArgs e) //Katsoo ja asettaa syötön tietokantaan
        {
            String enimi = etunimiTB.Text;
            String snimi = sukunimiTB.Text;
            String osoite = osoiteTB.Text;
            String pnumero = pnumeroTB.Text;
            String ptoimipaikka = ptoimipaikkaTB.Text;
            String ktunnus = ktunnusTB.Text;
            String salasana = salasanaTB.Text;

            //Jos kenttä tai kentät ovat tyhjiä, tulee virheviesti
            if (enimi.Trim().Equals("") || snimi.Trim().Equals("") || osoite.Trim().Equals("") || pnumero.Trim().Equals("") || ptoimipaikka.Trim().Equals("") || ktunnus.Trim().Equals("") || salasana.Trim().Equals(""))
            {
                MessageBox.Show("Et voi syöttää tyhjää", "Tyhjiä kenttiä", MessageBoxButtons.OK);
            }else if (ktunnus == enimi) //Käyttäjätunnus ei voi olla sama kuin etunimi
            {
                MessageBox.Show("Älä syötä samaa nimeä käyttäjätunnukseksi ja etunimeksi", "Käyttäjätunnus", MessageBoxButtons.OK);
            }
            else
            {
                Boolean lisaaAsiakas = asiakas.lisaaAsiakas(enimi, snimi, osoite, pnumero, ptoimipaikka, ktunnus, salasana);

                if (lisaaAsiakas) //Lisää annetut kentät ja niiden tiedot tietokantaan ja antaa viestin
                {
                    asiakkaatDG.DataSource = asiakas.haeAsiakkaat();
                    MessageBox.Show("Uusi asiakas lisätty ilman ongelmia", "Lisää asiakas", MessageBoxButtons.OK);
                }
                else //Jos jokin menee vikaan, tulee virheviesti
                {
                    MessageBox.Show("Jokin meni vikaan. Uutta asiakasta ei pystytty lisäämään", "Lisää asiakas", MessageBoxButtons.OK);
                }
            }
        }

        private void AsiakkaatForm_Load(object sender, EventArgs e)
        {
            asiakkaatDG.DataSource = asiakas.haeAsiakkaat();
        }

        private void muokkaaBT_Click(object sender, EventArgs e) //Muokataan asiakas
        {
            String enimi = etunimiTB.Text;
            String snimi = sukunimiTB.Text;
            String osoite = osoiteTB.Text;
            String pnumero = pnumeroTB.Text;
            String ptoimipaikka = ptoimipaikkaTB.Text;
            String ktunnus = ktunnusTB.Text;
            String salasana = salasanaTB.Text;

            if (enimi.Trim().Equals("") || snimi.Trim().Equals("") || osoite.Trim().Equals("") || pnumero.Trim().Equals("") || ptoimipaikka.Trim().Equals("") || ktunnus.Trim().Equals("") || salasana.Trim().Equals(""))
            {
                MessageBox.Show("Et voi syöttää tyhjää", "Tyhjiä kenttiä", MessageBoxButtons.OK);
            }
            else if (ktunnus == enimi) //Käyttäjätunnus ei voi olla sama kuin etunimi
            {
                MessageBox.Show("Älä syötä samaa nimeä käyttäjätunnukseksi ja etunimeksi", "Etunimi", MessageBoxButtons.OK);
            }
            else
            {
                Boolean muokkaaAsiakas = asiakas.muokkaaAsiakas(enimi, snimi, osoite, pnumero, ptoimipaikka, ktunnus, salasana);

                if (muokkaaAsiakas) //Muokkaa tiedot ja päivittää tietokannan
                {
                    asiakkaatDG.DataSource = asiakas.haeAsiakkaat();
                    MessageBox.Show("Asiakasta muokattu ilman ongelmia", "Muokkaa asiakas", MessageBoxButtons.OK);
                }
                else //Käyttäjänimeä ei voi muokata, koska se on PRIMARY KEY. Virheviesti tulee.
                {
                    MessageBox.Show("Et voi muokata käyttäjänimeä", "Muokkaa asiakas", MessageBoxButtons.OK);
                }
            }
        }

        private void asiakkaatDG_CellClick(object sender, DataGridViewCellEventArgs e) //Kun painetaan taulusta asiakkaan tietoja, ne täyttyvät kenttiin
        {
            ktunnusTB.Text = asiakkaatDG.CurrentRow.Cells[0].Value.ToString();
            etunimiTB.Text = asiakkaatDG.CurrentRow.Cells[1].Value.ToString();
            sukunimiTB.Text = asiakkaatDG.CurrentRow.Cells[2].Value.ToString();
            osoiteTB.Text = asiakkaatDG.CurrentRow.Cells[3].Value.ToString();
            pnumeroTB.Text = asiakkaatDG.CurrentRow.Cells[4].Value.ToString();
            ptoimipaikkaTB.Text = asiakkaatDG.CurrentRow.Cells[5].Value.ToString();
            salasanaTB.Text = asiakkaatDG.CurrentRow.Cells[6].Value.ToString();
        }

        private void poistaBT_Click(object sender, EventArgs e)
        {
            string ktunnus = ktunnusTB.Text;
            if (asiakas.poistaAsiakas(ktunnus)) //Poistetaan asiakas
            {
                asiakkaatDG.DataSource = asiakas.haeAsiakkaat();
                MessageBox.Show("Asiakas poistettu", "Poista asiakas", MessageBoxButtons.OK);
            }else
            {
                MessageBox.Show("Asiakasta ei pystytty poistamaan", "Poista asiakas", MessageBoxButtons.OK);
            }
        }

        private void naytaBT_Click(object sender, EventArgs e) //Vaihdetaan salasana näkyviin tai piiloon.
        {
            if (salasanaTB.UseSystemPasswordChar == true)
            {
                salasanaTB.UseSystemPasswordChar = false;
            }
            else
            {
                salasanaTB.UseSystemPasswordChar = true;
            }
        }
    }
}
