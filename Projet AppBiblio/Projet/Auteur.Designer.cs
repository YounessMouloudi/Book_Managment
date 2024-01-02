
namespace Projet
{
    partial class Auteur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Auteur));
            this.label3 = new System.Windows.Forms.Label();
            this.BtnModifier = new System.Windows.Forms.Button();
            this.BtnSupprimer = new System.Windows.Forms.Button();
            this.BtnAnnuler = new System.Windows.Forms.Button();
            this.BtnAjouter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textNom = new System.Windows.Forms.TextBox();
            this.textID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RetourBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DodgerBlue;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(105, 39);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(3);
            this.label3.Size = new System.Drawing.Size(183, 30);
            this.label3.TabIndex = 44;
            this.label3.Text = "Ajouter Un Auteur";
            // 
            // BtnModifier
            // 
            this.BtnModifier.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnModifier.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.BtnModifier.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.BtnModifier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.BtnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModifier.ForeColor = System.Drawing.Color.Black;
            this.BtnModifier.Location = new System.Drawing.Point(215, 245);
            this.BtnModifier.Name = "BtnModifier";
            this.BtnModifier.Size = new System.Drawing.Size(134, 32);
            this.BtnModifier.TabIndex = 43;
            this.BtnModifier.Text = "     Modifier";
            this.BtnModifier.UseVisualStyleBackColor = false;
            this.BtnModifier.Click += new System.EventHandler(this.BtnModifier_Click);
            // 
            // BtnSupprimer
            // 
            this.BtnSupprimer.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnSupprimer.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.BtnSupprimer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.BtnSupprimer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.BtnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSupprimer.ForeColor = System.Drawing.Color.Black;
            this.BtnSupprimer.Location = new System.Drawing.Point(30, 305);
            this.BtnSupprimer.Name = "BtnSupprimer";
            this.BtnSupprimer.Size = new System.Drawing.Size(134, 32);
            this.BtnSupprimer.TabIndex = 42;
            this.BtnSupprimer.Text = "       Supprimer";
            this.BtnSupprimer.UseVisualStyleBackColor = false;
            this.BtnSupprimer.Click += new System.EventHandler(this.BtnSupprimer_Click);
            // 
            // BtnAnnuler
            // 
            this.BtnAnnuler.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnAnnuler.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.BtnAnnuler.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.BtnAnnuler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.BtnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnnuler.ForeColor = System.Drawing.Color.Black;
            this.BtnAnnuler.Location = new System.Drawing.Point(215, 305);
            this.BtnAnnuler.Name = "BtnAnnuler";
            this.BtnAnnuler.Size = new System.Drawing.Size(134, 32);
            this.BtnAnnuler.TabIndex = 40;
            this.BtnAnnuler.Text = "     Annuler";
            this.BtnAnnuler.UseVisualStyleBackColor = false;
            this.BtnAnnuler.Click += new System.EventHandler(this.BtnAnnuler_Click);
            // 
            // BtnAjouter
            // 
            this.BtnAjouter.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnAjouter.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.BtnAjouter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.BtnAjouter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.BtnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAjouter.ForeColor = System.Drawing.Color.Black;
            this.BtnAjouter.Location = new System.Drawing.Point(30, 244);
            this.BtnAjouter.Name = "BtnAjouter";
            this.BtnAjouter.Size = new System.Drawing.Size(134, 32);
            this.BtnAjouter.TabIndex = 39;
            this.BtnAjouter.Text = "     Ajouter";
            this.BtnAjouter.UseVisualStyleBackColor = false;
            this.BtnAjouter.Click += new System.EventHandler(this.BtnAjouter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(27, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 38;
            this.label2.Text = "ID Auteur :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(27, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 19);
            this.label1.TabIndex = 37;
            this.label1.Text = "Nom Auteur :";
            // 
            // textNom
            // 
            this.textNom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNom.Location = new System.Drawing.Point(152, 168);
            this.textNom.Multiline = true;
            this.textNom.Name = "textNom";
            this.textNom.Size = new System.Drawing.Size(197, 28);
            this.textNom.TabIndex = 36;
            this.textNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNom_KeyPress);
            // 
            // textID
            // 
            this.textID.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textID.Location = new System.Drawing.Point(152, 100);
            this.textID.Multiline = true;
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(197, 28);
            this.textID.TabIndex = 35;
            this.textID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textID_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumSpringGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumSpringGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(368, 39);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumSpringGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 25;
            this.dataGridView1.Size = new System.Drawing.Size(316, 301);
            this.dataGridView1.TabIndex = 45;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBox4.Enabled = false;
            this.pictureBox4.Image = global::Projet.Properties.Resources.cancel;
            this.pictureBox4.Location = new System.Drawing.Point(215, 305);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(37, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 49;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBox3.Enabled = false;
            this.pictureBox3.Image = global::Projet.Properties.Resources.delete;
            this.pictureBox3.Location = new System.Drawing.Point(30, 305);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(37, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 48;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Image = global::Projet.Properties.Resources.edit;
            this.pictureBox2.Location = new System.Drawing.Point(215, 245);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 47;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::Projet.Properties.Resources.plus;
            this.pictureBox1.Location = new System.Drawing.Point(30, 244);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // RetourBtn
            // 
            this.RetourBtn.BackColor = System.Drawing.Color.Transparent;
            this.RetourBtn.BackgroundImage = global::Projet.Properties.Resources.Retour;
            this.RetourBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RetourBtn.FlatAppearance.BorderColor = System.Drawing.Color.SandyBrown;
            this.RetourBtn.FlatAppearance.BorderSize = 0;
            this.RetourBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.RetourBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SandyBrown;
            this.RetourBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RetourBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RetourBtn.ForeColor = System.Drawing.Color.Black;
            this.RetourBtn.Location = new System.Drawing.Point(1, 1);
            this.RetourBtn.Name = "RetourBtn";
            this.RetourBtn.Size = new System.Drawing.Size(51, 34);
            this.RetourBtn.TabIndex = 41;
            this.RetourBtn.UseVisualStyleBackColor = false;
            this.RetourBtn.Click += new System.EventHandler(this.RetourBtn_Click);
            // 
            // Auteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(705, 369);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnModifier);
            this.Controls.Add(this.BtnSupprimer);
            this.Controls.Add(this.RetourBtn);
            this.Controls.Add(this.BtnAnnuler);
            this.Controls.Add(this.BtnAjouter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textNom);
            this.Controls.Add(this.textID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Auteur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auteur";
            this.Load += new System.EventHandler(this.Auteur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnModifier;
        private System.Windows.Forms.Button BtnSupprimer;
        private System.Windows.Forms.Button RetourBtn;
        private System.Windows.Forms.Button BtnAnnuler;
        private System.Windows.Forms.Button BtnAjouter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNom;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }


}
