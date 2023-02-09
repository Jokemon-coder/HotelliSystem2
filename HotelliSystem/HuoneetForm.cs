using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Eramake;

namespace HotelliSystem
{
    public partial class HuoneetForm : Form
    {
        public HuoneetForm()
        {
            InitializeComponent();
        }

        private void HuoneetForm_FormClosing(object sender, FormClosingEventArgs e) //Open main window when this is closed. 
        {
            PaaIkkuna pikkuna = new PaaIkkuna();
            pikkuna.Show();
        }

        Huone huone = new Huone();
        private void HuoneetForm_Load(object sender, EventArgs e) //When the form is opened, database content is displayed on datagrid. 
        {
            tyyppiCB.DataSource = huone.huoneTyyppiLista();
            tyyppiCB.DisplayMember = "tyyppi";
            tyyppiCB.ValueMember = "kategoria_id";

            huoneetDG.DataSource = huone.haeHuoneet();
        }

        private void lishuoneBT_Click(object sender, EventArgs e) //Add a room into database
        {
            
            try //Check if everything is in order
            {
            int numero = Convert.ToInt32(numTB.Text);
            int tyyppi = Convert.ToInt32(tyyppiCB.SelectedValue.ToString());
            string puhelin = puhelinTB.Text;
            string vapaa = "";

                if (kylläBT.Checked)
                {
                    vapaa = "KYLLÄ";
                }
                else if (eiBT.Checked)
                {
                    vapaa = "EI";
                }

                if (huone.lisaaHuone(numero, tyyppi, puhelin, vapaa)) //If room is succefully added, update datagrid with new information and give message
                {
                    huoneetDG.DataSource = huone.haeHuoneet();
                    MessageBox.Show("Huone lisätty ilman ongelmia", "Huoneen lisäys", MessageBoxButtons.OK);
                }
                else //Otherwise receive error
                {
                    MessageBox.Show("Huonetta ei pystytty lisäämään", "Huoneen lisäys", MessageBoxButtons.OK);
                }
            }catch //Can't enter same room number for two different rooms
            {
                MessageBox.Show("Huoneen numero on jo käytössä", "Huoneen lisäys" , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void muohuoneBT_Click(object sender, EventArgs e) //Edit rooms
        {
            try
            {
                int huonenum = Convert.ToInt32(numTB.Text);
                int tyyppi = Convert.ToInt32(tyyppiCB.SelectedValue.ToString());
                String puhelin = puhelinTB.Text;
                String vapaa = "";

                if (kylläBT.Checked)
                {
                    vapaa = "KYLLÄ";
                }
                else if (eiBT.Checked)
                {
                    vapaa = "EI";
                }
                if (huone.muokkaaHuone(huonenum, tyyppi, puhelin, vapaa)) //If everything goes well, update datagrid and show message
                {
                    huoneetDG.DataSource = huone.haeHuoneet();
                    MessageBox.Show("Huonetta muokattu ilman ongelmia", "Muokkaa huone", MessageBoxButtons.OK);
                }
                else //Otherwise error
                {
                    MessageBox.Show("Huonetta ei pystytty muokkaamaan", "Muokkaa huone", MessageBoxButtons.OK);

                }
            }catch //Can't edit room number, as it is a PRIMARY key in database
            {
                MessageBox.Show("Huonetta ei pystytty muokkaamaan", "Jokin meni vikaan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void poistahuoneBT_Click(object sender, EventArgs e) //Delete room from database
        {
            try
            {
                int huonenum = Convert.ToInt32(numTB.Text);
                if (huone.poistaHuone(huonenum)) //If succesful, delete room based on it's number
                {
                    huoneetDG.DataSource = huone.haeHuoneet();
                    MessageBox.Show("Huone poistettu ilman ongelmia", "Huoneen poisto", MessageBoxButtons.OK);
                }
                else //Otherwise room is not deleted and error
                {
                    MessageBox.Show("Huonetta ei pystytty poistamaan", "Huoneen poisto", MessageBoxButtons.OK);
                }
            }
            catch //Room is not deleted and error
            {
                MessageBox.Show("Huonetta ei pystytty poistamaan", "Jokin meni vikaan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void tyhjBT_Click(object sender, EventArgs e) //Set all input fields as empty
        {
            numTB.Text = "";
            tyyppiCB.SelectedIndex = 0;
            puhelinTB.Text = "";
            kylläBT.Checked = true;
        }

        private void huoneetDG_CellClick(object sender, DataGridViewCellEventArgs e) //Get database information into the datagrid
        {
            numTB.Text = huoneetDG.CurrentRow.Cells[0].Value.ToString();
            tyyppiCB.SelectedValue = huoneetDG.CurrentRow.Cells[1].Value.ToString();
            puhelinTB.Text = huoneetDG.CurrentRow.Cells[2].Value.ToString();
            string vapaa = huoneetDG.CurrentRow.Cells[3].Value.ToString();
            if (vapaa.Equals("KYLLÄ"))
            {
                kylläBT.Checked = true;
            }
            else if (vapaa.Equals("EI"))
            {
                eiBT.Checked = true;
            }
        }
    }
}
