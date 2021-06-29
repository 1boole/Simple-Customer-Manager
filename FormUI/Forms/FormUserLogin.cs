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
    public partial class FormUserLogin : Form
    {
        public FormUserLogin()
        {
            InitializeComponent();
        }

        private void FormUserLogin_Load(object sender, EventArgs e)
        {

        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            //var userLoginStatus = ApiConnect.UserLogin(txtUserCode.Text, txtUserPass.Text);
            //lblStatus.Text = userLoginStatus;
            //var result = string.Join(" \n", ApiConnect.Test3().Result);


            var response = await ApiConnect.UserLogin(txtUserCode.Text, txtUserPass.Text);
            dynamic result = ApiConnect.ReadJson(response);
            lblStatus.Text = result.message;
            
        }
    }
}