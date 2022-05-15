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
    public partial class Consultation_des_notes : UserControl
    {
        Moyennes moyennes;
        public Consultation_des_notes()
        {
            moyennes = new Moyennes();
            InitializeComponent();
            try
            {
                Connexion.Connect("tp4");
            }
            catch
            {
                MessageBox.Show("Connexion échouée");
            }
        }

        private void Consultation_des_notes_Load(object sender, EventArgs e)
        {
            load_fil();
        }
       
        private void CalculerMoyenne()
        {
            string req = "select avg(note) from Notes where code_eleve='" + combo_mat.Text + "'";
            IDataReader dr = Connexion.Select(req);
            dr.Read();
            string moy = dr.GetValue(0) + "";
            dr.Close();
            moyennes.code_eleve = "" + combo_mat.Text;
            moyennes.code_fil = "" + combo_fil.Text;
            moyennes.niveau = "" + combo_niv.Text;
            moyennes.moyenne = float.Parse(moy);

            moyennes.save();
        }
        private void load_niv()
        {
            combo_niv.Items.Clear();
            if (combo_fil.Text != "AP")
            {
                for (int i = 1; i < 4; i++)
                    combo_niv.Items.Add(combo_fil.Text + i);
            }
            else
                for (int i = 1; i < 3; i++)
                    combo_niv.Items.Add(combo_fil.Text + i);
        }
        private void load_fil()
        {
            combo_fil.Items.Clear();
            List<List<dynamic>> LE = Model.all<Filiere>();
            for (int i = 0; i < LE.Count; i++)
            {
                combo_fil.Items.Add(LE.ElementAt(i).ElementAt(1));
            }
        }
        private void load_mat()
        {
            combo_mat.Items.Clear();

            string req = "SELECT code FROM Matiere WHERE code_module in (SELECT code FROM Module WHERE code_fil in (SELECT code FROM Filiere WHERE code  = '" + combo_fil.Text + "'))";
            IDataReader dr = Connexion.Select(req);
            while (dr.Read())
            {
                combo_mat.Items.Add(dr.GetValue(0) + "");
            }

            dr.Close();
        }

        private void combo_niv_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_mat();
        }

        private void combo_fil_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_niv();
        }

        private void btn_rechercher_Click(object sender, EventArgs e)
        {
            if (combo_fil.Text != "" && combo_niv.Text != "" && combo_mat.Text != "")
            {
                string sql = "select n.code_eleve , e.nom , e.prenom , n.note from eleve e, notes n where n.code_mat = '" + combo_mat.Text + "' and e.code=n.code_eleve;";
                IDataReader rd = Connexion.Select(sql);
                List<List<dynamic>> list = new List<List<dynamic>>();

                while (rd.Read())
                {
                    List<dynamic> l = new List<dynamic>();
                    for (int i = 0; i < rd.FieldCount; i++)
                        l.Add(rd.GetValue(i));
                    list.Add((dynamic)l);
                }
                rd.Close();
                DataGridView1.Rows.Clear();
                for (int i = 0; i < list.Count; i++)
                {
                    DataGridView1.Rows.Add();
                    DataGridView1.Rows[i].Cells[0].Value = list.ElementAt(i).ElementAt(0);
                    DataGridView1.Rows[i].Cells[1].Value = list.ElementAt(i).ElementAt(1);
                    DataGridView1.Rows[i].Cells[2].Value = list.ElementAt(i).ElementAt(2);
                    DataGridView1.Rows[i].Cells[3].Value = list.ElementAt(i).ElementAt(3);
                }

                string req = " select AVG(note) from notes where code_mat=" + "'" + combo_mat.Text + "'" + ";";
                IDataReader dr = Connexion.Select(req);
                dr.Read();
                txt_moy.Text = dr.GetValue(0) + "";
                dr.Close();
            }
            else
            {
                MessageBox.Show("Une erreure est servenue !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
