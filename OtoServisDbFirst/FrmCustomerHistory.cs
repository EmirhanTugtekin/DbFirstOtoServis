using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using OtoServisDbFirst;

namespace OtoServisDbFirst
{
    public partial class FrmCustomerHistory : Form
    {
        public FrmCustomerHistory()
        {
            InitializeComponent();
        }

        DbOtoServisEntities entities = new DbOtoServisEntities();

        public void list()
        {
            var values = from x in entities.TblHistory
                         select new
                         {
                             x.Id,
                             x.TblCustomer.CustomerName,
                             x.Info
                         };
            dataGridView1.DataSource = values.ToList();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmMainPage fmp = new FrmMainPage();
            fmp.Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            list();
        }
    }
}
