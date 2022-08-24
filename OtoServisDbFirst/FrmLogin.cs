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
using EntityLayer;
using FacadeLayer;

namespace OtoServisDbFirst
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        

        DbOtoServisEntities entities = new DbOtoServisEntities();
        public static string AdminName;
        public static string AdminId;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Connection.connection.Open();

            string query = "select * from TblAdmin where AdminName='" + txtName.Text.Trim() + "'and AdminPassword='" + txtPassword.Text.Trim() + "'";

            SqlDataAdapter sda = new SqlDataAdapter(query, Connection.connection);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            Connection.connection.Close();

            if (dt.Rows.Count == 1)
            {
                AdminName = txtName.Text;

                //----------------------------------------------------

                string d1 = "";

                Connection.connection.Open();

                SqlCommand command2 = new SqlCommand("select * from TblAdmin where AdminName='" + txtName.Text.Trim() + "'", Connection.connection);

                SqlDataReader dataReader = command2.ExecuteReader();

                while (dataReader.Read())
                {
                    d1 = dataReader["AdminId"].ToString();
                }

                Connection.connection.Close();

                AdminId = d1;

                //-------------------------------
                FrmMainPage mp = new FrmMainPage();
                mp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("HATALI GİRİŞ");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
