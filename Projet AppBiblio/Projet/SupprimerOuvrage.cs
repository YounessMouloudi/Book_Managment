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
    public partial class SupprimerOuvrage : Form
    {
        public SupprimerOuvrage()
        {
            InitializeComponent();
        }
        Ado d = new Ado();
        DataSet ds = new DataSet();
        public void Remplircombo()
        {
            d.da = new SqlDataAdapter("select nom_auteur from auteur", d.cn);
            d.da.Fill(ds, "auteur");
            comboAuteur.DataSource = ds.Tables["auteur"];
            comboAuteur.ValueMember = "nom_auteur";
            comboAuteur.DisplayMember = "nom_auteur";
            comboAuteur.Text = "Choisir un Auteur";

            d.da = new SqlDataAdapter("select * from types", d.cn);
            d.da.Fill(ds, "type");
            comboType.DataSource = ds.Tables["type"];
            comboType.ValueMember = "nom_type";
            comboType.DisplayMember = "nom_type";
            comboType.Text = "Choisir un Type";

        }
        public void RemplirGrid()
        {
            ds.Tables.Clear();
            d.da = new SqlDataAdapter("SELECT ouvrage.titre as 'Titre', auteur.nom_auteur as 'Nom auteur',ouvrage.id_auteur , ouvrage.année_édition ,editeur.nom_editeur as 'Nom éditeur', ouvrage.id_editeur , types.nom_type as 'Type Ouvrage' ,ouvrage.id_type FROM auteur INNER JOIN ouvrage ON auteur.id_auteur = ouvrage.id_auteur INNER JOIN editeur ON ouvrage.id_editeur = editeur.id_editeur INNER JOIN types ON ouvrage.id_type = types.codetype", d.cn);
            d.da.Fill(ds, "sup");
            dataGridView1.DataSource = ds.Tables["sup"];
            //for (int i = 0; i < ds.Tables["sup"].Rows.Count; i++)
            //{
            //    dataGridView1.Rows.Add(ds.Tables["sup"].Rows[i][0], ds.Tables["sup"].Rows[i][1], ds.Tables["sup"].Rows[i][2], ds.Tables["sup"].Rows[i][3], ds.Tables["sup"].Rows[i][4], ds.Tables["sup"].Rows[i][5], ds.Tables["sup"].Rows[i][6], ds.Tables["sup"].Rows[i][7]);

            //}
        }
        private void SupprimerOuvrage_Load(object sender, EventArgs e)
        {
            d.connection();
            Remplircombo();
            RemplirGrid();

        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            int c = 0;
            if (dataGridView1.CurrentRow.Selected == true)
            {
                DialogResult a = MessageBox.Show("vous voulez supprimer cet ouvrage ?", "Avertissement", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (a == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        dataGridView1.Rows.Remove(row);
                        c++;
                        d.da = new SqlDataAdapter("SELECT * from ouvrage", d.cn);
                        d.bc = new SqlCommandBuilder(d.da);
                        d.da.Update(ds, "sup");
                    }
                    MessageBox.Show(c + " Ouvrages Supprimée avec Succès.", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textTitre.Clear();
                }
                return;
            }
            MessageBox.Show(" Sélectionner une Ligne ou Plusieurs Lignes ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtnAfficher_Click(object sender, EventArgs e)
        {
            if (textTitre.Text == "")
            {
                comboAuteur.Text = "Choisir un Auteur";
                comboType.Text = "Choisir un Type";
                RemplirGrid();
                return;
            }
            comboAuteur.Text = "Choisir un Auteur";
            comboType.Text = "Choisir un Type";
            ds.Tables.Clear();
            d.da = new SqlDataAdapter("SELECT ouvrage.titre as 'Titre', auteur.nom_auteur as 'Nom auteur',ouvrage.id_auteur as 'ID aut', ouvrage.année_édition as 'Année édition',editeur.nom_editeur as 'Nom éditeur', ouvrage.id_editeur as 'ID edi', types.nom_type as 'Type Ouvrage' ,ouvrage.id_type as 'ID Type' FROM auteur INNER JOIN ouvrage ON auteur.id_auteur = ouvrage.id_auteur INNER JOIN editeur ON ouvrage.id_editeur = editeur.id_editeur INNER JOIN types ON ouvrage.id_type = types.codetype where titre like '" + '%' + textTitre.Text + '%' + "'", d.cn);
            d.da.Fill(ds, "sup");
            dataGridView1.DataSource = ds.Tables["sup"];
            if (ds.Tables["sup"].Rows.Count == 0)
            {
                MessageBox.Show("Il n'y a pas d'ouvrages avec ces lettres : " + textTitre.Text, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            textTitre.Clear(); comboAuteur.Text = "Choisir un Auteur";
            comboType.Text = "Choisir un Type"; textTitre.Focus();
        }

        private void RetourBtn_Click(object sender, EventArgs e)
        {
            Menu M = new Menu();
            M.Show();
            this.Close();
        }

        private void textTitre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) &&!char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void comboAuteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboAuteur.SelectedItem == null || comboAuteur.Text == "Choisir un Auteur")
            {
                MessageBox.Show("Choisir un Auteur", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            textTitre.Clear(); comboType.Text = "Choisir un Type";
            ds.Tables.Clear();
            d.da = new SqlDataAdapter("SELECT ouvrage.titre, auteur.nom_auteur,ouvrage.id_auteur, ouvrage.année_édition,editeur.nom_editeur, ouvrage.id_editeur, types.nom_type ,ouvrage.id_type FROM auteur INNER JOIN ouvrage ON auteur.id_auteur = ouvrage.id_auteur INNER JOIN editeur ON ouvrage.id_editeur = editeur.id_editeur INNER JOIN types ON ouvrage.id_type = types.codetype where nom_auteur = '" + comboAuteur.SelectedValue + "'", d.cn);
            d.da.Fill(ds, "sup");
            dataGridView1.DataSource = ds.Tables["sup"];


        }

        private void comboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboType.SelectedItem == null || comboType.Text == "Choisir un Type")
            {
                MessageBox.Show("Choisir un Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            textTitre.Clear(); comboAuteur.Text = "Choisir un Auteur";
            ds.Tables.Clear();
            d.da = new SqlDataAdapter("SELECT ouvrage.titre, auteur.nom_auteur,ouvrage.id_auteur, ouvrage.année_édition,editeur.nom_editeur, ouvrage.id_editeur, types.nom_type ,ouvrage.id_type FROM auteur INNER JOIN ouvrage ON auteur.id_auteur = ouvrage.id_auteur INNER JOIN editeur ON ouvrage.id_editeur = editeur.id_editeur INNER JOIN types ON ouvrage.id_type = types.codetype where nom_type = '" + comboType.SelectedValue + "'", d.cn);
            d.da.Fill(ds, "sup");
            dataGridView1.DataSource = ds.Tables["sup"];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
