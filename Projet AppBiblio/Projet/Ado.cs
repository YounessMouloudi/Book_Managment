using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet
{
    class Ado
    {
        public SqlConnection cn = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        public SqlDataAdapter da; public SqlDataAdapter da1;
        public DataTable dt = new DataTable();
        //public SqlDataReader dr;
        public SqlCommandBuilder bc;
        public void connection()
        {
            if (cn.State == ConnectionState.Closed || cn.State == ConnectionState.Broken)
            {
                cn.ConnectionString = @"Data Source=DESKTOP-QGT8PVU\SQLEXPRESS;Initial Catalog=gestionBiblio;Integrated Security=True";
                cn.Open();
            }
        }
        public void deconnection()
        {
            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
        }
        public void Vider(Control f)
        {
            foreach (Control ct in f.Controls)
            {
                if (ct.GetType() == typeof(TextBox))
                {
                    ct.Text = "";
                }
                if (ct.Controls.Count != 0)
                {
                    Vider(ct);
                }
            }
        }
        //public void form()
        //{
        //    foreach  (Form f in Application.OpenForms)
        //    {
        //        if (f)
        //        {
        //            f.Close();
        //        }
        //    }
        //}
    }
}
