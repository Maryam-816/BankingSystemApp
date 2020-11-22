using BakingSystemUI.Models;
using BakingSystemUI.Roles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BakingSystemUI.Forms
{
    public partial class LogForm : Form
    {
        public LogForm()
        {
            InitializeComponent();

            btn_registerSubmit.Click += btn_register_clicked;
            btn_loginSubmit.Click += btn_login_clicked;
        }

        private void btn_login_clicked(object sender, EventArgs e)
        {
              //get data
             //validate data
            //check data - database
           //go to new form or XXX
        }

        private void btn_register_clicked(object sender, EventArgs e)
        {
            //get data
            string
                 email = txbx_registerEmail.Text,
                 password = txbx_registerPassword.Text;
        }
        //validate data

        //register
        User user = new User { Email = email, Password = password, UserType = UserType.User };
        MessageBox.Show("You successfully registered!");

       

        private void LogForm_Load(object sender, EventArgs e)
        {

        }
    }
}
