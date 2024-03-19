using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Tarsashaz
{
    class Database
    {
        MySqlConnection connection = null;
        MySqlCommand command = null;

        public Database()
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "tarsashaz";
            sb.CharacterSet = "utf8";
            connection = new MySqlConnection(sb.ConnectionString);
            nyit();
            command = connection.CreateCommand();
            zar();
        }
        public void epuletekListboxba()
        {
            List<Epulet> epuletek = new List<Epulet>();
            command.CommandText = "SELECT `epuletid`,`utcanev`,`hazszam` FROM `epuletek`";
            nyit();
            using (MySqlDataReader dr = command.ExecuteReader())
            {
                while (dr.Read())
                {
                    Epulet epulet = new Epulet(dr.GetUInt64("epuletid"), dr.GetString("utcanev"), dr.GetInt32("hazszam"));
                    epuletek.Add(epulet);
                }
            }
            command.CommandText = "SELECT `lakoid`,`lakonev`,`szulev` FROM `lakok` WHERE `epuletid`= @id";
            foreach (Epulet item in epuletek)
            {
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@id", item.epuletid);
                using (MySqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Lako lako = new Lako(dr.GetUInt64("lakoid"), dr.GetString("lakonev"), dr.GetInt32("szulev"), item.epuletid);
                        item.lakok.Add(lako);
                    }
                }
                Program.formNyito.listBox_Epuletek.Items.Add(item);
            }
            zar();

        }

        private void zar()
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void nyit()
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }        
        }
    }
}
