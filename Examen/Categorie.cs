using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen
{
    public partial class Categorie : UserControl
    {
        string connetionString;
        MySqlConnection cnn;
        MySqlDataReader dr;
        MySqlCommand cm = new MySqlCommand();

        public void Vider()
        {
            TextDescription.Text = ""; TextLibelle.Text = "";
        }
        bool Verif()
        {
            if (TextDescription.Text == "" || TextLibelle.Text == ""
             )
            {
                return false;
            }
            else
            {
                return true;

            }
        }
        private bool LibelleExisteDeja(string libelle)
        {
            string Query = "SELECT COUNT(*) FROM categorie WHERE libellecat = @libelle";
            using (MySqlCommand cmd = new MySqlCommand(Query, cnn))
            {
                cmd.Parameters.AddWithValue("@libelle", libelle);
                cnn.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                cnn.Close();
                return count > 0;
            }
        }
        public string GetLabel1Value()
        {
            return label1.Text ;

        }

        public Categorie()
        {
            InitializeComponent();
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






        private void guna2DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {     
               string colName = dgvcategorie.Columns[e.ColumnIndex].Name;
                if (colName == "delete")
                {
                lbIdcat.Text = dgvcategorie.Rows[e.RowIndex].Cells[0].Value.ToString();

                try
                {
                        cnn.Open();
                        string idDelete = lbIdcat.Text;
                        cm = new MySqlCommand("DELETE FROM categorie WHERE idcategorie = @idDelete", cnn);
                        cm.Parameters.AddWithValue("@idDelete", idDelete);
                        int rowsAffected = cm.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("La Suppression est faite avec l'Id :" + idDelete);
                        }
                        else
                        {
                        MessageBox.Show("La Suppression est échouée.");
                    }
                }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur: " + ex.Message);
                    }
                    finally
                    {
                        cnn.Close();
                    }
                }

                else if (colName == "edit")
                {
                    lbIdcat.Text = dgvcategorie.Rows[e.RowIndex].Cells[0].Value.ToString();
                    TextLibelle.Text = dgvcategorie.Rows[e.RowIndex].Cells[1].Value.ToString();
                    TextDescription.Text = dgvcategorie.Rows[e.RowIndex].Cells[2].Value.ToString();
                    enregristrer.Enabled = true;
                    modifier.Enabled = true;
                    annuler.Enabled = true;

            }

            LoadCategorie();
            }


        public void LoadCategorie()
        {
            dgvcategorie.Rows.Clear();

            // Utilisation de paramètres pour éviter les attaques par injection SQL
            cm = new MySqlCommand("SELECT * FROM categorie WHERE CONCAT(idcategorie, libellecat, description) LIKE @search", cnn);
            cm.Parameters.AddWithValue("@search", "%" + TextSearch.Text + "%");

            if (cnn.State == ConnectionState.Closed)
            {
                cnn.Open();
            }
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                dgvcategorie.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString());

            }
            dr.Close();
            cnn.Close();
            label1.Text = dgvcategorie.RowCount.ToString();

        }
        private void Categorie_Load(object sender, EventArgs e)
        {
            LoadCategorie();
            enregristrer.Enabled = true;
            modifier.Enabled = false;
            annuler.Enabled = true;
        }


        private void annuler_Click(object sender, EventArgs e)
        {
            Vider();
        }

        private void enregristrer_Click(object sender, EventArgs e)
        {
            if (Verif() == false)
            {
                MessageBox.Show("Verifier les champs");
            }
            else if (LibelleExisteDeja(this.TextLibelle.Text))
            {
                MessageBox.Show("Ce Categorie existe déjà dans le tableau");
            }
            else
            {
                // Insérer le libellé car il n'existe pas encore
                string Query = "INSERT INTO categorie (libellecat, description) VALUES (@libellecat, @description)";
                using (MySqlCommand cmd = new MySqlCommand(Query, cnn))
                {
                    cmd.Parameters.AddWithValue("@libellecat", this.TextLibelle.Text);
                    cmd.Parameters.AddWithValue("@description", this.TextDescription.Text);

                    try
                    {
                        cnn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Enregistrement avec succès !");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur" + ex.Message);
                    }
                    finally
                    {
                        cnn.Close();
                    }
                    LoadCategorie();
                    Vider();
                }
            }
        }

        private void modifier_Click_1(object sender, EventArgs e)
        {
            cnn.Open();
            string idupdate = lbIdcat.Text;
            if (MessageBox.Show("Voulez-vous modifier cette Categorie?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cm = new MySqlCommand("UPDATE categorie SET libellecat = @libellecat, description=@description where idcategorie=@idupdate", cnn);
                cm.Parameters.AddWithValue("@libellecat", TextLibelle.Text);
                cm.Parameters.AddWithValue("@description", TextDescription.Text);
                cm.Parameters.AddWithValue("@idupdate", idupdate); // Ajout de ce paramètre manquant
                cm.ExecuteNonQuery();           
                Vider();
                cnn.Close();
                LoadCategorie();
        }
        }

        private void TextSearch_TextChanged(object sender, EventArgs e)
        {
            LoadCategorie();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}