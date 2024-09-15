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
using Ex = Microsoft.Office.Interop.Excel;

namespace DMRStock.sortiee
{
    public partial class ns : Form
    {
        static string constring = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        SqlConnection bd = new SqlConnection(constring);
        public ns()
        {
            InitializeComponent();
        }

        private void btnShowProductList_Click(object sender, EventArgs e)
        {
            productListe x = new productListe();
            x.StartPosition = FormStartPosition.CenterScreen;
            x.WindowState = FormWindowState.Normal;
            x.Show();
            int i = x.tableau.CurrentRow.Index;
            combonp.Text = x.tableau.Rows[i].Cells[0].Value.ToString().Trim();
            txtnop.Text = x.tableau.Rows[i].Cells[1].Value.ToString().Trim();
            txtq.Select();
            
        }
        private void clear()
        {
            txtClient.Text = "";
            txtNomClient.Text = "";
            txtq.Text = "0";
            combonp.Text = "";
            txtnop.Text = "";
            cmbEp.Text = "";
            tableau.Rows.Clear();
        }

        private void newSortiee_Load(object sender, EventArgs e)
        {
            try
            {
                //combotp.SelectedIndex = 2;
                bd.Open();
                SqlCommand cmd = new SqlCommand("SELECT produit.[n produit], produit.libelle, category.nom, produit.stock, produit.[prix achat], produit.[prix vente] FROM category INNER JOIN produit ON category.id = produit.category_id", bd);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    combonp.Items.Add(rd.GetValue(0));
                }
                bd.Close();
            }
            catch
            {
                MessageBox.Show("You doing something wrong please contact your responsible", "DMRSTOCK", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AJOUTER_Click(object sender, EventArgs e)
        {
            //try
            //{
            bd.Open();
            if (combonp.Text != "" && int.Parse(txtq.Text) > 0)
            {
                // Check if the product is already in the tableau
                for (int i = 0; i < tableau.Rows.Count - 1; i++)
                {
                    if (tableau.Rows[i].Cells[0].Value.ToString() == combonp.Text)
                    {
                        MessageBox.Show("Produit déjà ajouté");
                        return; // Exit the method if the product is already in the tableau
                    }
                }

                // Check stock availability for the selected product
                SqlCommand cmd3 = new SqlCommand("select [stock] from produit where [n produit] = '" + combonp.Text + "'", bd);
                SqlDataReader rd1 = cmd3.ExecuteReader();

                if (rd1.Read())
                {
                    int currentStock = Convert.ToInt32(rd1["stock"]);
                    rd1.Close();

                    int quantityToAdd = Convert.ToInt32(txtq.Text);

                    if (currentStock >= quantityToAdd)
                    {
                        
                        // Add the product to tableau
                        tableau.Rows.Add(
                            combonp.Text,
                            txtnop.Text,
                            cat.Text,
                            txtq.Text,
                            txtpv.Text
                        );
                        combonp.Text = ""; txtnop.Clear(); txtq.Text = "0"; txtpv.Text = "0"; cat.Text = "";
                    }
                    else
                    {
                        MessageBox.Show($"Stock insuffisant pour le produit sélectionné. Stock actuel: {currentStock} unités", "DMRSTOCK", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Produit non trouvé dans la base de données", "DMRSTOCK", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Veuillez vérifier la saisie", "DMRSTOCK", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            bd.Close();
            //}

            //catch
            //{
            //    MessageBox.Show("You doing something wrong please contact your responsible", "DMRSTOCK", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void combonp_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                bd.Open();
                SqlCommand cmd = new SqlCommand("SELECT produit.[n produit], produit.libelle, category.nom, produit.stock, produit.[prix achat], produit.[prix vente] FROM category INNER JOIN produit ON category.id = produit.category_id where produit.[n produit]=@prodName", bd);
                cmd.Parameters.AddWithValue("@prodName", combonp.Text);
                SqlDataReader rd = cmd.ExecuteReader();
                rd.Read();
                txtnop.Text = rd.GetValue(1).ToString();
                txtpv.Text = rd.GetValue(4).ToString();
                cat.Text = rd[2].ToString();
                bd.Close();
                txtq.Select();
            }
            catch
            {
                MessageBox.Show("You doing something wrong please contact your responsible", "DMRSTOCK", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bntClient_Click(object sender, EventArgs e)
        {
            try
            {
                listeClient x = new listeClient();
                x.StartPosition = FormStartPosition.CenterScreen;
                x.WindowState = FormWindowState.Normal;
                x.ShowDialog();
                int i = x.tableau.CurrentRow.Index;
                txtClient.Text = x.tableau.Rows[i].Cells[0].Value.ToString().Trim();
                txtNomClient.Text = x.tableau.Rows[i].Cells[1].Value.ToString().Trim();
            }
            catch
            {
                MessageBox.Show("You doing something wrong please contact your responsible", "DMRSTOCK", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void enregistrer_Click(object sender, EventArgs e)
        {
            try
            {
                bd.Open();

            if (tableau.Rows.Count > 1)
            {
                int nc = int.Parse(txtClient.Text);
                int j = 0;

                // Insert into sortie table
                SqlCommand cmd = new SqlCommand("INSERT INTO sortie VALUES (@nc, @nomClient, @dateSortie, @sortiePar, @status, @ep,@modeReglement)", bd);
                cmd.Parameters.AddWithValue("@nc", nc);
                cmd.Parameters.AddWithValue("@nomClient", txtNomClient.Text);
                cmd.Parameters.AddWithValue("@dateSortie", txtde.Value.Date.ToString());
                cmd.Parameters.AddWithValue("@sortiePar", txtsp.Text);
                cmd.Parameters.AddWithValue("@status", j.ToString());
                cmd.Parameters.AddWithValue("@ep", cmbEp.Text);
                cmd.Parameters.AddWithValue("@modeReglement", "non montionne");
                cmd.ExecuteNonQuery();

                // Get the latest n_sortie
                SqlCommand cmd1 = new SqlCommand("SELECT TOP 1 [n_sortie] FROM [sortie] ORDER BY [n_sortie] DESC", bd);
                SqlDataReader rd = cmd1.ExecuteReader();
                rd.Read();
                int ne = Convert.ToInt32(rd.GetValue(0));
                rd.Close();

                for (int i = 0; i < tableau.Rows.Count - 1; i++)
                {
                    // Insert into dsortie table
                    SqlCommand cmd2 = new SqlCommand("INSERT INTO dsortie  VALUES (@nSortie, @nProduit, @qte, @prixVente)", bd);
                    cmd2.Parameters.AddWithValue("@nSortie", ne);
                    cmd2.Parameters.AddWithValue("@nProduit", tableau.Rows[i].Cells[0].Value.ToString());
                    cmd2.Parameters.AddWithValue("@qte", tableau.Rows[i].Cells[3].Value.ToString());
                    cmd2.Parameters.AddWithValue("@prixVente", tableau.Rows[i].Cells[4].Value.ToString());
                    cmd2.ExecuteNonQuery();

                    // Update stock
                    int currentStock = int.Parse(tableau.Rows[i].Cells[3].Value.ToString());
                    SqlCommand cmd4 = new SqlCommand("UPDATE produit SET [stock] = [stock] - @currentStock WHERE [n produit] = @nProduit", bd);
                    cmd4.Parameters.AddWithValue("@currentStock", currentStock);
                    cmd4.Parameters.AddWithValue("@nProduit", tableau.Rows[i].Cells[0].Value.ToString());
                    cmd4.ExecuteNonQuery();
                }
                MessageBox.Show("Enregistrer avec succès", "DMRSTOCK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Specify the desired directory paths
                string outputDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "les bons sorties");
                string backupDirectory = Path.Combine(Environment.CurrentDirectory, "les bons sorties");

                // Create the directories if they don't exist
                Directory.CreateDirectory(outputDirectory);
                Directory.CreateDirectory(backupDirectory);

                // SQL query to fetch data
                SqlCommand printData = new SqlCommand("SELECT client.nom_client, client.ice, client.ville, [sortie ].n_sortie, [sortie ].[date sortie], [sortie ].sortie_par, dsortie.qte, dsortie.prix_vente, produit.libelle FROM client INNER JOIN [sortie ] ON client.n_client = [sortie ].n_client INNER JOIN dsortie ON [sortie ].n_sortie = dsortie.[n sortie] INNER JOIN produit ON dsortie.[n produit] = produit.[n produit] where [sortie ].n_sortie = '" + ne + "'", bd);
                //printData.Parameters.AddWithValue("@nSortie", ne);

                SqlDataReader reader = printData.ExecuteReader();

                Ex.Application app1 = new Ex.Application();
                Ex.Workbooks books = app1.Workbooks;
                Ex.Workbook book = books.Open(Path.Combine(Environment.CurrentDirectory, "BON SORTIE.xlsx"));
                Ex._Worksheet ws = book.ActiveSheet;

                if (reader.Read())
                {
                    // Debugging step to confirm client name is fetched
                    string clientName = reader[0].ToString();
                    ws.Cells[11, 5] = reader[3];
                    ws.Cells[12, 5] = reader[4];
                    ws.Cells[13, 5] = reader[5];
                    ws.Cells[11, 10] = clientName; // Assign client name to cell [11, 10]
                    ws.Cells[12, 10] = reader[1];
                    ws.Cells[13, 10] = reader[2];

                    int lineNombreTable = 20;
                    double totalAmount = 0;

                    do
                    {
                        ws.Cells[lineNombreTable, 2] = reader[8]; // Désignation
                        ws.Cells[lineNombreTable, 6] = reader[6]; // Quantité
                        ws.Cells[lineNombreTable, 7] = reader[7]; // Prix unitaire
                        double amount = Convert.ToDouble(reader[6]) * Convert.ToDouble(reader[7]);
                        ws.Cells[lineNombreTable, 8] = amount.ToString("F2"); // Montant
                        totalAmount += amount;
                        lineNombreTable++;
                    }
                    while (reader.Read());

                    // ws.Cells[lineNombreTable, 5] = totalAmount.ToString("F2"); // Total Montant
                }

                // Save the document as PDF in the specified directories
                string pdfOutputPath = Path.Combine(outputDirectory, "Bon Sortie N° " + ne + ".pdf");
                book.ExportAsFixedFormat(Ex.XlFixedFormatType.xlTypePDF, pdfOutputPath);

                // Backup the document as PDF in the specified backup directory
                string pdfOutputPath2 = Path.Combine(backupDirectory, "Bon Sortie N° " + ne + ".pdf");
                book.ExportAsFixedFormat(Ex.XlFixedFormatType.xlTypePDF, pdfOutputPath2);

                // Open the saved PDF document
                System.Diagnostics.Process.Start(pdfOutputPath);

                book.Close(false);
                app1.Quit();
                bd.Close();
                clear();
            }

        
            else
            {
                MessageBox.Show("Verifier la saisie", "DMRSTOCK", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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

        private void txtClient_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableau_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == tableau.Columns["Supprimer"].Index && e.RowIndex >= 0)
            {
                if (tableau.Rows[e.RowIndex].Cells["Supprimer"].Value != null)
                {
                    // Get the row to be deleted
                    DataGridViewRow row = tableau.Rows[e.RowIndex];

                    // Perform your delete logic here
                    // For example, you can delete the row from a data source
                    // and then remove it from the DataGridView
                    // data source.Remove(row.DataBoundItem); // Adjust this line as per your data source
                    tableau.Rows.Remove(row);
                }
            }
        }

        private void txtq_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtpv.Select();
            }
        }

        private void txtpv_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AJOUTER_Click(sender, e);
            }
        }

        private void txtq_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Prompt the user to enter the "n entre"
                string nSortieStr = Microsoft.VisualBasic.Interaction.InputBox("Veuillez entrer le numéro de sortie:", "Imprimer Bon Sortie", "");

                if (!int.TryParse(nSortieStr, out int nSortie))
                {
                    MessageBox.Show("Numéro de sortie invalide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Specify the desired directory paths
                string outputDirectory = Path.Combine(Environment.CurrentDirectory, "les bons sorties");
                string pdfOutputPath = Path.Combine(outputDirectory, "Bon Sortie N° " + nSortie + ".pdf");

                // Check if the file exists
                if (File.Exists(pdfOutputPath))
                {
                    // Open the saved PDF document
                    System.Diagnostics.Process.Start(pdfOutputPath);
                }
                else
                {
                    MessageBox.Show("Le bon sortie correspondant n'a pas été trouvé", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "DMRSTOCK", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
