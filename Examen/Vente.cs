using MySql.Data.MySqlClient;
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
    public partial class Vente : UserControl
    {
        private MySqlCommand cm;
        private MySqlConnection cnn;
        MySqlDataReader dr;

        private void loadProduit()
        {
            string connetionString = "server=localhost;database=db_gestion_entreprise;uid=root;pwd=\"\";";
            cnn = new MySqlConnection(connetionString);
            string query = "SELECT * FROM produit";
            cm = new MySqlCommand(query, cnn);
            MySqlDataAdapter da = new MySqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (ListProduct != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    CProduit categorie = new CProduit
                    {
                        Idprod = Convert.ToInt32(row["idprod"]),
                        Libelleprod = row["libelleprod"].ToString(),
                        Prix = Convert.ToInt32(row["prix"]),
                        Qte = Convert.ToInt32(row["quantite"]),

                    };
                    ListProduct.Items.Add(categorie);
                }
            }
            else
            {
                MessageBox.Show("Liste du produit est null");
            }
        }
      

        public void LoadVente()
        {
            int total = 0;
            int qt = 0;
            dgvVente.Rows.Clear();

            cm = new MySqlCommand("SELECT id, libelle, nbre_prod, prix_unitaire, total FROM vente ", cnn);

            cnn.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                dgvVente.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());
                total+= Convert.ToInt32(dr[4].ToString());
                qt+= Convert.ToInt32(dr[2].ToString());

            }

            dr.Close();
            cnn.Close();
            totauxPu.Text = total.ToString();
            Qttotal.Text = qt.ToString();

        }


        public Vente()
        {
            InitializeComponent();
            loadProduit();
            dgvClient.Rows.Clear();
            string connetionString = "server=localhost;database=db_gestion_entreprise;uid=root;pwd=\"\";";
            cnn = new MySqlConnection(connetionString);

        }



        private void TextSearch_MouseLeave(object sender, EventArgs e)
        {
            dgvClient.Rows.Clear();
            string tmp = TextSearch.Text;
            cm = new MySqlCommand("SELECT id , prenom, nom , tel, adresse FROM client WHERE (prenom) LIKE @search", cnn);
            cm.Parameters.AddWithValue("@search", "%" + TextSearch.Text + "%");

            cnn.Open();
            dr = cm.ExecuteReader();

            while (dr.Read())
            {
                dgvClient.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());
            }
            if (dgvClient.Rows.Count == 0)
            {
                MessageBox.Show(tmp + " n'existe pas parmi les clients");
            }

            dr.Close();
            cnn.Close();
        }

        private void deconnexion_Click(object sender, EventArgs e)
        {
            CProduit selectProduit = (CProduit)ListProduct.SelectedItem;
            int IdProd = selectProduit.Idprod;
            string libelle = selectProduit.Libelleprod;
            int pu = selectProduit.Prix;
            int Qt = selectProduit.Qte;
           
            int total = Qt * pu;

            string Query = "INSERT INTO vente (libelle, nbre_prod, prix_unitaire, total) VALUES (@libelle, @qte, @prix, @total)";

            using (MySqlCommand cmd = new MySqlCommand(Query, cnn))
            {
                cmd.Parameters.AddWithValue("@qte", Qt);
                cmd.Parameters.AddWithValue("@prix", pu);
                cmd.Parameters.AddWithValue("@libelle", libelle);
                cmd.Parameters.AddWithValue("@total", total);

                try
                {
                    cnn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Enregistrement avec succès ! Total amount: $" + total);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message + "\n" + ex.ToString());
                }
                finally
                {
                    cnn.Close();
                }
            }
            LoadVente();
        }

        private void Vente_Load(object sender, EventArgs e)
        {
            LoadVente();


        }

        private void dgvVente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Voulez-vous suprimer ce produit?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string colName = dgvVente.Columns[e.ColumnIndex].Name;
                if (colName == "delete")
                {
                    lbIdVente.Text = dgvVente.Rows[e.RowIndex].Cells[0].Value.ToString();

                    try
                    {
                        cnn.Open();
                        string idDelete = lbIdVente.Text;
                        cm = new MySqlCommand("DELETE FROM vente WHERE id = @idDelete", cnn);
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
                        MessageBox.Show("Error deleting record: " + ex.Message);
                    }
                    finally
                    {
                        cnn.Close();
                    }
                    LoadVente();
                }
            }
        }

        private void ListProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
