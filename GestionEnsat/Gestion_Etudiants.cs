using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionEnsat
{
    public partial class Gestion_Etudiants : UserControl
    {
        Eleve eleve;
        Filiere filiere;
        public static string code_eleve;
        public Gestion_Etudiants()
        {
            InitializeComponent();
            eleve = new Eleve();
            filiere = new Filiere();
            try
            {
                Connexion.Connect("tp4");
            }
            catch
            {
                MessageBox.Show("Connexion échouée");
            }

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells[0].Value != null)
            {
                txt_code.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txt_nom.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txt_prenom.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                combo_niv.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                combo_fil.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            }
        }
        private void vider()
        {
           
            txt_code.Text = "";
            txt_nom.Text = "";
            txt_prenom.Text = "";
            combo_fil.Text = "";
            combo_niv.Text = "";
            combo_fil.Items.Clear();
            combo_niv.Items.Clear();
            load_fil();
            
        }
        private void check_code_CheckedChanged(object sender, EventArgs e)
        {
            if (check_code.Checked)
            {
                check_nom.Enabled = false;
                check_prenom.Enabled = false;
                check_fil.Enabled = false;
                check_niv.Enabled = false;
            }
            else
            {
                check_nom.Enabled = true;
                check_prenom.Enabled = true;
                check_fil.Enabled = true;
                check_niv.Enabled = true;
            }

        }
        private void btn_nouveau_Click(object sender, EventArgs e)
        {
            vider();
        }

        private void Gestion_Etudiants_Load(object sender, EventArgs e)
        {
            load();
            vider();
        }
        private void load()
        {
            dataGridView1.Rows.Clear();
            List<List<dynamic>> LE = Model.all<Eleve>();
            for (int i = 0; i < LE.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = LE.ElementAt(i).ElementAt(1);
                dataGridView1.Rows[i].Cells[1].Value = LE.ElementAt(i).ElementAt(2);
                dataGridView1.Rows[i].Cells[2].Value = LE.ElementAt(i).ElementAt(3);
                dataGridView1.Rows[i].Cells[3].Value = LE.ElementAt(i).ElementAt(4);
                dataGridView1.Rows[i].Cells[4].Value = LE.ElementAt(i).ElementAt(5);
            }
        }
        private void load_niv()
        {
            if (combo_fil.Text != "AP") { 
                    for (int i = 1; i < 4; i++)
                      combo_niv.Items.Add(combo_fil.Text + i);
            }
            else
                for (int i = 1; i < 3; i++)
                    combo_niv.Items.Add(combo_fil.Text + i);
        }
        private void load_fil()
        {
            List<List<dynamic>> LE = Model.all<Filiere>();
            for (int i = 0; i < LE.Count; i++)
            {
                combo_fil.Items.Add(LE.ElementAt(i).ElementAt(1));
            }
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            eleve.code = "" + txt_code.Text;
            eleve.nom = "" + txt_nom.Text;
            eleve.prenom = "" + txt_prenom.Text;
            eleve.code_fil = combo_fil.Text;
            eleve.niveau = combo_niv.Text;

            if (eleve.save() == 1)
                MessageBox.Show("Insertion réussie");
            else
                MessageBox.Show("Insertion échouée");
            load();
        }
      
        private void btn_modifier_Click(object sender, EventArgs e)
        {
            if (txt_code.Text != "" && txt_nom.Text != "" && txt_prenom.Text != "" && combo_fil.Text != "" && combo_fil.Text != "")
            {
                    try { 
                eleve.id = Model.getID<Eleve>(txt_code.Text);
                eleve.code = "" + txt_code.Text;
                eleve.nom = "" + txt_nom.Text;
                eleve.prenom = "" + txt_prenom.Text;
                eleve.code_fil = combo_fil.Text;
                eleve.niveau = combo_niv.Text;

                if (eleve.save() == 1)
                    MessageBox.Show("Modification réussie");
                else
                    MessageBox.Show("Modification échouée");
                load();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Remplissez les champs vides !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            if (txt_code.Text != "" && txt_nom.Text != "" && txt_prenom.Text != "" && combo_fil.Text != "" && combo_fil.Text != "")
            {
                try
                {
                    eleve.id = Model.getID<Eleve>(txt_code.Text);
            if (eleve.delete() == 1)
                MessageBox.Show("Supprission réussie");
            else
                MessageBox.Show("Supprission échouée");
            load();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Selectionner l'étudiant à supprimer !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_rechercher_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Clear();

            Dictionary<string, object> dico = new Dictionary<string, object>();
            if (check_code.Checked)
                dico.Add("id", Model.getID<Eleve>(txt_code.Text));
            if (check_nom.Checked)
                dico.Add("nom", txt_nom.Text);
            if (check_prenom.Checked)
                dico.Add("prenom", txt_prenom.Text);
            if (check_fil.Checked)
                dico.Add("code_fil", combo_fil.Text);
            if (check_niv.Checked)
                dico.Add("niveau", combo_niv.Text);

            List<List<dynamic>> LE = Model.select<Eleve>(dico);
            for (int i = 0; i < LE.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = LE.ElementAt(i).ElementAt(1);
                dataGridView1.Rows[i].Cells[1].Value = LE.ElementAt(i).ElementAt(2);
                dataGridView1.Rows[i].Cells[2].Value = LE.ElementAt(i).ElementAt(3);
                dataGridView1.Rows[i].Cells[3].Value = LE.ElementAt(i).ElementAt(4);
                dataGridView1.Rows[i].Cells[4].Value = LE.ElementAt(i).ElementAt(5);
            }
            }
            catch(Exception ex)
            {
                load();
            }
        }

       private void btn_gdn_Click(object sender, EventArgs e)
        { 
            if(txt_code.Text != "") 
            {
                code_eleve = txt_code.Text;
                Gestion_des_notes c = new Gestion_des_notes();
            c.Show();
            }
            else
            {
                MessageBox.Show("Il faut choisir un élève !");
            }
        }

            private void combo_fil_SelectedIndexChanged(object sender, EventArgs e)
        {
            combo_niv.Items.Clear();
            load_niv();
        }

        
    }
}
