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
    public partial class TypeOuvrage : Form
    {
        public TypeOuvrage()
        {
            InitializeComponent();
        }
        Ado d = new Ado();
        DataSet ds = new DataSet();
        private void TypeOuvrage_Load(object sender, EventArgs e)
        {
            d.connection();
            ds.Tables.Clear();
            d.da = new SqlDataAdapter("select codetype as 'Id Type',nom_type as 'Nom Type' from types", d.cn);
            d.da.Fill(ds, "type");
            dataGridView1.DataSource = ds.Tables["type"];
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            if (textID.Text == "" || textNom.Text == "")
            {
                MessageBox.Show("Remplissez tous les champs", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataRow dr = ds.Tables["type"].NewRow();
            dr[0] = textID.Text;
            dr[1] = textNom.Text;
            for (int i = 0; i < ds.Tables["type"].Rows.Count; i++)
            {
                if (textID.Text == ds.Tables["type"].Rows[i][0].ToString())
                {
                    MessageBox.Show("Ce Type déjà existe", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            ds.Tables["type"].Rows.Add(dr);
            d.bc = new SqlCommandBuilder(d.da);
            d.da.Update(ds, "type");
            MessageBox.Show("Type Ajouté avec Succés.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            d.Vider(this); textID.Focus();
        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            if (textID.Text == "" || textNom.Text == "")
            {
                MessageBox.Show("Remplissez tous les champs", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = 0; i < ds.Tables["type"].Rows.Count; i++)
            {
                if (textID.Text == ds.Tables["type"].Rows[i][0].ToString())
                {
                    ds.Tables["type"].Rows[i][1] = textNom.Text;
                    d.bc = new SqlCommandBuilder(d.da);
                    d.da.Update(ds, "type");
                    MessageBox.Show("Type Modifié avec Succès.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    d.Vider(this); textID.Focus();
                    return;
                }
            }
            MessageBox.Show("Ce Type n'existe pas.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            if (textID.Text == "")
            {
                MessageBox.Show("Remplissez le champ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = 0; i < ds.Tables["type"].Rows.Count; i++)
            {
                if (textID.Text == ds.Tables["type"].Rows[i][0].ToString())
                {
                    DialogResult a = MessageBox.Show("Vous Voulez Supprimer Ce Type ?", "avertissement", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (a == DialogResult.Yes)
                    {
                        ds.Tables["type"].Rows[i].Delete();
                        d.bc = new SqlCommandBuilder(d.da);
                        d.da.Update(ds, "type");
                        MessageBox.Show("Type Supprimé avec Succès.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        d.Vider(this); textID.Focus();
                        return;
                    }
                    return;
                }
            }
            MessageBox.Show("Ce Type n'existe pas.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            textID.Clear(); textNom.Clear(); textID.Focus();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            Menu M = new Menu();
            M.Show();
            this.Close();
        }

        private void textID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textNom.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
