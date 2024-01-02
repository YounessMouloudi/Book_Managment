
namespace Projet
{
    partial class SupprimerOuvrage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupprimerOuvrage));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboAuteur = new System.Windows.Forms.ComboBox();
            this.comboType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RetourBtn = new System.Windows.Forms.Button();
            this.BtnAfficher = new System.Windows.Forms.Button();
            this.BtnSupprimer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textTitre = new System.Windows.Forms.TextBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.dataGridView1.Location = new System.Drawing.Point(361, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumSpringGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 30;
            this.dataGridView1.Size = new System.Drawing.Size(767, 292);
            this.dataGridView1.TabIndex = 61;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // comboAuteur
            // 
            this.comboAuteur.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboAuteur.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboAuteur.BackColor = System.Drawing.Color.White;
            this.comboAuteur.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboAuteur.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboAuteur.ForeColor = System.Drawing.Color.Black;
            this.comboAuteur.FormattingEnabled = true;
            this.comboAuteur.IntegralHeight = false;
            this.comboAuteur.Location = new System.Drawing.Point(179, 173);
            this.comboAuteur.Name = "comboAuteur";
            this.comboAuteur.Size = new System.Drawing.Size(176, 27);
            this.comboAuteur.TabIndex = 52;
            this.comboAuteur.SelectedIndexChanged += new System.EventHandler(this.comboAuteur_SelectedIndexChanged);
            // 
            // comboType
            // 
            this.comboType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboType.BackColor = System.Drawing.Color.White;
            this.comboType.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboType.ForeColor = System.Drawing.Color.Black;
            this.comboType.FormattingEnabled = true;
            this.comboType.IntegralHeight = false;
            this.comboType.Location = new System.Drawing.Point(179, 240);
            this.comboType.Name = "comboType";
            this.comboType.Size = new System.Drawing.Size(176, 27);
            this.comboType.TabIndex = 53;
            this.comboType.SelectedIndexChanged += new System.EventHandler(this.comboType_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Orange;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(22, 243);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(3);
            this.label6.Size = new System.Drawing.Size(128, 24);
            this.label6.TabIndex = 58;
            this.label6.Text = "Type d\'ouvrage";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label5.Location = new System.Drawing.Point(324, 38);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(5);
            this.label5.Size = new System.Drawing.Size(163, 28);
            this.label5.TabIndex = 57;
            this.label5.Text = "Supprimer Ouvrage";
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
            this.RetourBtn.ForeColor = System.Drawing.Color.Transparent;
            this.RetourBtn.Location = new System.Drawing.Point(1, 29);
            this.RetourBtn.Name = "RetourBtn";
            this.RetourBtn.Size = new System.Drawing.Size(59, 38);
            this.RetourBtn.TabIndex = 57;
            this.RetourBtn.UseVisualStyleBackColor = false;
            this.RetourBtn.Click += new System.EventHandler(this.RetourBtn_Click);
            // 
            // BtnAfficher
            // 
            this.BtnAfficher.BackColor = System.Drawing.Color.Black;
            this.BtnAfficher.FlatAppearance.BorderSize = 0;
            this.BtnAfficher.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnAfficher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAfficher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAfficher.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnAfficher.Location = new System.Drawing.Point(194, 305);
            this.BtnAfficher.Name = "BtnAfficher";
            this.BtnAfficher.Size = new System.Drawing.Size(142, 31);
            this.BtnAfficher.TabIndex = 55;
            this.BtnAfficher.Text = "Afficher Ouvrage";
            this.BtnAfficher.UseVisualStyleBackColor = false;
            this.BtnAfficher.Click += new System.EventHandler(this.BtnAfficher_Click);
            // 
            // BtnSupprimer
            // 
            this.BtnSupprimer.BackColor = System.Drawing.Color.Black;
            this.BtnSupprimer.FlatAppearance.BorderSize = 0;
            this.BtnSupprimer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSupprimer.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnSupprimer.Location = new System.Drawing.Point(25, 305);
            this.BtnSupprimer.Name = "BtnSupprimer";
            this.BtnSupprimer.Size = new System.Drawing.Size(97, 31);
            this.BtnSupprimer.TabIndex = 54;
            this.BtnSupprimer.Text = "Supprimer";
            this.BtnSupprimer.UseVisualStyleBackColor = false;
            this.BtnSupprimer.Click += new System.EventHandler(this.BtnSupprimer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Orange;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(22, 176);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(3);
            this.label2.Size = new System.Drawing.Size(74, 24);
            this.label2.TabIndex = 53;
            this.label2.Text = "L\'auteur";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Orange;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(22, 112);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(3);
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 52;
            this.label1.Text = "le Titre";
            // 
            // textTitre
            // 
            this.textTitre.BackColor = System.Drawing.Color.White;
            this.textTitre.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTitre.ForeColor = System.Drawing.Color.Black;
            this.textTitre.Location = new System.Drawing.Point(179, 103);
            this.textTitre.Multiline = true;
            this.textTitre.Name = "textTitre";
            this.textTitre.Size = new System.Drawing.Size(176, 27);
            this.textTitre.TabIndex = 51;
            this.textTitre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textTitre_KeyPress);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.Black;
            this.btnAnnuler.FlatAppearance.BorderSize = 0;
            this.btnAnnuler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAnnuler.Location = new System.Drawing.Point(112, 364);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(97, 31);
            this.btnAnnuler.TabIndex = 56;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // SupprimerOuvrage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::Projet.Properties.Resources.Supprimer;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1140, 412);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboAuteur);
            this.Controls.Add(this.comboType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RetourBtn);
            this.Controls.Add(this.BtnAfficher);
            this.Controls.Add(this.BtnSupprimer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textTitre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SupprimerOuvrage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supprimer";
            this.Load += new System.EventHandler(this.SupprimerOuvrage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboAuteur;
        private System.Windows.Forms.ComboBox comboType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button RetourBtn;
        private System.Windows.Forms.Button BtnAfficher;
        private System.Windows.Forms.Button BtnSupprimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textTitre;
        private System.Windows.Forms.Button btnAnnuler;
    }
}