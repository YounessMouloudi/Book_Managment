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
    public partial class RechercherOuvrage : Form
    {
        public RechercherOuvrage()
        {
            InitializeComponent();
        }
        Ado d = new Ado();
        DataSet ds = new DataSet();
        public void Remplircombo()
        {
            ds.Tables.Clear();
            d.da = new SqlDataAdapter("select nom_auteur from auteur order by nom_auteur", d.cn);
            d.da.Fill(ds, "auteur");
            comboAuteur.DataSource = ds.Tables["auteur"];
            comboAuteur.DisplayMember = "nom_auteur";
            comboAuteur.ValueMember = "nom_auteur";
            comboAuteur.Text = "Choisir un Auteur";

            ds.Tables.Clear();
            d.da = new SqlDataAdapter("select nom_type from types order by nom_type", d.cn);
            d.da.Fill(ds, "types");
            comboTypes.DataSource = ds.Tables["types"];
            comboTypes.DisplayMember = "nom_type";
            comboTypes.ValueMember = "nom_type";
            comboTypes.Text = "Choisir un Type";

        }
        private void RechercherOuvrage_Load(object sender, EventArgs e)
        {
            d.connection();
            Remplircombo();
        }

        private void BtnRechercher_Click(object sender, EventArgs e)
        {
            if ((textTitre.Text == "" && comboAuteur.Text == "Choisir un Auteur" && comboTypes.Text== "Choisir un Type") || (comboAuteur.Text == "" && comboTypes.Text == "") )
            {
                MessageBox.Show("Remplissez un champ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // hadi khass ykono b 3 3amrin had ydir recherche
            else if (textTitre.Text != "" && comboAuteur.Text != "Choisir un Auteur" && comboTypes.Text != "Choisir un Type")
            {
                ds.Tables.Clear();
                d.da = new SqlDataAdapter("select ouvrage.titre as 'Titre', auteur.nom_auteur as 'Nom auteur', ouvrage.année_édition as 'Année édition', editeur.nom_editeur as 'Nom éditeur', types.nom_type as 'Type Ouvrage' FROM auteur INNER JOIN ouvrage ON auteur.id_auteur = ouvrage.id_auteur INNER JOIN editeur ON ouvrage.id_editeur = editeur.id_editeur INNER JOIN types ON ouvrage.id_type = types.codetype where titre like '" + '%' + textTitre.Text + '%' + "'or nom_auteur ='" + comboAuteur.Text + "'or nom_type = '" + comboTypes.Text + "'", d.cn);
                d.da.Fill(ds, "tt");
                d.dt = ds.Tables["tt"];
                dataGridView1.DataSource = d.dt;
                textAnnée.Text = "";
            }
            // hadi ghay9lb b les deux comboboxes 
            else if (textTitre.Text == "" && comboAuteur.Text != "Choisir un Auteur" && comboTypes.Text != "Choisir un Type")
            {
                ds.Tables.Clear();
                d.da = new SqlDataAdapter("select ouvrage.titre as 'Titre', auteur.nom_auteur as 'Nom auteur', ouvrage.année_édition as 'Année édition', editeur.nom_editeur as 'Nom éditeur', types.nom_type as 'Type Ouvrage' FROM auteur INNER JOIN ouvrage ON auteur.id_auteur = ouvrage.id_auteur INNER JOIN editeur ON ouvrage.id_editeur = editeur.id_editeur INNER JOIN types ON ouvrage.id_type = types.codetype where nom_auteur ='" + comboAuteur.Text + "'or nom_type = '" + comboTypes.Text + "'", d.cn);
                d.da.Fill(ds, "tt");
                d.dt = ds.Tables["tt"];
                dataGridView1.DataSource = d.dt;
                textAnnée.Text = "";
            }
            // hadi ghay9lb ghi b le titre
            else if (textTitre.Text != "" && comboTypes.Text == "Choisir un Type" && comboAuteur.Text == "Choisir un Auteur")
            {
                ds.Tables.Clear();
                d.da = new SqlDataAdapter("select ouvrage.titre as 'Titre', auteur.nom_auteur as 'Nom auteur', ouvrage.année_édition as 'Année édition', editeur.nom_editeur as 'Nom éditeur', types.nom_type as 'Type Ouvrage' FROM auteur INNER JOIN ouvrage ON auteur.id_auteur = ouvrage.id_auteur INNER JOIN editeur ON ouvrage.id_editeur = editeur.id_editeur INNER JOIN types ON ouvrage.id_type = types.codetype where titre like '" + '%' + textTitre.Text + '%' + "'", d.cn);
                d.da.Fill(ds, "tt");
                d.dt = ds.Tables["tt"];
                dataGridView1.DataSource = d.dt;
                textAnnée.Text = "";
                textTitre.Text = "";
            }
            // hadi ghay9lb b le titre et comboauteur
            else if ((comboAuteur.SelectedItem != null && comboAuteur.Text != "Choisir un Auteur" && textTitre.Text != "" && comboTypes.Text != "") || (comboAuteur.SelectedItem != null && comboAuteur.Text != "Choisir un Auteur" && textTitre.Text != "" && comboTypes.Text == "Choisir un Type"))
            {
                ds.Tables.Clear();
                d.da = new SqlDataAdapter("select ouvrage.titre as 'Titre', auteur.nom_auteur as 'Nom auteur', ouvrage.année_édition as 'Année édition', editeur.nom_editeur as 'Nom éditeur', types.nom_type as 'Type Ouvrage' FROM auteur INNER JOIN ouvrage ON auteur.id_auteur = ouvrage.id_auteur INNER JOIN editeur ON ouvrage.id_editeur = editeur.id_editeur INNER JOIN types ON ouvrage.id_type = types.codetype where titre like '" + '%' + textTitre.Text + '%' + "'or nom_auteur ='" + comboAuteur.Text + "'", d.cn);
                d.da.Fill(ds, "tt");
                d.dt = ds.Tables["tt"];
                dataGridView1.DataSource = d.dt;
                textAnnée.Text = "";
            }
            // hadi ghay9lb ghi b comboauteur
            else if ((comboAuteur.SelectedItem != null && comboAuteur.Text != "Choisir un Auteur" && textTitre.Text == "" && comboTypes.Text != "" )|| (comboAuteur.SelectedItem != null && comboAuteur.Text != "Choisir un Auteur" && textTitre.Text == "" && comboTypes.Text == "Choisir un Type" ))
            {
                ds.Tables.Clear();
                d.da = new SqlDataAdapter("select ouvrage.titre as 'Titre', auteur.nom_auteur as 'Nom auteur', ouvrage.année_édition as 'Année édition', editeur.nom_editeur as 'Nom éditeur', types.nom_type as 'Type Ouvrage' FROM auteur INNER JOIN ouvrage ON auteur.id_auteur = ouvrage.id_auteur INNER JOIN editeur ON ouvrage.id_editeur = editeur.id_editeur INNER JOIN types ON ouvrage.id_type = types.codetype where nom_auteur ='" + comboAuteur.Text + "'", d.cn);
                d.da.Fill(ds, "tt");
                d.dt = ds.Tables["tt"];
                dataGridView1.DataSource = d.dt;
                textAnnée.Text = "";
                comboAuteur.Text = "Choisir un Auteur";
                //return;

                //MessageBox.Show("Choisir un Auteur", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return;
                //if (comboTypes.SelectedItem == null || comboTypes.Text == "Choisir un Type")
                //{
                //    MessageBox.Show("Choisir un Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    return;
                //}

            }
            // hadi ghay9lb b comboTypes et le titre
            else if ((comboTypes.SelectedItem != null && comboTypes.Text != "Choisir un Type" && textTitre.Text != "" && comboAuteur.Text == "Choisir un Auteur") || (comboTypes.SelectedItem != null && comboTypes.Text != "Choisir un Type" && textTitre.Text != "" && comboAuteur.Text != ""))
            {
                ds.Tables.Clear();
                d.da = new SqlDataAdapter("select ouvrage.titre as 'Titre', auteur.nom_auteur as 'Nom auteur', ouvrage.année_édition as 'Année édition', editeur.nom_editeur as 'Nom éditeur', types.nom_type as 'Type Ouvrage' FROM auteur INNER JOIN ouvrage ON auteur.id_auteur = ouvrage.id_auteur INNER JOIN editeur ON ouvrage.id_editeur = editeur.id_editeur INNER JOIN types ON ouvrage.id_type = types.codetype where titre like '" + '%' + textTitre.Text + '%' + "'or nom_type ='" + comboTypes.Text + "'", d.cn);
                d.da.Fill(ds, "tt");
                d.dt = ds.Tables["tt"];
                dataGridView1.DataSource = d.dt;
                textAnnée.Text = "";
            }
            // hadi ghay9lb ghi b comboTypes
            else if ((comboTypes.SelectedItem != null && comboTypes.Text != "Choisir un Type" && textTitre.Text == "" && comboAuteur.Text == "Choisir un Auteur") || (comboTypes.SelectedItem != null && comboTypes.Text != "Choisir un Type" && textTitre.Text == "" && comboAuteur.Text != ""))
            {
                ds.Tables.Clear();
                d.da = new SqlDataAdapter("select ouvrage.titre as 'Titre', auteur.nom_auteur as 'Nom auteur', ouvrage.année_édition as 'Année édition', editeur.nom_editeur as 'Nom éditeur', types.nom_type as 'Type Ouvrage' FROM auteur INNER JOIN ouvrage ON auteur.id_auteur = ouvrage.id_auteur INNER JOIN editeur ON ouvrage.id_editeur = editeur.id_editeur INNER JOIN types ON ouvrage.id_type = types.codetype where nom_type ='" + comboTypes.Text + "'", d.cn);
                d.da.Fill(ds, "tt");
                d.dt = ds.Tables["tt"];
                dataGridView1.DataSource = d.dt;
                textAnnée.Text = "";
                comboTypes.Text = "Choisir un Type";
            }
            if (d.dt.Rows.Count == 0)
            {
                MessageBox.Show("Il n'y a pas d'ouvrages avec ces critères" , "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //d.Vider(this); textTitre.Focus();
        }

        private void BtnRechercheDate_Click(object sender, EventArgs e)
        {
            if (textAnnée.Text == "")
            {
                MessageBox.Show("Remplissez le champ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textAnnée.Text.Length < 4)
            {
                MessageBox.Show("L'année doivent comporter au moins 4 digits", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ds.Tables.Clear();
            d.da = new SqlDataAdapter("select ouvrage.titre as 'Titre Ouvrage', auteur.nom_auteur as 'Nom auteur', ouvrage.année_édition as 'Année édition', editeur.nom_editeur as 'Nom éditeur', types.nom_type as 'Type Ouvrage' FROM auteur INNER JOIN ouvrage ON auteur.id_auteur = ouvrage.id_auteur INNER JOIN editeur ON ouvrage.id_editeur = editeur.id_editeur INNER JOIN types ON ouvrage.id_type = types.codetype where année_édition like '" + '%' + textAnnée.Text + '%' + "'", d.cn);
            d.da.Fill(ds, "tt");
            d.dt = ds.Tables["tt"];
            dataGridView1.DataSource = d.dt;
            comboAuteur.Text = "Choisir un Auteur"; comboTypes.Text = "Choisir un Type";
            textTitre.Text = "";
            if (d.dt.Rows.Count == 0)
            {
                MessageBox.Show("Il n'y a pas d'ouvrages à cette date : " + textAnnée.Text, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            d.Vider(this); comboAuteur.Text = "Choisir un Auteur"; comboTypes.Text = "Choisir un Type";
            textTitre.Focus();

        }

        private void RetourBtn_Click(object sender, EventArgs e)
        {
            Menu M = new Menu();
            M.Show();
            this.Close();

        }

        private void comboAuteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (comboAuteur.SelectedItem == null || comboAuteur.Text == "Choisir un Auteur")
            //{
            //    MessageBox.Show("Choisir un Auteur", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //ds.Tables.Clear();
            //d.da = new SqlDataAdapter("SELECT ouvrage.titre, auteur.nom_auteur, ouvrage.année_édition, editeur.nom_editeur, types.nom_type FROM auteur INNER JOIN ouvrage ON auteur.id_auteur = ouvrage.id_auteur INNER JOIN editeur ON ouvrage.id_editeur = editeur.id_editeur INNER JOIN types ON ouvrage.id_type = types.codetype where nom_auteur = '" + comboAuteur.SelectedValue + "'", d.cn);
            //d.da.Fill(ds, "tt");
            //dataGridView1.DataSource = ds.Tables["tt"];

        }

        private void comboTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (comboTypes.SelectedItem == null || comboTypes.Text == "Choisir un Type")
            //{
            //    MessageBox.Show("Choisir un Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //ds.Tables.Clear();
            //d.da = new SqlDataAdapter("select ouvrage.titre, auteur.nom_auteur, ouvrage.année_édition, editeur.nom_editeur, types.nom_type FROM auteur INNER JOIN ouvrage ON auteur.id_auteur = ouvrage.id_auteur INNER JOIN editeur ON ouvrage.id_editeur = editeur.id_editeur INNER JOIN types ON ouvrage.id_type = types.codetype where nom_type = '" + comboTypes.SelectedValue + "'", d.cn);
            //d.da.Fill(ds, "tt");
            //dataGridView1.DataSource = ds.Tables["tt"];

        }

        private void textAnnée_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            comboAuteur.Text = ""; comboTypes.Text = "";
            textTitre.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            comboAuteur.SelectedText = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textAnnée.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboTypes.SelectedText = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void textTitre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        // if (textTitre.Text != "" || comboAuteur.Text != "Choisir un Auteur" || comboTypes.Text != "Choisir un Type")
        //{
        //    ds.Tables.Clear();
        //    d.da = new SqlDataAdapter("select ouvrage.titre as 'Titre', auteur.nom_auteur as 'Nom auteur', ouvrage.année_édition as 'Année édition', editeur.nom_editeur as 'Nom éditeur', types.nom_type as 'Type Ouvrage' FROM auteur INNER JOIN ouvrage ON auteur.id_auteur = ouvrage.id_auteur INNER JOIN editeur ON ouvrage.id_editeur = editeur.id_editeur INNER JOIN types ON ouvrage.id_type = types.codetype where titre like '" + '%' + textTitre.Text + '%' + "'or nom_auteur ='" + comboAuteur.Text + "'or nom_type = '" + comboTypes.Text + "'", d.cn);
        //    d.da.Fill(ds, "tt");
        //    d.dt = ds.Tables["tt"];
        //    dataGridView1.DataSource = d.dt;
        //    textAnnée.Text = "";
        //    return;
        //}
        //else
        //{
        //    MessageBox.Show("remplire un champ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        //}


    }
}
