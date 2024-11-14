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
    public partial class Modifier : Form
    {
        public string sconstr = @"provider=Microsoft.jet.oleDB.4.0;Data source = GestionBiblio.mdb";
        public Modifier()
        {
            InitializeComponent();
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

            }

            catch (Exception ex)
            {
                MessageBox.Show("exception Générée : " + ex.Message);
            }
        }
        private void btn_valider_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("modification terminer");
            string txtsql = "update Livre set ISBN= '" + txt_isbn.Text +
                "',TitreLivre='" + txt_titre.Text +
                "',Auteur='" + txt_auteur.Text +
                "',AnneeSortie='" + txt_anneesortie.Text +
                "',TypeLivre='" + comboBoxTypelivre.Text +
                "',Editeur='" + txt_editeur.Text +
                "' where ISBN= " + txt_isbn.Text + "";
            lancerRequete(txtsql);
            MessageBox.Show("modification terminer");
            Hide();
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
