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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        Ado d = new Ado();
        DataSet ds = new DataSet();
        private void Login_Load(object sender, EventArgs e)
        {
            d.connection();
            d.da = new SqlDataAdapter("select * from Utilisateurs", d.cn);
            d.da.Fill(ds, "user");
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (textUser.Text == "" || textPassword.Text == "")
            {
                MessageBox.Show("Remplissez tous les champs", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textUser.Text.Length < 6)
            {
                MessageBox.Show("Votre UserName doivent comporter au moins 6 caractères", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            for (int i = 0; i < ds.Tables["user"].Rows.Count; i++)
            {
                if (textUser.Text == ds.Tables["user"].Rows[i][0].ToString() && textPassword.Text == ds.Tables["user"].Rows[i][1].ToString())
                {
                    MessageBox.Show("Bienvenue dans votre bibliothèque " + textUser.Text, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Menu M = new Menu();
                    M.Show();
                    this.Hide();
                    return;
                }
            }
            MessageBox.Show("            Votre MOT DE PASSE ou Nom Utilisateur Erroné \n\n Si vous n'êtes pas inscrit, inscrivez-vous, pour vous connecter", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void BtnSign_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inscription I = new Inscription();
            I.Show();

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            d.Vider(this);textUser.Focus();checkBox1.Checked = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textPassword.PasswordChar = '\0';
            }
            else
            {
                textPassword.PasswordChar = '*';
            }
        }

        private void textUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Controle de saisie => saisir juste des lettres ,digits et espace et control( ex: back)

            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '_'))
            {
                e.Handled = true;
            }
            //e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }
    }
}
