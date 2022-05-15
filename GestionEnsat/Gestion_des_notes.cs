using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionEnsat
{
    public partial class Gestion_des_notes : Form
    {
        Notes note;
        public Gestion_des_notes()
        {
            InitializeComponent();
            note = new Notes();
            txt_code_elev.Text = Gestion_Etudiants.code_eleve;
            try
            {
                Connexion.Connect("tp4");
            }
            catch
            {
                MessageBox.Show("Connexion échouée");
            }
        }
        private void vider()
        {
            txt_note.Text = "";
            combo_mat.Items.Clear();
            combo_mat.Text = "";
            mat_load();
        }
        private void btn_nouveau_Click(object sender, EventArgs e)
        {
            vider();
        }

        private void Gestion_des_notes_Load(object sender, EventArgs e)
        {
            vider();
          
            
        }
        private void mat_load()
        {
            
               string req = "SELECT code FROM Matiere WHERE code_module in (SELECT code FROM Module WHERE code_fil in (SELECT code FROM Filiere WHERE code in (SELECT code_fil FROM Eleve WHERE code = '" + txt_code_elev.Text + "')))";
               IDataReader dr = Connexion.Select(req);
               while (dr.Read())
               {
                  combo_mat.Items.Add(dr.GetValue(0) + "");
               }

               dr.Close();

        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            /*
           if (combo_mat.Text != "" && txt_note.Text != "")
           {
               try
               {
                   Connexion.cmd.CommandText="AjouterNote";
           Connexion.cmd.CommandType = CommandType.StoredProcedure;
           MySqlParameter p1 = new MySqlParameter("pcode_eleve", txt_code_elev.Text);
           Connexion.cmd.Parameters.Add(p1);
           MySqlParameter p2 = new MySqlParameter("pcode_mat", combo_mat.Text);
           Connexion.cmd.Parameters.Add(p2);
           MySqlParameter p3 = new MySqlParameter("pnote", float.Parse(txt_note.Text));
           Connexion.cmd.Parameters.Add(p3);

           if (Connexion.cmd.ExecuteNonQuery() == 1)
               MessageBox.Show("Insertion réussie");
           else
               MessageBox.Show("Insertion échouée");
               }
               catch (Exception ex)
               {
                   MessageBox.Show(ex.Message);
               }
           }
           else
           {
               MessageBox.Show("Une erreure est survenue !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);

           }*/

            if (combo_mat.Text != "" && txt_note.Text != "")
           {
               try { 
               note.code_eleve = txt_code_elev.Text;
               note.code_mat = combo_mat.Text;
               note.note = float.Parse(txt_note.Text);
               if (note.save() == 1)
                   MessageBox.Show("Insertion réussie");
               else
                   MessageBox.Show("Insertion échouée");
               }
               catch (Exception ex)
               {
                   MessageBox.Show(ex.Message);
               }
           }
           else
           {
               MessageBox.Show("Une erreure est survenue !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);

           }
        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {/*
            if (combo_mat.Text != "" && txt_note.Text != "")
            {
                try
                {
                    Connexion.cmd.CommandText = "ModifierNote";
                    Connexion.cmd.CommandType = CommandType.StoredProcedure;
                    MySqlParameter p1 = new MySqlParameter("pcode_eleve", txt_code_elev.Text);
                    Connexion.cmd.Parameters.Add(p1);
                    MySqlParameter p2 = new MySqlParameter("pcode_mat", combo_mat.Text);
                    Connexion.cmd.Parameters.Add(p2);
                    MySqlParameter p3 = new MySqlParameter("pnote", float.Parse(txt_note.Text));
                    Connexion.cmd.Parameters.Add(p3);

                    if (Connexion.cmd.ExecuteNonQuery() == 1)
                        MessageBox.Show("Modification réussie");
                    else
                        MessageBox.Show("Modification échouée");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Une erreure est survenue !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
              
            }

            */
            if (combo_mat.Text != "" && txt_note.Text != "")
            {
                
                    note.code_eleve = txt_code_elev.Text;
                    note.note = float.Parse(txt_note.Text);
                    note.code_mat = combo_mat.Text;

                    Dictionary<string, object> dico = new Dictionary<string, object>();
                    dico.Add("code_eleve", txt_code_elev.Text);
                    dico.Add("code_mat", combo_mat.Text);
                    List<List<dynamic>> LN = Model.select<Notes>(dico);
                    note.id = LN.First().ElementAt(0);
                    

                    if (note.save() == 1)
                        MessageBox.Show("Modification réussie");
                    else
                        MessageBox.Show("Modification échouée");
               
            }
            else
            {
                MessageBox.Show("Une erreure est survenue !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
             
            }
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            /*
            if (combo_mat.Text != "" && txt_note.Text != "")
            {
                try
                {
                    Connexion.cmd.CommandText = "SupprimerNote";
                    Connexion.cmd.CommandType = CommandType.StoredProcedure;
                    MySqlParameter p1 = new MySqlParameter("pcode_eleve", txt_code_elev.Text);
                    Connexion.cmd.Parameters.Add(p1);
                    MySqlParameter p2 = new MySqlParameter("pcode_mat", combo_mat.Text);
                    Connexion.cmd.Parameters.Add(p2);

                    if (Connexion.cmd.ExecuteNonQuery() == 1)
                        MessageBox.Show("Supprission réussie");
                    else
                        MessageBox.Show("Supprission échouée");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Une erreure est survenue !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
             
            }
            */
            if (combo_mat.Text != "")
            {
                try
                {
                    Dictionary<string, object> notes = new Dictionary<string, object>();
                notes.Add("code_eleve", txt_code_elev.Text);
                notes.Add("code_mat", combo_mat.Text);
                List<List<dynamic>> l = Model.select<Notes>(notes);
                note.id = l.ElementAt(0).ElementAt(0);
                if (note.delete() == 1)
                    MessageBox.Show("Supprission réussie");
                else
                    MessageBox.Show("Supprission échouée");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Une erreure est survenue !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_nouveau_Click(sender, e);
            }
        }

        private void btn_rechercher_Click(object sender, EventArgs e)
        {
            /* if (combo_mat.Text != "")
             {
                 try
                 {
                     Connexion.cmd.CommandText = "RechercherNote";
                     Connexion.cmd.CommandType = CommandType.StoredProcedure;
                     MySqlParameter p1 = new MySqlParameter("pcode_eleve", txt_code_elev.Text);
                     Connexion.cmd.Parameters.Add(p1);
                     MySqlParameter p2 = new MySqlParameter("pcode_mat", combo_mat.Text);
                     Connexion.cmd.Parameters.Add(p2);
                     IDataReader dr = Connexion.cmd.ExecuteReader();

                     while (dr.Read())
                     {
                         txt_note.Text = (dr[0].ToString());
                     }
                     dr.Close();

                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show(ex.Message);
                 }
             }
             else
             {
                 MessageBox.Show("Une erreure est survenue !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);

             }
             */
            try
            {
                Dictionary<string, object> DN = new Dictionary<string, object>();
                DN.Add("code_eleve", txt_code_elev.Text);
                DN.Add("code_mat", combo_mat.Text);
                List<List<dynamic>> LN = Model.select<Notes>(DN);

                txt_code_elev.Text = ""+LN.ElementAt(0).ElementAt(1) ;
                combo_mat.Text = "" + LN.ElementAt(0).ElementAt(2);
                txt_note.Text = "" + LN.ElementAt(0).ElementAt(3);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Cette matiére n'a pas de note !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
              
            }
        }
    }
}
