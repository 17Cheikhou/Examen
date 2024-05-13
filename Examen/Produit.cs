using Guna.UI2.Designer;
using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen
{
    public partial class Produit : UserControl
    {
        string connetionString;
        MySqlConnection cnn = null;
        MySqlDataReader dr;
        MySqlCommand cm = new MySqlCommand();
        int i = 0;

        public void Vider()
        {
            textQuantite.Text = ""; textLibelle.Text = ""; textPrix.Text = ""; textCategorie.Text = "";
        }
        bool Verif()
        {
            if (textQuantite.Text == "" || textLibelle.Text == "" || textPrix.Text == "" || textCategorie.Text == ""
             )
            {
                return false;
            }
            else
            {
                return true;

            }
        }
        private Image byteArrayToImage(byte[] byteArrayIn)
        {
            try
            {
                using (MemoryStream ms = new MemoryStream(byteArrayIn))
                {
                    Image img = Image.FromStream(ms);
                    return img;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la conversion de l'image : " + ex.Message);
                return null;
            }
        }
        private void LoadProduct()
        {
            string query = "SELECT p.idprod, p.libelleprod, p.prix, p.quantite, c.libellecat AS categorie, p.date_expire, p.image " +
                           "FROM produit p " +
                           "JOIN categorie c ON p.idcat = c.idcategorie ";

            MySqlCommand cmd = new MySqlCommand(query, cnn);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dvgProduit.RowTemplate.Height = 40;
            dvgProduit.DataSource = dt;
            DataGridViewImageColumn pic = new DataGridViewImageColumn();
            pic = (DataGridViewImageColumn)dvgProduit.Columns[6];
            pic.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }
        private void loadcat()
        {

            string connetionString = "server=localhost;database=db_gestion_entreprise;uid=root;pwd=\"\";";
            cnn = new MySqlConnection(connetionString);

            string query = "SELECT * FROM categorie";
            MySqlCommand cm = new MySqlCommand(query, cnn);
            MySqlDataAdapter da = new MySqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (textCategorie != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    i++;
                    CCategorie categorie = new CCategorie
                    {
                        Id = Convert.ToInt32(row["idcategorie"]),
                        Libelle = row["libellecat"].ToString()
                        
                    };
                    textCategorie.Items.Add(categorie);
                }
                label1.Text= i.ToString();

            }
            else
            {
                MessageBox.Show("Categorie est null");
            }
        }
        public Produit()
        {
            
            InitializeComponent();
            loadcat();
            dvgProduit.CellMouseEnter += dvgProduit_CellMouseEnter;

            string connetionString = "server=localhost;database=db_gestion_entreprise;uid=root;pwd=\"\";";
            cnn = new MySqlConnection(connetionString);
            try
            {
                cnn.Open();
                if (cnn.State == ConnectionState.Open)
                {
                    // MessageBox.Show("Sucess");

                }
                cnn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void Produit_Load(object sender, EventArgs e)
        {
            LoadProduct();


        }
        private void dvgProduit_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            
               
                
            
        }





        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

           
        }

        private void btnQuantite_TextChanged(object sender, EventArgs e)
        {

        }

        private byte[] getImage()
        {
            MemoryStream stream = new MemoryStream();
            importimg.Image.Save(stream, importimg.Image.RawFormat);
            return stream.GetBuffer();
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
                 OpenFileDialog open =new OpenFileDialog();
            if(open.ShowDialog() == DialogResult.OK)
            {
                importimg.Image=new Bitmap(open.FileName);

            }
        }

      

        private void dvgProduit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dvgProduit.Rows[e.RowIndex];
            // Récupérer les données de la ligne survolée
            idupdate.Text = dvgProduit.Rows[e.RowIndex].Cells[0].Value.ToString();
            textLibelle.Text = dvgProduit.Rows[e.RowIndex].Cells[1].Value.ToString();
            textPrix.Text = dvgProduit.Rows[e.RowIndex].Cells[2].Value.ToString();
            textQuantite.Text = dvgProduit.Rows[e.RowIndex].Cells[3].Value.ToString();
            textCategorie.Text = dvgProduit.Rows[e.RowIndex].Cells[4].Value.ToString();


        }



        private void enregristrer_Click(object sender, EventArgs e)
        {
            loadcat();
            // Récupérer la catégorie sélectionnée
            CCategorie selectedCategorie = (CCategorie)textCategorie.SelectedItem;
            int categoryId = selectedCategorie.Id;
            string categoryName = selectedCategorie.Libelle;
            if (Verif() == false)
            {
                MessageBox.Show("Verifier les champs");
            }

            else
            {

                string Query = "INSERT INTO produit(libelleprod, prix, quantite, idcat, date_expire, image) VALUES (@libelleprod, @prix, @quantite, @idcat, @date_expire, @image)";


                using (MySqlCommand cmd = new MySqlCommand(Query, cnn))
                {
                    cmd.Parameters.AddWithValue("@libelleprod", this.textLibelle.Text);
                    cmd.Parameters.AddWithValue("@prix", Convert.ToInt32(this.textPrix.Text));
                    cmd.Parameters.AddWithValue("@quantite", Convert.ToInt32(this.textQuantite.Text));
                    cmd.Parameters.AddWithValue("@date_expire", datepicker.Value);
                    cmd.Parameters.AddWithValue("@idcat", Convert.ToInt32(categoryId));
                    cmd.Parameters.AddWithValue("@image", getImage());



                    try
                    {
                        cnn.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Enregistrement avec succès !");
                        LoadProduct();
                        Vider();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Erreur" + ex.Message);
                    }
                    finally
                    {
                        cnn.Close();

                    }
                }
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            int ligne = dvgProduit.SelectedRows[0].Index;
            string idsup = dvgProduit.Rows[ligne].Cells["idprod"].Value.ToString(); // on remplace "id" par le nom de la colonne contenant l'identifiant de l'enregistrement dans la bd
            if (MessageBox.Show("Voulez-vous suprimer ce produit?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string query = "DELETE FROM produit WHERE idprod = @idsup";
                using (MySqlCommand cmd = new MySqlCommand(query, cnn))
                {
                    cmd.Parameters.AddWithValue("@idsup", idsup);

                    try
                    {
                        cnn.Open();
                        cmd.ExecuteNonQuery();
                        LoadProduct();


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur lors de la suppression : " + ex.Message);
                    }
                    finally
                    {
                        cnn.Close();
                    }
                }
            }

        }

        private void update_Click_2(object sender, EventArgs e)
        {
            cnn.Open();

            loadcat();
            // Récupérer la catégorie sélectionnée
            CCategorie selectedCategorie = (CCategorie)textCategorie.SelectedItem;
            int categoryId = selectedCategorie.Id;
            string categoryName = selectedCategorie.Libelle;
            String idupdateP = idupdate.Text;
            if (MessageBox.Show("Voulez-vous modifier ce produit?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cnn.Open();


                cm = new MySqlCommand("UPDATE produit SET libelleprod = @libelleprod, prix=@prix,  quantite=@quantite,  idcat=@idcat, date_expire=@date_expire, image=@image  where idprod=@idupdateP", cnn);
                cm.Parameters.AddWithValue("@libelleprod", this.textLibelle.Text);
                cm.Parameters.AddWithValue("@prix", Convert.ToInt32(this.textPrix.Text));
                cm.Parameters.AddWithValue("@quantite", Convert.ToInt32(this.textQuantite.Text));
                cm.Parameters.AddWithValue("@date_expire", datepicker.Value);
                cm.Parameters.AddWithValue("@idcat", Convert.ToInt32(categoryId));

                cm.Parameters.AddWithValue("@image", getImage());
                cm.Parameters.AddWithValue("@idupdateP", idupdateP);


                cm.ExecuteNonQuery();
                Vider();
                cnn.Close();
                LoadProduct();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Vider();

        }

        private void dvgProduit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }

