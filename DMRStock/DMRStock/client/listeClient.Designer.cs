
namespace DMRStock
{
    partial class listeClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableau = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fermer = new System.Windows.Forms.Button();
            this.txtNomClient = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVille = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.tableau)).BeginInit();
            this.SuspendLayout();
            // 
            // tableau
            // 
            this.tableau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableau.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column1,
            this.Column7,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.tableau.Location = new System.Drawing.Point(11, 119);
            this.tableau.Name = "tableau";
            this.tableau.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableau.Size = new System.Drawing.Size(1085, 486);
            this.tableau.TabIndex = 47;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "N° Client";
            this.Column8.Name = "Column8";
            this.Column8.Width = 10;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Denomination";
            this.Column1.Name = "Column1";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "ICE";
            this.Column7.Name = "Column7";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Responsable";
            this.Column2.Name = "Column2";
            this.Column2.Width = 120;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tel";
            this.Column3.Name = "Column3";
            this.Column3.Width = 120;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "E-mail";
            this.Column4.Name = "Column4";
            this.Column4.Width = 210;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Adresse";
            this.Column5.Name = "Column5";
            this.Column5.Width = 260;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Ville";
            this.Column6.Name = "Column6";
            // 
            // fermer
            // 
            this.fermer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fermer.BackColor = System.Drawing.Color.White;
            this.fermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fermer.ForeColor = System.Drawing.Color.Black;
            this.fermer.Location = new System.Drawing.Point(273, 23);
            this.fermer.Name = "fermer";
            this.fermer.Size = new System.Drawing.Size(154, 38);
            this.fermer.TabIndex = 46;
            this.fermer.Text = "FERMER";
            this.fermer.UseVisualStyleBackColor = false;
            this.fermer.Visible = false;
            this.fermer.Click += new System.EventHandler(this.fermer_Click);
            // 
            // txtNomClient
            // 
            this.txtNomClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNomClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomClient.Location = new System.Drawing.Point(117, 81);
            this.txtNomClient.Name = "txtNomClient";
            this.txtNomClient.Size = new System.Drawing.Size(387, 22);
            this.txtNomClient.TabIndex = 45;
            this.txtNomClient.TextChanged += new System.EventHandler(this.txtNomClient_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 44;
            this.label1.Text = "Denomination";
            // 
            // btnExport
            // 
            this.btnExport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(227)))));
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(948, 79);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(148, 24);
            this.btnExport.TabIndex = 48;
            this.btnExport.Text = "EXPORTER";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(227)))));
            this.label2.Location = new System.Drawing.Point(982, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 18);
            this.label2.TabIndex = 49;
            this.label2.Text = "Liste Client";
            // 
            // txtVille
            // 
            this.txtVille.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVille.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVille.FormattingEnabled = true;
            this.txtVille.Items.AddRange(new object[] {
            "",
            "Casablanca",
            "Rabat",
            "Fes",
            "Sale",
            "Marrakesh",
            "Agadir",
            "Tangier",
            "Meknes",
            "Oujda-Angad",
            "Al Hoceima",
            "Kenitra",
            "Tetouan",
            "Temara",
            "Safi",
            "Sale Al Jadida",
            "Mohammedia",
            "Khouribga",
            "Beni Mellal",
            "Fes al Bali",
            "El Jadid",
            "Taza",
            "Nador",
            "Settat",
            "Larache",
            "Ksar El Kebir",
            "Khemisset",
            "Guelmim",
            "Berrechid",
            "Errachidia",
            "Oued Zem",
            "Al Fqih Ben Calah",
            "Taourirt",
            "Berkane",
            "Sidi Slimane",
            "Sidi Qacem",
            "Khenifra",
            "Ifrane",
            "Taroudant",
            "Essaouira",
            "Tiflet",
            "Oulad Teima",
            "Sefrou",
            "Youssoufia",
            "Tan-Tan",
            "Ouezzane",
            "Guercif",
            "Ouarzazat",
            "Tirhanimine",
            "Dakhla",
            "Tiznit",
            "Fnidek",
            "Azrou",
            "Midelt",
            "Skhirate",
            "Souq Larb\'a al Gharb",
            "Jerada",
            "Smara",
            "Kasba Tadla",
            "Sidi Bennour",
            "Imzouren",
            "Martil",
            "Azemmour",
            "Tinghir",
            "Chefchaouen",
            "Al Aaroui",
            "El Aioun",
            "Zagora",
            "Taounate",
            "Sidi Yahia El Gharb",
            "Zaio",
            "Asilah",
            "Bouarfa",
            "El Hajeb",
            "Mechraa Bel Ksiri",
            "Bouznika",
            "Tahla",
            "Arfoud",
            "Setti Fatma",
            "Recani",
            "Sidi Ifni",
            "Ahfir",
            "Oulmes",
            "Bni Bouayach",
            "Ain Beni Mathar",
            "Boujniba",
            "Kelaat Mgouna",
            "Ifrane",
            "Zawyat an Nwacer",
            "Figuig (Centre)",
            "Targuist",
            "Midar",
            "Cap Negro II",
            "Mhamid",
            "Zag",
            "Gueltat Zemmour",
            "Oualidia",
            "Tarfaya",
            "Ain Leuh",
            "Taghazout",
            "Tafraout",
            "Oukaimedene",
            "Sidi Smai\'il",
            "Saidia",
            "Mosquee",
            "Imlili",
            "Zawyat ech Cheikh",
            "Akhfennir",
            "Tmourghout",
            "Jebel Tiskaouine",
            "Autre"});
            this.txtVille.Location = new System.Drawing.Point(555, 79);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(387, 24);
            this.txtVille.TabIndex = 55;
            this.txtVille.SelectedIndexChanged += new System.EventHandler(this.txtVille_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(510, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 56;
            this.label3.Text = "Ville";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(227)))));
            this.label9.Location = new System.Drawing.Point(1080, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 20);
            this.label9.TabIndex = 76;
            this.label9.Text = "X";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(227)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1113, 4);
            this.panel1.TabIndex = 77;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(227)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1109, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(4, 613);
            this.panel3.TabIndex = 78;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(227)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 613);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1109, 4);
            this.panel2.TabIndex = 79;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(227)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(4, 609);
            this.panel4.TabIndex = 80;
            // 
            // listeClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 617);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtVille);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.tableau);
            this.Controls.Add(this.fermer);
            this.Controls.Add(this.txtNomClient);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "listeClient";
            this.Text = "listeClient";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.listeClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableau)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView tableau;
        private System.Windows.Forms.Button fermer;
        private System.Windows.Forms.TextBox txtNomClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox txtVille;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}