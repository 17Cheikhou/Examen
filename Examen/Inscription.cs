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
    public partial class Inscription : Form
    {
        string connetionString;
        MySqlConnection cnn;
        private MySqlCommand cm;
        MySqlDataReader dr;

        bool Verif()
        {
            if (Prenom.Text == "" || Nom.Text == "" || Password.Text == "" || Email.Text == ""
             )
            {
                return false;
            }
            else
            {
                return true;

            }

        }
       

        public Inscription()
        {
            InitializeComponent();
            string connetionString = "server=localhost;database=db_gestion_entreprise;uid=root;pwd=\"\";";
            cnn = new MySqlConnection(connetionString);
        }

        private bool EmailExisteDeja(string email)
        {
            string Query = "SELECT COUNT(*) FROM user WHERE login = @login";
            using (MySqlCommand cmd = new MySqlCommand(Query, cnn))
            {
                cmd.Parameters.AddWithValue("@login", email);
                cnn.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                cnn.Close();
                return count > 0;
            }
        }

        private void enregristrer_Click(object sender, EventArgs e)
        {
          
            if (Verif() == false)
            {
                MessageBox.Show("Verifier les champs");
            }
            else if (EmailExisteDeja(this.Email.Text))
            {
                MessageBox.Show("Ce Email existe déjà dans le tableau");
            }
            else
            {
                // Insérer le libellé car il n'existe pas encore
                string Query = "INSERT INTO user (prenom, nom,login,password) VALUES (@prenom, @nom,@login,@password)";
                using (MySqlCommand cmd = new MySqlCommand(Query, cnn))
                {
                    cmd.Parameters.AddWithValue("@prenom", this.Prenom.Text);
                    cmd.Parameters.AddWithValue("@nom", this.Nom.Text);
                    cmd.Parameters.AddWithValue("@login", this.Email.Text);
                    cmd.Parameters.AddWithValue("@password", this.Password.Text);


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
                    Form1 f = new Form1();
                    f.Show();
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
