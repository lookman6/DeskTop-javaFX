using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Reflection;
using System.Data;
using System.Data.SqlClient;

namespace GestionEnsat
{
    class Connexion
    {
        public static IDbConnection con = null;
        public static IDbCommand cmd = null;
        public static void Connect(string dbname, string server = "localhost", string user = "root", string password = "")
        {

            if (con == null)
            {
                try
                {
                    con = new MySqlConnection("server= " + server + ";user id = " + user + "; database = " + dbname);
                    cmd = new MySqlCommand();
                    con.Open();
                }
                catch (Exception e)
                {
                    con = new SqlConnection("server= " + server + ";user id = " + user + "; database = " + dbname);
                    cmd = new SqlCommand();
                    con.Open();
                }
                if (con.State.ToString() == "Closed")
                    con.Open();
                cmd.Connection = con;
            }

        }
        public static int IUD(string req)
        {
            cmd.CommandText = req;
            return cmd.ExecuteNonQuery();

        }
        public static IDataReader Select(string req)
        {
            cmd.CommandText = req;
            return cmd.ExecuteReader();
        }
        public static Dictionary<string, string> getChamps_table(string table)
        {
            Dictionary<string, string> dico = new Dictionary<string, string>();
            IDataReader reader = Select("select column_name, column_type " +
            "from information_schema.columns where table_name='" + table + "' and table_schema = '"+con.Database+"'; ");
            while (reader.Read())
            {
                dico.Add(reader.GetString(0), reader.GetString(1));
            }
            //foreach (KeyValuePair<string, string> d in dico)
            //{
            // Console.WriteLine("Clé: {0}, Type: {1}", d.Key, d.Value);
            //}
            return dico;
        }
    }
}
