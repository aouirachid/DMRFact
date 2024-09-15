using DMRStock.Entree;
using DMRStock.facture;
using DMRStock.sortiee;
using DMRStock.user;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMRStock
{
    public partial class n_menu : Form
    {
        public string uti = "admin";
        public n_menu()
        {
            InitializeComponent();
            customizeDesign();
           
        }

        private void customizeDesign()
        {
            pPro.Visible = false;
            pClt.Visible = false;
            pEnt.Visible = false;
            pSor.Visible = false;
            pFac.Visible = false;
            pUti.Visible = false;

        }
        private void hideSubMenu()
        {
            if (pPro.Visible == true)
                pPro.Visible = false;
            if (pClt.Visible == true)
                pClt.Visible = false;
            if (pEnt.Visible == true)
                pEnt.Visible = false;
            if (pSor.Visible == true)
                pSor.Visible = false;
            if (pFac.Visible == true)
                pFac.Visible = false;
            if (pUti.Visible == true)
                pUti.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
      

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("VOULEZ-VOUS VRAIMENT SE DECONNECTER DE DMR STOCK ?", "DMR FACTURATION", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
                this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
         
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
           
        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void btnNu_Click(object sender, EventArgs e)
        {
            hideSubMenu();

            // Get the current form in the panelContent panel.
            Form currentForm = panelContent.Controls.OfType<Form>().FirstOrDefault();

            // If the current form is the form that the user wants to open, ignore the action.
            if (currentForm is newUser)
            {
                return;
            }

            // Close the current form if it is not null.
            if (currentForm != null)
            {
                currentForm.Close();
            }

            // Create a new instance of the form that the user wants to open.
            newUser a = new newUser();

            // Set the TopLevel property to false so that the form will be displayed in the panelContent panel.
            a.TopLevel = false;

            // Add the form to the panelContent panel.
            panelContent.Controls.Add(a);

            // Bring the form to the front of the panelContent panel.
            a.BringToFront();

            // Show the form.
            a.Show();
        }

        private void btnLi_Click(object sender, EventArgs e)
        {
            hideSubMenu();

            // Get the current form in the panelContent panel.
            Form currentForm = panelContent.Controls.OfType<Form>().FirstOrDefault();

            // If the current form is the form that the user wants to open, ignore the action.
            if (currentForm is userListe)
            {
                return;
            }

            // Close the current form if it is not null.
            if (currentForm != null)
            {
                currentForm.Close();
            }

            // Create a new instance of the form that the user wants to open.
            userListe a = new userListe();

            // Set the TopLevel property to false so that the form will be displayed in the panelContent panel.
            a.TopLevel = false;

            // Add the form to the panelContent panel.
            panelContent.Controls.Add(a);

            // Bring the form to the front of the panelContent panel.
            a.BringToFront();

            // Show the form.
            a.Show();
        }

        private void btnUti_Click(object sender, EventArgs e)
        {
            showSubMenu(pUti);
        }

        private void btnclt_Click(object sender, EventArgs e)
        {
            showSubMenu(pClt);

        }

        private void btnPro_Click(object sender, EventArgs e)
        {
            showSubMenu(pPro);

        }

        private void btnEnt_Click(object sender, EventArgs e)
        {
            showSubMenu(pEnt);

        }

        private void btnSor_Click(object sender, EventArgs e)
        {
            showSubMenu(pSor);

        }

        private void btnFac_Click(object sender, EventArgs e)
        {
            showSubMenu(pFac);

        }

        private void btnnclt_Click(object sender, EventArgs e)
        {
            hideSubMenu();

            // Get the current form in the panelContent panel.
            Form currentForm = panelContent.Controls.OfType<Form>().FirstOrDefault();

            // If the current form is the form that the user wants to open, ignore the action.
            if (currentForm is newClient)
            {
                return;
            }

            // Close the current form if it is not null.
            if (currentForm != null)
            {
                currentForm.Close();
            }

            // Create a new instance of the form that the user wants to open.
            newClient a = new newClient();

            // Set the TopLevel property to false so that the form will be displayed in the panelContent panel.
            a.TopLevel = false;

            // Add the form to the panelContent panel.
            panelContent.Controls.Add(a);

            // Bring the form to the front of the panelContent panel.
            a.BringToFront();

            // Show the form.
            a.Show();
        }

        private void btnLclt_Click(object sender, EventArgs e)
        {
            hideSubMenu();

            // Get the current form in the panelContent panel.
            Form currentForm = panelContent.Controls.OfType<Form>().FirstOrDefault();

            // If the current form is the form that the user wants to open, ignore the action.
            if (currentForm is listeClient)
            {
                return;
            }

            // Close the current form if it is not null.
            if (currentForm != null)
            {
                currentForm.Close();
            }

            // Create a new instance of the form that the user wants to open.
            listeClient a = new listeClient();

            // Set the TopLevel property to false so that the form will be displayed in the panelContent panel.
            a.TopLevel = false;

            // Add the form to the panelContent panel.
            panelContent.Controls.Add(a);

            // Bring the form to the front of the panelContent panel.
            a.BringToFront();

            // Show the form.
            a.Show();
        }

        private void btnNpro_Click(object sender, EventArgs e)
        {
            hideSubMenu();

            // Get the current form in the panelContent panel.
            Form currentForm = panelContent.Controls.OfType<Form>().FirstOrDefault();

            // If the current form is the form that the user wants to open, ignore the action.
            if (currentForm is createProduct)
            {
                return;
            }

            // Close the current form if it is not null.
            if (currentForm != null)
            {
                currentForm.Close();
            }

            // Create a new instance of the form that the user wants to open.
            createProduct a = new createProduct();

            // Set the TopLevel property to false so that the form will be displayed in the panelContent panel.
            a.TopLevel = false;

            // Add the form to the panelContent panel.
            panelContent.Controls.Add(a);

            // Bring the form to the front of the panelContent panel.
            a.BringToFront();

            // Show the form.
            a.Show();
        }

        private void btnLpro_Click(object sender, EventArgs e)
        {
            hideSubMenu();

            // Get the current form in the panelContent panel.
            Form currentForm = panelContent.Controls.OfType<Form>().FirstOrDefault();

            // If the current form is the form that the user wants to open, ignore the action.
            if (currentForm is productListe)
            {
                return;
            }

            // Close the current form if it is not null.
            if (currentForm != null)
            {
                currentForm.Close();
            }

            // Create a new instance of the form that the user wants to open.
            productListe a = new productListe();

            // Set the TopLevel property to false so that the form will be displayed in the panelContent panel.
            a.TopLevel = false;

            // Add the form to the panelContent panel.
            panelContent.Controls.Add(a);

            // Bring the form to the front of the panelContent panel.
            a.BringToFront();

            // Show the form.
            a.Show();
        }

        private void btnNsor_Click(object sender, EventArgs e)
        {
            hideSubMenu();

            // Get the current form in the panelContent panel.
            Form currentForm = panelContent.Controls.OfType<Form>().FirstOrDefault();

            // If the current form is the form that the user wants to open, ignore the action.
            if (currentForm is ns)
            {
                return;
            }

            // Close the current form if it is not null.
            if (currentForm != null)
            {
                currentForm.Close();
            }

            // Create a new instance of the form that the user wants to open.
            ns a = new ns();

            // Set the TopLevel property to false so that the form will be displayed in the panelContent panel.
            a.TopLevel = false;

            //select the person who is loged in to the app
            a.txtsp.Text = uti;

            // Add the form to the panelContent panel.
            panelContent.Controls.Add(a);

            // Bring the form to the front of the panelContent panel.
            a.BringToFront();

            // Show the form.
            a.Show();
        }

        private void btnLsor_Click(object sender, EventArgs e)
        {
            hideSubMenu();

            // Get the current form in the panelContent panel.
            Form currentForm = panelContent.Controls.OfType<Form>().FirstOrDefault();

            // If the current form is the form that the user wants to open, ignore the action.
            if (currentForm is listeSortie)
            {
                return;
            }

            // Close the current form if it is not null.
            if (currentForm != null)
            {
                currentForm.Close();
            }

            // Create a new instance of the form that the user wants to open.
            listeSortie a = new listeSortie();

            // Set the TopLevel property to false so that the form will be displayed in the panelContent panel.
            a.TopLevel = false;

            // Add the form to the panelContent panel.
            panelContent.Controls.Add(a);

            // Bring the form to the front of the panelContent panel.
            a.BringToFront();

            // Show the form.
            a.Show();
        }

        private void btnNfac_Click(object sender, EventArgs e)
        {
            hideSubMenu();

            // Get the current form in the panelContent panel.
            Form currentForm = panelContent.Controls.OfType<Form>().FirstOrDefault();

            // If the current form is the form that the user wants to open, ignore the action.
            if (currentForm is newFacture)
            {
                return;
            }

            // Close the current form if it is not null.
            if (currentForm != null)
            {
                currentForm.Close();
            }

            // Create a new instance of the form that the user wants to open.
            newFacture a = new newFacture();

            // Set the TopLevel property to false so that the form will be displayed in the panelContent panel.
            a.TopLevel = false;

            // Add the form to the panelContent panel.
            panelContent.Controls.Add(a);

            // Bring the form to the front of the panelContent panel.
            a.BringToFront();

            // Show the form.
            a.Show();
        }

        private void btnLfac_Click(object sender, EventArgs e)
        {
            hideSubMenu();

            // Get the current form in the panelContent panel.
            Form currentForm = panelContent.Controls.OfType<Form>().FirstOrDefault();

            // If the current form is the form that the user wants to open, ignore the action.
            if (currentForm is listeFacture)
            {
                return;
            }

            // Close the current form if it is not null.
            if (currentForm != null)
            {
                currentForm.Close();
            }

            // Create a new instance of the form that the user wants to open.
            listeFacture a = new listeFacture();

            // Set the TopLevel property to false so that the form will be displayed in the panelContent panel.
            a.TopLevel = false;

            // Add the form to the panelContent panel.
            panelContent.Controls.Add(a);

            // Bring the form to the front of the panelContent panel.
            a.BringToFront();

            // Show the form.
            a.Show();
        }

        private void btnRfac_Click(object sender, EventArgs e)
        {
            hideSubMenu();

            // Get the current form in the panelContent panel.
            Form currentForm = panelContent.Controls.OfType<Form>().FirstOrDefault();

            // If the current form is the form that the user wants to open, ignore the action.
            if (currentForm is reglementFacture)
            {
                return;
            }

            // Close the current form if it is not null.
            if (currentForm != null)
            {
                currentForm.Close();
            }

            // Create a new instance of the form that the user wants to open.
            reglementFacture a = new reglementFacture();

            // Set the TopLevel property to false so that the form will be displayed in the panelContent panel.
            a.TopLevel = false;

            // Add the form to the panelContent panel.
            panelContent.Controls.Add(a);

            // Bring the form to the front of the panelContent panel.
            a.BringToFront();

            // Show the form.
            a.Show();
        }

        private void btnNent_Click(object sender, EventArgs e)
        {
            hideSubMenu();

            // Get the current form in the panelContent panel.
            Form currentForm = panelContent.Controls.OfType<Form>().FirstOrDefault();

            // If the current form is the form that the user wants to open, ignore the action.
            if (currentForm is ne)
            {
                return;
            }

            // Close the current form if it is not null.
            if (currentForm != null)
            {
                currentForm.Close();
            }

            // Create a new instance of the form that the user wants to open.
            ne a = new ne();

            // Set the TopLevel property to false so that the form will be displayed in the panelContent panel.
            a.TopLevel = false;

            //select the person who is loged in to the app
            a.txtep.Text = uti;

            // Add the form to the panelContent panel.
            panelContent.Controls.Add(a);

            // Bring the form to the front of the panelContent panel.
            a.BringToFront();

            // Show the form.
            a.Show();
        }

        private void btnLent_Click(object sender, EventArgs e)
        {
            hideSubMenu();

            // Get the current form in the panelContent panel.
            Form currentForm = panelContent.Controls.OfType<Form>().FirstOrDefault();

            // If the current form is the form that the user wants to open, ignore the action.
            if (currentForm is listeEntree)
            {
                return;
            }

            // Close the current form if it is not null.
            if (currentForm != null)
            {
                currentForm.Close();
            }

            // Create a new instance of the form that the user wants to open.
            listeEntree a = new listeEntree();

            // Set the TopLevel property to false so that the form will be displayed in the panelContent panel.
            a.TopLevel = false;

            // Add the form to the panelContent panel.
            panelContent.Controls.Add(a);

            // Bring the form to the front of the panelContent panel.
            a.BringToFront();

            // Show the form.
            a.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void n_menu_Load(object sender, EventArgs e)
        {
            user.Text = uti;
        }
    }
}
