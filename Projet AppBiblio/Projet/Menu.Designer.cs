
namespace Projet
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.listMenu = new System.Windows.Forms.ListBox();
            this.Ajouter_type = new System.Windows.Forms.Button();
            this.Ajouter_Editeur = new System.Windows.Forms.Button();
            this.Ajouter_auteur = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnAfficher = new System.Windows.Forms.Button();
            this.BtnRechercher = new System.Windows.Forms.Button();
            this.BtnSupprimer = new System.Windows.Forms.Button();
            this.BtnAjouter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // listMenu
            // 
            this.listMenu.BackColor = System.Drawing.Color.DodgerBlue;
            this.listMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listMenu.FormattingEnabled = true;
            this.listMenu.ItemHeight = 29;
            this.listMenu.Items.AddRange(new object[] {
            "",
            "",
            "      Bienvenu Dans Votre Bibliothéque",
            "",
            "      Applications de gestion d\'ouvrages",
            "             "});
            this.listMenu.Location = new System.Drawing.Point(146, 125);
            this.listMenu.MultiColumn = true;
            this.listMenu.Name = "listMenu";
            this.listMenu.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listMenu.Size = new System.Drawing.Size(495, 232);
            this.listMenu.TabIndex = 22;
            // 
            // Ajouter_type
            // 
            this.Ajouter_type.BackColor = System.Drawing.Color.Yellow;
            this.Ajouter_type.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.Ajouter_type.FlatAppearance.BorderSize = 0;
            this.Ajouter_type.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.Ajouter_type.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Ajouter_type.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ajouter_type.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ajouter_type.ForeColor = System.Drawing.Color.Black;
            this.Ajouter_type.Location = new System.Drawing.Point(617, 391);
            this.Ajouter_type.Name = "Ajouter_type";
            this.Ajouter_type.Size = new System.Drawing.Size(159, 32);
            this.Ajouter_type.TabIndex = 21;
            this.Ajouter_type.Text = "Ajouter Type Ouvrage";
            this.Ajouter_type.UseVisualStyleBackColor = false;
            this.Ajouter_type.Click += new System.EventHandler(this.Ajouter_type_Click);
            // 
            // Ajouter_Editeur
            // 
            this.Ajouter_Editeur.BackColor = System.Drawing.Color.Yellow;
            this.Ajouter_Editeur.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.Ajouter_Editeur.FlatAppearance.BorderSize = 0;
            this.Ajouter_Editeur.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.Ajouter_Editeur.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Ajouter_Editeur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ajouter_Editeur.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ajouter_Editeur.ForeColor = System.Drawing.Color.Black;
            this.Ajouter_Editeur.Location = new System.Drawing.Point(314, 391);
            this.Ajouter_Editeur.Name = "Ajouter_Editeur";
            this.Ajouter_Editeur.Size = new System.Drawing.Size(159, 32);
            this.Ajouter_Editeur.TabIndex = 20;
            this.Ajouter_Editeur.Text = "Ajouter Editeur";
            this.Ajouter_Editeur.UseVisualStyleBackColor = false;
            this.Ajouter_Editeur.Click += new System.EventHandler(this.Ajouter_Editeur_Click);
            // 
            // Ajouter_auteur
            // 
            this.Ajouter_auteur.BackColor = System.Drawing.Color.Yellow;
            this.Ajouter_auteur.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.Ajouter_auteur.FlatAppearance.BorderSize = 0;
            this.Ajouter_auteur.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.Ajouter_auteur.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Ajouter_auteur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ajouter_auteur.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ajouter_auteur.ForeColor = System.Drawing.Color.Black;
            this.Ajouter_auteur.Location = new System.Drawing.Point(28, 391);
            this.Ajouter_auteur.Name = "Ajouter_auteur";
            this.Ajouter_auteur.Size = new System.Drawing.Size(159, 32);
            this.Ajouter_auteur.TabIndex = 19;
            this.Ajouter_auteur.Text = "Ajouter Auteur";
            this.Ajouter_auteur.UseVisualStyleBackColor = false;
            this.Ajouter_auteur.Click += new System.EventHandler(this.Ajouter_auteur_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumSpringGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(72, 125);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumSpringGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 23;
            this.dataGridView1.Size = new System.Drawing.Size(654, 233);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.Visible = false;
            // 
            // BtnAfficher
            // 
            this.BtnAfficher.BackColor = System.Drawing.Color.Yellow;
            this.BtnAfficher.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.BtnAfficher.FlatAppearance.BorderSize = 0;
            this.BtnAfficher.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.BtnAfficher.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnAfficher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAfficher.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAfficher.ForeColor = System.Drawing.Color.Black;
            this.BtnAfficher.Location = new System.Drawing.Point(617, 53);
            this.BtnAfficher.Name = "BtnAfficher";
            this.BtnAfficher.Size = new System.Drawing.Size(159, 32);
            this.BtnAfficher.TabIndex = 17;
            this.BtnAfficher.Text = "Afficher Ouvrage";
            this.BtnAfficher.UseVisualStyleBackColor = false;
            this.BtnAfficher.Click += new System.EventHandler(this.BtnAfficher_Click);
            // 
            // BtnRechercher
            // 
            this.BtnRechercher.BackColor = System.Drawing.Color.Yellow;
            this.BtnRechercher.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.BtnRechercher.FlatAppearance.BorderSize = 0;
            this.BtnRechercher.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.BtnRechercher.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnRechercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRechercher.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRechercher.ForeColor = System.Drawing.Color.Black;
            this.BtnRechercher.Location = new System.Drawing.Point(425, 53);
            this.BtnRechercher.Name = "BtnRechercher";
            this.BtnRechercher.Size = new System.Drawing.Size(159, 32);
            this.BtnRechercher.TabIndex = 16;
            this.BtnRechercher.Text = "Rechercher Ouvrage";
            this.BtnRechercher.UseVisualStyleBackColor = false;
            this.BtnRechercher.Click += new System.EventHandler(this.BtnRechercher_Click);
            // 
            // BtnSupprimer
            // 
            this.BtnSupprimer.BackColor = System.Drawing.Color.Yellow;
            this.BtnSupprimer.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.BtnSupprimer.FlatAppearance.BorderSize = 0;
            this.BtnSupprimer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.BtnSupprimer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSupprimer.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSupprimer.ForeColor = System.Drawing.Color.Black;
            this.BtnSupprimer.Location = new System.Drawing.Point(231, 53);
            this.BtnSupprimer.Name = "BtnSupprimer";
            this.BtnSupprimer.Size = new System.Drawing.Size(159, 32);
            this.BtnSupprimer.TabIndex = 15;
            this.BtnSupprimer.Text = "Supprimer Ouvrage";
            this.BtnSupprimer.UseVisualStyleBackColor = false;
            this.BtnSupprimer.Click += new System.EventHandler(this.BtnSupprimer_Click);
            // 
            // BtnAjouter
            // 
            this.BtnAjouter.BackColor = System.Drawing.Color.Yellow;
            this.BtnAjouter.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.BtnAjouter.FlatAppearance.BorderSize = 0;
            this.BtnAjouter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.BtnAjouter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAjouter.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAjouter.ForeColor = System.Drawing.Color.Black;
            this.BtnAjouter.Location = new System.Drawing.Point(28, 53);
            this.BtnAjouter.Name = "BtnAjouter";
            this.BtnAjouter.Size = new System.Drawing.Size(159, 32);
            this.BtnAjouter.TabIndex = 14;
            this.BtnAjouter.Text = "Ajouter Ouvrage";
            this.BtnAjouter.UseVisualStyleBackColor = false;
            this.BtnAjouter.Click += new System.EventHandler(this.BtnAjouter_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.BackgroundImage = global::Projet.Properties.Resources.Menu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listMenu);
            this.Controls.Add(this.Ajouter_type);
            this.Controls.Add(this.Ajouter_Editeur);
            this.Controls.Add(this.Ajouter_auteur);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnAfficher);
            this.Controls.Add(this.BtnRechercher);
            this.Controls.Add(this.BtnSupprimer);
            this.Controls.Add(this.BtnAjouter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listMenu;
        private System.Windows.Forms.Button Ajouter_type;
        private System.Windows.Forms.Button Ajouter_Editeur;
        private System.Windows.Forms.Button Ajouter_auteur;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnAfficher;
        private System.Windows.Forms.Button BtnRechercher;
        private System.Windows.Forms.Button BtnSupprimer;
        private System.Windows.Forms.Button BtnAjouter;
    }
}