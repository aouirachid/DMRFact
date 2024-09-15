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

namespace DMRStock.facture
{
    public partial class reglementFacture : Form
    {
        static string constring = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        SqlConnection bd = new SqlConnection(constring);
        public reglementFacture()
        {
            InitializeComponent();
        }

        private void reglementFacture_Load(object sender, EventArgs e)
        {

        }

        private void bntClient_Click(object sender, EventArgs e)
        {
            listeClient x = new listeClient();
            x.StartPosition = FormStartPosition.CenterScreen;
            x.WindowState = FormWindowState.Normal;
            x.Show();
            int i = x.tableau.CurrentRow.Index;
            txtClient.Text = x.tableau.Rows[i].Cells[0].Value.ToString();
        }

        private void reglementBonRemplir()
        {
            if (bd.State == ConnectionState.Open)
            {
                bd.Close();
            }
            tableauBon.Rows.Clear();
            bd.Open();
            SqlCommand cmd = new SqlCommand("SELECT [sortie ].n_sortie, [sortie ].[date sortie],SUM(dsortie.qte * dsortie.prix_vente)As MontantSortiee, [sortie ].n_client, [sortie ].ep, [sortie ].facture FROM [sortie ] INNER JOIN dsortie ON [sortie ].n_sortie = dsortie.[n sortie] where [sortie ].n_client='" + txtClient.Text + "' GROUP BY [sortie ].n_sortie,[sortie ].[date sortie], [sortie ].n_client,[sortie ].ep,[sortie ].facture HAVING ([sortie ].ep = 'Non Regle' and [sortie ].facture = 0)", bd);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                tableauBon.Rows.Add(
                    rd[0],
                    rd.GetDateTime(1).ToString("dd/MM/yyyy"),
                    rd[2]
                    );
            }
            bd.Close();
        }
        private void reglementFactureRemplir()
        {
            if (bd.State == ConnectionState.Open)
            {
                bd.Close();
            }
            tableauFacture.Rows.Clear();
            bd.Open();
            SqlCommand cmd = new SqlCommand("SELECT facture.N_facture,facture.Date_facture, SUM(dsortie.qte * dsortie.prix_vente*1.2) AS montantFacture, [sortie ].n_client, facture.paye FROM dsortie INNER JOIN facture INNER JOIN dfacture ON facture.N_facture = dfacture.N_facture ON dsortie.[n sortie] = dfacture.N_sortie INNER JOIN [sortie ] ON dsortie.[n sortie] = [sortie ].n_sortie AND dfacture.N_sortie = [sortie ].n_sortie  where [sortie ].n_CLIENT='" + txtClient.Text + "' GROUP BY facture.N_facture,facture.Date_facture, [sortie ].n_client, facture.paye HAVING (facture.paye = 0)", bd);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                tableauFacture.Rows.Add(
                    rd[0],
                    rd.GetDateTime(1).ToString("dd/MM/yyyy"),
                    rd[2]
                    );
            }
            bd.Close();
        }

        private void txtClient_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            if (cmbTypeReglement.SelectedIndex == 0)
            {
                tableauFacture.Visible = true;
                tableauBon.Visible = false;
                reglementFactureRemplir();
            }
            else
            {
                tableauFacture.Visible = false;
                tableauBon.Visible = true;
                reglementBonRemplir();
            }
            
            //catch
           // {
           //     MessageBox.Show("You doing something wrong please contact your responsible", "DMRSTOCK", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void saveReglementFacture()
        {
            bd.Open();
            int k = 0;
            if (cmbModePayment.Text != "")
            {
                for (int z = 0; z < tableauFacture.Rows.Count - 1; z++)
                {
                    if (Convert.ToBoolean(tableauFacture.Rows[z].Cells["select"].Value) == true)
                    {
                        k = 1;

                    }
                    if (k == 0)
                    {
                        MessageBox.Show("selctionner une Facture");
                        bd.Close();
                        return;
                    }
                    int i = 0;
                    SqlCommand cmd = new SqlCommand("update facture set [paye]='" + 1.ToString() + "',[mode reglement]='" + cmbModePayment.Text + "' where [N_facture]='" + tableauFacture.Rows[i].Cells[0].Value.ToString() + "'", bd);
                    cmd.ExecuteNonQuery();
                    
                }
                MessageBox.Show("Enregistrer avec succee", "DMRSTOCK");
            }
            txtClient.Text = ""; cmbModePayment.SelectedIndex = 0;
            bd.Close();
            return;
        }

        private void saveReglementBon()
        {
            bd.Open();
            int k = 0;
            if (cmbModePayment.Text != "")
            {
                for (int z = 0; z < tableauBon.Rows.Count - 1; z++)
                {
                    if (Convert.ToBoolean(tableauBon.Rows[z].Cells["selectBon"].Value) == true)
                    {
                        k = 1;

                    }
                    if (k == 0)
                    {
                        MessageBox.Show("selctionner une Bon sortie");
                        bd.Close();
                        return;
                    }
                    int i = 0;
                    string query = "update sortie set [ep]=@ep, modeReglement=@modeReglement where n_sortie=@nSortie";
                    SqlCommand cmd = new SqlCommand(query, bd);
                    cmd.Parameters.AddWithValue("@ep", "Regle");
                    cmd.Parameters.AddWithValue("@modeReglement", cmbModePayment.Text);
                    cmd.Parameters.AddWithValue("@nSortie", tableauBon.Rows[i].Cells[0].Value.ToString());
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Enregistrer avec succee", "DMRSTOCK");
            }
            txtClient.Text = ""; cmbModePayment.SelectedIndex = 0;
            bd.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //try
            //{
            if (cmbTypeReglement.SelectedIndex == 0)
            {
                saveReglementFacture();
            }
            else
            {
                saveReglementBon();
            }
            //}
            //catch
            //{
            //    MessageBox.Show("You doing something wrong please contact your responsible", "DMRSTOCK", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
        private void sumTotalFacture()
        {
            lms.Text = "0.00";
            for (int z = 0; z < tableauFacture.Rows.Count; z++)
            {

                if (Convert.ToBoolean(tableauFacture.Rows[z].Cells["select"].Value) == true)
                {
                    lms.Text = (float.Parse(lms.Text) + Convert.ToDouble(tableauFacture.Rows[z].Cells[2].Value)).ToString("0.00");
                }
            }
        }

        private void sumTotalBon()
        {
            lms.Text = "0.00";
            for (int z = 0; z < tableauBon.Rows.Count; z++)
            {

                if (Convert.ToBoolean(tableauBon.Rows[z].Cells["selectBon"].Value) == true)
                {
                    lms.Text = (float.Parse(lms.Text) + Convert.ToDouble(tableauBon.Rows[z].Cells[2].Value)).ToString("0.00");
                }
            }
        }

        private void btnMantantTotal_Click(object sender, EventArgs e)
        {
            if (cmbTypeReglement.SelectedIndex == 0)
            {
                sumTotalFacture();
            }
            else
            {
                sumTotalBon();
            }
        }

        private void cmbTypeReglement_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTypeReglement.SelectedIndex == 0)
            {
                lms.Text = "0.00";
                txtClient.Text = "";
                tableauFacture.Visible = true;
                tableauBon.Visible = false;
            }
            else
            {
                lms.Text = "0.00";
                txtClient.Text = "";
                tableauFacture.Visible = false;
                tableauBon.Visible = true;
            }
        }

        private void printFacture()
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

        private void printBon()
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

        private void btnImp_Click(object sender, EventArgs e)
        {
            if (cmbTypeReglement.SelectedIndex == 0)
            {
                printFacture();
            }
            else
            {
                printBon();
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
