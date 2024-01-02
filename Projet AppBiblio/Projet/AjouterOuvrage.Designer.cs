
namespace Projet
{
    partial class AjouterOuvrage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjouterOuvrage));
            this.comboEditeur = new System.Windows.Forms.ComboBox();
            this.comboAuteur = new System.Windows.Forms.ComboBox();
            this.comboType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RetourBtn = new System.Windows.Forms.Button();
            this.BtnAnnuler = new System.Windows.Forms.Button();
            this.BtnAjouter = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textAnnée = new System.Windows.Forms.TextBox();
            this.textTitre = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAjouteA = new System.Windows.Forms.Button();
            this.btnAjouteE = new System.Windows.Forms.Button();
            this.btnAjouteT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboEditeur
            // 
            this.comboEditeur.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboEditeur.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboEditeur.BackColor = System.Drawing.Color.White;
            this.comboEditeur.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboEditeur.FormattingEnabled = true;
            this.comboEditeur.IntegralHeight = false;
            this.comboEditeur.Location = new System.Drawing.Point(217, 331);
            this.comboEditeur.Name = "comboEditeur";
            this.comboEditeur.Size = new System.Drawing.Size(201, 27);
            this.comboEditeur.TabIndex = 39;
            // 
            // comboAuteur
            // 
            this.comboAuteur.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboAuteur.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboAuteur.BackColor = System.Drawing.Color.White;
            this.comboAuteur.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboAuteur.FormattingEnabled = true;
            this.comboAuteur.IntegralHeight = false;
            this.comboAuteur.Location = new System.Drawing.Point(217, 203);
            this.comboAuteur.Name = "comboAuteur";
            this.comboAuteur.Size = new System.Drawing.Size(201, 27);
            this.comboAuteur.TabIndex = 37;
            // 
            // comboType
            // 
            this.comboType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboType.BackColor = System.Drawing.Color.White;
            this.comboType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboType.FormattingEnabled = true;
            this.comboType.IntegralHeight = false;
            this.comboType.Location = new System.Drawing.Point(217, 396);
            this.comboType.Name = "comboType";
            this.comboType.Size = new System.Drawing.Size(201, 27);
            this.comboType.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Thistle;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 397);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 19);
            this.label6.TabIndex = 47;
            this.label6.Text = "Type d\'ouvrage :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.SandyBrown;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 60);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(2);
            this.label5.Size = new System.Drawing.Size(137, 23);
            this.label5.TabIndex = 46;
            this.label5.Text = "Ajouter Ouvrage";
            // 
            // RetourBtn
            // 
            this.RetourBtn.BackColor = System.Drawing.Color.SandyBrown;
            this.RetourBtn.FlatAppearance.BorderColor = System.Drawing.Color.SandyBrown;
            this.RetourBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RetourBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RetourBtn.ForeColor = System.Drawing.Color.Black;
            this.RetourBtn.Location = new System.Drawing.Point(341, 462);
            this.RetourBtn.Name = "RetourBtn";
            this.RetourBtn.Size = new System.Drawing.Size(130, 31);
            this.RetourBtn.TabIndex = 43;
            this.RetourBtn.Text = "Retour";
            this.RetourBtn.UseVisualStyleBackColor = false;
            this.RetourBtn.Click += new System.EventHandler(this.RetourBtn_Click);
            // 
            // BtnAnnuler
            // 
            this.BtnAnnuler.BackColor = System.Drawing.Color.SandyBrown;
            this.BtnAnnuler.FlatAppearance.BorderColor = System.Drawing.Color.SandyBrown;
            this.BtnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnnuler.ForeColor = System.Drawing.Color.Black;
            this.BtnAnnuler.Location = new System.Drawing.Point(189, 462);
            this.BtnAnnuler.Name = "BtnAnnuler";
            this.BtnAnnuler.Size = new System.Drawing.Size(130, 31);
            this.BtnAnnuler.TabIndex = 42;
            this.BtnAnnuler.Text = "Annuler";
            this.BtnAnnuler.UseVisualStyleBackColor = false;
            this.BtnAnnuler.Click += new System.EventHandler(this.BtnAnnuler_Click);
            // 
            // BtnAjouter
            // 
            this.BtnAjouter.BackColor = System.Drawing.Color.SandyBrown;
            this.BtnAjouter.FlatAppearance.BorderColor = System.Drawing.Color.SandyBrown;
            this.BtnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAjouter.ForeColor = System.Drawing.Color.Black;
            this.BtnAjouter.Location = new System.Drawing.Point(31, 462);
            this.BtnAjouter.Name = "BtnAjouter";
            this.BtnAjouter.Size = new System.Drawing.Size(130, 31);
            this.BtnAjouter.TabIndex = 41;
            this.BtnAjouter.Text = "Ajouter";
            this.BtnAjouter.UseVisualStyleBackColor = false;
            this.BtnAjouter.Click += new System.EventHandler(this.BtnAjouter_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Thistle;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 19);
            this.label4.TabIndex = 41;
            this.label4.Text = "Editeur :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Thistle;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 19);
            this.label3.TabIndex = 40;
            this.label3.Text = "Année d\'édition :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Thistle;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 39;
            this.label2.Text = "L\'auteur :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Thistle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 19);
            this.label1.TabIndex = 38;
            this.label1.Text = "le Titre :";
            // 
            // textAnnée
            // 
            this.textAnnée.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAnnée.Location = new System.Drawing.Point(217, 266);
            this.textAnnée.MaxLength = 4;
            this.textAnnée.Multiline = true;
            this.textAnnée.Name = "textAnnée";
            this.textAnnée.Size = new System.Drawing.Size(201, 27);
            this.textAnnée.TabIndex = 38;
            this.textAnnée.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textAnnée_KeyPress);
            // 
            // textTitre
            // 
            this.textTitre.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTitre.Location = new System.Drawing.Point(217, 135);
            this.textTitre.MaxLength = 60;
            this.textTitre.Multiline = true;
            this.textTitre.Name = "textTitre";
            this.textTitre.Size = new System.Drawing.Size(201, 27);
            this.textTitre.TabIndex = 36;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projet.Properties.Resources.AjouterOuvrage;
            this.pictureBox1.Location = new System.Drawing.Point(208, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // btnAjouteA
            // 
            this.btnAjouteA.BackColor = System.Drawing.Color.Transparent;
            this.btnAjouteA.BackgroundImage = global::Projet.Properties.Resources.plus;
            this.btnAjouteA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAjouteA.FlatAppearance.BorderColor = System.Drawing.Color.SandyBrown;
            this.btnAjouteA.FlatAppearance.BorderSize = 0;
            this.btnAjouteA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAjouteA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAjouteA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouteA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouteA.ForeColor = System.Drawing.Color.Black;
            this.btnAjouteA.Location = new System.Drawing.Point(435, 206);
            this.btnAjouteA.Name = "btnAjouteA";
            this.btnAjouteA.Size = new System.Drawing.Size(51, 26);
            this.btnAjouteA.TabIndex = 48;
            this.btnAjouteA.UseVisualStyleBackColor = false;
            this.btnAjouteA.Click += new System.EventHandler(this.btnAjouteA_Click);
            // 
            // btnAjouteE
            // 
            this.btnAjouteE.BackColor = System.Drawing.Color.Transparent;
            this.btnAjouteE.BackgroundImage = global::Projet.Properties.Resources.plus;
            this.btnAjouteE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAjouteE.FlatAppearance.BorderColor = System.Drawing.Color.SandyBrown;
            this.btnAjouteE.FlatAppearance.BorderSize = 0;
            this.btnAjouteE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAjouteE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAjouteE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouteE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouteE.ForeColor = System.Drawing.Color.Black;
            this.btnAjouteE.Location = new System.Drawing.Point(435, 332);
            this.btnAjouteE.Name = "btnAjouteE";
            this.btnAjouteE.Size = new System.Drawing.Size(51, 26);
            this.btnAjouteE.TabIndex = 49;
            this.btnAjouteE.UseVisualStyleBackColor = false;
            this.btnAjouteE.Click += new System.EventHandler(this.btnAjouteE_Click);
            // 
            // btnAjouteT
            // 
            this.btnAjouteT.BackColor = System.Drawing.Color.Transparent;
            this.btnAjouteT.BackgroundImage = global::Projet.Properties.Resources.plus;
            this.btnAjouteT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAjouteT.FlatAppearance.BorderColor = System.Drawing.Color.SandyBrown;
            this.btnAjouteT.FlatAppearance.BorderSize = 0;
            this.btnAjouteT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAjouteT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAjouteT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouteT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouteT.ForeColor = System.Drawing.Color.Black;
            this.btnAjouteT.Location = new System.Drawing.Point(435, 397);
            this.btnAjouteT.Name = "btnAjouteT";
            this.btnAjouteT.Size = new System.Drawing.Size(51, 26);
            this.btnAjouteT.TabIndex = 50;
            this.btnAjouteT.UseVisualStyleBackColor = false;
            this.btnAjouteT.Click += new System.EventHandler(this.btnAjouteT_Click);
            // 
            // AjouterOuvrage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(483, 512);
            this.Controls.Add(this.btnAjouteT);
            this.Controls.Add(this.btnAjouteE);
            this.Controls.Add(this.btnAjouteA);
            this.Controls.Add(this.comboEditeur);
            this.Controls.Add(this.comboAuteur);
            this.Controls.Add(this.comboType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.RetourBtn);
            this.Controls.Add(this.BtnAnnuler);
            this.Controls.Add(this.BtnAjouter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textAnnée);
            this.Controls.Add(this.textTitre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AjouterOuvrage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajouter";
            this.Load += new System.EventHandler(this.AjouterOuvrage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboEditeur;
        private System.Windows.Forms.ComboBox comboAuteur;
        private System.Windows.Forms.ComboBox comboType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button RetourBtn;
        private System.Windows.Forms.Button BtnAnnuler;
        private System.Windows.Forms.Button BtnAjouter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textAnnée;
        private System.Windows.Forms.TextBox textTitre;
        private System.Windows.Forms.Button btnAjouteA;
        private System.Windows.Forms.Button btnAjouteE;
        private System.Windows.Forms.Button btnAjouteT;
    }
}