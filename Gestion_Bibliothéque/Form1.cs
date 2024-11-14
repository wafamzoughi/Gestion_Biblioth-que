using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Bibliothéque
{
    public partial class Form1 : Form
    {
        public string sconstr = @"provider=Microsoft.jet.oleDB.4.0;Data source = GestionBiblio.mdb";
        public Form1()
        {
            InitializeComponent();
        }
        public void Charger_Liste_Livre()
        {
            DataGridlivre.Rows.Clear();
            string txtsql;
            txtsql = "select * from Livre";
            OleDbConnection ocn = new OleDbConnection(sconstr);
            OleDbCommand ocm = new OleDbCommand(txtsql, ocn);
            
                ocm.Connection.Open();
           
                OleDbDataReader reader = ocm.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                string[] row = new string[] {
                reader.GetValue(0).ToString() ,
                reader.GetString(1),
                reader.GetString(2),
                reader.GetValue(3).ToString(),
                reader.GetString(4),
                reader.GetString(5)};
                DataGridlivre.Rows.Add(row);



            }

            reader.Close();
            ocn.Close();
            
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
             Charger_Liste_Livre();
           
        }
        public void lancerRequete(string requete)
        {
            OleDbConnection ocn = new OleDbConnection();
            OleDbCommand ocm = new OleDbCommand();
            ocn.ConnectionString = sconstr;
            try
            {
                ocn.Open();
                ocm.Connection = ocn;
                ocm.CommandText = requete;
                int k = ocm.ExecuteNonQuery();
                ocn.Close();
                MessageBox.Show("***Supression terminer avec succée***");
            }

            catch (Exception ex)
            {
                MessageBox.Show("exception Générée : " + ex.Message);
            }
        }


        private void DataGridclient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

        private void btn_modif_Click(object sender, EventArgs e)
        {
            Modifier frm_modif = new Modifier(); 
            int lignecourrant;
            string ISBN, TitreLivre, Auteur, AnneeSortie, TypeLivre, Editeur;

            if (DataGridlivre.RowCount == 0)
                return;
            lignecourrant = DataGridlivre.CurrentRow.Index;

            ISBN = DataGridlivre.Rows[lignecourrant].Cells[0].Value.ToString();
            TitreLivre = DataGridlivre.Rows[lignecourrant].Cells[1].Value.ToString();
            Auteur = DataGridlivre.Rows[lignecourrant].Cells[2].Value.ToString();
            AnneeSortie = DataGridlivre.Rows[lignecourrant].Cells[3].Value.ToString();
            TypeLivre = DataGridlivre.Rows[lignecourrant].Cells[4].Value.ToString();
            Editeur = DataGridlivre.Rows[lignecourrant].Cells[5].Value.ToString();

            frm_modif.txt_isbn.Text = ISBN;
            frm_modif.txt_titre.Text = TitreLivre;
            frm_modif.txt_auteur.Text = Auteur;
            frm_modif.txt_anneesortie.Text = AnneeSortie;
            frm_modif.comboBoxTypelivre.Text = TypeLivre;
            frm_modif.txt_editeur.Text = Editeur;
            frm_modif.txt_isbn.Enabled = false;
            frm_modif.ShowDialog();
            Charger_Liste_Livre();
        }

        private void txt_recherche_TextChanged(object sender, EventArgs e)
        {
            DataGridlivre.Rows.Clear();
            string txtsql;
            txtsql = "select *  from Livre where TitreLivre like '%" + txt_recherche.Text + "%' or TypeLivre like '%" + txt_recherche.Text + "%'";
            OleDbConnection ocn = new OleDbConnection(sconstr);
            OleDbCommand ocm = new OleDbCommand(txtsql, ocn);
            ocm.Connection.Open();
            OleDbDataReader reader = ocm.ExecuteReader(CommandBehavior.CloseConnection);
            while (reader.Read())
            {
                string[] row = new string[] { reader.GetValue(0).ToString(),
                reader.GetValue(0).ToString() ,
                reader.GetString(1),
                reader.GetString(2),
                reader.GetValue(3).ToString(),
                reader.GetString(4),
                reader.GetString(5)};
                DataGridlivre.Rows.Add(row);

            }
            reader.Close();
            ocn.Close();
        }

        private void btn_suprimer_Click(object sender, EventArgs e)
        {
            int lignecourrant;
            string ISBN;
            string req_sup;
            if (DataGridlivre.RowCount == 0)
                return;
            lignecourrant = DataGridlivre.CurrentRow.Index;

            ISBN = DataGridlivre.Rows[lignecourrant].Cells[0].Value.ToString();
            DialogResult Supp_livre =
                (MessageBox.Show("voulez vous supprimer le livre'" +
                DataGridlivre.Rows[lignecourrant].Cells[1].Value.ToString() +
                "'", "supression livre", MessageBoxButtons.YesNo));
            if (Supp_livre == DialogResult.Yes)
            {
                req_sup = "delete from Livre where ISBN=" + ISBN + "";
                lancerRequete(req_sup);
                Charger_Liste_Livre();
            }
            else
            {
                return;
            }
        }

        private void btn_quitter_Click(object sender, EventArgs e)
        {
           
            DialogResult Supp_livre =
                (MessageBox.Show("voulez vous quitter l'application " +  MessageBoxButtons.YesNo));
            this.Close();
        }

        private void btn_ajouter_Click_1(object sender, EventArgs e)
        {
            Ajouter fm = new Ajouter();
            fm.ShowDialog();
            Charger_Liste_Livre();
        }
    }
}
