using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace DMRStock.user
{
    public partial class loginPage : Form
    {
        static string constring = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        SqlConnection bd = new SqlConnection(constring);
        int i = 0;
        public loginPage()
        {
            InitializeComponent();
        }

        private void inscriverez_vous_Click(object sender, EventArgs e)
        {
            try
            {
                bd.Open();
                SqlCommand cmd = new SqlCommand("select * from utilisateur where [login]='" + txtli.Text + "' and [password]='" + txtmdp.Text + "'", bd);
                SqlDataReader rd = cmd.ExecuteReader();

                if (rd.HasRows == true)
                {
                    rd.Read();
                    n_menu x = new n_menu();
                    x.uti = txtli.Text;
                    this.Hide();
                    if (rd.GetValue(4).ToString().Trim() == "Super admin")
                    {
                       x.btnUti.Visible = true;
                    }
                    else
                        x.btnUti.Visible = false;

                    x.Show();
                }
                else
                {
                    MessageBox.Show("Mot de pase incorrecte", "DMRSTOCK", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtmdp.Clear();
                    txtli.Clear(); txtli.Select();
                }

                if (i == 3)
                {

                    MessageBox.Show("Désolé vus avez dépassé le nombre de fois que vous devez entrer le mot de passe", "DMRSTOCK",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                }
                i++;
                bd.Close();
            }
            catch
            {
                MessageBox.Show("You doing something wrong please contact your responsible", "DMRSTOCK", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mpa_CheckedChanged(object sender, EventArgs e)
        {
            if (mpa.Checked == true)
            {
                txtmdp.UseSystemPasswordChar = false;
            }


            else
            {
                txtmdp.UseSystemPasswordChar = true;
            }
        }
    }
}
