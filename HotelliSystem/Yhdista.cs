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
    class Yhdista
    {
        private readonly MySqlConnection yhteys = new MySqlConnection("datasource=localhost; port=3306; username=example; password=example; database=hotelli"); //Get connection to SQL database.
        
        public MySqlConnection OtaYhteys()
        {
            return yhteys;
        }

        public void AvaaYhteys() //Open connection
        {
            if(yhteys.State == ConnectionState.Closed)
            {
                yhteys.Open();
            }
        }

        public void SuljeYhteys() //Close connection
        {
            if(yhteys.State == ConnectionState.Open)
            {
                yhteys.Close();
            }
        }
    }
}
