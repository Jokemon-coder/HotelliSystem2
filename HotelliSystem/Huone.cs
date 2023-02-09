using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using Eramake;

namespace HotelliSystem
{
    class Huone
    {
        Yhdista yht = new Yhdista();

        public DataTable huoneTyyppiLista() //Get the types of rooms from database as a list
        {
            MySqlCommand komento = new MySqlCommand("SELECT * FROM `huone_kategoria`", yht.OtaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);

            return taulu;
        }

        public DataTable huoneTyyppiltaLista(int tyyppi) //Get rooms by type and if they're available
        {
            MySqlCommand komento = new MySqlCommand("SELECT * FROM `huoneet` WHERE `tyyppi`=@tp and vapaa='KYLLÄ'", yht.OtaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();
            komento.Parameters.Add("@tp", MySqlDbType.Int32).Value = tyyppi;

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);

            return taulu;
        }

        public int haeHuoneTyyppi(int numero) //Get room by it's number from database
        {
            MySqlCommand komento = new MySqlCommand("SELECT `tyyppi` FROM `huoneet` WHERE `numero`=@num", yht.OtaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();
            komento.Parameters.Add("@num", MySqlDbType.Int32).Value = numero;

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);

            return Convert.ToInt32(taulu.Rows[0][0].ToString());
        }

        public bool huoneestaKYLLAEI(int numero, String KYLLA_tai_EI) //Get "KYLLÄ" if room is free and "EI" if it is not
        {
            MySqlCommand komento = new MySqlCommand("UPDATE `huoneet` SET `vapaa`=@kyl_ei WHERE `numero`=@num", yht.OtaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();
            komento.Parameters.Add("@num", MySqlDbType.Int32).Value = numero;
            komento.Parameters.Add("@kyl_ei", MySqlDbType.VarChar).Value = KYLLA_tai_EI;

            yht.AvaaYhteys();
            if (komento.ExecuteNonQuery() == 1)
            {
                yht.SuljeYhteys();
                return false;
            }
            else
            {
                yht.SuljeYhteys();
                return true;
            }
        }

        public bool lisaaHuone(int huonenum, int tyyppi, String puhelin, String vapaa) //Add room into database with values
        {
            MySqlCommand komento = new MySqlCommand();
            String lisaa = "INSERT INTO `huoneet`(`numero`, `tyyppi`, `puhelin`, `vapaa`) VALUES (@num,@tp,@puh,@vap)";
            komento.CommandText = lisaa;
            komento.Connection = yht.OtaYhteys();

            komento.Parameters.Add("@num", MySqlDbType.Int32).Value = huonenum;
            komento.Parameters.Add("@tp", MySqlDbType.Int32).Value = tyyppi;
            komento.Parameters.Add("@puh", MySqlDbType.VarChar).Value = puhelin;
            komento.Parameters.Add("@vap", MySqlDbType.VarChar).Value = vapaa;

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

        public DataTable haeHuoneet() //Get rooms from database
        {
            MySqlCommand komento = new MySqlCommand("SELECT * FROM `huoneet`", yht.OtaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);

            return taulu;
        }

        public bool muokkaaHuone(int huonenum, int tyyppi, String puhelin, String vapaa) //Edit room and it's information in database
        {
            MySqlCommand komento = new MySqlCommand();
            String muokkaa = "UPDATE `huoneet` SET `tyyppi`=@tp,`puhelin`=@puh,`vapaa`=@vap WHERE `numero`=@num";
            komento.CommandText = muokkaa;
            komento.Connection = yht.OtaYhteys();

            komento.Parameters.Add("@num", MySqlDbType.Int32).Value = huonenum;
            komento.Parameters.Add("@tp", MySqlDbType.Int32).Value = tyyppi;
            komento.Parameters.Add("@puh", MySqlDbType.VarChar).Value = puhelin;
            komento.Parameters.Add("@vap", MySqlDbType.VarChar).Value = vapaa;

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
        public bool poistaHuone(int huonenum) //Delete room entirely from database based on it's room number
        {
            MySqlCommand komento = new MySqlCommand();
            String poista = "DELETE FROM `huoneet` WHERE `numero`=@num";
            komento.CommandText = poista;
            komento.Connection = yht.OtaYhteys();
            komento.Parameters.Add("@num", MySqlDbType.Int32).Value = huonenum;
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
