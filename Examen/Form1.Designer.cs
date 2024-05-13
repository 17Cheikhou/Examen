namespace Examen
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.hiddenpass = new Guna.UI2.WinForms.Guna2RadioButton();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.password = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.textUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.inscription = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(370, 421);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // hiddenpass
            // 
            this.hiddenpass.AutoSize = true;
            this.hiddenpass.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.hiddenpass.CheckedState.BorderThickness = 0;
            this.hiddenpass.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.hiddenpass.CheckedState.InnerColor = System.Drawing.Color.White;
            this.hiddenpass.CheckedState.InnerOffset = -4;
            this.hiddenpass.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hiddenpass.Location = new System.Drawing.Point(587, 303);
            this.hiddenpass.Name = "hiddenpass";
            this.hiddenpass.Size = new System.Drawing.Size(103, 17);
            this.hiddenpass.TabIndex = 16;
            this.hiddenpass.Text = "Show Password";
            this.hiddenpass.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.hiddenpass.UncheckedState.BorderThickness = 2;
            this.hiddenpass.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.hiddenpass.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(491, 214);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(82, 22);
            this.guna2HtmlLabel3.TabIndex = 15;
            this.guna2HtmlLabel3.Text = "Password :";
            // 
            // password
            // 
            this.password.BorderRadius = 20;
            this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password.DefaultText = "";
            this.password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.password.Location = new System.Drawing.Point(491, 255);
            this.password.Name = "password";
            this.password.PasswordChar = '●';
            this.password.PlaceholderText = "";
            this.password.SelectedText = "";
            this.password.Size = new System.Drawing.Size(200, 36);
            this.password.TabIndex = 14;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(491, 123);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(86, 22);
            this.guna2HtmlLabel2.TabIndex = 13;
            this.guna2HtmlLabel2.Text = "Username :";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(530, 26);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(161, 28);
            this.guna2HtmlLabel1.TabIndex = 12;
            this.guna2HtmlLabel1.Text = "Register Account";
            // 
            // textUsername
            // 
            this.textUsername.BorderRadius = 20;
            this.textUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textUsername.DefaultText = "";
            this.textUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textUsername.Location = new System.Drawing.Point(491, 164);
            this.textUsername.Name = "textUsername";
            this.textUsername.PasswordChar = '\0';
            this.textUsername.PlaceholderText = "";
            this.textUsername.SelectedText = "";
            this.textUsername.Size = new System.Drawing.Size(200, 36);
            this.textUsername.TabIndex = 11;
            // 
            // guna2Button2
            // 
            this.guna2Button2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.guna2Button2.BorderColor = System.Drawing.Color.SlateBlue;
            this.guna2Button2.BorderRadius = 10;
            this.guna2Button2.BorderThickness = 2;
            this.guna2Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(26)))), ((int)(((byte)(55)))));
            this.guna2Button2.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(17)))), ((int)(((byte)(37)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button2.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(17)))), ((int)(((byte)(37)))));
            this.guna2Button2.Location = new System.Drawing.Point(491, 358);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.PressedColor = System.Drawing.Color.AliceBlue;
            this.guna2Button2.Size = new System.Drawing.Size(160, 45);
            this.guna2Button2.TabIndex = 18;
            this.guna2Button2.Text = "CONNEXION";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // inscription
            // 
            this.inscription.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.inscription.BorderColor = System.Drawing.Color.SlateBlue;
            this.inscription.BorderRadius = 10;
            this.inscription.BorderThickness = 2;
            this.inscription.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inscription.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.inscription.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.inscription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.inscription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.inscription.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(26)))), ((int)(((byte)(55)))));
            this.inscription.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(17)))), ((int)(((byte)(37)))));
            this.inscription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.inscription.ForeColor = System.Drawing.Color.White;
            this.inscription.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.inscription.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(17)))), ((int)(((byte)(37)))));
            this.inscription.Location = new System.Drawing.Point(76, 358);
            this.inscription.Name = "inscription";
            this.inscription.PressedColor = System.Drawing.Color.AliceBlue;
            this.inscription.Size = new System.Drawing.Size(152, 45);
            this.inscription.TabIndex = 20;
            this.inscription.Text = "INSCRIPTION";
            this.inscription.Click += new System.EventHandler(this.inscription_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(734, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(784, 421);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.inscription);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.hiddenpass);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.password);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.textUsername);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2RadioButton hiddenpass;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2TextBox password;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox textUsername;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button inscription;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

