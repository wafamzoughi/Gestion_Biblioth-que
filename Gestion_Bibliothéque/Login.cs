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
    public partial class Login : Form
    {
        public string sconstr = @"provider=Microsoft.jet.oleDB.4.0;Data source = GestionBiblio.mdb";
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            string txtsql = "select count (login) from Login where login='" + Txt_Login.Text + "' and pwd='" + Txt_pwd.Text + "'";
            OleDbConnection ocn = new OleDbConnection(sconstr);
            OleDbCommand ocm = new OleDbCommand(txtsql, ocn);
            Int32 ival;

            try
            {
                ocm.Connection.Open();
                ival = Convert.ToInt32(ocm.ExecuteScalar());
                if (ival == 0)
                {
                    System.Media.SystemSounds.Hand.Play();
                    MessageBox.Show("verifier l'identifient", "erreur login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Txt_Login.Text = "";
                    Txt_pwd.Text = "";
                    Txt_Login.Focus();
                    ocm.Connection.Close();
                }
                else
                {
                    ocm.Connection.Close();
                    Form1 frm1 = new Form1();
                    frm1.Show();
                    Hide();
                }


            }

            catch (Exception ex)
            {
                MessageBox.Show("exception Générée : " + ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Close();
        }
    }
}
