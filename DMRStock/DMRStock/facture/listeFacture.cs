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

namespace DMRStock.facture
{
    public partial class listeFacture : Form
    {
        static string constring = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        SqlConnection bd = new SqlConnection(constring);
        string etat;
        public listeFacture()
        {
            InitializeComponent();
        }

        private void Remplir()
        {
            try
            {
                tableau.Rows.Clear();
                bd.Open();
                SqlCommand cmd = new SqlCommand("SELECT facture.N_facture, dfacture.N_sortie, facture.Date_facture, facture.paye, facture.[mode reglement] FROM facture INNER JOIN dfacture ON facture.N_facture = dfacture.N_facture", bd);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    if (rd[3].ToString() == "1")
                    {
                        etat = "Paye";
                    }
                    else
                    {
                        etat = "Non Paye";
                    }

                    tableau.Rows.Add(
                       rd.GetValue(0),
                       rd.GetValue(1),
                       rd.GetValue(2),
                       etat,
                       rd.GetValue(4)
                        );
                }
                bd.Close();
            }
            catch
            {
                MessageBox.Show("You doing something wrong please contact your responsible", "DMRSTOCK", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void listeFacture_Load(object sender, EventArgs e)
        {
            Remplir();
        }

        private void FilterFactures()
        {
            try
            {
                tableau.Rows.Clear();
                bd.Open();

                string paymentStatusFilter = cmbPaymentStatus.SelectedItem?.ToString();
                string factureNumberFilter = txtnf.Text.Trim();

                // Base query
                string query = "SELECT facture.N_facture, dfacture.N_sortie, facture.Date_facture, facture.paye, facture.[mode reglement] FROM facture INNER JOIN dfacture ON facture.N_facture = dfacture.N_facture WHERE 1=1";

                // Add filters
                if (!string.IsNullOrEmpty(factureNumberFilter))
                {
                    query += " AND facture.[N_facture] LIKE @factureNumber";
                }

                if (!string.IsNullOrEmpty(paymentStatusFilter))
                {
                    if (paymentStatusFilter == "Paye")
                    {
                        query += " AND facture.paye = 1";
                    }
                    else if (paymentStatusFilter == "Non Paye")
                    {
                        query += " AND facture.paye = 0";
                    }
                }


                SqlCommand cmd = new SqlCommand(query, bd);

                // Add parameters
                if (!string.IsNullOrEmpty(factureNumberFilter))
                {
                    cmd.Parameters.AddWithValue("@factureNumber", "%" + factureNumberFilter + "%");
                }

                SqlDataReader rd = cmd.ExecuteReader();

                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        if (rd[3].ToString() == "1")
                        {
                            etat = "Paye";
                        }
                        else
                        {
                            etat = "Non Paye";
                        }

                        tableau.Rows.Add(
                            rd.GetValue(0),
                            rd.GetValue(1),
                            rd.GetValue(2),
                            etat,
                            rd.GetValue(4)
                        );
                    }
                }
                bd.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "DMRSTOCK", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FilterFacturesDate()
        {
            try
            {
                tableau.Rows.Clear();
                bd.Open();

                string paymentStatusFilter = cmbPaymentStatus.SelectedItem?.ToString();
                string factureNumberFilter = txtnf.Text.Trim();
                string fromDate = dtpFromDate.Value.ToString("yyyy-MM-dd");
                string toDate = dtpToDate.Value.ToString("yyyy-MM-dd");

                // Base query
                string query = "SELECT facture.N_facture, dfacture.N_sortie, facture.Date_facture, facture.paye, facture.[mode reglement] FROM facture INNER JOIN dfacture ON facture.N_facture = dfacture.N_facture WHERE 1=1";

                // Add filters
                if (!string.IsNullOrEmpty(factureNumberFilter))
                {
                    query += " AND facture.[N_facture] LIKE @factureNumber";
                }

                if (!string.IsNullOrEmpty(paymentStatusFilter))
                {
                    if (paymentStatusFilter == "Paye")
                    {
                        query += " AND facture.paye = 1";
                    }
                    else if (paymentStatusFilter == "Non Paye")
                    {
                        query += " AND facture.paye = 0";
                    }
                }

                query += " AND facture.Date_facture BETWEEN @fromDate AND @toDate";

                SqlCommand cmd = new SqlCommand(query, bd);

                // Add parameters
                if (!string.IsNullOrEmpty(factureNumberFilter))
                {
                    cmd.Parameters.AddWithValue("@factureNumber", "%" + factureNumberFilter + "%");
                }

                cmd.Parameters.AddWithValue("@fromDate", fromDate);
                cmd.Parameters.AddWithValue("@toDate", toDate);

                SqlDataReader rd = cmd.ExecuteReader();

                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        if (rd[3].ToString() == "1")
                        {
                            etat = "Paye";
                        }
                        else
                        {
                            etat = "Non Paye";
                        }

                        tableau.Rows.Add(
                            rd.GetValue(0),
                            rd.GetValue(1),
                            rd.GetValue(2),
                            etat,
                            rd.GetValue(4)
                        );
                    }
                }
                bd.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "DMRSTOCK", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void statuts()
        {
            bd.Open();
            SqlCommand cmd = new SqlCommand("SELECT paye from facture", bd);
            SqlDataReader rd = cmd.ExecuteReader();
            rd.Read();
            if (rd[0].ToString() == "1")
            {
                etat = "Paye";
            }
            else
            {
                etat = "Non Paye";
            }
        }

        private void txtnf_TextChanged(object sender, EventArgs e)
        {
            FilterFactures();
        }

        private void cmbPaymentStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterFactures();
        }

        private void dtpFromDate_ValueChanged(object sender, EventArgs e)
        {
            //FilterFactures();
        }

        private void dtpToDate_ValueChanged(object sender, EventArgs e)
        {
            //FilterFactures();
        }

        private void rechercheDate_Click(object sender, EventArgs e)
        {
            FilterFacturesDate();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

        
}
