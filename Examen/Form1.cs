using MySql.Data.MySqlClient;
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
using System.Xml.Linq;

namespace Examen
{
    public partial class Form1 : Form
    {
        string connetionString;
        MySqlConnection cnn;
        private MySqlCommand cm;
        private Timer autoRefreshTimer;
        MySqlDataReader dr;

        bool Verif()
        {
            if (textUsername.Text == "" || password.Text == ""
             )
            {
                return false;
            }
            else
            {
                return true;

            }
        }
            public Form1()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;database=db_gestion_entreprise;uid=root;pwd=\"\";";
            MySqlConnection cnn = new MySqlConnection(connectionString);
            try
            {
                MySqlCommand cm = new MySqlCommand("SELECT * FROM user WHERE login=@username AND password=@password", cnn);
                cm.Parameters.AddWithValue("@username", textUsername.Text);
                cm.Parameters.AddWithValue("@password", password.Text);
                cnn.Open();
                MySqlDataReader dr = cm.ExecuteReader();

                if (dr.Read())
                {
                    Dasbh d = new Dasbh();
                    this.Hide();
                    d.Show();
                }
                else
                {
                    MessageBox.Show("Invalid username or password!", "ACCESS DENIED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void guna2RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (hiddenpass.Checked == false)
              {
                  password.UseSystemPasswordChar = true;

              }
              else
              {
                  password.UseSystemPasswordChar = false;
              }


        }

        private void inscription_Click(object sender, EventArgs e)
        {
            Inscription inscription = new Inscription();
            inscription.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
