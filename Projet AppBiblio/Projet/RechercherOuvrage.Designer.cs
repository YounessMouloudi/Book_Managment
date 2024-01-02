
namespace Projet
{
    partial class RechercherOuvrage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RechercherOuvrage));
            this.label3 = new System.Windows.Forms.Label();
            this.textAnnée = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboAuteur = new System.Windows.Forms.ComboBox();
            this.comboTypes = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnRechercheDate = new System.Windows.Forms.Button();
            this.BtnRechercher = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textTitre = new System.Windows.Forms.TextBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.RetourBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGreen;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(23, 302);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(3);
            this.label3.Size = new System.Drawing.Size(128, 24);
            this.label3.TabIndex = 76;
            this.label3.Text = "Année d\'édition";
            // 
            // textAnnée
            // 
            this.textAnnée.BackColor = System.Drawing.SystemColors.Window;
            this.textAnnée.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAnnée.ForeColor = System.Drawing.Color.Black;
            this.textAnnée.Location = new System.Drawing.Point(178, 302);
            this.textAnnée.MaxLength = 4;
            this.textAnnée.Multiline = true;
            this.textAnnée.Name = "textAnnée";
            this.textAnnée.Size = new System.Drawing.Size(179, 27);
            this.textAnnée.TabIndex = 68;
            this.textAnnée.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textAnnée_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumSpringGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 40;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumSpringGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(378, 88);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumSpringGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 30;
            this.dataGridView1.Size = new System.Drawing.Size(603, 315);
            this.dataGridView1.TabIndex = 74;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // comboAuteur
            // 
            this.comboAuteur.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboAuteur.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboAuteur.BackColor = System.Drawing.SystemColors.Window;
            this.comboAuteur.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboAuteur.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboAuteur.ForeColor = System.Drawing.Color.Black;
            this.comboAuteur.FormattingEnabled = true;
            this.comboAuteur.IntegralHeight = false;
            this.comboAuteur.Location = new System.Drawing.Point(178, 158);
            this.comboAuteur.Name = "comboAuteur";
            this.comboAuteur.Size = new System.Drawing.Size(179, 27);
            this.comboAuteur.TabIndex = 66;
            this.comboAuteur.SelectedIndexChanged += new System.EventHandler(this.comboAuteur_SelectedIndexChanged);
            // 
            // comboTypes
            // 
            this.comboTypes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboTypes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboTypes.BackColor = System.Drawing.SystemColors.Window;
            this.comboTypes.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboTypes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTypes.ForeColor = System.Drawing.Color.Black;
            this.comboTypes.FormattingEnabled = true;
            this.comboTypes.IntegralHeight = false;
            this.comboTypes.Location = new System.Drawing.Point(178, 225);
            this.comboTypes.Name = "comboTypes";
            this.comboTypes.Size = new System.Drawing.Size(179, 27);
            this.comboTypes.TabIndex = 67;
            this.comboTypes.SelectedIndexChanged += new System.EventHandler(this.comboTypes_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightGreen;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(23, 225);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(3);
            this.label6.Size = new System.Drawing.Size(128, 24);
            this.label6.TabIndex = 71;
            this.label6.Text = "Type d\'ouvrage";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Goldenrod;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(324, 21);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(5);
            this.label5.Size = new System.Drawing.Size(173, 28);
            this.label5.TabIndex = 70;
            this.label5.Text = "Rechercher Ouvrage";
            // 
            // BtnRechercheDate
            // 
            this.BtnRechercheDate.BackColor = System.Drawing.Color.Goldenrod;
            this.BtnRechercheDate.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.BtnRechercheDate.FlatAppearance.BorderSize = 0;
            this.BtnRechercheDate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod;
            this.BtnRechercheDate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.BtnRechercheDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRechercheDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRechercheDate.ForeColor = System.Drawing.Color.Black;
            this.BtnRechercheDate.Location = new System.Drawing.Point(193, 372);
            this.BtnRechercheDate.Name = "BtnRechercheDate";
            this.BtnRechercheDate.Size = new System.Drawing.Size(164, 32);
            this.BtnRechercheDate.TabIndex = 70;
            this.BtnRechercheDate.Text = "Rechercher Par Date";
            this.BtnRechercheDate.UseVisualStyleBackColor = false;
            this.BtnRechercheDate.Click += new System.EventHandler(this.BtnRechercheDate_Click);
            // 
            // BtnRechercher
            // 
            this.BtnRechercher.BackColor = System.Drawing.Color.Goldenrod;
            this.BtnRechercher.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.BtnRechercher.FlatAppearance.BorderSize = 0;
            this.BtnRechercher.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod;
            this.BtnRechercher.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.BtnRechercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRechercher.ForeColor = System.Drawing.Color.Black;
            this.BtnRechercher.Location = new System.Drawing.Point(26, 372);
            this.BtnRechercher.Name = "BtnRechercher";
            this.BtnRechercher.Size = new System.Drawing.Size(134, 32);
            this.BtnRechercher.TabIndex = 69;
            this.BtnRechercher.Text = "         Rechercher";
            this.BtnRechercher.UseVisualStyleBackColor = false;
            this.BtnRechercher.Click += new System.EventHandler(this.BtnRechercher_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGreen;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(23, 158);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(3);
            this.label2.Size = new System.Drawing.Size(74, 24);
            this.label2.TabIndex = 67;
            this.label2.Text = "L\'auteur";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGreen;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(23, 88);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(3);
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 66;
            this.label1.Text = "le Titre";
            // 
            // textTitre
            // 
            this.textTitre.BackColor = System.Drawing.SystemColors.Window;
            this.textTitre.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTitre.ForeColor = System.Drawing.Color.Black;
            this.textTitre.Location = new System.Drawing.Point(178, 88);
            this.textTitre.Multiline = true;
            this.textTitre.Name = "textTitre";
            this.textTitre.Size = new System.Drawing.Size(179, 27);
            this.textTitre.TabIndex = 65;
            this.textTitre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textTitre_KeyPress);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.Goldenrod;
            this.btnAnnuler.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.btnAnnuler.FlatAppearance.BorderSize = 0;
            this.btnAnnuler.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod;
            this.btnAnnuler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.ForeColor = System.Drawing.Color.Black;
            this.btnAnnuler.Location = new System.Drawing.Point(111, 421);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(125, 32);
            this.btnAnnuler.TabIndex = 71;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // RetourBtn
            // 
            this.RetourBtn.BackColor = System.Drawing.Color.Transparent;
            this.RetourBtn.BackgroundImage = global::Projet.Properties.Resources.Retour;
            this.RetourBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RetourBtn.FlatAppearance.BorderColor = System.Drawing.Color.SandyBrown;
            this.RetourBtn.FlatAppearance.BorderSize = 0;
            this.RetourBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.RetourBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.RetourBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RetourBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RetourBtn.ForeColor = System.Drawing.Color.Black;
            this.RetourBtn.Location = new System.Drawing.Point(0, 21);
            this.RetourBtn.Name = "RetourBtn";
            this.RetourBtn.Size = new System.Drawing.Size(66, 38);
            this.RetourBtn.TabIndex = 72;
            this.RetourBtn.UseVisualStyleBackColor = false;
            this.RetourBtn.Click += new System.EventHandler(this.RetourBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Goldenrod;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::Projet.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(26, 372);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 77;
            this.pictureBox1.TabStop = false;
            // 
            // RechercherOuvrage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::Projet.Properties.Resources.Recherche;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(993, 467);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.RetourBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textAnnée);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboAuteur);
            this.Controls.Add(this.comboTypes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnRechercheDate);
            this.Controls.Add(this.BtnRechercher);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textTitre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RechercherOuvrage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rechercher";
            this.Load += new System.EventHandler(this.RechercherOuvrage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RetourBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textAnnée;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboAuteur;
        private System.Windows.Forms.ComboBox comboTypes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnRechercheDate;
        private System.Windows.Forms.Button BtnRechercher;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textTitre;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}