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
    class Asiakas
    {
        Yhdista yht = new Yhdista();
        public bool lisaaAsiakas(String enimi, String snimi, String osoite, String pnumero, String ppaikka, String ktunnus, String salasana) //Add customer to database
        {
            MySqlCommand komento = new MySqlCommand();
            String lisaa = "INSERT INTO `asiakkaat`(`Ktunnus`, `Etunimi`, `Sukunimi`, `Lähiosoite`, `Postinumero`, `Postitoimipaikka`, `Salasana`) VALUES (@ktunnus,@enimi,@snimi,@osoite,@pnumero,@ppaikka,@salasana)";
            komento.CommandText = lisaa;
            komento.Connection = yht.OtaYhteys();

            komento.Parameters.Add("@ktunnus", MySqlDbType.VarChar).Value = ktunnus;
            komento.Parameters.Add("@enimi", MySqlDbType.VarChar).Value = enimi;
            komento.Parameters.Add("@snimi", MySqlDbType.VarChar).Value = snimi;
            komento.Parameters.Add("@osoite", MySqlDbType.VarChar).Value = osoite;
            komento.Parameters.Add("@pnumero", MySqlDbType.VarChar).Value = pnumero;
            komento.Parameters.Add("@ppaikka", MySqlDbType.VarChar).Value = ppaikka;
            komento.Parameters.Add("@salasana", MySqlDbType.VarChar).Value = eCryptography.Encrypt(salasana); //Encrypt their password

            yht.AvaaYhteys();
            if (komento.ExecuteNonQuery() == 1)
            {
                return true;
            }else
            {
                yht.SuljeYhteys();
                return false;
            }  
        }

        public DataTable haeAsiakkaat() //Get customers from database
        {
            MySqlCommand komento = new MySqlCommand("SELECT * FROM `asiakkaat`", yht.OtaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);

            return taulu;
        }

        public bool muokkaaAsiakas(String enimi, String snimi, String osoite, String pnumero, String ppaikka, String ktunnus, String salasana) //Edit customer in database
        {
            MySqlCommand komento = new MySqlCommand();
            String muokkaa = "UPDATE `asiakkaat` SET `Ktunnus`=@ktunnus,`Etunimi`=@enimi,`Sukunimi`=@snimi,`Lähiosoite`=@osoite,`Postinumero`=@pnumero,`Postitoimipaikka`=@ppaikka,`Salasana`=@salasana WHERE `Ktunnus`=@ktunnus";
            komento.CommandText = muokkaa;
            komento.Connection = yht.OtaYhteys();

            komento.Parameters.Add("@ktunnus", MySqlDbType.VarChar).Value = ktunnus;
            komento.Parameters.Add("@enimi", MySqlDbType.VarChar).Value = enimi;
            komento.Parameters.Add("@snimi", MySqlDbType.VarChar).Value = snimi;
            komento.Parameters.Add("@osoite", MySqlDbType.VarChar).Value = osoite;
            komento.Parameters.Add("@pnumero", MySqlDbType.VarChar).Value = pnumero;
            komento.Parameters.Add("@ppaikka", MySqlDbType.VarChar).Value = ppaikka;
            komento.Parameters.Add("@salasana", MySqlDbType.VarChar).Value = eCryptography.Encrypt(salasana);

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

        public bool poistaAsiakas(String ktunnus) //Delete customer based on their username
        {
            MySqlCommand komento = new MySqlCommand();
            String poista = "DELETE FROM `asiakkaat` WHERE `Ktunnus`=@ktunnus";
            komento.CommandText = poista;
            komento.Connection = yht.OtaYhteys();
            komento.Parameters.Add("@ktunnus", MySqlDbType.VarChar).Value = ktunnus;
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
