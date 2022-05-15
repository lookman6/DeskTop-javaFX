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
    public partial class Bilan_annuel : UserControl
    {
        Moyennes moyennes;
        public Bilan_annuel()
        {
            InitializeComponent();
            moyennes = new Moyennes();
            try
            {
                Connexion.Connect("tp4");
            }
            catch
            {
                MessageBox.Show("Connexion échouée");
            }
            
        }

        private void CalculerMoyenne()
        {
            string req = "select avg(note) from Notes where code_eleve='" + combo_etu.Text + "'";
            IDataReader dr = Connexion.Select(req);
            dr.Read();
            string moy = dr.GetValue(0) + "";
            dr.Close();
            moyennes.code_eleve = "" + combo_etu.Text;
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
        private void load_etu()
        {
            combo_etu.Items.Clear();
            Dictionary<string, object> dico = new Dictionary<string, object>();
            dico.Add("niveau", combo_niv.Text);
            List<List<dynamic>> l = Model.select<Eleve>(dico);
            for (int i = 0; i < l.Count; i++)
                combo_etu.Items.Add(l.ElementAt(i).ElementAt(1));
        }
        private void Rechercher_Click(object sender, EventArgs e)
        {
            if (combo_fil.Text != "" && combo_niv.Text != "" && combo_etu.Text != "")
            {
                try
                {
                    string req = "select n.code_mat , m.designation, mo.semestre, n.note from notes n, matiere m, module mo where n.code_mat = m.code and m.code_module = mo.code and n.code_eleve = '" + combo_etu.Text + "' and mo.niveau = '" + combo_niv.Text + "';";

                    IDataReader rd = Connexion.Select(req);
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
                    CalculerMoyenne();
                    GetMoyenne();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Une erreure est servenue !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void GetMoyenne()
        {
            string req = "select moyenne from moyennes where code_eleve='" + combo_etu.Text + "' and niveau='" + combo_niv.Text + "';";
            IDataReader dr = Connexion.Select(req);
            dr.Read();
            txt_moy_ann.Text = dr.GetValue(0) + "";
            dr.Close();
        }
        private void combo_fil_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_niv();
        }

        private void combo_niv_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_etu();
        }

        private void Bilan_annuel_Load(object sender, EventArgs e)
        {
            load_fil();
        }
    }
}
