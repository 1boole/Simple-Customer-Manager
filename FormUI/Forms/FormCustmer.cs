using FormUI.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI.Forms
{
    public partial class FormCustmer : Form
    {
        public FormCustmer()
        {
            InitializeComponent();
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            txtId.Enabled = false;
            var datasource= ApiConnect.LoadCustomer("*");
            lblSuccessStatus.Text = datasource.message;
            dataGrid.DataSource = datasource.data;

        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGrid.CurrentRow.Selected = true;
            txtId.Text = dataGrid.Rows[e.RowIndex].Cells["id"].Value.ToString();
            txtCustomerCode.Text = dataGrid.Rows[e.RowIndex].Cells["code"].Value.ToString();
            txtCustomerName.Text = dataGrid.Rows[e.RowIndex].Cells["name"].Value.ToString();
            txtCustomerCity.Text = dataGrid.Rows[e.RowIndex].Cells["city"].Value.ToString();
        }
    }
}
