
namespace DMRStock.facture
{
    partial class reglementFacture
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnImp = new System.Windows.Forms.Button();
            this.btnMantantTotal = new System.Windows.Forms.Button();
            this.cmbModePayment = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lms = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.tableauFacture = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bntClient = new System.Windows.Forms.Button();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTypeReglement = new System.Windows.Forms.ComboBox();
            this.tableauBon = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectBon = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tableauFacture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableauBon)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImp
            // 
            this.btnImp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnImp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(227)))));
            this.btnImp.FlatAppearance.BorderSize = 0;
            this.btnImp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImp.ForeColor = System.Drawing.Color.White;
            this.btnImp.Location = new System.Drawing.Point(141, 151);
            this.btnImp.Name = "btnImp";
            this.btnImp.Size = new System.Drawing.Size(115, 28);
            this.btnImp.TabIndex = 71;
            this.btnImp.Text = "Imprimer";
            this.btnImp.UseVisualStyleBackColor = false;
            this.btnImp.Click += new System.EventHandler(this.btnImp_Click);
            // 
            // btnMantantTotal
            // 
            this.btnMantantTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMantantTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(227)))));
            this.btnMantantTotal.FlatAppearance.BorderSize = 0;
            this.btnMantantTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMantantTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMantantTotal.ForeColor = System.Drawing.Color.White;
            this.btnMantantTotal.Location = new System.Drawing.Point(383, 151);
            this.btnMantantTotal.Name = "btnMantantTotal";
            this.btnMantantTotal.Size = new System.Drawing.Size(115, 28);
            this.btnMantantTotal.TabIndex = 70;
            this.btnMantantTotal.Text = "Afficher total";
            this.btnMantantTotal.UseVisualStyleBackColor = false;
            this.btnMantantTotal.Click += new System.EventHandler(this.btnMantantTotal_Click);
            // 
            // cmbModePayment
            // 
            this.cmbModePayment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbModePayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbModePayment.FormattingEnabled = true;
            this.cmbModePayment.Items.AddRange(new object[] {
            "Espece",
            "Cheque",
            "Virment Bancaire",
            "Effet"});
            this.cmbModePayment.Location = new System.Drawing.Point(141, 111);
            this.cmbModePayment.Name = "cmbModePayment";
            this.cmbModePayment.Size = new System.Drawing.Size(357, 24);
            this.cmbModePayment.TabIndex = 69;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 68;
            this.label1.Text = "Mode payment";
            // 
            // lms
            // 
            this.lms.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lms.AutoSize = true;
            this.lms.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lms.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lms.Location = new System.Drawing.Point(504, 151);
            this.lms.Name = "lms";
            this.lms.Size = new System.Drawing.Size(67, 31);
            this.lms.TabIndex = 67;
            this.lms.Text = "0.00";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(227)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(262, 151);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(115, 28);
            this.btnSave.TabIndex = 65;
            this.btnSave.Text = "Enregistrer";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tableauFacture
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableauFacture.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tableauFacture.Anchor = System.Windows.Forms.AnchorStyles.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableauFacture.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tableauFacture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableauFacture.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.select});
            this.tableauFacture.Location = new System.Drawing.Point(15, 210);
            this.tableauFacture.Name = "tableauFacture";
            this.tableauFacture.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableauFacture.Size = new System.Drawing.Size(1086, 395);
            this.tableauFacture.TabIndex = 64;
            this.tableauFacture.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "N° Facture";
            this.Column1.Name = "Column1";
            this.Column1.Width = 250;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Date facture";
            this.Column2.Name = "Column2";
            this.Column2.Width = 255;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Montant";
            this.Column3.Name = "Column3";
            this.Column3.Width = 255;
            // 
            // select
            // 
            this.select.HeaderText = "Selectionner";
            this.select.Name = "select";
            this.select.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.select.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.select.Width = 255;
            // 
            // bntClient
            // 
            this.bntClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bntClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(227)))));
            this.bntClient.FlatAppearance.BorderSize = 0;
            this.bntClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntClient.ForeColor = System.Drawing.Color.White;
            this.bntClient.Location = new System.Drawing.Point(141, 83);
            this.bntClient.Name = "bntClient";
            this.bntClient.Size = new System.Drawing.Size(72, 22);
            this.bntClient.TabIndex = 63;
            this.bntClient.Text = "CHOISIR";
            this.bntClient.UseVisualStyleBackColor = false;
            this.bntClient.Click += new System.EventHandler(this.bntClient_Click);
            // 
            // txtClient
            // 
            this.txtClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClient.Location = new System.Drawing.Point(219, 83);
            this.txtClient.Name = "txtClient";
            this.txtClient.Size = new System.Drawing.Size(279, 22);
            this.txtClient.TabIndex = 62;
            this.txtClient.TextChanged += new System.EventHandler(this.txtClient_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 61;
            this.label3.Text = "Client";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(227)))));
            this.label6.Location = new System.Drawing.Point(929, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 18);
            this.label6.TabIndex = 72;
            this.label6.Text = "Reglement facture";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(227)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1113, 4);
            this.panel1.TabIndex = 86;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(227)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1109, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(4, 613);
            this.panel3.TabIndex = 87;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(227)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 613);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1109, 4);
            this.panel2.TabIndex = 88;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(227)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(4, 609);
            this.panel4.TabIndex = 89;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(227)))));
            this.label9.Location = new System.Drawing.Point(1080, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 20);
            this.label9.TabIndex = 90;
            this.label9.Text = "X";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 16);
            this.label2.TabIndex = 91;
            this.label2.Text = "Type Reglement";
            // 
            // cmbTypeReglement
            // 
            this.cmbTypeReglement.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbTypeReglement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTypeReglement.FormattingEnabled = true;
            this.cmbTypeReglement.Items.AddRange(new object[] {
            "Facture",
            "Bon Sortiee"});
            this.cmbTypeReglement.Location = new System.Drawing.Point(141, 53);
            this.cmbTypeReglement.Name = "cmbTypeReglement";
            this.cmbTypeReglement.Size = new System.Drawing.Size(357, 24);
            this.cmbTypeReglement.TabIndex = 92;
            this.cmbTypeReglement.SelectedIndexChanged += new System.EventHandler(this.cmbTypeReglement_SelectedIndexChanged);
            // 
            // tableauBon
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableauBon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.tableauBon.Anchor = System.Windows.Forms.AnchorStyles.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableauBon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.tableauBon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableauBon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.selectBon});
            this.tableauBon.Location = new System.Drawing.Point(15, 210);
            this.tableauBon.Name = "tableauBon";
            this.tableauBon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableauBon.Size = new System.Drawing.Size(1086, 395);
            this.tableauBon.TabIndex = 93;
            this.tableauBon.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "N Bon Sortie";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 250;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Date Sortie";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 255;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Montant";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 255;
            // 
            // selectBon
            // 
            this.selectBon.HeaderText = "Selectionner";
            this.selectBon.Name = "selectBon";
            this.selectBon.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.selectBon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.selectBon.Width = 255;
            // 
            // reglementFacture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 617);
            this.Controls.Add(this.tableauBon);
            this.Controls.Add(this.cmbTypeReglement);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnImp);
            this.Controls.Add(this.btnMantantTotal);
            this.Controls.Add(this.cmbModePayment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lms);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tableauFacture);
            this.Controls.Add(this.bntClient);
            this.Controls.Add(this.txtClient);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "reglementFacture";
            this.Text = "reglementFacture";
            this.Load += new System.EventHandler(this.reglementFacture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableauFacture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableauBon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImp;
        private System.Windows.Forms.Button btnMantantTotal;
        private System.Windows.Forms.ComboBox cmbModePayment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lms;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView tableauFacture;
        private System.Windows.Forms.Button bntClient;
        public System.Windows.Forms.TextBox txtClient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTypeReglement;
        private System.Windows.Forms.DataGridView tableauBon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn select;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selectBon;
    }
}