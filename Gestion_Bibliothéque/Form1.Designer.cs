namespace Gestion_Bibliothéque
{
    partial class Form1
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_recherche = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.btn_modif = new System.Windows.Forms.Button();
            this.btn_quitter = new System.Windows.Forms.Button();
            this.btn_suprimer = new System.Windows.Forms.Button();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DataGridlivre = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.Panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridlivre)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel4
            // 
            this.Panel4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Panel4.Controls.Add(this.PictureBox1);
            this.Panel4.Controls.Add(this.txt_recherche);
            this.Panel4.Controls.Add(this.Label2);
            this.Panel4.Location = new System.Drawing.Point(31, 321);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(373, 40);
            this.Panel4.TabIndex = 15;
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(79, 2);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(30, 36);
            this.PictureBox1.TabIndex = 5;
            this.PictureBox1.TabStop = false;
            // 
            // txt_recherche
            // 
            this.txt_recherche.Location = new System.Drawing.Point(121, 10);
            this.txt_recherche.Name = "txt_recherche";
            this.txt_recherche.Size = new System.Drawing.Size(239, 20);
            this.txt_recherche.TabIndex = 10;
            this.txt_recherche.TextChanged += new System.EventHandler(this.txt_recherche_TextChanged);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Italic);
            this.Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label2.Location = new System.Drawing.Point(3, 12);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(70, 15);
            this.Label2.TabIndex = 9;
            this.Label2.Text = "Recherche";
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Panel2.Controls.Add(this.btn_modif);
            this.Panel2.Controls.Add(this.btn_quitter);
            this.Panel2.Controls.Add(this.btn_suprimer);
            this.Panel2.Controls.Add(this.btn_ajouter);
            this.Panel2.Location = new System.Drawing.Point(669, 60);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(134, 223);
            this.Panel2.TabIndex = 14;
            // 
            // btn_modif
            // 
            this.btn_modif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_modif.Image = ((System.Drawing.Image)(resources.GetObject("btn_modif.Image")));
            this.btn_modif.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_modif.Location = new System.Drawing.Point(23, 76);
            this.btn_modif.Name = "btn_modif";
            this.btn_modif.Size = new System.Drawing.Size(96, 38);
            this.btn_modif.TabIndex = 4;
            this.btn_modif.Text = "Modifier";
            this.btn_modif.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_modif.UseVisualStyleBackColor = false;
            this.btn_modif.Click += new System.EventHandler(this.btn_modif_Click);
            // 
            // btn_quitter
            // 
            this.btn_quitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_quitter.Image = ((System.Drawing.Image)(resources.GetObject("btn_quitter.Image")));
            this.btn_quitter.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_quitter.Location = new System.Drawing.Point(23, 170);
            this.btn_quitter.Name = "btn_quitter";
            this.btn_quitter.Size = new System.Drawing.Size(96, 37);
            this.btn_quitter.TabIndex = 3;
            this.btn_quitter.Text = "Quitter";
            this.btn_quitter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_quitter.UseVisualStyleBackColor = false;
            this.btn_quitter.Click += new System.EventHandler(this.btn_quitter_Click);
            // 
            // btn_suprimer
            // 
            this.btn_suprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_suprimer.Image = ((System.Drawing.Image)(resources.GetObject("btn_suprimer.Image")));
            this.btn_suprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_suprimer.Location = new System.Drawing.Point(23, 125);
            this.btn_suprimer.Name = "btn_suprimer";
            this.btn_suprimer.Size = new System.Drawing.Size(96, 39);
            this.btn_suprimer.TabIndex = 2;
            this.btn_suprimer.Text = "Supprimer";
            this.btn_suprimer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_suprimer.UseVisualStyleBackColor = false;
            this.btn_suprimer.Click += new System.EventHandler(this.btn_suprimer_Click);
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_ajouter.Image = ((System.Drawing.Image)(resources.GetObject("btn_ajouter.Image")));
            this.btn_ajouter.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ajouter.Location = new System.Drawing.Point(23, 26);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(96, 41);
            this.btn_ajouter.TabIndex = 0;
            this.btn_ajouter.Text = "Ajouter";
            this.btn_ajouter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ajouter.UseVisualStyleBackColor = false;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.DataGridlivre);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 373);
            this.panel1.TabIndex = 13;
            // 
            // DataGridlivre
            // 
            this.DataGridlivre.AllowUserToAddRows = false;
            this.DataGridlivre.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.DataGridlivre.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridlivre.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DataGridlivre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridlivre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridlivre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column5,
            this.Column3,
            this.Column2,
            this.Column4,
            this.Column6});
            this.DataGridlivre.Location = new System.Drawing.Point(14, 53);
            this.DataGridlivre.MultiSelect = false;
            this.DataGridlivre.Name = "DataGridlivre";
            this.DataGridlivre.ReadOnly = true;
            this.DataGridlivre.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridlivre.Size = new System.Drawing.Size(632, 227);
            this.DataGridlivre.TabIndex = 5;
            this.DataGridlivre.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridclient_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ISBN";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Titre de Livre";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Auteur";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Année Sortie";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Type Livre";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Editeur";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 372);
            this.Controls.Add(this.Panel4);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Panel4.ResumeLayout(false);
            this.Panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.Panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridlivre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.Panel Panel4;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.TextBox txt_recherche;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.Button btn_modif;
        internal System.Windows.Forms.Button btn_quitter;
        internal System.Windows.Forms.Button btn_suprimer;
        internal System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.DataGridView DataGridlivre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}

