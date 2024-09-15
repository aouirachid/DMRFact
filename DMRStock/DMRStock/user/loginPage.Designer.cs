
namespace DMRStock.user
{
    partial class loginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginPage));
            this.fermer = new System.Windows.Forms.Button();
            this.inscriverez_vous = new System.Windows.Forms.Button();
            this.txtli = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mpa = new System.Windows.Forms.CheckBox();
            this.txtmdp = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // fermer
            // 
            this.fermer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fermer.BackColor = System.Drawing.Color.White;
            this.fermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fermer.ForeColor = System.Drawing.Color.Black;
            this.fermer.Location = new System.Drawing.Point(190, 283);
            this.fermer.Name = "fermer";
            this.fermer.Size = new System.Drawing.Size(154, 38);
            this.fermer.TabIndex = 33;
            this.fermer.Text = "FERMER";
            this.fermer.UseVisualStyleBackColor = false;
            this.fermer.Click += new System.EventHandler(this.fermer_Click);
            // 
            // inscriverez_vous
            // 
            this.inscriverez_vous.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inscriverez_vous.BackColor = System.Drawing.Color.White;
            this.inscriverez_vous.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inscriverez_vous.Location = new System.Drawing.Point(350, 283);
            this.inscriverez_vous.Name = "inscriverez_vous";
            this.inscriverez_vous.Size = new System.Drawing.Size(172, 38);
            this.inscriverez_vous.TabIndex = 3;
            this.inscriverez_vous.Text = "SE CONNECTER";
            this.inscriverez_vous.UseVisualStyleBackColor = false;
            this.inscriverez_vous.Click += new System.EventHandler(this.inscriverez_vous_Click);
            // 
            // txtli
            // 
            this.txtli.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtli.BackColor = System.Drawing.Color.White;
            this.txtli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtli.Location = new System.Drawing.Point(222, 152);
            this.txtli.Name = "txtli";
            this.txtli.Size = new System.Drawing.Size(332, 26);
            this.txtli.TabIndex = 1;
            this.txtli.Text = "admin";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 24);
            this.label2.TabIndex = 32;
            this.label2.Text = "MOT DE PASSE";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 24);
            this.label1.TabIndex = 31;
            this.label1.Text = "LOGIN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(138, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(336, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // mpa
            // 
            this.mpa.AutoSize = true;
            this.mpa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mpa.Location = new System.Drawing.Point(222, 238);
            this.mpa.Name = "mpa";
            this.mpa.Size = new System.Drawing.Size(216, 22);
            this.mpa.TabIndex = 75;
            this.mpa.Text = "AFFICHER MOT DE PASSE";
            this.mpa.UseVisualStyleBackColor = true;
            this.mpa.CheckedChanged += new System.EventHandler(this.mpa_CheckedChanged);
            // 
            // txtmdp
            // 
            this.txtmdp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmdp.Location = new System.Drawing.Point(222, 197);
            this.txtmdp.Name = "txtmdp";
            this.txtmdp.Size = new System.Drawing.Size(332, 26);
            this.txtmdp.TabIndex = 2;
            this.txtmdp.UseSystemPasswordChar = true;
            // 
            // loginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 333);
            this.Controls.Add(this.txtmdp);
            this.Controls.Add(this.mpa);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.fermer);
            this.Controls.Add(this.inscriverez_vous);
            this.Controls.Add(this.txtli);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "loginPage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fermer;
        private System.Windows.Forms.Button inscriverez_vous;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox mpa;
        private System.Windows.Forms.TextBox txtmdp;
        public System.Windows.Forms.TextBox txtli;
    }
}