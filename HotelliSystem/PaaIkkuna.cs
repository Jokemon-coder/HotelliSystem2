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
    public partial class PaaIkkuna : Form
    {
        public PaaIkkuna()
        {
            InitializeComponent();
        }

        private void PaaIkkuna_FormClosing(object sender, FormClosingEventArgs e) //Open the sign in form
        {
            KirjautumisForm kirjaForm = new KirjautumisForm();
            kirjaForm.Show();
        }

        private void asiakkaatToolStripMenuItem_Click(object sender, EventArgs e) //Open up the customer form
        {
            this.Hide();
            AsiakkaatForm asiaForm = new AsiakkaatForm();
            asiaForm.ShowDialog();
        }

        private void huoneetToolStripMenuItem_Click(object sender, EventArgs e) //Open up the room form
        {
            this.Hide();
            HuoneetForm huoneForm = new HuoneetForm();
            huoneForm.ShowDialog();
        }

        private void varauksetToolStripMenuItem_Click(object sender, EventArgs e) //Open up the reservation form
        {
            this.Hide();
            VarauksetForm varausForm = new VarauksetForm();
            varausForm.ShowDialog();
        }
    }
}
