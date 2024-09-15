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

namespace DMRStock.facture
{
    public partial class newFacture : Form
    {
        static string constring = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        SqlConnection bd = new SqlConnection(constring);
        string companyName = System.Configuration.ConfigurationManager.AppSettings["companyName"];
        public newFacture()
        {
            InitializeComponent();
        }

        private void bntClient_Click(object sender, EventArgs e)
        {
            try
            {
                listeClient x = new listeClient();
                x.StartPosition = FormStartPosition.CenterScreen;
                x.WindowState = FormWindowState.Normal;
                x.Show();
                int i = x.tableau.CurrentRow.Index;
                txtClient.Text = x.tableau.Rows[i].Cells[0].Value.ToString();
            }
            catch
            {
                MessageBox.Show("You doing something wrong please contact your responsible", "DMRSTOCK", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clear()
        {
            txtClient.Text = "";
            cmbDateEcheance.Text = "";
            txtVille.Text = "";
        }

        private void txtClient_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tableau.Rows.Clear();
                bd.Open();
                SqlCommand cmd = new SqlCommand("SELECT [sortie ].n_sortie, [sortie ].[date sortie], SUM(dsortie.qte * dsortie.[prix_vente]) AS mt FROM dsortie " +
                    "INNER JOIN  [sortie] ON dsortie.[n sortie] = [sortie].n_sortie INNER JOIN produit ON dsortie." +
                    "[n produit] = produit.[n produit]  where [sortie ].n_CLIENT='" + txtClient.Text + "' and [sortie ].facture='" + "0" + "' and [sortie ].ep ='" + "Non Regle" + "'   GROUP BY[sortie].n_sortie, [sortie].[date sortie]  ", bd);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    tableau.Rows.Add(
                        rd[0],
                        rd[1],
                        rd[2]
                        );
                }
                bd.Close();
                
            }
            catch
            {
                if (bd.State == ConnectionState.Open)
                {
                    bd.Close();
                }
                MessageBox.Show("You doing something wrong please contact your responsible", "DMRSTOCK", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                bd.Open();
                int k = 0;
                for (int z = 0; z < tableau.Rows.Count - 1; z++)
                {
                    if (Convert.ToBoolean(tableau.Rows[z].Cells["select"].Value) == true)
                    {
                        k = 1;
                    }
                }
                if (k == 0)
                {
                    MessageBox.Show("selctionner une sortie");
                    bd.Close();
                    return;
                }

                float taux = float.Parse(Microsoft.VisualBasic.Interaction.InputBox("Remise facture"));
                SqlCommand cmd = new SqlCommand("insert into facture values(@date, @param0, 'non mentionne', @taux, @ville, @dateEcheance, @fp)", bd);
                cmd.Parameters.AddWithValue("@date", txtDate.Value);
                cmd.Parameters.AddWithValue("@param0", 0);
                cmd.Parameters.AddWithValue("@taux", taux);
                cmd.Parameters.AddWithValue("@ville", txtVille.Text);
                cmd.Parameters.AddWithValue("@dateEcheance", cmbDateEcheance.Text);
                cmd.Parameters.AddWithValue("@fp", txtfp.Text);
                cmd.ExecuteNonQuery();

                SqlCommand cmd2 = new SqlCommand("select top(1) [n_facture] from [facture] order by [n_facture] desc", bd);
                SqlDataReader rd = cmd2.ExecuteReader();
                rd.Read();
                int ne = Convert.ToInt32(rd.GetValue(0));
                rd.Close();

                for (int i = 0; i < tableau.Rows.Count - 1; i++)
                {
                    if (Convert.ToBoolean(tableau.Rows[i].Cells["select"].Value) == true)
                    {
                        SqlCommand cmd1 = new SqlCommand("insert into dfacture values(@ne, @nSortie)", bd);
                        cmd1.Parameters.AddWithValue("@ne", ne);
                        cmd1.Parameters.AddWithValue("@nSortie", tableau.Rows[i].Cells[0].Value.ToString());
                        cmd1.ExecuteNonQuery();

                        SqlCommand cmd4 = new SqlCommand("update sortie set [facture] = 1 where [n_sortie] = @nSortie", bd);
                        cmd4.Parameters.AddWithValue("@nSortie", tableau.Rows[i].Cells[0].Value.ToString());
                        cmd4.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Enregistrer avec succee", "DMRSTOCK");



                // Create the invoice combined num
                string invoiceNumber = ne.ToString().PadLeft(3, '0');
                string invoiceNumberCombined = $"{companyName}  {invoiceNumber} / {txtDate.Value.Year}";
                // Specify the desired directory paths
                string outputDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Les Factures");
                string backupDirectory = Path.Combine(Environment.CurrentDirectory, "Les Factures");

                // Create the directories if they don't exist
                Directory.CreateDirectory(outputDirectory);
                Directory.CreateDirectory(backupDirectory);

                // SQL query to fetch data
                SqlCommand printData = new SqlCommand("SELECT facture.N_facture, facture.Date_facture, facture.ville, facture.Date_echeance, facture.fp, client.nom_client, client.ice, client.ville AS clientCity, produit.libelle, dsortie.qte, dsortie.prix_vente, dfacture.N_sortie FROM [sortie ] INNER JOIN client ON [sortie ].n_client = client.n_client INNER JOIN dsortie ON [sortie ].n_sortie = dsortie.[n sortie] INNER JOIN produit ON dsortie.[n produit] = produit.[n produit] INNER JOIN facture INNER JOIN dfacture ON facture.N_facture = dfacture.N_facture ON [sortie ].n_sortie = dfacture.N_sortie where facture.N_facture = '" + ne + "'", bd);
                //printData.Parameters.AddWithValue("@nSortie", ne);

                SqlDataReader reader = printData.ExecuteReader();

                Ex.Application app1 = new Ex.Application();
                Ex.Workbooks books = app1.Workbooks;
                Ex.Workbook book = books.Open(Path.Combine(Environment.CurrentDirectory, "FACTURE.xlsx"));
                Ex._Worksheet ws = book.ActiveSheet;

                if (reader.Read())
                {
                    ws.Cells[10, 5] = invoiceNumberCombined;
                    ws.Cells[11, 5] = reader[1];
                    ws.Cells[12, 5] = reader[2];
                    ws.Cells[13, 5] = reader[3];
                    ws.Cells[14, 5] = reader[4];
                    ws.Cells[11, 10] = reader[5];
                    ws.Cells[12, 10] = reader[6];
                    ws.Cells[13, 10] = reader[7];

                    int lineNombreTable = 20;
                    double totalAmountHt = 0;
                    double tva = 0.2;
                    double totalAmountTtc = 0;
                    double tauxTva = 0;

                    do
                    {
                        ws.Cells[lineNombreTable, 2] = reader[8];
                        ws.Cells[lineNombreTable, 6] = reader[9]; // qte
                        ws.Cells[lineNombreTable, 7] = reader[10]; // prix_vente
                        double amount = Convert.ToDouble(reader[9]) * Convert.ToDouble(reader[10]);
                        ws.Cells[lineNombreTable, 8] = amount.ToString("F2"); // MontantHt
                        totalAmountHt += amount;
                        lineNombreTable++;
                    }
                    while (reader.Read());

                    tauxTva = totalAmountHt * tva;
                    totalAmountTtc = totalAmountHt + tauxTva;

                    ws.Cells[40, 10] = tauxTva.ToString("F2"); // tauxTva
                    ws.Cells[41, 10] = totalAmountTtc.ToString("F2"); // MontantHt
                }

                // Save the document as PDF in the specified directories
                string pdfOutputPath = Path.Combine(outputDirectory, "Facture N° " + ne + ".pdf");
                book.ExportAsFixedFormat(Ex.XlFixedFormatType.xlTypePDF, pdfOutputPath);

                // Backup the document as PDF in the specified backup directory
                string pdfOutputPath2 = Path.Combine(backupDirectory, "Facture N° " + ne + ".pdf");
                book.ExportAsFixedFormat(Ex.XlFixedFormatType.xlTypePDF, pdfOutputPath2);

                // Open the saved PDF document
                System.Diagnostics.Process.Start(pdfOutputPath);

                book.Close(false);
                app1.Quit();
                bd.Close();
                clear();
            }
            catch
            {
                if (bd.State == ConnectionState.Open)
                {
                    bd.Close();
                }
                MessageBox.Show("You doing something wrong please contact your responsible", "DMRSTOCK", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tableau_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void print_Click(object sender, EventArgs e)
        {
            try
            {
                // Prompt the user to enter the "n entre"
                string nFactureStr = Microsoft.VisualBasic.Interaction.InputBox("Veuillez entrer le numéro de Facture:", "Imprimer Facture", "");

                if (!int.TryParse(nFactureStr, out int nFacture))
                {
                    MessageBox.Show("Numéro de Facture invalide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Specify the desired directory paths
                string outputDirectory = Path.Combine(Environment.CurrentDirectory, "Les Factures");
                string pdfOutputPath = Path.Combine(outputDirectory, "Facture N° " + nFacture + ".pdf");

                // Check if the file exists
                if (File.Exists(pdfOutputPath))
                {
                    // Open the saved PDF document
                    System.Diagnostics.Process.Start(pdfOutputPath);
                }
                else
                {
                    MessageBox.Show("La Facture correspondant n'a pas été trouvé", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "DMRSTOCK", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
