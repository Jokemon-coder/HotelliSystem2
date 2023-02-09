using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelliSystem
{
    public partial class VarauksetForm : Form
    {
        public VarauksetForm()
        {
            InitializeComponent();
        }

        Huone huone = new Huone();
        Varaus varaus = new Varaus();
        
        private void VarauksetForm_FormClosing(object sender, FormClosingEventArgs e) //Kun suljetaan, pääikkuna auki
        {
            PaaIkkuna pikkuna = new PaaIkkuna();
            pikkuna.Show();
        }

        private void VarauksetForm_Load(object sender, EventArgs e) //Annetaan huoneen tyypit ja numerot
        {
            tyyppiCB.DataSource = huone.huoneTyyppiLista();
            tyyppiCB.DisplayMember = "tyyppi";
            tyyppiCB.ValueMember = "kategoria_id";

            int tyyppi = Convert.ToInt32(tyyppiCB.SelectedValue.ToString());
            huoneNumCB.DataSource = huone.huoneTyyppiltaLista(tyyppi);
            huoneNumCB.DisplayMember = "numero";
            huoneNumCB.ValueMember = "numero";

            varauksetDG.DataSource = varaus.haeVaraukset();
        }

        private void lisvarausBT_Click(object sender, EventArgs e) //Lisätään varaus ja sen tiedot tietokantaan
        {
            try 
            {
                String asiakas = asiakasTB.Text;
                int huoneNumero = Convert.ToInt32(huoneNumCB.SelectedValue);
                DateTime saapuminen = saapusmisDTP.Value;
                DateTime lahto = lahtoDTP.Value;

                if (saapuminen.Day < DateTime.Now.Day) //Saapumis- ja lähtöaika samana päivänä tai tulevaisuudessa. Saapuminen ei voi olla ennen nykyistä päivämäärää.
                {
                    MessageBox.Show("Päivämäärän pitää olla joko sama tai tulevaisuudessa", "Virheellinen saapumisaika", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (lahto.Day < saapuminen.Day)
                {
                    MessageBox.Show("Päivämäärän pitää olla joko sama tai myöhemmin kuin saapumisaika", "Virheellinen lähtöaika", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (varaus.lisaaVaraus(huoneNumero, asiakas, saapuminen, lahto)) //Varaus lisätään ja viesti
                    {
                        huone.huoneestaKYLLAEI(huoneNumero, "EI");
                        varauksetDG.DataSource = varaus.haeVaraukset();
                        MessageBox.Show("Varaus lisätty ilman ongelmia", "Varauksen lisäys", MessageBoxButtons.OK);

                        //Kun on lisätty uusi varaus ja painetaan OK viestilaatikosta, kentät tyhjennetään 
                        varausTB.Text = "";
                        asiakasTB.Text = "";
                        tyyppiCB.SelectedIndex = 0;
                        saapusmisDTP.Value = DateTime.Now;
                        lahtoDTP.Value = DateTime.Now;
                    }
                    else //Muuten jos ei lisätty, viesti siitä
                    {
                        MessageBox.Show("Varausta ei pystytty lisäämään", "Varauksen lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }catch //Virhe
            {
                MessageBox.Show("Varausta ei pystytty lisäämään", "Varauksen lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void muovarausBT_Click(object sender, EventArgs e) //Muokataan varaus
        {
            try //Try-catch ja kaikki sen sisälle
            {
                int varausID = Convert.ToInt32(varausTB.Text);
                int huoneNumero = Convert.ToInt32(varauksetDG.CurrentRow.Cells[1].Value.ToString());
                String asiakas = asiakasTB.Text;
                DateTime saapuminen = saapusmisDTP.Value;
                DateTime lahto = lahtoDTP.Value;
                //Määritellään tiedot ja niiden tyypit

                if (saapuminen.Day < DateTime.Now.Day) //Jos saapumisaika on menneisyydessä, tulee viesti eikä lisätä mitään
                {
                    MessageBox.Show("Päivämäärän pitää olla tulevaisuudessa", "Virheellinen saapumisaika", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (lahto.Day < saapuminen.Day) //Jos lähtöaika on aikaisemmin kuin saapumisaika, tulee viesti eikä lisätä mitään
                {
                    MessageBox.Show("Päivämäärän pitää olla myöhemmin kuin saapumisaika", "Virheellinen lähtöaika", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else 
                {
                    if (varaus.muokkaaVaraus(varausID, huoneNumero, asiakas, saapuminen, lahto)) //Muuten muokkaus menee eteenpäin
                    {
                        //En saanut tehtyä niin, että voi muokata varauksen huoneen numeroa johonkin toiseen (Missä vika?). Jos haluaa vaihtaa varauksen numeron, pitää poistaa ja luoda uusi varaus

                        //Huone, jota muokataan laitetaan "EI" eli ei ole vapaa.
                        huone.huoneestaKYLLAEI(huoneNumero, "EI");
                        varauksetDG.DataSource = varaus.haeVaraukset();
                        MessageBox.Show("Varausta muokattu ilman ongelmia", "Varauksen muokkaus", MessageBoxButtons.OK);
                    }
                    else //Muuten jos ei muokattu, viesti siitä
                    {
                        MessageBox.Show("Varausta ei pystytty muokkaamaan", "Varauksen muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch //Virhe
            {
                MessageBox.Show("Varausta ei pystytty muokkaamaan", "Varauksen muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void poistavarausBT_Click(object sender, EventArgs e) //Poistetaan varaus ja sen tiedot tietokannasta
        {
            try
            {
                int varausID = Convert.ToInt32(varausTB.Text);
                int huoneNumero = Convert.ToInt32(varauksetDG.CurrentRow.Cells[1].Value.ToString());
                if (varaus.poistaVaraus(varausID)) //Jos kaikki menee läpi, varaus poistetaan ja kyseinen huone asennetaan vapaaksi eli KYLLÄ on vapaa
                {
                    huone.huoneestaKYLLAEI(huoneNumero, "KYLLÄ");
                    varauksetDG.DataSource = varaus.haeVaraukset();
                    MessageBox.Show("Varaus poistettu ilman ongelmia", "Varauksen poistaminen", MessageBoxButtons.OK);

                    //Kun varaus poistettu, tyhjennetään kentät
                    varausTB.Text = "";
                    asiakasTB.Text = "";
                    tyyppiCB.SelectedIndex = 0;
                    saapusmisDTP.Value = DateTime.Now;
                    lahtoDTP.Value = DateTime.Now;
                }
                else //Muuten jos ei poistettu, viesti siitä
                {
                    MessageBox.Show("Varausta ei pystytty poistamaan", "Varauksen poistaminen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch //Virhe
            {
                MessageBox.Show("Varausta ei pystytty poistamaan", "Varauksen poistaminen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tyhjBT_Click(object sender, EventArgs e) //Asettaa kentät tyhjiksi
        {
            varausTB.Text = "";
            asiakasTB.Text = "";
            tyyppiCB.SelectedIndex = 0;
            saapusmisDTP.Value = DateTime.Now;
            lahtoDTP.Value = DateTime.Now;
        }

        private void tyyppiCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int tyyppi = Convert.ToInt32(tyyppiCB.SelectedValue.ToString());
                huoneNumCB.DataSource = huone.huoneTyyppiltaLista(tyyppi);
                huoneNumCB.DisplayMember = "numero";
                huoneNumCB.ValueMember = "numero";
            }
            catch
            {

            }
        }

        private void varauksetDG_CellClick(object sender, DataGridViewCellEventArgs e) //Tietotaulukosta tiedot kenttiin
        {
            varausTB.Text = varauksetDG.CurrentRow.Cells[0].Value.ToString();
            
            int huoneID = Convert.ToInt32(varauksetDG.CurrentRow.Cells[1].Value.ToString());
            tyyppiCB.SelectedValue = huone.haeHuoneTyyppi(huoneID);

            huoneNumCB.SelectedValue = huoneID;

            asiakasTB.Text = varauksetDG.CurrentRow.Cells[2].Value.ToString();

            saapusmisDTP.Value = Convert.ToDateTime(varauksetDG.CurrentRow.Cells[3].Value);
            lahtoDTP.Value = Convert.ToDateTime(varauksetDG.CurrentRow.Cells[4].Value);
        }
    }
}
