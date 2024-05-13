namespace Examen
{
    partial class Client
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvClient = new System.Windows.Forms.DataGridView();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.clear = new Guna.UI2.WinForms.Guna2Button();
            this.update = new Guna.UI2.WinForms.Guna2Button();
            this.delete = new Guna.UI2.WinForms.Guna2Button();
            this.enregristrer = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel10 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.idverif = new System.Windows.Forms.Label();
            this.TextAdresse = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextTel = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextSexe = new Guna.UI2.WinForms.Guna2ComboBox();
            this.TextPrenom = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextNom = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dgvClient);
            this.panel1.Location = new System.Drawing.Point(14, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(748, 221);
            this.panel1.TabIndex = 1;
            // 
            // dgvClient
            // 
            this.dgvClient.AllowUserToAddRows = false;
            this.dgvClient.AllowUserToDeleteRows = false;
            this.dgvClient.BackgroundColor = System.Drawing.Color.White;
            this.dgvClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClient.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(17)))), ((int)(((byte)(37)))));
            this.dgvClient.Location = new System.Drawing.Point(0, 0);
            this.dgvClient.Name = "dgvClient";
            this.dgvClient.ReadOnly = true;
            this.dgvClient.RowHeadersWidth = 40;
            this.dgvClient.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgvClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClient.Size = new System.Drawing.Size(748, 221);
            this.dgvClient.TabIndex = 0;
            this.dgvClient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClient_CellClick);
            this.dgvClient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick_1);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 46;
            this.guna2Elipse1.TargetControl = this.panel2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(17)))), ((int)(((byte)(37)))));
            this.panel2.Controls.Add(this.clear);
            this.panel2.Controls.Add(this.update);
            this.panel2.Controls.Add(this.delete);
            this.panel2.Controls.Add(this.enregristrer);
            this.panel2.Controls.Add(this.guna2HtmlLabel10);
            this.panel2.Controls.Add(this.guna2HtmlLabel9);
            this.panel2.Controls.Add(this.guna2HtmlLabel8);
            this.panel2.Controls.Add(this.guna2HtmlLabel7);
            this.panel2.Controls.Add(this.guna2HtmlLabel3);
            this.panel2.Controls.Add(this.idverif);
            this.panel2.Controls.Add(this.TextAdresse);
            this.panel2.Controls.Add(this.TextTel);
            this.panel2.Controls.Add(this.TextSexe);
            this.panel2.Controls.Add(this.TextPrenom);
            this.panel2.Controls.Add(this.TextNom);
            this.panel2.Location = new System.Drawing.Point(14, 272);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(748, 175);
            this.panel2.TabIndex = 2;
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.Transparent;
            this.clear.BorderColor = System.Drawing.Color.White;
            this.clear.BorderRadius = 10;
            this.clear.BorderThickness = 2;
            this.clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.clear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.clear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.clear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.clear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(170)))), ((int)(((byte)(231)))));
            this.clear.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(17)))), ((int)(((byte)(37)))));
            this.clear.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.ForeColor = System.Drawing.Color.White;
            this.clear.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(170)))), ((int)(((byte)(231)))));
            this.clear.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(26)))), ((int)(((byte)(55)))));
            this.clear.HoverState.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.clear.HoverState.ForeColor = System.Drawing.Color.White;
            this.clear.Location = new System.Drawing.Point(647, 130);
            this.clear.Name = "clear";
            this.clear.PressedColor = System.Drawing.Color.AliceBlue;
            this.clear.Size = new System.Drawing.Size(75, 38);
            this.clear.TabIndex = 87;
            this.clear.Text = "Clear";
            this.clear.Click += new System.EventHandler(this.clear_Click_1);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.Transparent;
            this.update.BorderColor = System.Drawing.Color.White;
            this.update.BorderRadius = 10;
            this.update.BorderThickness = 2;
            this.update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.update.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.update.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.update.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.update.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(170)))), ((int)(((byte)(231)))));
            this.update.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(17)))), ((int)(((byte)(37)))));
            this.update.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.Color.White;
            this.update.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(170)))), ((int)(((byte)(231)))));
            this.update.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(26)))), ((int)(((byte)(55)))));
            this.update.HoverState.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.update.HoverState.ForeColor = System.Drawing.Color.White;
            this.update.Location = new System.Drawing.Point(543, 128);
            this.update.Name = "update";
            this.update.PressedColor = System.Drawing.Color.AliceBlue;
            this.update.Size = new System.Drawing.Size(75, 38);
            this.update.TabIndex = 86;
            this.update.Text = "Update";
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Transparent;
            this.delete.BorderColor = System.Drawing.Color.White;
            this.delete.BorderRadius = 10;
            this.delete.BorderThickness = 2;
            this.delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.delete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(170)))), ((int)(((byte)(231)))));
            this.delete.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(17)))), ((int)(((byte)(37)))));
            this.delete.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.Color.White;
            this.delete.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(170)))), ((int)(((byte)(231)))));
            this.delete.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(26)))), ((int)(((byte)(55)))));
            this.delete.HoverState.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.HoverState.ForeColor = System.Drawing.Color.White;
            this.delete.Location = new System.Drawing.Point(451, 128);
            this.delete.Name = "delete";
            this.delete.PressedColor = System.Drawing.Color.AliceBlue;
            this.delete.Size = new System.Drawing.Size(75, 38);
            this.delete.TabIndex = 85;
            this.delete.Text = "Delete";
            this.delete.Click += new System.EventHandler(this.delete_Click_1);
            // 
            // enregristrer
            // 
            this.enregristrer.BackColor = System.Drawing.Color.Transparent;
            this.enregristrer.BorderColor = System.Drawing.Color.White;
            this.enregristrer.BorderRadius = 10;
            this.enregristrer.BorderThickness = 2;
            this.enregristrer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enregristrer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.enregristrer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.enregristrer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.enregristrer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.enregristrer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(170)))), ((int)(((byte)(231)))));
            this.enregristrer.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(17)))), ((int)(((byte)(37)))));
            this.enregristrer.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enregristrer.ForeColor = System.Drawing.Color.White;
            this.enregristrer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(170)))), ((int)(((byte)(231)))));
            this.enregristrer.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(26)))), ((int)(((byte)(55)))));
            this.enregristrer.HoverState.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enregristrer.HoverState.ForeColor = System.Drawing.Color.White;
            this.enregristrer.Location = new System.Drawing.Point(359, 128);
            this.enregristrer.Name = "enregristrer";
            this.enregristrer.PressedColor = System.Drawing.Color.AliceBlue;
            this.enregristrer.Size = new System.Drawing.Size(75, 38);
            this.enregristrer.TabIndex = 84;
            this.enregristrer.Text = "Add";
            this.enregristrer.Click += new System.EventHandler(this.enregristrer_Click);
            // 
            // guna2HtmlLabel10
            // 
            this.guna2HtmlLabel10.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel10.Font = new System.Drawing.Font("Cooper Black", 13F);
            this.guna2HtmlLabel10.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel10.Location = new System.Drawing.Point(21, 130);
            this.guna2HtmlLabel10.Name = "guna2HtmlLabel10";
            this.guna2HtmlLabel10.Size = new System.Drawing.Size(80, 22);
            this.guna2HtmlLabel10.TabIndex = 83;
            this.guna2HtmlLabel10.Text = "Adresse :";
            // 
            // guna2HtmlLabel9
            // 
            this.guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel9.Font = new System.Drawing.Font("Cooper Black", 13F);
            this.guna2HtmlLabel9.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel9.Location = new System.Drawing.Point(21, 76);
            this.guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            this.guna2HtmlLabel9.Size = new System.Drawing.Size(39, 22);
            this.guna2HtmlLabel9.TabIndex = 82;
            this.guna2HtmlLabel9.Text = "Tel :";
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Cooper Black", 13F);
            this.guna2HtmlLabel8.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(21, 23);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(51, 22);
            this.guna2HtmlLabel8.TabIndex = 81;
            this.guna2HtmlLabel8.Text = "Sexe :";
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Cooper Black", 13F);
            this.guna2HtmlLabel7.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(341, 23);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(79, 22);
            this.guna2HtmlLabel7.TabIndex = 80;
            this.guna2HtmlLabel7.Text = "Prenom :";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Cooper Black", 13F);
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(334, 76);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(52, 22);
            this.guna2HtmlLabel3.TabIndex = 79;
            this.guna2HtmlLabel3.Text = "Nom :";
            // 
            // idverif
            // 
            this.idverif.AutoSize = true;
            this.idverif.Location = new System.Drawing.Point(18, 74);
            this.idverif.Name = "idverif";
            this.idverif.Size = new System.Drawing.Size(0, 13);
            this.idverif.TabIndex = 78;
            // 
            // TextAdresse
            // 
            this.TextAdresse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(17)))), ((int)(((byte)(37)))));
            this.TextAdresse.BorderColor = System.Drawing.Color.White;
            this.TextAdresse.BorderRadius = 20;
            this.TextAdresse.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.TextAdresse.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextAdresse.DefaultText = "";
            this.TextAdresse.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextAdresse.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextAdresse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextAdresse.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextAdresse.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextAdresse.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextAdresse.ForeColor = System.Drawing.Color.Black;
            this.TextAdresse.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextAdresse.Location = new System.Drawing.Point(107, 130);
            this.TextAdresse.Name = "TextAdresse";
            this.TextAdresse.PasswordChar = '\0';
            this.TextAdresse.PlaceholderForeColor = System.Drawing.Color.White;
            this.TextAdresse.PlaceholderText = "";
            this.TextAdresse.SelectedText = "";
            this.TextAdresse.Size = new System.Drawing.Size(192, 36);
            this.TextAdresse.TabIndex = 76;
            // 
            // TextTel
            // 
            this.TextTel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(17)))), ((int)(((byte)(37)))));
            this.TextTel.BorderColor = System.Drawing.Color.White;
            this.TextTel.BorderRadius = 20;
            this.TextTel.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.TextTel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextTel.DefaultText = "";
            this.TextTel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextTel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextTel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextTel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextTel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextTel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextTel.ForeColor = System.Drawing.Color.Black;
            this.TextTel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextTel.Location = new System.Drawing.Point(107, 67);
            this.TextTel.Name = "TextTel";
            this.TextTel.PasswordChar = '\0';
            this.TextTel.PlaceholderForeColor = System.Drawing.Color.White;
            this.TextTel.PlaceholderText = "ee";
            this.TextTel.SelectedText = "";
            this.TextTel.Size = new System.Drawing.Size(192, 36);
            this.TextTel.TabIndex = 75;
            // 
            // TextSexe
            // 
            this.TextSexe.AutoRoundedCorners = true;
            this.TextSexe.BackColor = System.Drawing.Color.Transparent;
            this.TextSexe.BorderRadius = 17;
            this.TextSexe.BorderThickness = 0;
            this.TextSexe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.TextSexe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TextSexe.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextSexe.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextSexe.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TextSexe.ForeColor = System.Drawing.Color.Black;
            this.TextSexe.ItemHeight = 30;
            this.TextSexe.Items.AddRange(new object[] {
            "Homme",
            "Femme"});
            this.TextSexe.Location = new System.Drawing.Point(107, 9);
            this.TextSexe.Name = "TextSexe";
            this.TextSexe.Size = new System.Drawing.Size(192, 36);
            this.TextSexe.TabIndex = 71;
            // 
            // TextPrenom
            // 
            this.TextPrenom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(17)))), ((int)(((byte)(37)))));
            this.TextPrenom.BorderColor = System.Drawing.Color.White;
            this.TextPrenom.BorderRadius = 20;
            this.TextPrenom.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.TextPrenom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextPrenom.DefaultText = "";
            this.TextPrenom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextPrenom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextPrenom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextPrenom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextPrenom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextPrenom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextPrenom.ForeColor = System.Drawing.Color.Black;
            this.TextPrenom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextPrenom.Location = new System.Drawing.Point(449, 10);
            this.TextPrenom.Name = "TextPrenom";
            this.TextPrenom.PasswordChar = '\0';
            this.TextPrenom.PlaceholderForeColor = System.Drawing.Color.White;
            this.TextPrenom.PlaceholderText = "ee";
            this.TextPrenom.SelectedText = "";
            this.TextPrenom.Size = new System.Drawing.Size(192, 36);
            this.TextPrenom.TabIndex = 70;
            // 
            // TextNom
            // 
            this.TextNom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(17)))), ((int)(((byte)(37)))));
            this.TextNom.BorderColor = System.Drawing.Color.White;
            this.TextNom.BorderRadius = 20;
            this.TextNom.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.TextNom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextNom.DefaultText = "";
            this.TextNom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextNom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextNom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextNom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextNom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextNom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextNom.ForeColor = System.Drawing.Color.Black;
            this.TextNom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextNom.Location = new System.Drawing.Point(449, 74);
            this.TextNom.Name = "TextNom";
            this.TextNom.PasswordChar = '\0';
            this.TextNom.PlaceholderForeColor = System.Drawing.Color.White;
            this.TextNom.PlaceholderText = "ee";
            this.TextNom.SelectedText = "";
            this.TextNom.Size = new System.Drawing.Size(192, 36);
            this.TextNom.TabIndex = 69;
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Cooper Black", 13F);
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(428, 71);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(52, 22);
            this.guna2HtmlLabel6.TabIndex = 54;
            this.guna2HtmlLabel6.Text = "Nom :";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Cooper Black", 13F);
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(428, 17);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(79, 22);
            this.guna2HtmlLabel2.TabIndex = 56;
            this.guna2HtmlLabel2.Text = "Prenom :";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Cooper Black", 13F);
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(95, 17);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(51, 22);
            this.guna2HtmlLabel4.TabIndex = 59;
            this.guna2HtmlLabel4.Text = "Sexe :";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.AutoSize = false;
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Cooper Black", 13F);
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(95, 67);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(110, 25);
            this.guna2HtmlLabel5.TabIndex = 60;
            this.guna2HtmlLabel5.Text = "Tel :";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Cooper Black", 13F);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(95, 130);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(110, 25);
            this.guna2HtmlLabel1.TabIndex = 65;
            this.guna2HtmlLabel1.Text = "Adresse";
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(26)))), ((int)(((byte)(55)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Client";
            this.Size = new System.Drawing.Size(778, 450);
            this.Load += new System.EventHandler(this.Client_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvClient;
        private Guna.UI2.WinForms.Guna2HtmlLabel idclientverif;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2TextBox TextAdresse;
        private Guna.UI2.WinForms.Guna2TextBox TextTel;
        private Guna.UI2.WinForms.Guna2ComboBox TextSexe;
        private Guna.UI2.WinForms.Guna2TextBox TextPrenom;
        private Guna.UI2.WinForms.Guna2TextBox TextNom;
        private System.Windows.Forms.Label idverif;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel10;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2Button update;
        private Guna.UI2.WinForms.Guna2Button delete;
        private Guna.UI2.WinForms.Guna2Button enregristrer;
        private Guna.UI2.WinForms.Guna2Button clear;
    }
}
