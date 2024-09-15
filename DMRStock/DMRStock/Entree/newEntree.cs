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
using Ex = Microsoft.Office.Interop.Excel;

namespace DMRStock.Entree
{
    public partial class ne : Form
    {
        static string constring = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        SqlConnection bd = new SqlConnection(constring);
        public ne()
        {
            InitializeComponent();
        }

        private void combotp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combotp.SelectedIndex != 2)
            {
                txtnp.Enabled = true;
            }
            else
                txtnp.Enabled = false;
        }
        private void clear()
        {
            combotp.SelectedIndex = 2;
            txtnp.Text = "";
            txtq.Text = "0";
            combonp.Text = "";
            txtnop.Text = "";
            tableau.Rows.Clear();
        }
        private void ne_Load(object sender, EventArgs e)
        {
            try
            {
                combotp.SelectedIndex = 2;

                bd.Open();
                SqlCommand cmd = new SqlCommand("select*from produit", bd);
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

        private void combonp_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                bd.Open();
                SqlCommand cmd = new SqlCommand("select produit.libelle, category.nom FROM category INNER JOIN produit ON category.id = produit.category_id where [n produit]='" + combonp.Text + "'", bd);
                SqlDataReader rd = cmd.ExecuteReader();
                rd.Read();
                txtnop.Text = rd.GetValue(0).ToString();
                cat.Text = rd[1].ToString();
                bd.Close();
                txtq.Select();
            }
            catch
            {
                MessageBox.Show("You doing something wrong please contact your responsible", "DMRSTOCK", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void AJOUTER_Click(object sender, EventArgs e)
        {
            try
            {
                if (combonp.Text != "" && int.Parse(txtq.Text) > 0)
                {
                    for (int i = 0; i < tableau.Rows.Count - 1; i++)
                    {
                        if (tableau.Rows[i].Cells[0].Value.ToString() == combonp.Text)
                        {
                            MessageBox.Show("produit deja ajoute");
                            return;
                        }
                    }
                    tableau.Rows.Add(
                        combonp.Text,
                        txtnop.Text,
                        cat.Text,
                        txtq.Text
                        );
                    combonp.Text = ""; txtnop.Clear(); txtq.Text = "0";cat.Clear();
                }
                else
                {
                    MessageBox.Show("verifier la saiser", "DMRSTOCK", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("verifier la saiser", "DMRSTOCK", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void enregistrer_Click(object sender, EventArgs e)
        {
            if (tableau.Rows.Count > 1)
            {
                try
                {
                    bd.Open();

                    // Use parameterized queries to avoid SQL injection
                    SqlCommand cmd = new SqlCommand("INSERT INTO entree VALUES (@typePiece, @nPiece, @dateEntre, @entreePar)", bd);
                    cmd.Parameters.AddWithValue("@typePiece", combotp.Text);
                    cmd.Parameters.AddWithValue("@nPiece", txtnp.Text);
                    cmd.Parameters.AddWithValue("@dateEntre", txtde.Value.ToString());
                    cmd.Parameters.AddWithValue("@entreePar", txtep.Text);
                    cmd.ExecuteNonQuery();

                    SqlCommand cmd1 = new SqlCommand("SELECT TOP 1 [n entre] FROM [entree] ORDER BY [n entre] DESC", bd);
                    SqlDataReader rd = cmd1.ExecuteReader();
                    rd.Read();
                    int ne = Convert.ToInt32(rd.GetValue(0));
                    rd.Close();

                    for (int i = 0; i < tableau.Rows.Count - 1; i++)
                    {
                        SqlCommand cmd2 = new SqlCommand("INSERT INTO dentree VALUES (@nEntre, @nProduit, @qte)", bd);
                        cmd2.Parameters.AddWithValue("@nEntre", ne);
                        cmd2.Parameters.AddWithValue("@nProduit", tableau.Rows[i].Cells[0].Value.ToString());
                        cmd2.Parameters.AddWithValue("@qte", tableau.Rows[i].Cells[3].Value.ToString());
                        cmd2.ExecuteNonQuery();

                        SqlCommand cmd3 = new SqlCommand("SELECT stock FROM produit WHERE [n produit] = @nProduit", bd);
                        cmd3.Parameters.AddWithValue("@nProduit", tableau.Rows[i].Cells[0].Value.ToString());
                        SqlDataReader rd1 = cmd3.ExecuteReader();
                        rd1.Read();
                        int qs = Convert.ToInt32(rd1.GetValue(0)) + Convert.ToInt32(tableau.Rows[i].Cells[3].Value);
                        rd1.Close();

                        SqlCommand cmd4 = new SqlCommand("UPDATE produit SET stock = @stock WHERE [n produit] = @nProduit", bd);
                        cmd4.Parameters.AddWithValue("@stock", qs);
                        cmd4.Parameters.AddWithValue("@nProduit", tableau.Rows[i].Cells[0].Value.ToString());
                        cmd4.ExecuteNonQuery();
                    }

                    MessageBox.Show("Enregistrer avec succes", "DMRSTOCK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Specify the desired directory paths
                    string outputDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "les bons entree");
                    string backupDirectory = Path.Combine(Environment.CurrentDirectory, "les bons entree");

                    // Create the directories if they don't exist
                    Directory.CreateDirectory(outputDirectory);
                    Directory.CreateDirectory(backupDirectory);
                    MessageBox.Show("N entree",ne.ToString()) ;
                    SqlCommand printData = new SqlCommand("SELECT entree.[n entre], entree.[type piece], entree.[n piece], entree.[date entre], entree.[entree par], produit.libelle, dentree.qte, produit.[prix achat] FROM entree INNER JOIN dentree ON entree.[n entre] = dentree.[n entree] INNER JOIN produit ON dentree.[n produit] = produit.[n produit] where entree.[n entre] = '" + ne + "'", bd);
                    //printData.Parameters.AddWithValue("@nEntre", ne);
                    SqlDataReader reader = printData.ExecuteReader();

                    Ex.Application app1 = new Ex.Application();
                    Ex.Workbooks books = app1.Workbooks;
                    Ex.Workbook book = books.Open(Path.Combine(Environment.CurrentDirectory, "BON ENTREE.xlsx"));
                    Ex._Worksheet ws = book.ActiveSheet;

                    if (reader.Read())
                    {
                        ws.Cells[10, 5] = reader[0];
                        ws.Cells[11, 5] = reader[3];
                        ws.Cells[12, 5] = reader[1];
                        ws.Cells[13, 5] = reader[2];

                        int lineNombreTable = 20;
                        double totalAmount = 0;

                        do
                        {
                            ws.Cells[lineNombreTable, 2] = reader[5]; // Désignation
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
                    string pdfOutputPath = Path.Combine(outputDirectory, "Bon Entree N° " + ne + ".pdf");
                    book.ExportAsFixedFormat(Ex.XlFixedFormatType.xlTypePDF, pdfOutputPath);

                    // Backup the document as PDF in the specified backup directory
                    string pdfOutputPath2 = Path.Combine(backupDirectory, "Bon Entree N° " + ne + ".pdf");
                    book.ExportAsFixedFormat(Ex.XlFixedFormatType.xlTypePDF, pdfOutputPath2);

                    // Open the saved PDF document
                    System.Diagnostics.Process.Start(pdfOutputPath);

                    book.Close(false);
                    app1.Quit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "DMRSTOCK", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (bd.State == System.Data.ConnectionState.Open)
                    {
                        bd.Close();
                    }
                }
            }

        }

        private void imprimer_Click(object sender, EventArgs e)
        {
            try
            {
                // Prompt the user to enter the "n entre"
                string nEntreStr = Microsoft.VisualBasic.Interaction.InputBox("Veuillez entrer le numéro d'entrée:", "Imprimer Bon Entree", "");

                if (!int.TryParse(nEntreStr, out int nEntre))
                {
                    MessageBox.Show("Numéro d'entrée invalide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Specify the desired directory paths
                string outputDirectory = Path.Combine(Environment.CurrentDirectory, "les bons entree");
                string pdfOutputPath = Path.Combine(outputDirectory, "Bon Entree N° " + nEntre + ".pdf");

                // Check if the file exists
                if (File.Exists(pdfOutputPath))
                {
                    // Open the saved PDF document
                    System.Diagnostics.Process.Start(pdfOutputPath);
                }
                else
                {
                    MessageBox.Show("Le bon entree correspondant n'a pas été trouvé", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "DMRSTOCK", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fermer_Click(object sender, EventArgs e)
        {
            this.Close();
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
                AJOUTER_Click(sender, e);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
