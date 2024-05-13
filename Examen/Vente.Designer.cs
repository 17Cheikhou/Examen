namespace Examen
{
    partial class Vente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vente));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ListProduct = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.deconnexion = new System.Windows.Forms.PictureBox();
            this.dgvVente = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TextSearch = new System.Windows.Forms.TextBox();
            this.dgvClient = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbIdVente = new System.Windows.Forms.Label();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.totauxPu = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Qttotal = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.deconnexion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).BeginInit();
            this.SuspendLayout();
            // 
            // ListProduct
            // 
            this.ListProduct.AutoRoundedCorners = true;
            this.ListProduct.BackColor = System.Drawing.Color.Transparent;
            this.ListProduct.BorderRadius = 17;
            this.ListProduct.BorderThickness = 0;
            this.ListProduct.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ListProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ListProduct.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ListProduct.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ListProduct.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ListProduct.ForeColor = System.Drawing.Color.Black;
            this.ListProduct.ItemHeight = 30;
            this.ListProduct.Location = new System.Drawing.Point(108, 3);
            this.ListProduct.Name = "ListProduct";
            this.ListProduct.Size = new System.Drawing.Size(116, 36);
            this.ListProduct.TabIndex = 24;
            this.ListProduct.SelectedIndexChanged += new System.EventHandler(this.ListProduct_SelectedIndexChanged);
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Cooper Black", 13F);
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(12, 8);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(88, 22);
            this.guna2HtmlLabel6.TabIndex = 26;
            this.guna2HtmlLabel6.Text = "Produits :";
            // 
            // deconnexion
            // 
            this.deconnexion.Image = ((System.Drawing.Image)(resources.GetObject("deconnexion.Image")));
            this.deconnexion.Location = new System.Drawing.Point(237, 6);
            this.deconnexion.Name = "deconnexion";
            this.deconnexion.Size = new System.Drawing.Size(39, 31);
            this.deconnexion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.deconnexion.TabIndex = 40;
            this.deconnexion.TabStop = false;
            this.deconnexion.Click += new System.EventHandler(this.deconnexion_Click);
            // 
            // dgvVente
            // 
            this.dgvVente.AllowUserToAddRows = false;
            this.dgvVente.AllowUserToDeleteRows = false;
            this.dgvVente.BackgroundColor = System.Drawing.Color.White;
            this.dgvVente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(26)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column11,
            this.Column2,
            this.Column3,
            this.Column4,
            this.delete});
            this.dgvVente.Location = new System.Drawing.Point(282, 6);
            this.dgvVente.Name = "dgvVente";
            this.dgvVente.ReadOnly = true;
            this.dgvVente.Size = new System.Drawing.Size(484, 201);
            this.dgvVente.TabIndex = 41;
            this.dgvVente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVente_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.HeaderText = "Id";
            this.Column1.MinimumWidth = 50;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Lib";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Qte";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 40;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "P.U";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Total";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 70;
            // 
            // delete
            // 
            this.delete.HeaderText = "";
            this.delete.Image = ((System.Drawing.Image)(resources.GetObject("delete.Image")));
            this.delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Width = 30;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Cooper Black", 13F);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(12, 239);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(72, 22);
            this.guna2HtmlLabel1.TabIndex = 42;
            this.guna2HtmlLabel1.Text = "Clients :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(212, 233);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // TextSearch
            // 
            this.TextSearch.Location = new System.Drawing.Point(108, 233);
            this.TextSearch.Multiline = true;
            this.TextSearch.Name = "TextSearch";
            this.TextSearch.Size = new System.Drawing.Size(128, 28);
            this.TextSearch.TabIndex = 43;
            this.TextSearch.MouseLeave += new System.EventHandler(this.TextSearch_MouseLeave);
            // 
            // dgvClient
            // 
            this.dgvClient.AllowUserToAddRows = false;
            this.dgvClient.AllowUserToDeleteRows = false;
            this.dgvClient.BackgroundColor = System.Drawing.Color.White;
            this.dgvClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(26)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dgvClient.Location = new System.Drawing.Point(282, 233);
            this.dgvClient.Name = "dgvClient";
            this.dgvClient.ReadOnly = true;
            this.dgvClient.Size = new System.Drawing.Size(484, 201);
            this.dgvClient.TabIndex = 45;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Id";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 50;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Prenom";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Nom";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Telephone";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Adresse";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // lbIdVente
            // 
            this.lbIdVente.AutoSize = true;
            this.lbIdVente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbIdVente.Location = new System.Drawing.Point(220, 121);
            this.lbIdVente.Name = "lbIdVente";
            this.lbIdVente.Size = new System.Drawing.Size(0, 13);
            this.lbIdVente.TabIndex = 46;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Cooper Black", 13F);
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(12, 98);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(99, 22);
            this.guna2HtmlLabel2.TabIndex = 47;
            this.guna2HtmlLabel2.Text = "Prix Total :";
            // 
            // totauxPu
            // 
            this.totauxPu.BackColor = System.Drawing.Color.Transparent;
            this.totauxPu.Font = new System.Drawing.Font("Cooper Black", 13F);
            this.totauxPu.ForeColor = System.Drawing.Color.White;
            this.totauxPu.Location = new System.Drawing.Point(137, 98);
            this.totauxPu.Name = "totauxPu";
            this.totauxPu.Size = new System.Drawing.Size(3, 2);
            this.totauxPu.TabIndex = 48;
            this.totauxPu.Text = null;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Cooper Black", 13F);
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(12, 152);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(139, 22);
            this.guna2HtmlLabel3.TabIndex = 49;
            this.guna2HtmlLabel3.Text = "Quantite Total :";
            // 
            // Qttotal
            // 
            this.Qttotal.BackColor = System.Drawing.Color.Transparent;
            this.Qttotal.Font = new System.Drawing.Font("Cooper Black", 13F);
            this.Qttotal.ForeColor = System.Drawing.Color.White;
            this.Qttotal.Location = new System.Drawing.Point(166, 152);
            this.Qttotal.Name = "Qttotal";
            this.Qttotal.Size = new System.Drawing.Size(3, 2);
            this.Qttotal.TabIndex = 50;
            this.Qttotal.Text = null;
            // 
            // Vente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(26)))), ((int)(((byte)(55)))));
            this.Controls.Add(this.Qttotal);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.totauxPu);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.lbIdVente);
            this.Controls.Add(this.dgvClient);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TextSearch);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.dgvVente);
            this.Controls.Add(this.deconnexion);
            this.Controls.Add(this.guna2HtmlLabel6);
            this.Controls.Add(this.ListProduct);
            this.Name = "Vente";
            this.Size = new System.Drawing.Size(778, 450);
            this.Load += new System.EventHandler(this.Vente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deconnexion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox ListProduct;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private System.Windows.Forms.PictureBox deconnexion;
        private System.Windows.Forms.DataGridView dgvVente;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TextSearch;
        private System.Windows.Forms.DataGridView dgvClient;
        private System.Windows.Forms.Label lbIdVente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewImageColumn delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel totauxPu;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel Qttotal;
    }
}
