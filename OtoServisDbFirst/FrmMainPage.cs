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
using BusinessLayer;

namespace OtoServisDbFirst
{
    public partial class FrmMainPage : Form
    {
        public FrmMainPage()
        {
            InitializeComponent();
        }

        DbOtoServisEntities entities = new DbOtoServisEntities();

        public void List()
        {
            dataGridView1.DataSource = BLCustomer.BLCustomerList();
        }

        private void FrmMainPage_Load(object sender, EventArgs e)
        {
            lblAdminInfo.Text = FrmLogin.AdminName;
            txtAdmin.Text = FrmLogin.AdminName;

            //---------------
            List();

            //------

            cmbBrand.DataSource = entities.TblBrand.ToList();
            cmbBrand.DisplayMember="BrandName";
            cmbBrand.ValueMember = "BrandId";

            //------

            cmbMechanic.DataSource = entities.TblMechanic.ToList();
            cmbMechanic.DisplayMember = "MechanicName";
            cmbMechanic.ValueMember = "MechanicId";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TblCustomer tblCustomer = new TblCustomer();

            tblCustomer.CustomerName = txtName.Text;
            tblCustomer.CustomerSurname = txtSurname.Text;
            tblCustomer.CustomerPhone = mskPhone.Text;
            tblCustomer.CustomerCarPlateNumber = txtPlate.Text;
            tblCustomer.CustomerDeliveryDate = Convert.ToDateTime(mskDeliveryDate.Text);
            tblCustomer.CustomerBringDate = Convert.ToDateTime(mskBringDate.Text);
            tblCustomer.CustomerCarBrandId = Convert.ToInt32(cmbBrand.SelectedValue);
            tblCustomer.CustomerMechanicId = Convert.ToInt32(cmbMechanic.SelectedValue);
            tblCustomer.CustomerCarBrandId = Convert.ToInt32(txtAdmin.Text);
            tblCustomer.CustomerRequest = richTextBox1.Text;

            BLCustomer.BLAddCustomer(tblCustomer);

            //------------------------------------------------------------------------

            string d1 = "", d2 = "";

            Connection.connection.Open();

            SqlCommand command = new SqlCommand("select top(1) * from TblCustomer order by customerId desc", Connection.connection);

            SqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                d1 = dataReader["customerId"].ToString();
                d2 = dataReader["customerRequest"].ToString();
            }

            Connection.connection.Close();

            //---------------------------------------------

            TblHistory tblHistory = new TblHistory();

            BLCustomer.BLAddHistory(tblHistory, d1, d2);

            //---------------------------------------------
            List();
            MessageBox.Show("Müşteri eklendi.");

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            BLCustomer.BLDeleteCustomer(id);

            MessageBox.Show("Kayıt başarılı bir şekilde silindi");

            List();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            TblCustomer tblCustomer = new TblCustomer();
            BLCustomer.BLUpdateCustomer(tblCustomer, id);

            dataGridView1.DataSource = BLCustomer.BLCustomerList();
        }

        private void btnSearchByName_Click(object sender, EventArgs e)
        {
            string customerName = txtName.Text;
            var values = entities.TblCustomer.Where(y => y.CustomerName == customerName).ToList();
            dataGridView1.DataSource = values;
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            List();
        }
      
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtName.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSurname.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();

            mskPhone.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mskBringDate.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            mskDeliveryDate.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();

            richTextBox1.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();

            cmbBrand.SelectedText = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            cmbMechanic.SelectedText = dataGridView1.Rows[secilen].Cells[8].Value.ToString();

            txtAdmin.Text = dataGridView1.Rows[secilen].Cells[9].Value.ToString();

            txtPlate.Text = dataGridView1.Rows[secilen].Cells[10].Value.ToString();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            FrmCustomerHistory fch = new FrmCustomerHistory();
            fch.Show();
            this.Hide();
        }
    }
}
