using Examen;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
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
    public partial class Client : UserControl
    {
        string connetionString;
        MySqlConnection cnn;
        private MySqlCommand cm;
        private Timer autoRefreshTimer;

        bool Verif()
        {
            if (TextPrenom.Text == "" || TextNom.Text == "" || TextAdresse.Text == "" || TextTel.Text == "" || TextSexe.Text == ""
             )
            {
                return false;
            }
            else
            {
                return true;

            }
        }
        public void Vider()
        {
            TextPrenom.Text = ""; TextNom.Text = ""; TextAdresse.Text = ""; TextTel.Text = ""; TextSexe.Text = "";
        }
        private void guna2DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            idverif.Text = dgvClient.Rows[e.RowIndex].Cells[0].Value.ToString();
            TextPrenom.Text = dgvClient.Rows[e.RowIndex].Cells[1].Value.ToString();
            TextNom.Text = dgvClient.Rows[e.RowIndex].Cells[2].Value.ToString();
            TextAdresse.Text = dgvClient.Rows[e.RowIndex].Cells[3].Value.ToString();
            TextTel.Text = dgvClient.Rows[e.RowIndex].Cells[4].Value.ToString();



        }
        private void loadClient()
        {
            string connetionString = "server=localhost;database=db_gestion_entreprise;uid=root;pwd=\"\";";
            cnn = new MySqlConnection(connetionString);

            string query = "SELECT * FROM client";
            MySqlCommand cm = new MySqlCommand(query, cnn);
            MySqlDataAdapter da = new MySqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvClient.DataSource = dt;

        }
        public Client()
        {
            InitializeComponent();
            dgvClient.CellContentClick += new DataGridViewCellEventHandler(guna2DataGridView1_CellContentClick_1);

          
        }
        private void enregristrer_Click(object sender, EventArgs e)
        {
            connetionString = "server=localhost;database=db_gestion_entreprise;uid=root;pwd=\"\";";
            cnn = new MySqlConnection(connetionString);
            int N = TextAdresse.Text.Length;
            string matricule = "000"+ this.TextPrenom.Text.Substring(0, 1) + this.TextAdresse.Text.Substring(N-1);

            string Query = "INSERT INTO client(matricule, prenom, nom, tel,adresse ,sexe) VALUES (@matricule, @prenom, @nom, @tel,@adresse,@sexe)";

            if (Verif())
            {
                using (MySqlCommand cmd = new MySqlCommand(Query, cnn))
                {
                    cmd.Parameters.AddWithValue("@matricule", matricule);
                    cmd.Parameters.AddWithValue("@prenom", this.TextPrenom.Text);
                    cmd.Parameters.AddWithValue("@nom", TextNom.Text);
                    cmd.Parameters.AddWithValue("@tel", this.TextTel.Text);
                    cmd.Parameters.AddWithValue("@adresse", this.TextAdresse.Text);
                    cmd.Parameters.AddWithValue("@sexe", this.TextSexe.Text);




                    try
                    {
                        cnn.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Enregistrement avec succès !");
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
                    loadClient();
                    Vider();


                }
            }
            else
            {
                MessageBox.Show("Verifier les champs ");
            }
        }

        private void Client_Load(object sender, EventArgs e)
        {
            loadClient();
        }



        private void dgvClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idverif.Text = dgvClient.Rows[e.RowIndex].Cells[0].Value.ToString();
            TextPrenom.Text = dgvClient.Rows[e.RowIndex].Cells[2].Value.ToString();
            TextNom.Text = dgvClient.Rows[e.RowIndex].Cells[3].Value.ToString();
            TextTel.Text = dgvClient.Rows[e.RowIndex].Cells[4].Value.ToString();
            TextAdresse.Text = dgvClient.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void update_Click(object sender, EventArgs e)
        {
            int N = TextAdresse.Text.Length;
            string matricule = "000" + this.TextPrenom.Text.Substring(0, 1) + this.TextAdresse.Text.Substring(N - 1);
            String idupdateC = idverif.Text;
            if (MessageBox.Show("Voulez-vous modifier ce Client?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cnn.Open();

                cm = new MySqlCommand("UPDATE client SET prenom = @prenom, nom = @nom, tel = @tel, adresse = @adresse, sexe = @sexe, matricule = @matricule where id = @idupdateC", cnn);

                cm.Parameters.AddWithValue("@matricule", matricule);
                cm.Parameters.AddWithValue("@prenom", this.TextPrenom.Text);
                cm.Parameters.AddWithValue("@nom", TextNom.Text);
                cm.Parameters.AddWithValue("@tel", this.TextTel.Text);
                cm.Parameters.AddWithValue("@adresse", this.TextAdresse.Text);
                cm.Parameters.AddWithValue("@sexe", this.TextSexe.Text);
                cm.Parameters.AddWithValue("@idupdateC", idupdateC);

                cm.ExecuteNonQuery();
                Vider();
                cnn.Close();
                loadClient();
            }
        }

        private void delete_Click_1(object sender, EventArgs e)
        {
            {
                int ligne = dgvClient.SelectedRows[0].Index;
                string idsup = dgvClient.Rows[ligne].Cells["id"].Value.ToString(); // on remplace "id" par le nom de la colonne contenant l'identifiant de l'enregistrement dans la bd
                if (MessageBox.Show("Voulez-vous vraiment suprimer ce client?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string query = "DELETE FROM client WHERE id = @idsup";
                    using (MySqlCommand cmd = new MySqlCommand(query, cnn))
                    {
                        cmd.Parameters.AddWithValue("@idsup", idsup);

                        try
                        {
                            cnn.Open();
                            cmd.ExecuteNonQuery();
                            loadClient();
                            Vider();


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
        }

        private void clear_Click_1(object sender, EventArgs e)
        {
            Vider();

        }
    }
}


