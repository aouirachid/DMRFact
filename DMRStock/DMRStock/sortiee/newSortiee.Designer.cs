
namespace DMRStock.sortiee
{
    partial class ns
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
            this.btnShowProductList = new System.Windows.Forms.Button();
            this.AJOUTER = new System.Windows.Forms.Button();
            this.txtpv = new System.Windows.Forms.TextBox();
            this.tableau = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supprimer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtq = new System.Windows.Forms.TextBox();
            this.txtnop = new System.Windows.Forms.TextBox();
            this.combonp = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.enregistrer = new System.Windows.Forms.Button();
            this.fermer = new System.Windows.Forms.Button();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.bntClient = new System.Windows.Forms.Button();
            this.txtNomClient = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtsp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtde = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.cat = new System.Windows.Forms.TextBox();
            this.cmbEp = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tableau)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShowProductList
            // 
            this.btnShowProductList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(88)))), ((int)(((byte)(84)))));
            this.btnShowProductList.FlatAppearance.BorderSize = 0;
            this.btnShowProductList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowProductList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowProductList.ForeColor = System.Drawing.Color.White;
            this.btnShowProductList.Location = new System.Drawing.Point(11, 253);
            this.btnShowProductList.Name = "btnShowProductList";
            this.btnShowProductList.Size = new System.Drawing.Size(125, 23);
            this.btnShowProductList.TabIndex = 32;
            this.btnShowProductList.Text = "CHOISIR";
            this.btnShowProductList.UseVisualStyleBackColor = false;
            this.btnShowProductList.Click += new System.EventHandler(this.btnShowProductList_Click);
            // 
            // AJOUTER
            // 
            this.AJOUTER.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(88)))), ((int)(((byte)(84)))));
            this.AJOUTER.FlatAppearance.BorderSize = 0;
            this.AJOUTER.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AJOUTER.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AJOUTER.ForeColor = System.Drawing.Color.White;
            this.AJOUTER.Location = new System.Drawing.Point(973, 253);
            this.AJOUTER.Name = "AJOUTER";
            this.AJOUTER.Size = new System.Drawing.Size(125, 23);
            this.AJOUTER.TabIndex = 31;
            this.AJOUTER.Text = "AJOUTER";
            this.AJOUTER.UseVisualStyleBackColor = false;
            this.AJOUTER.Click += new System.EventHandler(this.AJOUTER_Click);
            // 
            // txtpv
            // 
            this.txtpv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpv.Location = new System.Drawing.Point(793, 254);
            this.txtpv.Name = "txtpv";
            this.txtpv.Size = new System.Drawing.Size(173, 22);
            this.txtpv.TabIndex = 28;
            this.txtpv.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtpv_KeyUp);
            // 
            // tableau
            // 
            this.tableau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableau.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column5,
            this.Column3,
            this.Column4,
            this.Supprimer});
            this.tableau.Location = new System.Drawing.Point(11, 292);
            this.tableau.Name = "tableau";
            this.tableau.RowHeadersWidth = 62;
            this.tableau.Size = new System.Drawing.Size(1087, 313);
            this.tableau.TabIndex = 27;
            this.tableau.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableau_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "N° DE REFERENCE";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 180;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "NOM DE PRODUIT";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 180;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "CATEGORIE";
            this.Column5.Name = "Column5";
            this.Column5.Width = 180;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "QUANTITE";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 180;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "PRIX DE VENTE";
            this.Column4.Name = "Column4";
            this.Column4.Width = 180;
            // 
            // Supprimer
            // 
            this.Supprimer.HeaderText = "SUPPRIMER";
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Supprimer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Supprimer.Text = "Supprimer colone";
            this.Supprimer.UseColumnTextForButtonValue = true;
            // 
            // txtq
            // 
            this.txtq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtq.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtq.Location = new System.Drawing.Point(614, 254);
            this.txtq.Name = "txtq";
            this.txtq.Size = new System.Drawing.Size(173, 22);
            this.txtq.TabIndex = 26;
            this.txtq.TextChanged += new System.EventHandler(this.txtq_TextChanged);
            this.txtq.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtq_KeyUp);
            // 
            // txtnop
            // 
            this.txtnop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnop.Location = new System.Drawing.Point(256, 254);
            this.txtnop.Name = "txtnop";
            this.txtnop.Size = new System.Drawing.Size(173, 22);
            this.txtnop.TabIndex = 25;
            // 
            // combonp
            // 
            this.combonp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combonp.FormattingEnabled = true;
            this.combonp.Location = new System.Drawing.Point(142, 252);
            this.combonp.Name = "combonp";
            this.combonp.Size = new System.Drawing.Size(108, 24);
            this.combonp.TabIndex = 24;
            this.combonp.SelectedIndexChanged += new System.EventHandler(this.combonp_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(88)))), ((int)(((byte)(84)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(271, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 28);
            this.button1.TabIndex = 31;
            this.button1.Text = "Imprimer";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // enregistrer
            // 
            this.enregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(88)))), ((int)(((byte)(84)))));
            this.enregistrer.FlatAppearance.BorderSize = 0;
            this.enregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enregistrer.ForeColor = System.Drawing.Color.White;
            this.enregistrer.Location = new System.Drawing.Point(135, 179);
            this.enregistrer.Name = "enregistrer";
            this.enregistrer.Size = new System.Drawing.Size(130, 28);
            this.enregistrer.TabIndex = 30;
            this.enregistrer.Text = "Enregistrer";
            this.enregistrer.UseVisualStyleBackColor = false;
            this.enregistrer.Click += new System.EventHandler(this.enregistrer_Click);
            // 
            // fermer
            // 
            this.fermer.BackColor = System.Drawing.Color.White;
            this.fermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fermer.ForeColor = System.Drawing.Color.Black;
            this.fermer.Location = new System.Drawing.Point(49, 12);
            this.fermer.Name = "fermer";
            this.fermer.Size = new System.Drawing.Size(164, 28);
            this.fermer.TabIndex = 28;
            this.fermer.Text = "FERMER";
            this.fermer.UseVisualStyleBackColor = false;
            this.fermer.Visible = false;
            this.fermer.Click += new System.EventHandler(this.fermer_Click);
            // 
            // txtClient
            // 
            this.txtClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClient.Enabled = false;
            this.txtClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClient.Location = new System.Drawing.Point(16, 12);
            this.txtClient.Name = "txtClient";
            this.txtClient.ReadOnly = true;
            this.txtClient.Size = new System.Drawing.Size(27, 22);
            this.txtClient.TabIndex = 45;
            this.txtClient.Text = "0";
            this.txtClient.Visible = false;
            // 
            // bntClient
            // 
            this.bntClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(88)))), ((int)(((byte)(84)))));
            this.bntClient.FlatAppearance.BorderSize = 0;
            this.bntClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntClient.ForeColor = System.Drawing.Color.White;
            this.bntClient.Location = new System.Drawing.Point(135, 55);
            this.bntClient.Name = "bntClient";
            this.bntClient.Size = new System.Drawing.Size(72, 22);
            this.bntClient.TabIndex = 44;
            this.bntClient.Text = "CHOISIR";
            this.bntClient.UseVisualStyleBackColor = false;
            this.bntClient.Click += new System.EventHandler(this.bntClient_Click);
            // 
            // txtNomClient
            // 
            this.txtNomClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomClient.Enabled = false;
            this.txtNomClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomClient.Location = new System.Drawing.Point(213, 55);
            this.txtNomClient.Name = "txtNomClient";
            this.txtNomClient.ReadOnly = true;
            this.txtNomClient.Size = new System.Drawing.Size(188, 22);
            this.txtNomClient.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 16);
            this.label6.TabIndex = 27;
            this.label6.Text = "Dénomination";
            // 
            // txtsp
            // 
            this.txtsp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsp.Enabled = false;
            this.txtsp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsp.Location = new System.Drawing.Point(135, 111);
            this.txtsp.Name = "txtsp";
            this.txtsp.ReadOnly = true;
            this.txtsp.Size = new System.Drawing.Size(266, 22);
            this.txtsp.TabIndex = 25;
            this.txtsp.Text = "Admin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Sortie par";
            // 
            // txtde
            // 
            this.txtde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtde.Location = new System.Drawing.Point(135, 83);
            this.txtde.Name = "txtde";
            this.txtde.Size = new System.Drawing.Size(266, 22);
            this.txtde.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Date de sortie";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(88)))), ((int)(((byte)(84)))));
            this.label1.Location = new System.Drawing.Point(950, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 18);
            this.label1.TabIndex = 42;
            this.label1.Text = "Nouveau Sortie";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(88)))), ((int)(((byte)(84)))));
            this.label2.Location = new System.Drawing.Point(1080, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 20);
            this.label2.TabIndex = 49;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(88)))), ((int)(((byte)(84)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1113, 4);
            this.panel1.TabIndex = 50;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(88)))), ((int)(((byte)(84)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1109, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(4, 613);
            this.panel3.TabIndex = 51;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(88)))), ((int)(((byte)(84)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(4, 613);
            this.panel4.TabIndex = 52;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(88)))), ((int)(((byte)(84)))));
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(4, 613);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1105, 4);
            this.panel2.TabIndex = 53;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(88)))), ((int)(((byte)(84)))));
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(1101, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(4, 4);
            this.panel5.TabIndex = 47;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(88)))), ((int)(((byte)(84)))));
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(4, 4);
            this.panel6.TabIndex = 47;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(88)))), ((int)(((byte)(84)))));
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(4, 4);
            this.panel7.TabIndex = 47;
            // 
            // cat
            // 
            this.cat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cat.Location = new System.Drawing.Point(435, 254);
            this.cat.Name = "cat";
            this.cat.Size = new System.Drawing.Size(173, 22);
            this.cat.TabIndex = 54;
            // 
            // cmbEp
            // 
            this.cmbEp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEp.FormattingEnabled = true;
            this.cmbEp.Items.AddRange(new object[] {
            "Regle",
            "Non Regle"});
            this.cmbEp.Location = new System.Drawing.Point(135, 139);
            this.cmbEp.Name = "cmbEp";
            this.cmbEp.Size = new System.Drawing.Size(266, 24);
            this.cmbEp.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 16);
            this.label3.TabIndex = 56;
            this.label3.Text = "Etat de paiment";
            // 
            // ns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 617);
            this.Controls.Add(this.cmbEp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cat);
            this.Controls.Add(this.tableau);
            this.Controls.Add(this.btnShowProductList);
            this.Controls.Add(this.enregistrer);
            this.Controls.Add(this.txtpv);
            this.Controls.Add(this.combonp);
            this.Controls.Add(this.txtnop);
            this.Controls.Add(this.txtq);
            this.Controls.Add(this.AJOUTER);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtsp);
            this.Controls.Add(this.bntClient);
            this.Controls.Add(this.fermer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtClient);
            this.Controls.Add(this.txtde);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNomClient);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ns";
            this.Text = "newSortiee";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.newSortiee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableau)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AJOUTER;
        private System.Windows.Forms.TextBox txtpv;
        private System.Windows.Forms.DataGridView tableau;
        private System.Windows.Forms.TextBox txtq;
        private System.Windows.Forms.TextBox txtnop;
        private System.Windows.Forms.ComboBox combonp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button enregistrer;
        private System.Windows.Forms.Button fermer;
        private System.Windows.Forms.Button bntClient;
        private System.Windows.Forms.TextBox txtNomClient;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtsp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker txtde;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnShowProductList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox cat;
        private System.Windows.Forms.ComboBox cmbEp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn Supprimer;
    }
}