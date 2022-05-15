using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//panel//anchor 
//datagridview//Autosizecolumnmode//fill//selectionmode//fullrowselect
namespace GestionEnsat
{
    public partial class GestionDesNotes : Form
    {
        public GestionDesNotes()
        {
            InitializeComponent();
        }

        private void filiéreToolStripMenuItem_Click(object sender, EventArgs e)
        {
        //    Gestion_Filieres c = new Gestion_Filieres();
        //    c.Show();
         //   this.panel1.Controls.Clear();
        //    this.panel1.Controls.Add(c);
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous quitter !", "Comfirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                this.Close();
        }

        private void etudiantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gestion_Etudiants c = new Gestion_Etudiants();
            c.Show();
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(c);
        }

        private void matièreToolStripMenuItem_Click(object sender, EventArgs e)
        {
        //    Gestion_Matieres c = new Gestion_Matieres();
        //    c.Show();
        //    this.panel1.Controls.Clear();
         //   this.panel1.Controls.Add(c);
        }

        private void bilanToolStripMenuItem_Click(object sender, EventArgs e)
        {
                Bilan_annuel c = new Bilan_annuel();
                c.Show();
                this.panel1.Controls.Clear();
               this.panel1.Controls.Add(c);
        }

        private void notesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultation_des_notes c = new Consultation_des_notes();
            c.Show();
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(c);
        }
    }
}
