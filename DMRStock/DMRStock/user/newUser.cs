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

namespace DMRStock.user
{
    public partial class newUser : Form
    {
        static string constring = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        SqlConnection bd = new SqlConnection(constring);
        int nuser;
        public newUser()
        {
            InitializeComponent();
        }
        private void clear()
        {
            txtEmail.Text = "";
            txtli.Text = "";
            txtmdp.Text = "";
            cmbt.Text = "";
        }

        private void remplir()
        {
            tableau.Rows.Clear();
            bd.Open();
            SqlCommand cmd = new SqlCommand("select * from utilisateur ", bd);
            SqlDataReader rd = cmd.ExecuteReader();
            while(rd.Read())
            {
                tableau.Rows.Add(
                    rd[0],
                    rd[1],
                    rd[2],
                    rd[3],
                    rd[4]
                    );
            }
            bd.Close();
        }
        private void inscriverez_vous_Click(object sender, EventArgs e)
        {
            
            bd.Open();
            SqlCommand cmd = new SqlCommand("insert into utilisateur values(@email,@login,@motDePasse,@type)", bd);
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@login", txtli.Text);
            cmd.Parameters.AddWithValue("@motDePasse", txtmdp.Text);
            cmd.Parameters.AddWithValue("@type", cmbt.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Enregistrement effectué avec succée", "DMRSTOCK");
            bd.Close();
            clear();
            remplir();

        }

        private void fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newUser_Load(object sender, EventArgs e)
        {
            remplir();
        }

        private void logIn_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tableau.Rows.Clear();
                bd.Open();
                SqlCommand cmd = new SqlCommand("SELECT * from utilisateur where  login like @login and type like @type", bd);
                cmd.Parameters.AddWithValue("@login", "%" + logIn.Text + "%");
                cmd.Parameters.AddWithValue("@type", "%" + cmbType.Text + "%");
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    tableau.Rows.Add(
                     rd[0],
                     rd[1],
                     rd[2],
                     rd[3],
                     rd[4]
                     );
                }
                bd.Close();
            }
            catch
            {
                MessageBox.Show("You doing something wrong please contact your responsible", "DMRSTOCK", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            tableau.Rows.Clear();
            bd.Open();
            SqlCommand cmd = new SqlCommand("SELECT * from utilisateur where  type like @type and login like @login", bd);
            cmd.Parameters.AddWithValue("@login", "%" + logIn.Text + "%");
            cmd.Parameters.AddWithValue("@type", "%" + cmbType.Text + "%");
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                tableau.Rows.Add(
                    rd[0],
                 rd[1],
                 rd[2],
                 rd[3],
                 rd[4]
                 );
            }
            bd.Close();
        }

        private void tableau_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = tableau.CurrentRow.Index;
            nuser = Int32.Parse(tableau.Rows[i].Cells[0].Value.ToString());
            id.Text = tableau.Rows[i].Cells[0].Value.ToString().Trim();
            txtEmail.Text = tableau.Rows[i].Cells[1].Value.ToString().Trim();
            txtli.Text = tableau.Rows[i].Cells[2].Value.ToString().Trim();
            txtmdp.Text = tableau.Rows[i].Cells[3].Value.ToString().Trim();
            cmbt.Text = tableau.Rows[i].Cells[4].Value.ToString().Trim();
            inscriverez_vous.Enabled = false;
            Modifier.Enabled = true;
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            bd.Open();
            SqlCommand cmd = new SqlCommand("update utilisateur set email = @email , login = @login , password = @motDePasse , type = @type  where id = '" + nuser.ToString() + "'  ", bd);
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@login", txtli.Text);
            cmd.Parameters.AddWithValue("@motDePasse", txtmdp.Text);
            cmd.Parameters.AddWithValue("@type", cmbt.Text);
            cmd.ExecuteNonQuery();
            bd.Close();
            MessageBox.Show("MODIFICATION EFFECTUEE AVEC SUCCES", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            remplir();
            clear();
            inscriverez_vous.Enabled = true;
            Modifier.Enabled = false;
        }

        private void Exporter_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV Files|*.csv";

            // Set the default file name
            saveFileDialog.FileName = "export Liste Utilisateur " + DateTime.Now.ToString("yyyy_MM_dd") + ".csv";

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
                            string[] headers = sr.ReadLine().Split(';');
                            DataTable dt = new DataTable();

                            foreach (string header in headers)
                            {
                                dt.Columns.Add(header);
                            }
                            string line;
                            while ((line = sr.ReadLine()) != null)
                            {
                                string[] values = line.Split(';');
                                string query = "insert into utilisateur ([email],[login],[password],[type]) VALUES (@Value1, @Value2, @Value3, @Value4)";
                                using (SqlCommand cmd = new SqlCommand(query, bd))
                                {
                                    cmd.Parameters.AddWithValue("@Value1", values[0]);
                                    cmd.Parameters.AddWithValue("@Value2", values[1]);
                                    cmd.Parameters.AddWithValue("@Value3", values[2]);
                                    cmd.Parameters.AddWithValue("@Value4", values[3]);
                                    cmd.ExecuteNonQuery();
                                }
                            }
                        }
                        bd.Close();
                    }

                    MessageBox.Show("Les données ont été importées avec succès.", "Import", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch 
                {
                    MessageBox.Show("You doing something wrong please contact your responsible", "DMRSTOCK", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (bd.State == ConnectionState.Open)
                        bd.Close();
                }

                remplir();
            }
        }
    }
}
