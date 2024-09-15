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
    public partial class mainproject : Form
    {
        public mainproject()
        {
            InitializeComponent();
            //this.Resize += mainproject_Resize;
            customizeDesign();
        }
        private void customizeDesign()
        {
            panelSubProduit.Visible = false;
            panelSubClient.Visible = false;
            panelSubEntree.Visible = false;
            panelSubSortie.Visible = false;
            panelSubFacture.Visible = false;
            panelSubUser.Visible = false;
            
        }
        private void hideSubMenu()
        {
            if (panelSubProduit.Visible == true)
                panelSubProduit.Visible = false;
            if (panelSubClient.Visible == true)
                panelSubClient.Visible = false;
            if (panelSubEntree.Visible == true)
                panelSubEntree.Visible = false;
            if (panelSubSortie.Visible == true)
                panelSubSortie.Visible = false;
            if (panelSubFacture.Visible == true)
                panelSubFacture.Visible = false;
            if (panelSubUser.Visible == true)
                panelSubUser.Visible = false;
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
        private void mainproject_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btncloseh_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }

        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNewClient_Click(object sender, EventArgs e)
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

        private void btnListeSortie_Click(object sender, EventArgs e)
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

        private void btnProduit_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubProduit);
        }

        private void btnNewProd_Click(object sender, EventArgs e)
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

        private void btnListeProd_Click(object sender, EventArgs e)
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

        private void btnListeClient_Click(object sender, EventArgs e)
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

        private void btnNewEntree_Click(object sender, EventArgs e)
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

            // Add the form to the panelContent panel.
            panelContent.Controls.Add(a);

            // Bring the form to the front of the panelContent panel.
            a.BringToFront();

            // Show the form.
            a.Show();
        }

        private void btnListeEntree_Click(object sender, EventArgs e)
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

        private void btnNewSortie_Click(object sender, EventArgs e)
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

            // Add the form to the panelContent panel.
            panelContent.Controls.Add(a);

            // Bring the form to the front of the panelContent panel.
            a.BringToFront();

            // Show the form.
            a.Show();
        }

        private void btnNewFacture_Click(object sender, EventArgs e)
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

        private void btnListeFacture_Click(object sender, EventArgs e)
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

        private void btnReglement_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
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

        private void btnClient_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubClient);
        }

        private void btnEntree_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubEntree);
        }

        private void btnSortie_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubSortie);
        }

        private void btnFacture_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubFacture);
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubUser);
        }

        private void mainproject_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                // Check if the content panel has any controls (forms) open
                if (panelContent.Controls.Count > 0 && panelContent.Controls[0] is Form contentForm)
                {
                    // Maximize the form within the content panel
                    contentForm.WindowState = FormWindowState.Maximized;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
