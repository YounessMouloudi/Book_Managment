
namespace Projet
{
    partial class Inscription
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inscription));
            this.textUser = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.textTelephone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.comboVille = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RetourBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textUser
            // 
            this.textUser.BackColor = System.Drawing.Color.White;
            this.textUser.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUser.Location = new System.Drawing.Point(221, 167);
            this.textUser.MaxLength = 40;
            this.textUser.Multiline = true;
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(188, 26);
            this.textUser.TabIndex = 0;
            this.textUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textUser_KeyPress);
            // 
            // textPassword
            // 
            this.textPassword.BackColor = System.Drawing.Color.White;
            this.textPassword.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPassword.Location = new System.Drawing.Point(221, 226);
            this.textPassword.MaxLength = 40;
            this.textPassword.Multiline = true;
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(188, 26);
            this.textPassword.TabIndex = 1;
            // 
            // textTelephone
            // 
            this.textTelephone.BackColor = System.Drawing.Color.White;
            this.textTelephone.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTelephone.Location = new System.Drawing.Point(221, 347);
            this.textTelephone.MaxLength = 10;
            this.textTelephone.Multiline = true;
            this.textTelephone.Name = "textTelephone";
            this.textTelephone.Size = new System.Drawing.Size(188, 26);
            this.textTelephone.TabIndex = 3;
            this.textTelephone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textTelephone_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSalmon;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "UserName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSalmon;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightSalmon;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ville";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightSalmon;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Telephone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gold;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 114);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(3);
            this.label5.Size = new System.Drawing.Size(416, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Merci de remplir ce formulaire pour créer un compte !";
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnConfirmer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmer.Location = new System.Drawing.Point(43, 413);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(135, 31);
            this.btnConfirmer.TabIndex = 4;
            this.btnConfirmer.Text = "Confirmer";
            this.btnConfirmer.UseVisualStyleBackColor = false;
            this.btnConfirmer.Click += new System.EventHandler(this.btnConfirmer_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.Location = new System.Drawing.Point(274, 413);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(135, 31);
            this.btnAnnuler.TabIndex = 5;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // comboVille
            // 
            this.comboVille.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboVille.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboVille.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboVille.FormattingEnabled = true;
            this.comboVille.Items.AddRange(new object[] {
            "Agadir",
            "Al-Hoceima",
            "Arfoud ",
            "Asilah",
            "Azilal",
            "Azrou",
            "Béni Mellal",
            "Berkane",
            "Berrechid",
            "Boulemane",
            "Bouznika",
            "Casablanca",
            "Chefchaouen",
            "Dakhla",
            "El Hajeb",
            "El Jadida",
            "Errachidia",
            "Essaouira",
            "Fés",
            "Fquih Ben Salah",
            "Guelmim",
            "Guercif",
            "Ifrane",
            "Inezgane",
            "Kasba Tadla",
            "Kénitra",
            "Khémisset",
            "Khénifra",
            "Khouribga",
            "Ksar el-Kébir",
            "laâyoune",
            "Larache",
            "M\'rirt",
            "Marrakech",
            "Meknès",
            "Midelt",
            "Mohammédia",
            "Nador",
            "Ouarzazate",
            "Ouezzane",
            "Oujda",
            "Rabat",
            "Rissani",
            "Safi",
            "Saïdia",
            "Salé",
            "Sefrou",
            "Semara",
            "Settat ",
            "Sidi Kacem",
            "Sidi Slimane",
            "Tan-Tan",
            "Tanger",
            "TaourirteTaounate",
            "Tarfaya",
            "Taroudannt",
            "Tata",
            "Taza",
            "Témara",
            "Tétouan",
            "Tifelt",
            "Tiflet",
            "Tinghir",
            "Tiznit",
            "Zagora"});
            this.comboVille.Location = new System.Drawing.Point(221, 291);
            this.comboVille.Name = "comboVille";
            this.comboVille.Size = new System.Drawing.Size(188, 27);
            this.comboVille.Sorted = true;
            this.comboVille.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projet.Properties.Resources.Inscription;
            this.pictureBox1.Location = new System.Drawing.Point(112, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
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
            this.RetourBtn.Location = new System.Drawing.Point(-1, 0);
            this.RetourBtn.Name = "RetourBtn";
            this.RetourBtn.Size = new System.Drawing.Size(51, 34);
            this.RetourBtn.TabIndex = 42;
            this.RetourBtn.UseVisualStyleBackColor = false;
            this.RetourBtn.Click += new System.EventHandler(this.RetourBtn_Click);
            // 
            // Inscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(443, 466);
            this.Controls.Add(this.RetourBtn);
            this.Controls.Add(this.comboVille);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnConfirmer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textTelephone);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Inscription";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inscription";
            this.Load += new System.EventHandler(this.Inscription_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textUser;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.TextBox textTelephone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnConfirmer;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.ComboBox comboVille;
        private System.Windows.Forms.Button RetourBtn;
    }
}
