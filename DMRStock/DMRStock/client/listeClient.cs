using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Configuration;

namespace DMRStock
{
    public partial class listeClient : Form
    {
        static string constring = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        SqlConnection bd = new SqlConnection(constring);
        public listeClient()
        {
            InitializeComponent();
        }

        private void listeClient_Load(object sender, EventArgs e)
        {
            Remplir();
        }
        private void Remplir()
        {
            try
            {
                tableau.Rows.Clear();
                bd.Open();
                SqlCommand cmd = new SqlCommand("select * from client", bd);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    tableau.Rows.Add(
                       rd[0],
                       rd[2],
                       rd[1],
                       rd[3],
                       rd[4],
                       rd[5],
                       rd[6],
                       rd[7]
                        );
                }
                bd.Close();
            }
            catch
            {
                MessageBox.Show("You doing something wrong please contact your responsible", "DMRSTOCK", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV Files|*.csv";

            // Set the default file name
            saveFileDialog.FileName = "export Liste Produit " + DateTime.Now.ToString("yyyy_MM_dd") + ".csv";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                {
                    // Write header row
                    for (int i = 0; i < tableau.Columns.Count; i++)
                    {
                        sw.Write(tableau.Columns[i].HeaderText);
                        if (i < tableau.Columns.Count - 1)
                        {
                            sw.Write(";");
                        }
                    }
                    sw.WriteLine();

                    // Write data rows
                    foreach (DataGridViewRow row in tableau.Rows)
                    {
                        for (int i = 0; i < tableau.Columns.Count; i++)
                        {
                            sw.Write(row.Cells[i].Value);
                            if (i < tableau.Columns.Count - 1)
                            {
                                sw.Write(";");
                            }
                        }
                        sw.WriteLine();
                    }
                }
                MessageBox.Show("Les données ont été exportées avec succès.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtNomClient_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tableau.Rows.Clear();
                bd.Open();
                SqlCommand cmd = new SqlCommand("select * from client where [nom_client] like '%" + txtNomClient.Text + "%' and [ville] like '%" + txtVille.Text + "%'", bd);
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows == true)
                {
                    while (rd.Read())
                    {
                        tableau.Rows.Add(
                        rd[0],
                        rd[2],
                        rd[1],
                        rd[3],
                        rd[4],
                        rd[5],
                        rd[6],
                        rd[7]
                            );
                    }
                }
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

        private void txtVille_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                tableau.Rows.Clear();
                bd.Open();
                SqlCommand cmd = new SqlCommand("select * from client where [ville] like '%" + txtVille.Text + "%' and [nom_client] like '%" + txtNomClient.Text + "%'", bd);
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows == true)
                {
                    while (rd.Read())
                    {
                        tableau.Rows.Add(
                        rd[0],
                        rd[2],
                        rd[1],
                        rd[3],
                        rd[4],
                        rd[5],
                        rd[6],
                        rd[7]
                            );
                    }
                }
                bd.Close();
            }
            catch
            {
                MessageBox.Show("You doing something wrong please contact your responsible", "DMRSTOCK", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
