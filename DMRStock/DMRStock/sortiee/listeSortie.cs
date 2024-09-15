﻿using System;
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

namespace DMRStock.sortiee
{
    public partial class listeSortie : Form
    {
        static string constring = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        SqlConnection bd = new SqlConnection(constring);
        public listeSortie()
        {
            InitializeComponent();
        }

        private void listeSortie_Load(object sender, EventArgs e)
        {
            try
            {
                tableau.Rows.Clear();
                bd.Open();
                SqlCommand cmd = new SqlCommand("SELECT sortie.n_sortie, produit.libelle, category.nom, dsortie.qte, sortie.[date sortie], sortie.ep, sortie.sortie_par FROM dsortie INNER JOIN sortie ON dsortie.[n sortie] = sortie.n_sortie INNER JOIN produit ON dsortie.[n produit] = produit.[n produit] INNER JOIN category ON produit.category_id = category.id", bd);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    tableau.Rows.Add(
                       rd.GetValue(0),
                       rd.GetValue(1),
                       rd.GetValue(2),
                       rd.GetValue(3),
                       rd.GetDateTime(4).ToString("dd/MM/yyyy"),
                       rd.GetValue(5),
                       rd[6]
                        );
                }
                bd.Close();
            }
            catch
            {
                MessageBox.Show("You have an error please contact your responseble", "DMRSTOCK", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bd.Close();
            }
            bd.Open();
            SqlCommand cmb = new SqlCommand("select * from category ", bd);
            SqlDataReader rb = cmb.ExecuteReader();
            cmbCat.Items.Clear();
            while (rb.Read())
            {
                cmbCat.Items.Add(rb.GetValue(1)).ToString().Trim();
            }
            rb.Close();
            bd.Close();
        }

        private void txtNomProduit_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tableau.Rows.Clear();
                bd.Open();
                SqlCommand cmd = new SqlCommand("SELECT sortie.n_sortie, produit.libelle, category.nom, dsortie.qte, sortie.[date sortie], sortie.ep, sortie.sortie_par FROM dsortie INNER JOIN sortie ON dsortie.[n sortie] = sortie.n_sortie INNER JOIN produit ON dsortie.[n produit] = produit.[n produit] INNER JOIN category ON produit.category_id = category.id where produit.libelle like '%" + txtNomProduit.Text + "%' and category.nom like '%" + cmbCat.Text + "%'", bd);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    tableau.Rows.Add(
                       rd.GetValue(0),
                       rd.GetValue(1),
                       rd.GetValue(2),
                       rd.GetValue(3),
                       rd.GetDateTime(4).ToString("dd/MM/yyyy"),
                       rd.GetValue(5),
                       rd[6]
                        );
                }
                bd.Close();
            }
            catch
            {
                MessageBox.Show("You have an error please contact your responseble", "DMRSTOCK", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV Files|*.csv";

            // Set the default file name
            saveFileDialog.FileName = "export Liste Sortie " + DateTime.Now.ToString("yyyy_MM_dd") + ".csv";

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

        private void cmbCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                tableau.Rows.Clear();
                bd.Open();
                SqlCommand cmd = new SqlCommand("SELECT sortie.n_sortie, produit.libelle, category.nom, dsortie.qte, sortie.[date sortie], sortie.ep, sortie.sortie_par FROM dsortie INNER JOIN sortie ON dsortie.[n sortie] = sortie.n_sortie INNER JOIN produit ON dsortie.[n produit] = produit.[n produit] INNER JOIN category ON produit.category_id = category.id where category.nom like '%" + cmbCat.Text + "%' and produit.libelle like '%" + txtNomProduit.Text + "%'", bd);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    tableau.Rows.Add(
                       rd.GetValue(0),
                       rd.GetValue(1),
                       rd.GetValue(2),
                       rd.GetValue(3),
                       rd.GetDateTime(4).ToString("dd/MM/yyyy"),
                       rd.GetValue(5),
                       rd[6]
                        );
                }
                bd.Close();
            }
            catch
            {
                MessageBox.Show("You have an error please contact your responseble", "DMRSTOCK", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rechercheDate_Click(object sender, EventArgs e)
        {
            tableau.Rows.Clear();
            bd.Open();

            string query = "SELECT sortie.n_sortie, produit.libelle, category.nom, dsortie.qte, sortie.[date sortie], sortie.ep, sortie.sortie_par FROM dsortie INNER JOIN sortie ON dsortie.[n sortie] = sortie.n_sortie INNER JOIN produit ON dsortie.[n produit] = produit.[n produit] INNER JOIN category ON produit.category_id = category.id WHERE sortie.[date sortie] >= @fromDate AND sortie.[date sortie] <= @toDate and produit.libelle LIKE @nomProduit AND category.nom LIKE @category";
            SqlCommand cmd = new SqlCommand(query, bd);
            cmd.Parameters.AddWithValue("@nomProduit", "%" + txtNomProduit.Text + "%");
            cmd.Parameters.AddWithValue("@category", "%" + cmbCat.Text + "%");
            cmd.Parameters.AddWithValue("@fromDate", fromDate.Value.Date);
            cmd.Parameters.AddWithValue("@toDate", toDate.Value.Date.AddDays(1));

            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                tableau.Rows.Add(
                    rd[0].ToString().Trim(),
                    rd[1].ToString().Trim(),
                    rd[2].ToString().Trim(),
                    rd[3].ToString().Trim(),
                    rd.GetDateTime(4).ToString("dd/MM/yyyy"),
                    rd[5].ToString().Trim(),
                    rd[6].ToString().Trim()
                );
            }

            bd.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
