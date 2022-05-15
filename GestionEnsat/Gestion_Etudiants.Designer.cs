
namespace GestionEnsat
{
    partial class Gestion_Etudiants
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_code = new System.Windows.Forms.TextBox();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.txt_prenom = new System.Windows.Forms.TextBox();
            this.combo_fil = new System.Windows.Forms.ComboBox();
            this.combo_niv = new System.Windows.Forms.ComboBox();
            this.check_code = new System.Windows.Forms.CheckBox();
            this.check_nom = new System.Windows.Forms.CheckBox();
            this.check_prenom = new System.Windows.Forms.CheckBox();
            this.check_fil = new System.Windows.Forms.CheckBox();
            this.check_niv = new System.Windows.Forms.CheckBox();
            this.btn_nouveau = new System.Windows.Forms.Button();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.btn_modifier = new System.Windows.Forms.Button();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.btn_rechercher = new System.Windows.Forms.Button();
            this.btn_gdn = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(55, 237);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(564, 144);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Code :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nom :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Prenom :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Filière :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Niveau :";
            // 
            // txt_code
            // 
            this.txt_code.Location = new System.Drawing.Point(178, 48);
            this.txt_code.Name = "txt_code";
            this.txt_code.Size = new System.Drawing.Size(166, 20);
            this.txt_code.TabIndex = 6;
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(178, 82);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(166, 20);
            this.txt_nom.TabIndex = 7;
            // 
            // txt_prenom
            // 
            this.txt_prenom.Location = new System.Drawing.Point(178, 114);
            this.txt_prenom.Name = "txt_prenom";
            this.txt_prenom.Size = new System.Drawing.Size(166, 20);
            this.txt_prenom.TabIndex = 8;
            // 
            // combo_fil
            // 
            this.combo_fil.FormattingEnabled = true;
            this.combo_fil.Location = new System.Drawing.Point(178, 148);
            this.combo_fil.Name = "combo_fil";
            this.combo_fil.Size = new System.Drawing.Size(166, 21);
            this.combo_fil.TabIndex = 9;
            this.combo_fil.SelectedIndexChanged += new System.EventHandler(this.combo_fil_SelectedIndexChanged);
            // 
            // combo_niv
            // 
            this.combo_niv.FormattingEnabled = true;
            this.combo_niv.Location = new System.Drawing.Point(178, 183);
            this.combo_niv.Name = "combo_niv";
            this.combo_niv.Size = new System.Drawing.Size(166, 21);
            this.combo_niv.TabIndex = 10;
            // 
            // check_code
            // 
            this.check_code.AutoSize = true;
            this.check_code.Location = new System.Drawing.Point(359, 50);
            this.check_code.Name = "check_code";
            this.check_code.Size = new System.Drawing.Size(15, 14);
            this.check_code.TabIndex = 11;
            this.check_code.Tag = "v";
            this.check_code.UseVisualStyleBackColor = true;
            this.check_code.CheckedChanged += new System.EventHandler(this.check_code_CheckedChanged);
            // 
            // check_nom
            // 
            this.check_nom.AutoSize = true;
            this.check_nom.Location = new System.Drawing.Point(359, 85);
            this.check_nom.Name = "check_nom";
            this.check_nom.Size = new System.Drawing.Size(15, 14);
            this.check_nom.TabIndex = 12;
            this.check_nom.Tag = "v";
            this.check_nom.UseVisualStyleBackColor = true;
            // 
            // check_prenom
            // 
            this.check_prenom.AutoSize = true;
            this.check_prenom.Location = new System.Drawing.Point(359, 117);
            this.check_prenom.Name = "check_prenom";
            this.check_prenom.Size = new System.Drawing.Size(15, 14);
            this.check_prenom.TabIndex = 13;
            this.check_prenom.Tag = "v";
            this.check_prenom.UseVisualStyleBackColor = true;
            // 
            // check_fil
            // 
            this.check_fil.AutoSize = true;
            this.check_fil.Location = new System.Drawing.Point(359, 151);
            this.check_fil.Name = "check_fil";
            this.check_fil.Size = new System.Drawing.Size(15, 14);
            this.check_fil.TabIndex = 14;
            this.check_fil.Tag = "v";
            this.check_fil.UseVisualStyleBackColor = true;
            // 
            // check_niv
            // 
            this.check_niv.AutoSize = true;
            this.check_niv.Location = new System.Drawing.Point(359, 186);
            this.check_niv.Name = "check_niv";
            this.check_niv.Size = new System.Drawing.Size(15, 14);
            this.check_niv.TabIndex = 15;
            this.check_niv.Tag = "v";
            this.check_niv.UseVisualStyleBackColor = true;
            // 
            // btn_nouveau
            // 
            this.btn_nouveau.Location = new System.Drawing.Point(427, 32);
            this.btn_nouveau.Name = "btn_nouveau";
            this.btn_nouveau.Size = new System.Drawing.Size(169, 25);
            this.btn_nouveau.TabIndex = 16;
            this.btn_nouveau.Text = "Nouveau";
            this.btn_nouveau.UseVisualStyleBackColor = true;
            this.btn_nouveau.Click += new System.EventHandler(this.btn_nouveau_Click);
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Location = new System.Drawing.Point(426, 63);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(169, 25);
            this.btn_ajouter.TabIndex = 17;
            this.btn_ajouter.Text = "Ajouter";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // btn_modifier
            // 
            this.btn_modifier.Location = new System.Drawing.Point(427, 94);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(169, 25);
            this.btn_modifier.TabIndex = 18;
            this.btn_modifier.Text = "Modifier";
            this.btn_modifier.UseVisualStyleBackColor = true;
            this.btn_modifier.Click += new System.EventHandler(this.btn_modifier_Click);
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.Location = new System.Drawing.Point(427, 125);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(169, 25);
            this.btn_supprimer.TabIndex = 19;
            this.btn_supprimer.Text = "Supprimer";
            this.btn_supprimer.UseVisualStyleBackColor = true;
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click);
            // 
            // btn_rechercher
            // 
            this.btn_rechercher.Location = new System.Drawing.Point(427, 156);
            this.btn_rechercher.Name = "btn_rechercher";
            this.btn_rechercher.Size = new System.Drawing.Size(169, 25);
            this.btn_rechercher.TabIndex = 20;
            this.btn_rechercher.Text = "Rechercher";
            this.btn_rechercher.UseVisualStyleBackColor = true;
            this.btn_rechercher.Click += new System.EventHandler(this.btn_rechercher_Click);
            // 
            // btn_gdn
            // 
            this.btn_gdn.Location = new System.Drawing.Point(427, 187);
            this.btn_gdn.Name = "btn_gdn";
            this.btn_gdn.Size = new System.Drawing.Size(169, 25);
            this.btn_gdn.TabIndex = 21;
            this.btn_gdn.Text = "Gestion des notes";
            this.btn_gdn.UseVisualStyleBackColor = true;
            this.btn_gdn.Click += new System.EventHandler(this.btn_gdn_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "codeElev";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "nom";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "prenom";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "niveau";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "codeFil";
            this.Column5.Name = "Column5";
            // 
            // Gestion_Etudiants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_gdn);
            this.Controls.Add(this.btn_rechercher);
            this.Controls.Add(this.btn_supprimer);
            this.Controls.Add(this.btn_modifier);
            this.Controls.Add(this.btn_ajouter);
            this.Controls.Add(this.btn_nouveau);
            this.Controls.Add(this.check_niv);
            this.Controls.Add(this.check_fil);
            this.Controls.Add(this.check_prenom);
            this.Controls.Add(this.check_nom);
            this.Controls.Add(this.check_code);
            this.Controls.Add(this.combo_niv);
            this.Controls.Add(this.combo_fil);
            this.Controls.Add(this.txt_prenom);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.txt_code);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Gestion_Etudiants";
            this.Size = new System.Drawing.Size(680, 401);
            this.Load += new System.EventHandler(this.Gestion_Etudiants_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_code;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.TextBox txt_prenom;
        private System.Windows.Forms.ComboBox combo_fil;
        private System.Windows.Forms.ComboBox combo_niv;
        private System.Windows.Forms.CheckBox check_code;
        private System.Windows.Forms.CheckBox check_nom;
        private System.Windows.Forms.CheckBox check_prenom;
        private System.Windows.Forms.CheckBox check_fil;
        private System.Windows.Forms.CheckBox check_niv;
        private System.Windows.Forms.Button btn_nouveau;
        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.Button btn_modifier;
        private System.Windows.Forms.Button btn_supprimer;
        private System.Windows.Forms.Button btn_rechercher;
        private System.Windows.Forms.Button btn_gdn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}
