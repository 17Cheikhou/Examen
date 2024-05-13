using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen
{
    public partial class Dasbh : Form
    {
        public Dasbh()
        {
            InitializeComponent();
        }

        private void btndashbord_Click(object sender, EventArgs e)
        {
            active1.Height = btndashbord.Height;
            active1.Top = btndashbord.Top;
            dashbord1.Visible = true;
            vente1.Visible = false;
            produit1.Visible = false;
            categorie1.Visible = false;
            client1.Visible = false;
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            active1.Height = btnClient.Height;
            active1.Top = btnClient.Top;
            dashbord1.Visible = false;
            vente1.Visible = false;
            produit1.Visible = false;
            categorie1.Visible = false;
            client1.Visible = true;
        }

        private void btnVente_Click(object sender, EventArgs e)
        {
            active1.Height = btnVente.Height;
            active1.Top = btnVente.Top;
            dashbord1.Visible = false;
            vente1.Visible = true;
            produit1.Visible = false;
            categorie1.Visible = false;
            client1.Visible = false;
        }

        private void btnCategorie_Click(object sender, EventArgs e)
        {
            active1.Height = btnCategorie.Height;
            active1.Top = btnCategorie.Top;
            dashbord1.Visible = false;
            vente1.Visible = false;
            produit1.Visible = false;
            categorie1.Visible = true;
            client1.Visible = false;
        }

        private void btnProduit_Click(object sender, EventArgs e)
        {
            active1.Height = btnProduit.Height;
            active1.Top = btnProduit.Top;
            dashbord1.Visible = false;
            vente1.Visible = false;
            produit1.Visible = true;
            categorie1.Visible = false;
            client1.Visible = false;
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            // Ajoutez votre logique ici
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vous déconnecter ?", "Enregistrement", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
                Form1 f = new Form1();
                f.Show();

            }
        }

        private void dashbord1_Load(object sender, EventArgs e)
        {
            // Ajoutez votre logique de chargement ici
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
