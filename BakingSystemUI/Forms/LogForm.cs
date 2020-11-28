using BakingSystemUI.Core;
using BakingSystemUI.Data;
using BakingSystemUI.Models;
using BakingSystemUI.Roles;
using System;
using System.Windows.Forms;

namespace BakingSystemUI.Forms
{
    public partial class LogForm : Form
    {
        private readonly DbContext dbContext;
        public LogForm()
        {
            InitializeComponent();
            //+
            regLogControl1.btn_submit.Text = "Register";
            regLogControl2.btn_submit.Text = "Login";
            regLogControl1.btn_submit.Click += btn_register_clicked;
            regLogControl2.btn_submit.Click += btn_login_clicked;
            dbContext = new DbContext();
        }

        private void btn_register_clicked(object sender, EventArgs e)
        {
            //get data
            string
                 email = regLogControl1.txbx_email.Text,
                 password = regLogControl1.txbx_password.Text;

            if (dbContext.Users.FindItem(u => u.Email == email) == null)
            {
                User user = new User { Id = Identificator<User>.GetId(), Email = email, Password = password, UserType = UserType.User };
                dbContext.Users.Add(user);
                MessageBox.Show("You successfully registered!");
            }
        }

        private void btn_login_clicked(object sender, EventArgs e)
        {
            //get data
            string
              email = regLogControl2.txbx_email.Text,
              password = regLogControl2.txbx_password.Text;
            //    //validate data
            //    //check data - database
            User currentUser = dbContext.Users.FindItem(u => u.Email == email);
            if (currentUser != null)
            {
                Session.User = currentUser;
                Session.LogForm = this;
                if (currentUser.UserType == UserType.User)
                {

                    //MessageBox.Show("You successfully logged in!");
                    new MainForm().Show();
                    Hide();
                }

                else if (currentUser.UserType == UserType.Admin)
                {
                    new MainForm().Show();
                    Hide();
                }
            }
            else
            {
                MessageBox.Show("Your email or password is wrong!");
            }
        }

        //    //go to new form or XXX
    }

}

