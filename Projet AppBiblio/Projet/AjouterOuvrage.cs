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


namespace Projet
{
    public partial class AjouterOuvrage : Form
    {
        public AjouterOuvrage()
        {
            InitializeComponent();
        }
        Ado d = new Ado();
        DataSet ds = new DataSet();
        public void Remplircombo()
        {
            d.da = new SqlDataAdapter("select * from auteur order by nom_auteur", d.cn);
            d.da.Fill(ds, "auteur");
            d.dt = ds.Tables["auteur"];
            comboAuteur.DataSource = d.dt;
            comboAuteur.DisplayMember = "nom_auteur";
            comboAuteur.ValueMember = "id_auteur";
            comboAuteur.Text = "Choisir un Auteur";

            d.da = new SqlDataAdapter("select * from editeur order by nom_editeur", d.cn);
            d.da.Fill(ds, "editeur");
            d.dt = ds.Tables["editeur"];
            comboEditeur.DataSource = d.dt;
            comboEditeur.DisplayMember = "nom_editeur";
            comboEditeur.ValueMember = "id_editeur";
            comboEditeur.Text = "Choisir un Editeur";

            d.da = new SqlDataAdapter("select * from types order by nom_type", d.cn);
            d.da.Fill(ds, "types");
            d.dt = ds.Tables["types"];
            comboType.DataSource = d.dt;
            comboType.DisplayMember = "nom_type";
            comboType.ValueMember = "codetype";
            comboType.Text = "Choisir un Type";

        }

        private void AjouterOuvrage_Load(object sender, EventArgs e)
        {
            d.connection();
            Remplircombo();
            d.da = new SqlDataAdapter("select * from ouvrage", d.cn);
            d.da.Fill(ds, "ouvrage");

        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            if (textTitre.Text == "" || textAnnée.Text == "" || comboAuteur.Text == "" || comboEditeur.Text == "" || comboType.Text == "" )
            {
                MessageBox.Show("Remplissez tous les champs", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboAuteur.SelectedItem == null || comboAuteur.Text == "Choisir un Auteur")
            {
                MessageBox.Show("Choisir un Auteur", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboEditeur.SelectedItem == null || comboEditeur.Text == "Choisir un Editeur")
            {
                MessageBox.Show("Choisir un Editeur", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboType.SelectedItem == null || comboType.Text == "Choisir un Type")
            {
                MessageBox.Show("Choisir un Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textAnnée.Text.Length < 4)
            {
                MessageBox.Show("L'année doivent comporter au moins 4 digits", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textTitre.Text.Length < 6)
            {
                MessageBox.Show("Le Titre doivent comporter au moins 6 caractères", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //d.da = new SqlDataAdapter("select titre from ouvrage where titre like '" +'%'+ textTitre.Text + '%'+ "'", d.cn);
            //d.da = new SqlDataAdapter("select titre from ouvrage where titre in ('" + textTitre.Text + "')", d.cn);
            d.da1 = new SqlDataAdapter("select titre from ouvrage", d.cn);
            d.da1.Fill(ds, "titre");
            for (int i = 0; i < ds.Tables["titre"].Rows.Count; i++)
            {
                if (textTitre.Text.ToLower() == ds.Tables["titre"].Rows[i][0].ToString().ToLower())
                {
                    MessageBox.Show("Ce Titre déjà existe", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            DataRow dr = ds.Tables["ouvrage"].NewRow();
            dr[0] = textTitre.Text;
            dr[1] = comboAuteur.SelectedValue;
            dr[2] = textAnnée.Text;
            dr[3] = comboEditeur.SelectedValue;
            dr[4] = comboType.SelectedValue;
            ds.Tables["ouvrage"].Rows.Add(dr);
            d.bc = new SqlCommandBuilder(d.da);
            d.da.Update(ds, "ouvrage");
            MessageBox.Show("Ouvrage Ajouté avec Succés ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            d.Vider(this);
            comboAuteur.Text = "Choisir un Auteur"; comboEditeur.Text = "Choisir un Editeur"; comboType.Text = "Choisir un Type"; textTitre.Focus();
        }

        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            d.Vider(this); comboAuteur.Text = "Choisir un Auteur"; comboEditeur.Text = "Choisir un Editeur"; comboType.Text = "Choisir un Type"; textTitre.Focus();
        }

        private void RetourBtn_Click(object sender, EventArgs e)
        {
            Menu M = new Menu();
            M.Show();
            this.Close();
        }

        private void textAnnée_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAjouteA_Click(object sender, EventArgs e)
        {
            this.Hide();
            Auteur A = new Auteur();
            A.ShowDialog();
            A = null;
            AjouterOuvrage B = new AjouterOuvrage();
            B.Activate();
            B.Show();

        }

        private void btnAjouteE_Click(object sender, EventArgs e)
        {
            this.Close();
            //this.Hide();
            Editeur E = new Editeur();
            E.ShowDialog();
            E = null;
            AjouterOuvrage A = new AjouterOuvrage();
            A.Show();
            //this.Activate();
        }

        private void btnAjouteT_Click(object sender, EventArgs e)
        {
            this.Close();
            //this.Hide();
            TypeOuvrage T = new TypeOuvrage();
            T.ShowDialog();
            T = null;
            AjouterOuvrage A = new AjouterOuvrage();
            A.Show();
        }

        //private void AjouterOuvrage_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
        //    {
        //        if (Application.OpenForms[i].Name == "Login")
        //            Application.OpenForms[i].Close();
        //    }

        //}
    }
}
