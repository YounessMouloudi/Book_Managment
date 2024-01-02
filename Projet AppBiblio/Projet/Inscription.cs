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
    public partial class Inscription : Form
    {
        public Inscription()
        {
            InitializeComponent();
        }
        Ado d = new Ado();
        DataSet ds = new DataSet();
        private void Inscription_Load(object sender, EventArgs e)
        {
            d.connection();
            ds.Tables.Clear();
            d.da = new SqlDataAdapter("select * from utilisateurs", d.cn);
            d.da.Fill(ds, "utilisateurs");
            comboVille.Text = "Choisir une ville";

        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            if (textUser.Text == "" || textPassword.Text == "" || comboVille.Text == "" || textTelephone.Text == "")
            {
                MessageBox.Show("Remplissez tous les champs", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboVille.SelectedItem == null || comboVille.Text == "Choisir une ville")
            {
                MessageBox.Show("Choisir une ville", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textUser.Text.Length < 6)
            {
                MessageBox.Show("Votre UserName doivent comporter au moins 6 caractères", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textPassword.Text.Length < 6)
            {
                MessageBox.Show("Votre PASSWORD doivent comporter au moins 6 caractères", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textTelephone.Text.Length < 10)
            {
                MessageBox.Show("Votre Telephone doivent comporter 10 digits", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!textTelephone.Text.StartsWith("06") && !textTelephone.Text.StartsWith("07"))
            {
                MessageBox.Show("Votre Telephone doit commencer par 06 ou 07", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            for (int i = 0; i < ds.Tables["utilisateurs"].Rows.Count; i++)
            {
                if (textUser.Text == ds.Tables["utilisateurs"].Rows[i][0].ToString())
                {
                    MessageBox.Show("Cette UserName déjà existe", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            d.cmd = new SqlCommand("insert into utilisateurs values('" + textUser.Text.ToLower() + "','" + textPassword.Text + "','" + comboVille.Text + "','" + textTelephone.Text + "')", d.cn);
            d.cmd.ExecuteNonQuery();
            MessageBox.Show("inscription avec succès", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Login L = new Login();
            this.Close();
            MessageBox.Show("Merci de connecter de nouveau", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            L.Show();

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            d.Vider(this); comboVille.Text = "Choisir une ville"; textUser.Focus();
        }

        private void textUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit (e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '_'))
            {
                e.Handled = true;
            }
        }

        private void textTelephone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void RetourBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Login L = new Login();
            L.Show();
        }
    }
}
