using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using Eramake;

namespace HotelliSystem
{
    class Varaus
    {
        Yhdista yht = new Yhdista();

        public DataTable haeVaraukset() //Get reservations and their information from database.
        {
            MySqlCommand komento = new MySqlCommand("SELECT * FROM `varaukset`", yht.OtaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);

            return taulu;
        }

        public bool lisaaVaraus(int huonenum, String asiakas, DateTime saapuminen, DateTime lahto) //Add reservation and its information into database.
        {
            MySqlCommand komento = new MySqlCommand();
            String lisaa = "INSERT INTO `varaukset`(`huoneNumero`, `asiakasID`, `saapumisAika`, `lahtoAika`) VALUES (@huonenum,@asiaID,@saika,@laika)";
            komento.CommandText = lisaa;
            komento.Connection = yht.OtaYhteys();

            komento.Parameters.Add("@huonenum", MySqlDbType.Int32).Value = huonenum;
            komento.Parameters.Add("@asiaID", MySqlDbType.VarChar).Value = asiakas;
            komento.Parameters.Add("@saika", MySqlDbType.Date).Value = saapuminen;
            komento.Parameters.Add("@laika", MySqlDbType.Date).Value = lahto;

            yht.AvaaYhteys();
            if (komento.ExecuteNonQuery() == 1)
            {
                yht.SuljeYhteys();
                return true;
            }
            else
            {
                yht.SuljeYhteys();
                return false;
            }
        }

        public bool muokkaaVaraus(int varausID, int huonenum, String asiakas, DateTime saapuminen, DateTime lahto) //Edit reservation and its information based on "VarausID".
        {
            MySqlCommand komento = new MySqlCommand();
            String muokkaa = "UPDATE `varaukset` SET `huoneNumero`=@huonenum,`asiakasID`=@asiaID,`saapumisAika`=@saika,`lahtoAika`=@laika WHERE `VarausID` =@varID";
            komento.CommandText = muokkaa;
            komento.Connection = yht.OtaYhteys();

            komento.Parameters.Add("@varID", MySqlDbType.Int32).Value = varausID;
            komento.Parameters.Add("@huonenum", MySqlDbType.Int32).Value = huonenum;
            komento.Parameters.Add("@asiaID", MySqlDbType.VarChar).Value = asiakas;
            komento.Parameters.Add("@saika", MySqlDbType.Date).Value = saapuminen;
            komento.Parameters.Add("@laika", MySqlDbType.Date).Value = lahto;

            yht.AvaaYhteys();
            if (komento.ExecuteNonQuery() == 1)
            {
                return true;
            }
            else
            {
                yht.SuljeYhteys();
                return false;
            }
        }

        public bool poistaVaraus(int varausID) //Delete reservation based on "VarausID".
        {
            MySqlCommand komento = new MySqlCommand();
            String poista = "DELETE FROM `varaukset` WHERE `VarausID`=@varID";
            komento.CommandText = poista;
            komento.Connection = yht.OtaYhteys();
            komento.Parameters.Add("@varID", MySqlDbType.Int32).Value = varausID;
            yht.AvaaYhteys();

            if (komento.ExecuteNonQuery() == 1)
            {
                yht.SuljeYhteys();
                return true;
            }
            else
            {
                yht.SuljeYhteys();
                return false;
            }
        }
    }
}
