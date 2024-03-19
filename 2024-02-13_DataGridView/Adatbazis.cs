using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace _2024_02_13_DataGridView
{
    class Adatbazis
    {
        MySqlConnection connection = null;
        MySqlCommand sql = null;

        public Adatbazis()
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "orszagok";
            sb.CharacterSet = "utf8";
            connection = new MySqlConnection(sb.ConnectionString);
            sql = connection.CreateCommand();
            try
            {
                kapcsolatNyit();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                kapcsolatZar();
            }
        }

        internal List<Orszag> orszagAdatokBetoltese()
        {
            List<Orszag> orszagok = new List<Orszag>();
            sql.CommandText = "SELECT `orszag`,`fovaros`,`terulet` FROM `orszagok` WHERE 1;";
            try
            {
                kapcsolatNyit();
                using (MySqlDataReader dr = sql.ExecuteReader())
                {
                    while (dr.Read())
                    {
                            orszagok.Add(new Orszag(dr.GetString("orszag"), dr.GetString("fovaros"), dr.GetDouble("terulet")));
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                kapcsolatZar();
            }

            return orszagok;
        }

        private void kapcsolatZar()
        {
            if (connection.State != System.Data.ConnectionState.Closed)
            {
                connection.Close();
            }
        }

        private void kapcsolatNyit()
        {
            if (connection.State != System.Data.ConnectionState.Open) connection.Open();
        }
    }
}

