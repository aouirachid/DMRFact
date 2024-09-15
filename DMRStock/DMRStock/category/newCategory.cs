using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace DMRStock.category
{
    public partial class newCategory : Form
    {
        static string constring = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        SqlConnection bd = new SqlConnection(constring);
        public newCategory()
        {
            InitializeComponent();
        }
        private void clear()
        {
            txtNomCat.Text = "";
        }
        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (txtNomCat.Text != "")
            {
                bd.Open();
                SqlCommand cmd = new SqlCommand("insert into category values (@name)", bd);
                cmd.Parameters.AddWithValue("@name", txtNomCat.Text);
                cmd.ExecuteNonQuery();
                clear();
                MessageBox.Show("Enregistrer avec succès", "DMRSTOCK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bd.Close();
            }
            else
            {
                MessageBox.Show("Vérifier la saisie", "DMRSTOCK", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
