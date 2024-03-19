using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace _2024_01_09_Lakopark
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
            sb.Database = "lakopark";
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

        internal List<Lakopark> parkadatokBetoltese()
        {
            List<Lakopark> lp = new List<Lakopark>();
            sql.CommandText = "SELECT * FROM lakopark NATURAL JOIN epuletek;";
            try
            {
                kapcsolatNyit();
                using (MySqlDataReader dr = sql.ExecuteReader())
                {
                    int aktualisId = -1;
                    int lakoparkIndex = -1;
                    while (dr.Read())
                    {
                        if (aktualisId!=dr.GetInt32("lakoparkId"))
                        {
                            lp.Add(new Lakopark(dr.GetInt32("lakoparkId"), dr.GetString("lakoparkNev"), dr.GetInt32("utcakSzama"), dr.GetInt32("telkekSzama")));
                            aktualisId = dr.GetInt32("lakoparkId");
                            lakoparkIndex++;
                        }
                        lp[lakoparkIndex].HazAdat(dr.GetInt32("utcaSzam"), dr.GetInt32("hazSzam"), dr.GetInt32("emelet"));
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

            return lp;
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
