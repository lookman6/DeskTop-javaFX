
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Reflection;
using System.Data;
using Newtonsoft.Json;
using System.Dynamic;

namespace GestionEnsat
{
    class Model
    {
        public int id = 0;
        private string sql = "";


        public Dictionary<string, T> ToDictionary<T>(object obj)
        {
            var json = JsonConvert.SerializeObject(obj);
            var dico = JsonConvert.DeserializeObject<Dictionary<string, T>>(json);
            return dico;
        }
        private dynamic DictionaryToObject(Dictionary<String, object> dico)
        {
            var expandoObj = new ExpandoObject();
            var expandoObjCollection = (ICollection<KeyValuePair<String, Object>>)expandoObj;

            foreach (var keyValuePair in dico)
            {
                expandoObjCollection.Add(keyValuePair);
            }
            dynamic eoDynamic = expandoObj;
            return eoDynamic;
        }
        public int save()
        {
            
            string req = "";

            Dictionary<string, object> dico = new Dictionary<string, object>();
            dico = ToDictionary<object>(this);
            if (id == 0)
            {
                bool ok = dico.Remove(dico.Last().Key);
                req = "insert into " + GetType().Name + " values(0, ";

                foreach (var k in dico)
                {
                    if (k.Value == dico.Last().Value)
                    {
                        if (k.Value.GetType().ToString() == "System.String")
                            req += "\"" + dico.Last().Value + "\"" + ");";
                        else
                            req += dico.Last().Value + ");";

                        break;
                    }
                    else
                    {
                        if (k.Value.GetType().ToString() == "System.String")
                            req += "\"" + k.Value + "\"" + ",";
                        else
                            req += k.Value + ",";
                    }
                }
            }
            else
            {

                req = "update " + GetType().Name + " set ";
                foreach (var k in dico)
                {
                    if (k.Key == dico.ElementAt(dico.Count() - 2).Key) break;
                    if (k.Value.GetType().ToString() == "System.String")
                        req += k.Key + "=" + "\"" + k.Value + "\"" + " , ";
                    else
                        req += k.Key + "=" + k.Value + " , ";

                }
                if (dico.ElementAt(dico.Count() - 2).Value.GetType().ToString() == "System.String")
                    req += dico.ElementAt(dico.Count() - 2).Key + "= " + "\"" + dico.ElementAt(dico.Count() - 2).Value + "\"" + " where id = " + dico["id"] + ";";
                else
                    req += dico.ElementAt(dico.Count() - 2).Key + "= " + dico.ElementAt(dico.Count() - 2).Value + ") where id = " + dico["id"] + ";";
            }
            return Connexion.IUD(req);

        }
        public static int getID<T>(string cr)
        {
            Dictionary<string, object> dico = new Dictionary<string, object>();
            dico.Add("code", cr);
            List<List<dynamic>> d = Model.select<T>(dico);
            return (int)d.First().ElementAt(0);
        }
        public dynamic find()
        {
            Dictionary<string, object> dico = new Dictionary<string, object>();
            Dictionary<string, string> ch = Connexion.getChamps_table(this.GetType().Name);
            int i = 0;
            IDataReader rd = Connexion.Select("select * from " + this.GetType().Name + " where id=" + id + ";");
            foreach (var c in ch)
            {
                rd.Read();
                dico.Add(c.Key, rd.GetValue(i));
                i++;
            }
            rd.Close();
            return (dynamic)DictionaryToObject(dico);
        }
        public static dynamic find<T>(int id)
        {
            List<dynamic> L = new List<dynamic>();
            string tab = typeof(T).Name;
            IDataReader rd = Connexion.Select("select * from " + tab + " where id = " + id + ";");
            while (rd.Read())
            {
                for (int i = 0; i < rd.FieldCount; i++)
                {
                    L.Add(rd.GetValue(i));
                }
            }
            rd.Close();
            return L;
        }
        public int delete()
        {
            sql = "delete from " + this.GetType().Name + " where id=" + id + ";";
            return Connexion.IUD(sql);
        }
        public int delete_proc(string proc)
        {
            MySqlCommand cmd = new MySqlCommand(proc, (MySqlConnection)Connexion.con);
            cmd.CommandType = CommandType.StoredProcedure;
            MySqlParameter p = new MySqlParameter("idP", id);
            cmd.Parameters.Add(p);
            return cmd.ExecuteNonQuery();

        }
        public List<dynamic> All()
        {
            List<dynamic> L = new List<dynamic>();
            sql = "select * from " + this.GetType().Name;
            IDataReader rd = Connexion.Select(sql);
            while (rd.Read())
            {
                for (int i = 0; i < rd.FieldCount; i++)
                    L.Add(rd.GetValue(i));
            }
            rd.Close();
            return L;
        }
        public static List<List<dynamic>> all<T>()
        {
            List<List<dynamic>> L = new List<List<dynamic>>();
            string tab = typeof(T).Name;
            IDataReader rd = Connexion.Select("select * from " + tab + ";");
            while (rd.Read())
            {
                List<dynamic> a = new List<dynamic>();
                for (int i = 0; i < rd.FieldCount; i++)
                {
                    a.Add(rd.GetValue(i));
                }
                L.Add((dynamic)a);
            }
            rd.Close();
            return L;
        }
        public List<dynamic> selectionner(Dictionary<string, object> dico)
        {
            List<dynamic> e = new List<dynamic>();
            Dictionary<string, string> ch = Connexion.getChamps_table(this.GetType().Name);
            string req = "Select * from " + this.GetType().Name + " where ";
            foreach (var r in dico)
            {
                if (r.Key == dico.ElementAt(dico.Count() - 1).Key) break;
                if (r.Value.GetType().ToString() == "System.String")
                    req += r.Key + " = " + "\"" + r.Value + "\"" + " and ";
                else
                    req += r.Key + " = " + r.Value + " and ";
            }
            if (dico.ElementAt(dico.Count() - 1).Value.GetType().ToString() == "System.String")
                req += dico.ElementAt(dico.Count() - 1).Key + " = " + "\"" + dico.ElementAt(dico.Count() - 1).Value + "\"" + " ;";
            else
                req += dico.ElementAt(dico.Count() - 1).Key + " = " + dico.ElementAt(dico.Count() - 1).Value + " ;";
            IDataReader rd = Connexion.Select(req);
            int i;


            while (rd.Read())
            {
                Dictionary<string, object> a = new Dictionary<string, object>();

                i = 0;
                foreach (var f in ch)
                {
                    a.Add(f.Key, rd.GetValue(i));
                    i++;
                }
                e.Add((dynamic)DictionaryToObject(a));
            }
            rd.Close();

            return e;
        }
        public List<dynamic> Select(Dictionary<string, object> dico)
        {
            int i;
            for (i = 0; i < dico.Count() && dico.ElementAt(i).Key != "id"; i++) ;

            if (i >= dico.Count())
                return selectionner(dico);
            else
            {
                id = (int)dico.ElementAt(i).Value;
       
                List<dynamic> a = new List<dynamic>();

                a.Add(find());
                return a;
            }

        }

        public static List<List<dynamic>> select<T>(Dictionary<string, object> dico)
        {
            int a;
            for (a = 0; a < dico.Count() && dico.ElementAt(a).Key != "id"; a++) ;

            int i = 1;
            List<List<dynamic>> list = new List<List<dynamic>>();
            string sql = "select * from " + typeof(T).Name + " where ";
            if (a == dico.Count())
            {
                foreach (var d in dico)
                {
                    if (d.Value.GetType().ToString() == "System.String")
                    {
                        sql += d.Key + "=" + "\"" + d.Value + "\"";
                    }
                    else
                    {
                        sql += d.Key + "=" + d.Value;
                    }
                    if (i < dico.Count)
                    {
                        sql += " and ";
                        i++;
                    }
                }
            }
            else
            {
                sql += " id=" + dico.ElementAt(a).Value;
            }
            sql += ";";
            IDataReader rd = Connexion.Select(sql);

            while (rd.Read())
            {
                List<dynamic> L = new List<dynamic>();
                for (int t = 0; t < rd.FieldCount; t++)
                {
                    L.Add(rd.GetValue(t));
                }

                list.Add(L);
            }
            rd.Close();
            return list;
        }
        

    }
}
