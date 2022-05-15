
namespace GestionEnsat
{
    partial class Consultation_des_notes
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
            this.txt_moy = new System.Windows.Forms.TextBox();
            this.moy = new System.Windows.Forms.Label();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_rechercher = new System.Windows.Forms.Button();
            this.Niveau = new System.Windows.Forms.Label();
            this.combo_niv = new System.Windows.Forms.ComboBox();
            this.Matiere = new System.Windows.Forms.Label();
            this.Filiere = new System.Windows.Forms.Label();
            this.combo_mat = new System.Windows.Forms.ComboBox();
            this.combo_fil = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_moy
            // 
            this.txt_moy.Location = new System.Drawing.Point(349, 301);
            this.txt_moy.Margin = new System.Windows.Forms.Padding(2);
            this.txt_moy.Name = "txt_moy";
            this.txt_moy.Size = new System.Drawing.Size(107, 20);
            this.txt_moy.TabIndex = 29;
            // 
            // moy
            // 
            this.moy.AutoSize = true;
            this.moy.Location = new System.Drawing.Point(204, 304);
            this.moy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.moy.Name = "moy";
            this.moy.Size = new System.Drawing.Size(116, 13);
            this.moy.TabIndex = 28;
            this.moy.Text = "Moyenne de la classe :";
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
            this.DataGridView1.Location = new System.Drawing.Point(92, 134);
            this.DataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowHeadersWidth = 62;
            this.DataGridView1.RowTemplate.Height = 28;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size = new System.Drawing.Size(549, 150);
            this.DataGridView1.TabIndex = 27;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Code";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nom";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Prenom";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Note";
            this.Column4.Name = "Column4";
            // 
            // btn_rechercher
            // 
            this.btn_rechercher.Location = new System.Drawing.Point(448, 87);
            this.btn_rechercher.Margin = new System.Windows.Forms.Padding(2);
            this.btn_rechercher.Name = "btn_rechercher";
            this.btn_rechercher.Size = new System.Drawing.Size(132, 28);
            this.btn_rechercher.TabIndex = 26;
            this.btn_rechercher.Text = "Rechercher";
            this.btn_rechercher.UseVisualStyleBackColor = true;
            this.btn_rechercher.Click += new System.EventHandler(this.btn_rechercher_Click);
            // 
            // Niveau
            // 
            this.Niveau.AutoSize = true;
            this.Niveau.Location = new System.Drawing.Point(374, 53);
            this.Niveau.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Niveau.Name = "Niveau";
            this.Niveau.Size = new System.Drawing.Size(47, 13);
            this.Niveau.TabIndex = 25;
            this.Niveau.Text = "Niveau :";
            // 
            // combo_niv
            // 
            this.combo_niv.FormattingEnabled = true;
            this.combo_niv.Location = new System.Drawing.Point(448, 50);
            this.combo_niv.Margin = new System.Windows.Forms.Padding(2);
            this.combo_niv.Name = "combo_niv";
            this.combo_niv.Size = new System.Drawing.Size(132, 21);
            this.combo_niv.TabIndex = 24;
            this.combo_niv.SelectedIndexChanged += new System.EventHandler(this.combo_niv_SelectedIndexChanged);
            // 
            // Matiere
            // 
            this.Matiere.AutoSize = true;
            this.Matiere.Location = new System.Drawing.Point(100, 95);
            this.Matiere.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Matiere.Name = "Matiere";
            this.Matiere.Size = new System.Drawing.Size(48, 13);
            this.Matiere.TabIndex = 23;
            this.Matiere.Text = "Matiere :";
            // 
            // Filiere
            // 
            this.Filiere.AutoSize = true;
            this.Filiere.Location = new System.Drawing.Point(100, 50);
            this.Filiere.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Filiere.Name = "Filiere";
            this.Filiere.Size = new System.Drawing.Size(40, 13);
            this.Filiere.TabIndex = 22;
            this.Filiere.Text = "Filiere :";
            // 
            // combo_mat
            // 
            this.combo_mat.FormattingEnabled = true;
            this.combo_mat.Location = new System.Drawing.Point(169, 92);
            this.combo_mat.Margin = new System.Windows.Forms.Padding(2);
            this.combo_mat.Name = "combo_mat";
            this.combo_mat.Size = new System.Drawing.Size(130, 21);
            this.combo_mat.TabIndex = 21;
            // 
            // combo_fil
            // 
            this.combo_fil.FormattingEnabled = true;
            this.combo_fil.Location = new System.Drawing.Point(169, 50);
            this.combo_fil.Margin = new System.Windows.Forms.Padding(2);
            this.combo_fil.Name = "combo_fil";
            this.combo_fil.Size = new System.Drawing.Size(130, 21);
            this.combo_fil.TabIndex = 20;
            this.combo_fil.SelectedIndexChanged += new System.EventHandler(this.combo_fil_SelectedIndexChanged);
            // 
            // Consultation_des_notes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_moy);
            this.Controls.Add(this.moy);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.btn_rechercher);
            this.Controls.Add(this.Niveau);
            this.Controls.Add(this.combo_niv);
            this.Controls.Add(this.Matiere);
            this.Controls.Add(this.Filiere);
            this.Controls.Add(this.combo_mat);
            this.Controls.Add(this.combo_fil);
            this.Name = "Consultation_des_notes";
            this.Size = new System.Drawing.Size(733, 371);
            this.Load += new System.EventHandler(this.Consultation_des_notes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_moy;
        private System.Windows.Forms.Label moy;
        private System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.Button btn_rechercher;
        private System.Windows.Forms.Label Niveau;
        private System.Windows.Forms.ComboBox combo_niv;
        private System.Windows.Forms.Label Matiere;
        private System.Windows.Forms.Label Filiere;
        private System.Windows.Forms.ComboBox combo_mat;
        private System.Windows.Forms.ComboBox combo_fil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}
