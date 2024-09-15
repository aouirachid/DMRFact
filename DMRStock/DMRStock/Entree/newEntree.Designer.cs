
namespace DMRStock.Entree
{
    partial class ne
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
            this.tableau = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supprimer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtq = new System.Windows.Forms.TextBox();
            this.txtnop = new System.Windows.Forms.TextBox();
            this.combonp = new System.Windows.Forms.ComboBox();
            this.imprimer = new System.Windows.Forms.Button();
            this.enregistrer = new System.Windows.Forms.Button();
            this.fermer = new System.Windows.Forms.Button();
            this.txtep = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtde = new System.Windows.Forms.DateTimePicker();
            this.txtnp = new System.Windows.Forms.TextBox();
            this.combotp = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cat = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tableau)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowProductList
            // 
            this.btnShowProductList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(227)))));
            this.btnShowProductList.FlatAppearance.BorderSize = 0;
            this.btnShowProductList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowProductList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowProductList.ForeColor = System.Drawing.Color.White;
            this.btnShowProductList.Location = new System.Drawing.Point(15, 251);
            this.btnShowProductList.Name = "btnShowProductList";
            this.btnShowProductList.Size = new System.Drawing.Size(127, 22);
            this.btnShowProductList.TabIndex = 16;
            this.btnShowProductList.Text = "CHOISIR";
            this.btnShowProductList.UseVisualStyleBackColor = false;
            this.btnShowProductList.Click += new System.EventHandler(this.btnShowProductList_Click);
            // 
            // AJOUTER
            // 
            this.AJOUTER.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(227)))));
            this.AJOUTER.FlatAppearance.BorderSize = 0;
            this.AJOUTER.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AJOUTER.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AJOUTER.ForeColor = System.Drawing.Color.White;
            this.AJOUTER.Location = new System.Drawing.Point(971, 251);
            this.AJOUTER.Name = "AJOUTER";
            this.AJOUTER.Size = new System.Drawing.Size(122, 22);
            this.AJOUTER.TabIndex = 15;
            this.AJOUTER.Text = "AJOUTER";
            this.AJOUTER.UseVisualStyleBackColor = false;
            this.AJOUTER.Click += new System.EventHandler(this.AJOUTER_Click);
            // 
            // tableau
            // 
            this.tableau.AllowUserToDeleteRows = false;
            this.tableau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableau.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3,
            this.Supprimer});
            this.tableau.Location = new System.Drawing.Point(14, 289);
            this.tableau.Name = "tableau";
            this.tableau.RowHeadersWidth = 62;
            this.tableau.Size = new System.Drawing.Size(1079, 316);
            this.tableau.TabIndex = 11;
            this.tableau.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableau_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "N° DE  REFERENCE";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "NOM DE PRODUIT";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 230;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "CATEGORIE";
            this.Column4.Name = "Column4";
            this.Column4.Width = 230;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "QUANTITE";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 230;
            // 
            // Supprimer
            // 
            this.Supprimer.HeaderText = "SUPPRIMER";
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Text = "Supprimer colone";
            this.Supprimer.UseColumnTextForButtonValue = true;
            // 
            // txtq
            // 
            this.txtq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtq.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtq.Location = new System.Drawing.Point(740, 250);
            this.txtq.Name = "txtq";
            this.txtq.Size = new System.Drawing.Size(225, 22);
            this.txtq.TabIndex = 10;
            this.txtq.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtq_KeyUp);
            // 
            // txtnop
            // 
            this.txtnop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnop.Location = new System.Drawing.Point(278, 251);
            this.txtnop.Name = "txtnop";
            this.txtnop.Size = new System.Drawing.Size(225, 22);
            this.txtnop.TabIndex = 9;
            // 
            // combonp
            // 
            this.combonp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combonp.FormattingEnabled = true;
            this.combonp.Location = new System.Drawing.Point(147, 249);
            this.combonp.Name = "combonp";
            this.combonp.Size = new System.Drawing.Size(125, 24);
            this.combonp.TabIndex = 8;
            this.combonp.SelectedIndexChanged += new System.EventHandler(this.combonp_SelectedIndexChanged);
            // 
            // imprimer
            // 
            this.imprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(227)))));
            this.imprimer.FlatAppearance.BorderSize = 0;
            this.imprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imprimer.ForeColor = System.Drawing.Color.White;
            this.imprimer.Location = new System.Drawing.Point(270, 175);
            this.imprimer.Name = "imprimer";
            this.imprimer.Size = new System.Drawing.Size(130, 28);
            this.imprimer.TabIndex = 15;
            this.imprimer.Text = "Imprimer";
            this.imprimer.UseVisualStyleBackColor = false;
            this.imprimer.Click += new System.EventHandler(this.imprimer_Click);
            // 
            // enregistrer
            // 
            this.enregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(227)))));
            this.enregistrer.FlatAppearance.BorderSize = 0;
            this.enregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enregistrer.ForeColor = System.Drawing.Color.White;
            this.enregistrer.Location = new System.Drawing.Point(134, 175);
            this.enregistrer.Name = "enregistrer";
            this.enregistrer.Size = new System.Drawing.Size(130, 28);
            this.enregistrer.TabIndex = 14;
            this.enregistrer.Text = "Enregistrer";
            this.enregistrer.UseVisualStyleBackColor = false;
            this.enregistrer.Click += new System.EventHandler(this.enregistrer_Click);
            // 
            // fermer
            // 
            this.fermer.BackColor = System.Drawing.Color.White;
            this.fermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fermer.ForeColor = System.Drawing.Color.Black;
            this.fermer.Location = new System.Drawing.Point(657, 92);
            this.fermer.Name = "fermer";
            this.fermer.Size = new System.Drawing.Size(164, 28);
            this.fermer.TabIndex = 12;
            this.fermer.Text = "FERMER";
            this.fermer.UseVisualStyleBackColor = false;
            this.fermer.Visible = false;
            this.fermer.Click += new System.EventHandler(this.fermer_Click);
            // 
            // txtep
            // 
            this.txtep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtep.Enabled = false;
            this.txtep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtep.Location = new System.Drawing.Point(134, 137);
            this.txtep.Name = "txtep";
            this.txtep.ReadOnly = true;
            this.txtep.Size = new System.Drawing.Size(266, 22);
            this.txtep.TabIndex = 9;
            this.txtep.Text = "Admin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Entrée par";
            // 
            // txtde
            // 
            this.txtde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtde.Location = new System.Drawing.Point(134, 109);
            this.txtde.Name = "txtde";
            this.txtde.Size = new System.Drawing.Size(266, 22);
            this.txtde.TabIndex = 7;
            // 
            // txtnp
            // 
            this.txtnp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnp.Enabled = false;
            this.txtnp.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnp.Location = new System.Drawing.Point(134, 81);
            this.txtnp.Name = "txtnp";
            this.txtnp.Size = new System.Drawing.Size(266, 22);
            this.txtnp.TabIndex = 6;
            // 
            // combotp
            // 
            this.combotp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combotp.FormattingEnabled = true;
            this.combotp.Items.AddRange(new object[] {
            "FACTURE",
            "BON DE COMMANDE",
            "AUCUN"});
            this.combotp.Location = new System.Drawing.Point(134, 51);
            this.combotp.Name = "combotp";
            this.combotp.Size = new System.Drawing.Size(266, 24);
            this.combotp.TabIndex = 5;
            this.combotp.SelectedIndexChanged += new System.EventHandler(this.combotp_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date d\'entrée";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "N° de pièces";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type de pièces";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(227)))));
            this.label6.Location = new System.Drawing.Point(935, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 18);
            this.label6.TabIndex = 41;
            this.label6.Text = "Nouvelle entreé";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
            // cat
            // 
            this.cat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cat.Location = new System.Drawing.Point(509, 250);
            this.cat.Name = "cat";
            this.cat.Size = new System.Drawing.Size(225, 22);
            this.cat.TabIndex = 81;
            // 
            // ne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 617);
            this.Controls.Add(this.cat);
            this.Controls.Add(this.tableau);
            this.Controls.Add(this.btnShowProductList);
            this.Controls.Add(this.imprimer);
            this.Controls.Add(this.AJOUTER);
            this.Controls.Add(this.combonp);
            this.Controls.Add(this.txtnop);
            this.Controls.Add(this.txtq);
            this.Controls.Add(this.txtep);
            this.Controls.Add(this.enregistrer);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.fermer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtde);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtnp);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.combotp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ne";
            this.Text = "newEntree";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ne_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableau)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AJOUTER;
        private System.Windows.Forms.DataGridView tableau;
        private System.Windows.Forms.TextBox txtq;
        private System.Windows.Forms.TextBox txtnop;
        private System.Windows.Forms.ComboBox combonp;
        private System.Windows.Forms.Button imprimer;
        private System.Windows.Forms.Button enregistrer;
        private System.Windows.Forms.Button fermer;
        public System.Windows.Forms.TextBox txtep;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker txtde;
        private System.Windows.Forms.TextBox txtnp;
        private System.Windows.Forms.ComboBox combotp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnShowProductList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox cat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewButtonColumn Supprimer;
    }
}