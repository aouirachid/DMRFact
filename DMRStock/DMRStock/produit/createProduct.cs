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
using System.IO;
using DMRStock.category;

namespace DMRStock
{
    public partial class createProduct : Form
    {
        static string constring = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        SqlConnection bd = new SqlConnection(constring);
        string npr;

        public createProduct()
        {
            InitializeComponent();
        }

        private void createProduct_Load(object sender, EventArgs e)
        {
            Remplir();
            bd.Open();
            SqlCommand cmd = new SqlCommand("select * from category ", bd);
            SqlDataReader rd = cmd.ExecuteReader();
            cmbCat.Items.Clear();
            cmdCat2.Items.Clear();
            while (rd.Read())
            {
                cmbCat.Items.Add(rd.GetValue(1)).ToString().Trim();
                cmdCat2.Items.Add(rd.GetValue(1)).ToString().Trim();
            }
            rd.Close();
            bd.Close();
        }
        private void clear()
        {
            txtnp.Text = "0";
            txtpa.Text = "0";
            txtpv.Text = "0";
            txts.Text = "0";
            txtl.Text = "";
            cmbCat.Text = "";
            catNum.Text = "";
        }
        private void Remplir()
        {
            try
            {
                tableau.Rows.Clear();
                bd.Open();
                SqlCommand cmd = new SqlCommand("SELECT produit.[n produit], produit.libelle, category.nom, produit.stock, produit.[prix achat], produit.[prix vente] FROM category INNER JOIN produit ON category.id = produit.category_id", bd);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    tableau.Rows.Add(
                       rd.GetValue(0),
                       rd.GetValue(1),
                       rd.GetValue(2),
                       rd.GetValue(3),
                       rd.GetValue(4),
                       rd.GetValue(5)
                        );
                }
                bd.Close();
            }
            catch
            {
                MessageBox.Show("You doing something wrong please contact your responsible", "DMRSTOCK", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtnp.Text != "" && txtl.Text != "" && float.Parse(txtpa.Text) > 0 && float.Parse(txtpv.Text) >= float.Parse(txtpa.Text))
                {
                    bd.Open();

                    // Use parameterized query to prevent SQL injection
                    string query = "INSERT INTO produit VALUES(@Name, @Description, @Supplier, @PurchaseAmount, @SaleAmount, @Category)";

                    using (SqlCommand cmd = new SqlCommand(query, bd))
                    {
                        // Add parameters
                        cmd.Parameters.AddWithValue("@Name", txtnp.Text);
                        cmd.Parameters.AddWithValue("@Description", txtl.Text);
                        cmd.Parameters.AddWithValue("@Supplier", txts.Text);
                        cmd.Parameters.AddWithValue("@PurchaseAmount", float.Parse(txtpa.Text));
                        cmd.Parameters.AddWithValue("@SaleAmount", float.Parse(txtpv.Text));
                        cmd.Parameters.AddWithValue("@Category", catNum.Text);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Enregistrer avec succès", "DMRSTOCK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                    }

                    bd.Close();
                }
                else
                {
                    MessageBox.Show("Vérifier la saisie", "DMRSTOCK", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                Remplir();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "DMRSTOCK", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    string query = "UPDATE produit SET [libelle]=@Libelle, [stock]=@Stock, [Prix achat]=@PrixAchat, [Prix vente]=@PrixVente, category_id = @Category WHERE [n produit]=@NProduit";

                    using (SqlCommand cmd = new SqlCommand(query, bd))
                    {
                        // Add parameters
                        cmd.Parameters.AddWithValue("@Libelle", txtl.Text);
                        cmd.Parameters.AddWithValue("@Stock", txts.Text);
                        cmd.Parameters.AddWithValue("@PrixAchat", float.Parse(txtpa.Text));
                        cmd.Parameters.AddWithValue("@PrixVente", float.Parse(txtpv.Text));
                        cmd.Parameters.AddWithValue("@NProduit", npr.ToString());
                        cmd.Parameters.AddWithValue("@Category", catNum.Text);

                        cmd.ExecuteNonQuery();

                        bd.Close();
                        MessageBox.Show("Modification a été bien effectuée", "DMRSTOCK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                Remplir();
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "DMRSTOCK", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
                                string query = "INSERT INTO produit ([n produit],[libelle],[stock],[prix achat],[prix vente],[category_id]) VALUES (@Value1, @Value2, @Value3, @Value4, @Value5,@Value6)";
                                using (SqlCommand cmd = new SqlCommand(query, bd))
                                {
                                    cmd.Parameters.AddWithValue("@Value1", values[0]);
                                    cmd.Parameters.AddWithValue("@Value2", values[1]);
                                    cmd.Parameters.AddWithValue("@Value3", values[2]);
                                    cmd.Parameters.AddWithValue("@Value4", values[3]);
                                    cmd.Parameters.AddWithValue("@Value5", values[4]);
                                    cmd.Parameters.AddWithValue("@Value6", values[5]);
                                    cmd.ExecuteNonQuery();
                                }
                            }
                        }
                    }

                    MessageBox.Show("Les données ont été importées avec succès.", "Import", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("You doing something wrong please contact your responsible", "DMRSTOCK", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (bd.State == ConnectionState.Open)
                        bd.Close();
                }
                Remplir();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                npr = (Microsoft.VisualBasic.Interaction.InputBox("MERCI D'ECRIRE UN NUMERO DE PRODUIT", "DMRSTOCK"));
                bd.Open();
                SqlCommand cmd = new SqlCommand("select*from produit where[n produit]='" + npr.ToString() + "'", bd);
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows == true)
                {
                    rd.Read();
                    txtnp.Text = rd.GetValue(0).ToString().Trim();
                    txtl.Text = rd.GetValue(1).ToString().Trim();
                    txts.Text = rd.GetValue(2).ToString().Trim();
                    txtpa.Text = rd.GetValue(3).ToString().Trim();
                    txtpv.Text = rd.GetValue(4).ToString().Trim();
                    btnSave.Enabled = false;
                    btnModifier.Enabled = true;
                }
                else
                {
                    MessageBox.Show("N produit " + npr.ToString() + " N'exsiste pas", "DMRSTOCK");
                }
                bd.Close();
            }
            catch
            {
                MessageBox.Show("You doing something wrong please contact your responsible", "DMRSTOCK", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cat_Click(object sender, EventArgs e)
        {
            newCategory nc = new newCategory();
            nc.StartPosition = FormStartPosition.CenterScreen;
            nc.ShowDialog();
        }

        private void cmbCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            bd.Open();
            SqlCommand cmd = new SqlCommand("select*from category where nom =@nomCat", bd);
            cmd.Parameters.AddWithValue("@nomCat", cmbCat.Text);
            SqlDataReader rd = cmd.ExecuteReader();
            rd.Read();
            catNum.Text = rd.GetValue(0).ToString().Trim();
            bd.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tableau.Rows.Clear();
                bd.Open();
                SqlCommand cmd = new SqlCommand("SELECT produit.[n produit], produit.libelle, category.nom, produit.stock, produit.[prix achat], produit.[prix vente] FROM category INNER JOIN produit ON category.id = produit.category_id where produit.libelle like @nomProduit and category.nom like @category", bd);
                cmd.Parameters.AddWithValue("@nomProduit", "%" + textBox1.Text + "%");
                cmd.Parameters.AddWithValue("@category", "%" + cmdCat2.Text + "%");
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    tableau.Rows.Add(
                       rd.GetValue(0),
                       rd.GetValue(1),
                       rd.GetValue(2),
                       rd.GetValue(3),
                       rd.GetValue(4),
                       rd.GetValue(5)
                        );
                }
                bd.Close();
            }
            catch
            {
                MessageBox.Show("You doing something wrong please contact your responsible", "DMRSTOCK", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdCat2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                tableau.Rows.Clear();
                bd.Open();
                SqlCommand cmd = new SqlCommand("SELECT produit.[n produit], produit.libelle, category.nom, produit.stock, produit.[prix achat], produit.[prix vente] FROM category INNER JOIN produit ON category.id = produit.category_id where category.nom like @category and produit.libelle like @nomProduit", bd);
                cmd.Parameters.AddWithValue("@nomProduit", "%" + textBox1.Text + "%");
                cmd.Parameters.AddWithValue("@category", "%" + cmdCat2.Text + "%");
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    tableau.Rows.Add(
                       rd.GetValue(0),
                       rd.GetValue(1),
                       rd.GetValue(2),
                       rd.GetValue(3),
                       rd.GetValue(4),
                       rd.GetValue(5)
                        );
                }
                bd.Close();
            }
            catch
            {
                MessageBox.Show("You doing something wrong please contact your responsible", "DMRSTOCK", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExporte_Click(object sender, EventArgs e)
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

        private void label7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
