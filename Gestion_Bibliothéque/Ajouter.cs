using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Bibliothéque
{
    public partial class Ajouter : Form
    {
        public string sconstr = @"provider=Microsoft.jet.oleDB.4.0;Data source = GestionBiblio.mdb";
        public Ajouter()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
                ocm.ExecuteNonQuery();
                ocn.Close();
                MessageBox.Show("***Insertion terminée avec succès***");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception générée : " + ex.Message);
            }
        }
        private void btn_valider_Click(object sender, EventArgs e)
        {
            string txtinsert;
            txtinsert = "INSERT INTO Livre (ISBN, TitreLivre, Auteur, AnneeSortie, TypeLivre, Editeur) VALUES (" +
               "'" + txt_isbn.Text + "', " +
               "'" + txt_titre.Text + "', " +
               "'" + txt_auteur.Text + "', " +
               "'" + txt_anneesortie.Text + "', " +
               "'" + comboBoxTypelivre.Text + "', " +
               "'" + txt_editeur.Text + "')";

            lancerRequete(txtinsert);
            Hide();
        }

       
    }
}
