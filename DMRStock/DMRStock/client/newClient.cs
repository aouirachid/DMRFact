using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;

namespace DMRStock
{
    public partial class newClient : Form
    {
        static string constring = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        SqlConnection bd = new SqlConnection(constring);
        string npr;
        public newClient()
        {
            InitializeComponent();
        }

        private void newClient_Load(object sender, EventArgs e)
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
        private void clear()
        {
            txtNomComplete.Text = "";
            txtIce.Text = "";
            txtVille.SelectedIndex = 109;
            txtTel.Text = "+212 ### ### ###";
            txtemail.Text = "";
            txtAdresse.Text = "";
            txtResponsable.Text = "";
        }

        private void txtIce_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            try
            {
                if (bd.State == ConnectionState.Open)
                    bd.Close();

                bd.Open();

                // Check if the client already exists
                using (SqlCommand cmdCheck = new SqlCommand("SELECT [nom_client] FROM client WHERE [nom_client] = @NomClient", bd))
                {
                    cmdCheck.Parameters.AddWithValue("@NomClient", txtNomComplete.Text);

                    using (SqlDataReader rd1 = cmdCheck.ExecuteReader())
                    {
                        if (rd1.HasRows)
                        {
                            MessageBox.Show("Client déjà existé", "DMRSTOCK", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return; // Exit the method if the client already exists
                        }
                    }
                }

                // Insert the new client
                if (txtNomComplete.Text != "" && txtTel.Text != "" && txtAdresse.Text != "" && txtVille.Text != "")
                {
                    using (SqlCommand cmdInsert = new SqlCommand("INSERT INTO client VALUES(@Ice, @NomClient, @Responsable, @Tel, @Email, @Adresse, @Ville)", bd))
                    {
                        cmdInsert.Parameters.AddWithValue("@Ice", txtIce.Text);
                        cmdInsert.Parameters.AddWithValue("@NomClient", txtNomComplete.Text);
                        cmdInsert.Parameters.AddWithValue("@Responsable", txtResponsable.Text);
                        cmdInsert.Parameters.AddWithValue("@Tel", txtTel.Text);
                        cmdInsert.Parameters.AddWithValue("@Email", txtemail.Text);
                        cmdInsert.Parameters.AddWithValue("@Adresse", txtAdresse.Text);
                        cmdInsert.Parameters.AddWithValue("@Ville", txtVille.Text);

                        cmdInsert.ExecuteNonQuery();

                        clear();
                        MessageBox.Show("Enregistrer avec succès", "DMRSTOCK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Remplir();
                    }
                }
                else
                {
                    MessageBox.Show("Vérifier la saisie", "DMRSTOCK", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "DMRSTOCK", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                bd.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV Files|*.csv";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    {
                        bd.Open();

                        using (StreamReader sr = new StreamReader(openFileDialog.FileName))
                        {
                            string[] headers = sr.ReadLine().Split(',');
                            DataTable dt = new DataTable();

                            foreach (string header in headers)
                            {
                                dt.Columns.Add(header);
                            }
                            string line;
                            while ((line = sr.ReadLine()) != null)
                            {
                                string[] values = line.Split(',');
                                string query = "INSERT INTO client ([ice],[nom_client],[respnsable],[tel],[email],[adresse],[ville]) VALUES (@Value1, @Value2, @Value3,@Value4, @Value5, @Value6, @Value7)";
                                using (SqlCommand cmd = new SqlCommand(query, bd))
                                {
                                    cmd.Parameters.AddWithValue("@Value1", values[1]);
                                    cmd.Parameters.AddWithValue("@Value2", values[2]);
                                    cmd.Parameters.AddWithValue("@Value3", values[3]);
                                    cmd.Parameters.AddWithValue("@Value4", values[4]);
                                    cmd.Parameters.AddWithValue("@Value5", values[5]);
                                    cmd.Parameters.AddWithValue("@Value6", values[6]);
                                    cmd.Parameters.AddWithValue("@Value7", values[7]);
                                    cmd.ExecuteNonQuery();
                                }
                            }
                        }
                    }

                    MessageBox.Show("Les données ont été importées avec succès.", "DMRSTOCK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch 
                {
                    MessageBox.Show("You doing something wrong please contact your responsible", "DMRSTOCK", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (bd.State == ConnectionState.Open)
                        bd.Close();
                }
                Remplir();
            }
        }

        private void btnfermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                npr = Microsoft.VisualBasic.Interaction.InputBox("MERCI D'ECRIRE LA DENOMENATION DE L'ENTREPRISE", "DMRSTOCK");
                bd.Open();
                SqlCommand cmd = new SqlCommand("select*from client where[nom_client]='" + npr.ToString() + "'", bd);
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows == true)
                {
                    rd.Read();
                    txtIce.Text = rd.GetValue(1).ToString().Trim();
                    txtNomComplete.Text = rd.GetValue(2).ToString().Trim();
                    txtResponsable.Text = rd.GetValue(3).ToString().Trim();
                    txtTel.Text = rd.GetValue(4).ToString().Trim();
                    txtemail.Text = rd.GetValue(5).ToString().Trim();
                    txtAdresse.Text = rd.GetValue(6).ToString().Trim();
                    txtVille.Text = rd.GetValue(7).ToString().Trim();
                    btnEnregistrer.Enabled = false;
                    btnModifier.Enabled = true;
                }
                else
                {
                    MessageBox.Show("DENOMENATION " + npr.ToString() + " N'exsiste pas", "DMRSTOCK");
                }
                bd.Close();
            }
            catch
            {
                MessageBox.Show("You doing something wrong please contact your responsible", "DMRSTOCK", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Effectuer la modification", "DMRSTOCK", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bd.Open();

                    // Use parameterized query to prevent SQL injection
                    string query = "UPDATE client SET [ice]=@ice, [nom_client]=@nomClient, [respnsable]=@responsable, [tel]=@tel, [email]=@email, [adresse]=@adresse, [ville]=@ville WHERE [nom_client]=@den";

                    using (SqlCommand cmd = new SqlCommand(query, bd))
                    {
                        // Add parameters
                        cmd.Parameters.AddWithValue("@ice", txtIce.Text);
                        cmd.Parameters.AddWithValue("@nomClient", txtNomComplete.Text);
                        cmd.Parameters.AddWithValue("@responsable", txtResponsable.Text);
                        cmd.Parameters.AddWithValue("@tel", txtTel.Text);
                        cmd.Parameters.AddWithValue("@email", txtemail.Text);
                        cmd.Parameters.AddWithValue("@adresse", txtAdresse.Text);
                        cmd.Parameters.AddWithValue("@ville", txtVille.Text);
                        cmd.Parameters.AddWithValue("@den", npr.ToString());

                        cmd.ExecuteNonQuery();

                        bd.Close();
                        MessageBox.Show("Modification a été bien effectuée", "DMRSTOCK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                clear();
                Remplir();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "DMRSTOCK", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNomClient_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tableau.Rows.Clear();
                bd.Open();
                SqlCommand cmd = new SqlCommand("select * from client where [nom_client] like '%" + txtNomClient.Text + "%' and [ville] like '%" + cmbVille.Text + "%'", bd);
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                tableau.Rows.Clear();
                bd.Open();
                SqlCommand cmd = new SqlCommand("select * from client where [ville] like '%" + cmbVille.Text + "%' and [nom_client] like '%" + txtNomClient.Text + "%'", bd);
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

        private void label9_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
