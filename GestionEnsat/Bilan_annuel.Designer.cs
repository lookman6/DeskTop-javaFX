
namespace GestionEnsat
{
    partial class Bilan_annuel
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_moy_ann = new System.Windows.Forms.TextBox();
            this.moy = new System.Windows.Forms.Label();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_rechercher = new System.Windows.Forms.Button();
            this.Niveau = new System.Windows.Forms.Label();
            this.combo_niv = new System.Windows.Forms.ComboBox();
            this.Etudiant = new System.Windows.Forms.Label();
            this.Filiere = new System.Windows.Forms.Label();
            this.combo_etu = new System.Windows.Forms.ComboBox();
            this.combo_fil = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_moy_ann
            // 
            this.txt_moy_ann.Location = new System.Drawing.Point(326, 298);
            this.txt_moy_ann.Margin = new System.Windows.Forms.Padding(2);
            this.txt_moy_ann.Name = "txt_moy_ann";
            this.txt_moy_ann.Size = new System.Drawing.Size(107, 20);
            this.txt_moy_ann.TabIndex = 19;
            // 
            // moy
            // 
            this.moy.AutoSize = true;
            this.moy.Location = new System.Drawing.Point(200, 302);
            this.moy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.moy.Name = "moy";
            this.moy.Size = new System.Drawing.Size(101, 13);
            this.moy.TabIndex = 18;
            this.moy.Text = "Moyenne Annuelle :";
            // 
            // DataGridView1
            // 
            this.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.DataGridView1.Location = new System.Drawing.Point(88, 132);
            this.DataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowHeadersWidth = 62;
            this.DataGridView1.RowTemplate.Height = 28;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size = new System.Drawing.Size(549, 150);
            this.DataGridView1.TabIndex = 17;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Code matiere";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Designation";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Semestre";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Note";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            // 
            // btn_rechercher
            // 
            this.btn_rechercher.Location = new System.Drawing.Point(444, 85);
            this.btn_rechercher.Margin = new System.Windows.Forms.Padding(2);
            this.btn_rechercher.Name = "btn_rechercher";
            this.btn_rechercher.Size = new System.Drawing.Size(132, 28);
            this.btn_rechercher.TabIndex = 16;
            this.btn_rechercher.Text = "Rechercher";
            this.btn_rechercher.UseVisualStyleBackColor = true;
            this.btn_rechercher.Click += new System.EventHandler(this.Rechercher_Click);
            // 
            // Niveau
            // 
            this.Niveau.AutoSize = true;
            this.Niveau.Location = new System.Drawing.Point(370, 51);
            this.Niveau.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Niveau.Name = "Niveau";
            this.Niveau.Size = new System.Drawing.Size(47, 13);
            this.Niveau.TabIndex = 15;
            this.Niveau.Text = "Niveau :";
            // 
            // combo_niv
            // 
            this.combo_niv.FormattingEnabled = true;
            this.combo_niv.Location = new System.Drawing.Point(444, 48);
            this.combo_niv.Margin = new System.Windows.Forms.Padding(2);
            this.combo_niv.Name = "combo_niv";
            this.combo_niv.Size = new System.Drawing.Size(132, 21);
            this.combo_niv.TabIndex = 14;
            this.combo_niv.SelectedIndexChanged += new System.EventHandler(this.combo_niv_SelectedIndexChanged);
            // 
            // Etudiant
            // 
            this.Etudiant.AutoSize = true;
            this.Etudiant.Location = new System.Drawing.Point(96, 93);
            this.Etudiant.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Etudiant.Name = "Etudiant";
            this.Etudiant.Size = new System.Drawing.Size(52, 13);
            this.Etudiant.TabIndex = 13;
            this.Etudiant.Text = "Etudiant :";
            // 
            // Filiere
            // 
            this.Filiere.AutoSize = true;
            this.Filiere.Location = new System.Drawing.Point(96, 48);
            this.Filiere.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Filiere.Name = "Filiere";
            this.Filiere.Size = new System.Drawing.Size(40, 13);
            this.Filiere.TabIndex = 12;
            this.Filiere.Text = "Filiere :";
            // 
            // combo_etu
            // 
            this.combo_etu.FormattingEnabled = true;
            this.combo_etu.Location = new System.Drawing.Point(165, 90);
            this.combo_etu.Margin = new System.Windows.Forms.Padding(2);
            this.combo_etu.Name = "combo_etu";
            this.combo_etu.Size = new System.Drawing.Size(130, 21);
            this.combo_etu.TabIndex = 11;
            // 
            // combo_fil
            // 
            this.combo_fil.FormattingEnabled = true;
            this.combo_fil.Location = new System.Drawing.Point(165, 48);
            this.combo_fil.Margin = new System.Windows.Forms.Padding(2);
            this.combo_fil.Name = "combo_fil";
            this.combo_fil.Size = new System.Drawing.Size(130, 21);
            this.combo_fil.TabIndex = 10;
            this.combo_fil.SelectedIndexChanged += new System.EventHandler(this.combo_fil_SelectedIndexChanged);
            // 
            // Bilan_annuel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_moy_ann);
            this.Controls.Add(this.moy);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.btn_rechercher);
            this.Controls.Add(this.Niveau);
            this.Controls.Add(this.combo_niv);
            this.Controls.Add(this.Etudiant);
            this.Controls.Add(this.Filiere);
            this.Controls.Add(this.combo_etu);
            this.Controls.Add(this.combo_fil);
            this.Name = "Bilan_annuel";
            this.Size = new System.Drawing.Size(743, 368);
            this.Load += new System.EventHandler(this.Bilan_annuel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_moy_ann;
        private System.Windows.Forms.Label moy;
        private System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btn_rechercher;
        private System.Windows.Forms.Label Niveau;
        private System.Windows.Forms.ComboBox combo_niv;
        private System.Windows.Forms.Label Etudiant;
        private System.Windows.Forms.Label Filiere;
        private System.Windows.Forms.ComboBox combo_etu;
        private System.Windows.Forms.ComboBox combo_fil;
    }
}
