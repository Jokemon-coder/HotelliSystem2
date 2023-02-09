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
using Eramake;

namespace HotelliSystem
{
    public partial class KirjautumisForm : Form
    {
        public KirjautumisForm()
        {
            InitializeComponent();
        }

        private void naytaBT_Click(object sender, EventArgs e) //Switch password between visible and invisible.
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

        private void kirjauduBT_Click(object sender, EventArgs e)
        {
            //Connect and get a username and password from users.
            Yhdista yht = new Yhdista();
            DataTable taulu = new DataTable();
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            MySqlCommand komento = new MySqlCommand();
            String qr = "SELECT Ktunnus, Salasana FROM `asiakkaat` WHERE `Ktunnus` =@ktunnus AND `Salasana` =@ss";

            komento.CommandText = qr;
            komento.Connection = yht.OtaYhteys();

            komento.Parameters.Add("@ktunnus", MySqlDbType.VarChar).Value = kayttajaTB.Text;
            komento.Parameters.Add("@ss", MySqlDbType.VarChar).Value = eCryptography.Encrypt(salasanaTB.Text);

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);

            if(taulu.Rows.Count > 0) //If everything is in order, proceed to next window
            {
                this.Hide();
                PaaIkkuna pikkuna = new PaaIkkuna();
                pikkuna.Show();
            }else //Otherwise give one of 3 error messages based on if username or password are empty or the user doesn't exist.
            {
                if(kayttajaTB.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Syötä käyttänimesi kirjautuaksesi sisään", "Tyhjä käyttänimi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }else if (salasanaTB.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Syötä salasanasi kirjautuaksesi sisään", "Tyhjä salasana", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }else
                {
                    MessageBox.Show("Tätä käyttänimeä tai salasanaa ei ole olemassa", "Tietoja ei löytynyt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void KirjautumisForm_FormClosing(object sender, FormClosingEventArgs e) //Close the entire program
        {
            Environment.Exit(0);
        }

        private void tietojaToolStripMenuItem_Click(object sender, EventArgs e) //Open information tab
        {
            MessageBox.Show("Ohjelman on tehnyt Joel Mantere", "Tietoja ohjelmasta", MessageBoxButtons.OK);
        }

        private void kayttajaTB_KeyDown(object sender, KeyEventArgs e) //Pressing enter in the input field moves onto the next field
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void salasanaTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }
    }
}
