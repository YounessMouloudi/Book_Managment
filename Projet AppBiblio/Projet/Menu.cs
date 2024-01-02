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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        Ado d = new Ado();
        DataSet ds = new DataSet();
        private void Menu_Load(object sender, EventArgs e)
        {
            d.connection();
        }

        private void Ajouter_auteur_Click(object sender, EventArgs e)
        {
            this.Close();
            Auteur A = new Auteur();
            A.Show();
        }

        private void Ajouter_Editeur_Click(object sender, EventArgs e)
        {
            this.Hide();
            Editeur E = new Editeur();
            E.Show();
        }

        private void Ajouter_type_Click(object sender, EventArgs e)
        {
            this.Close();
            TypeOuvrage T = new TypeOuvrage();
            T.Show();
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            this.Close();
            AjouterOuvrage Ajoute = new AjouterOuvrage();
            Ajoute.Show();
        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            this.Close();
            SupprimerOuvrage S = new SupprimerOuvrage();
            S.Show();
        }

        private void BtnRechercher_Click(object sender, EventArgs e)
        {
            this.Close();
            RechercherOuvrage R = new RechercherOuvrage();
            R.Show();
        }

        private void BtnAfficher_Click(object sender, EventArgs e)
        {
            listMenu.Visible = false;
            dataGridView1.Visible = true;
            ds.Tables.Clear();
            //d.da = new SqlDataAdapter("select ouvrage.titre, auteur.nom_auteur , ouvrage.année_édition , editeur.nom_editeur , types.nom_type FROM auteur INNER JOIN ouvrage ON auteur.id_auteur = ouvrage.id_auteur INNER JOIN editeur ON ouvrage.id_editeur = editeur.id_editeur INNER JOIN types ON ouvrage.id_type = types.codetype", d.cn);
            d.da = new SqlDataAdapter("select ouvrage.titre as 'Titre', auteur.nom_auteur as 'Nom auteur', ouvrage.année_édition as 'Année édition', editeur.nom_editeur as 'Nom éditeur', types.nom_type as 'Type Ouvrage' FROM auteur INNER JOIN ouvrage ON auteur.id_auteur = ouvrage.id_auteur INNER JOIN editeur ON ouvrage.id_editeur = editeur.id_editeur INNER JOIN types ON ouvrage.id_type = types.codetype", d.cn);
            d.da.Fill(ds, "afficher");
            dataGridView1.DataSource = ds.Tables["afficher"];
        }
    }
}
