namespace Gestion_Bibliothéque
{
    partial class Ajouter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ajouter));
            this.Panel3 = new System.Windows.Forms.Panel();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.btn_valider = new System.Windows.Forms.Button();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.comboBoxTypelivre = new System.Windows.Forms.ComboBox();
            this.Typelivre = new System.Windows.Forms.Label();
            this.Editeur = new System.Windows.Forms.Label();
            this.Anneesortie = new System.Windows.Forms.Label();
            this.Auteur = new System.Windows.Forms.Label();
            this.Titrelivre = new System.Windows.Forms.Label();
            this.ISBN = new System.Windows.Forms.Label();
            this.txt_editeur = new System.Windows.Forms.TextBox();
            this.txt_anneesortie = new System.Windows.Forms.TextBox();
            this.txt_auteur = new System.Windows.Forms.TextBox();
            this.txt_titre = new System.Windows.Forms.TextBox();
            this.txt_isbn = new System.Windows.Forms.TextBox();
            this.Panel3.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel3
            // 
            this.Panel3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Panel3.Controls.Add(this.btn_annuler);
            this.Panel3.Controls.Add(this.btn_valider);
            this.Panel3.Location = new System.Drawing.Point(317, 49);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(122, 200);
            this.Panel3.TabIndex = 14;
            // 
            // btn_annuler
            // 
            this.btn_annuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_annuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_annuler.Image = ((System.Drawing.Image)(resources.GetObject("btn_annuler.Image")));
            this.btn_annuler.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_annuler.Location = new System.Drawing.Point(20, 129);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(82, 35);
            this.btn_annuler.TabIndex = 1;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_annuler.UseVisualStyleBackColor = false;
            // 
            // btn_valider
            // 
            this.btn_valider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_valider.Image = ((System.Drawing.Image)(resources.GetObject("btn_valider.Image")));
            this.btn_valider.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_valider.Location = new System.Drawing.Point(20, 32);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(82, 40);
            this.btn_valider.TabIndex = 0;
            this.btn_valider.Text = "Valider";
            this.btn_valider.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_valider.UseVisualStyleBackColor = false;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Panel2.Controls.Add(this.Panel3);
            this.Panel2.Controls.Add(this.comboBoxTypelivre);
            this.Panel2.Controls.Add(this.Typelivre);
            this.Panel2.Controls.Add(this.Editeur);
            this.Panel2.Controls.Add(this.Anneesortie);
            this.Panel2.Controls.Add(this.Auteur);
            this.Panel2.Controls.Add(this.Titrelivre);
            this.Panel2.Controls.Add(this.ISBN);
            this.Panel2.Controls.Add(this.txt_editeur);
            this.Panel2.Controls.Add(this.txt_anneesortie);
            this.Panel2.Controls.Add(this.txt_auteur);
            this.Panel2.Controls.Add(this.txt_titre);
            this.Panel2.Controls.Add(this.txt_isbn);
            this.Panel2.Location = new System.Drawing.Point(1, 2);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(464, 291);
            this.Panel2.TabIndex = 13;
            // 
            // comboBoxTypelivre
            // 
            this.comboBoxTypelivre.AutoCompleteCustomSource.AddRange(new string[] {
            "Roman",
            "Action",
            "Comédie",
            "Horreur"});
            this.comboBoxTypelivre.FormattingEnabled = true;
            this.comboBoxTypelivre.Items.AddRange(new object[] {
            "Roman",
            "Action",
            "Comédie",
            "Horreur"});
            this.comboBoxTypelivre.Location = new System.Drawing.Point(143, 192);
            this.comboBoxTypelivre.Name = "comboBoxTypelivre";
            this.comboBoxTypelivre.Size = new System.Drawing.Size(135, 21);
            this.comboBoxTypelivre.TabIndex = 22;
            // 
            // Typelivre
            // 
            this.Typelivre.AutoSize = true;
            this.Typelivre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Typelivre.Location = new System.Drawing.Point(4, 197);
            this.Typelivre.Name = "Typelivre";
            this.Typelivre.Size = new System.Drawing.Size(81, 16);
            this.Typelivre.TabIndex = 21;
            this.Typelivre.Text = "Type Livre";
            // 
            // Editeur
            // 
            this.Editeur.AutoSize = true;
            this.Editeur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Editeur.Location = new System.Drawing.Point(5, 229);
            this.Editeur.Name = "Editeur";
            this.Editeur.Size = new System.Drawing.Size(56, 16);
            this.Editeur.TabIndex = 20;
            this.Editeur.Text = "Editeur";
            // 
            // Anneesortie
            // 
            this.Anneesortie.AutoSize = true;
            this.Anneesortie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Anneesortie.Location = new System.Drawing.Point(5, 155);
            this.Anneesortie.Name = "Anneesortie";
            this.Anneesortie.Size = new System.Drawing.Size(94, 16);
            this.Anneesortie.TabIndex = 19;
            this.Anneesortie.Text = "Année sortie";
            // 
            // Auteur
            // 
            this.Auteur.AutoSize = true;
            this.Auteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Auteur.Location = new System.Drawing.Point(5, 116);
            this.Auteur.Name = "Auteur";
            this.Auteur.Size = new System.Drawing.Size(51, 16);
            this.Auteur.TabIndex = 18;
            this.Auteur.Text = "Auteur";
            // 
            // Titrelivre
            // 
            this.Titrelivre.AutoSize = true;
            this.Titrelivre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titrelivre.Location = new System.Drawing.Point(4, 81);
            this.Titrelivre.Name = "Titrelivre";
            this.Titrelivre.Size = new System.Drawing.Size(95, 16);
            this.Titrelivre.TabIndex = 17;
            this.Titrelivre.Text = "Titre de livre";
            // 
            // ISBN
            // 
            this.ISBN.AutoSize = true;
            this.ISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ISBN.Location = new System.Drawing.Point(8, 49);
            this.ISBN.Name = "ISBN";
            this.ISBN.Size = new System.Drawing.Size(42, 16);
            this.ISBN.TabIndex = 16;
            this.ISBN.Text = "ISBN";
            this.ISBN.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_editeur
            // 
            this.txt_editeur.Location = new System.Drawing.Point(143, 229);
            this.txt_editeur.Name = "txt_editeur";
            this.txt_editeur.Size = new System.Drawing.Size(135, 20);
            this.txt_editeur.TabIndex = 15;
            // 
            // txt_anneesortie
            // 
            this.txt_anneesortie.Location = new System.Drawing.Point(143, 155);
            this.txt_anneesortie.MaxLength = 4;
            this.txt_anneesortie.Name = "txt_anneesortie";
            this.txt_anneesortie.Size = new System.Drawing.Size(135, 20);
            this.txt_anneesortie.TabIndex = 13;
            // 
            // txt_auteur
            // 
            this.txt_auteur.Location = new System.Drawing.Point(143, 116);
            this.txt_auteur.MaxLength = 15;
            this.txt_auteur.Name = "txt_auteur";
            this.txt_auteur.Size = new System.Drawing.Size(135, 20);
            this.txt_auteur.TabIndex = 12;
            // 
            // txt_titre
            // 
            this.txt_titre.Location = new System.Drawing.Point(143, 81);
            this.txt_titre.Name = "txt_titre";
            this.txt_titre.Size = new System.Drawing.Size(135, 20);
            this.txt_titre.TabIndex = 9;
            // 
            // txt_isbn
            // 
            this.txt_isbn.Location = new System.Drawing.Point(144, 49);
            this.txt_isbn.MaxLength = 13;
            this.txt_isbn.Name = "txt_isbn";
            this.txt_isbn.Size = new System.Drawing.Size(135, 20);
            this.txt_isbn.TabIndex = 8;
            // 
            // Ajouter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 296);
            this.Controls.Add(this.Panel2);
            this.Name = "Ajouter";
            this.Text = "Ajouter";
            this.Panel3.ResumeLayout(false);
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel Panel3;
        internal System.Windows.Forms.Button btn_annuler;
        internal System.Windows.Forms.Button btn_valider;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.TextBox txt_editeur;
        internal System.Windows.Forms.TextBox txt_anneesortie;
        internal System.Windows.Forms.TextBox txt_auteur;
        internal System.Windows.Forms.TextBox txt_titre;
        internal System.Windows.Forms.TextBox txt_isbn;
        private System.Windows.Forms.Label ISBN;
        private System.Windows.Forms.Label Anneesortie;
        private System.Windows.Forms.Label Auteur;
        private System.Windows.Forms.Label Titrelivre;
        private System.Windows.Forms.Label Typelivre;
        private System.Windows.Forms.Label Editeur;
        internal System.Windows.Forms.ComboBox comboBoxTypelivre;
    }
}