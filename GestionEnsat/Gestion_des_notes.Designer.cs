
namespace GestionEnsat
{
    partial class Gestion_des_notes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_rechercher = new System.Windows.Forms.Button();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.btn_modifier = new System.Windows.Forms.Button();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.btn_nouveau = new System.Windows.Forms.Button();
            this.combo_mat = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_note = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_code_elev = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_rechercher
            // 
            this.btn_rechercher.Location = new System.Drawing.Point(514, 94);
            this.btn_rechercher.Name = "btn_rechercher";
            this.btn_rechercher.Size = new System.Drawing.Size(169, 25);
            this.btn_rechercher.TabIndex = 53;
            this.btn_rechercher.Text = "Rechercher";
            this.btn_rechercher.UseVisualStyleBackColor = true;
            this.btn_rechercher.Click += new System.EventHandler(this.btn_rechercher_Click);
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.Location = new System.Drawing.Point(515, 63);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(169, 25);
            this.btn_supprimer.TabIndex = 52;
            this.btn_supprimer.Text = "Supprimer";
            this.btn_supprimer.UseVisualStyleBackColor = true;
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click);
            // 
            // btn_modifier
            // 
            this.btn_modifier.Location = new System.Drawing.Point(319, 110);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(169, 25);
            this.btn_modifier.TabIndex = 51;
            this.btn_modifier.Text = "Modifier";
            this.btn_modifier.UseVisualStyleBackColor = true;
            this.btn_modifier.Click += new System.EventHandler(this.btn_modifier_Click);
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Location = new System.Drawing.Point(318, 79);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(169, 25);
            this.btn_ajouter.TabIndex = 50;
            this.btn_ajouter.Text = "Ajouter";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // btn_nouveau
            // 
            this.btn_nouveau.Location = new System.Drawing.Point(319, 48);
            this.btn_nouveau.Name = "btn_nouveau";
            this.btn_nouveau.Size = new System.Drawing.Size(169, 25);
            this.btn_nouveau.TabIndex = 49;
            this.btn_nouveau.Text = "Nouveau";
            this.btn_nouveau.UseVisualStyleBackColor = true;
            this.btn_nouveau.Click += new System.EventHandler(this.btn_nouveau_Click);
            // 
            // combo_mat
            // 
            this.combo_mat.FormattingEnabled = true;
            this.combo_mat.Location = new System.Drawing.Point(101, 81);
            this.combo_mat.Name = "combo_mat";
            this.combo_mat.Size = new System.Drawing.Size(166, 21);
            this.combo_mat.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Matiere :";
            // 
            // txt_note
            // 
            this.txt_note.Location = new System.Drawing.Point(101, 115);
            this.txt_note.Name = "txt_note";
            this.txt_note.Size = new System.Drawing.Size(166, 20);
            this.txt_note.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Note :";
            // 
            // txt_code_elev
            // 
            this.txt_code_elev.Enabled = false;
            this.txt_code_elev.Location = new System.Drawing.Point(101, 42);
            this.txt_code_elev.Name = "txt_code_elev";
            this.txt_code_elev.Size = new System.Drawing.Size(166, 20);
            this.txt_code_elev.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Code Eleve :";
            // 
            // Gestion_des_notes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 184);
            this.Controls.Add(this.btn_rechercher);
            this.Controls.Add(this.btn_supprimer);
            this.Controls.Add(this.btn_modifier);
            this.Controls.Add(this.btn_ajouter);
            this.Controls.Add(this.btn_nouveau);
            this.Controls.Add(this.combo_mat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_note);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_code_elev);
            this.Controls.Add(this.label1);
            this.Name = "Gestion_des_notes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion_des_notes";
            this.Load += new System.EventHandler(this.Gestion_des_notes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_rechercher;
        private System.Windows.Forms.Button btn_supprimer;
        private System.Windows.Forms.Button btn_modifier;
        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.Button btn_nouveau;
        private System.Windows.Forms.ComboBox combo_mat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_note;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_code_elev;
        private System.Windows.Forms.Label label1;
    }
}