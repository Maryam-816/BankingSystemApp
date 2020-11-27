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
            btn_registerSubmit.Click += btn_register_clicked;
            btn_loginSubmit.Click += btn_login_clicked;
            dbContext = new DbContext();
        }
        
        private void btn_login_clicked(object sender, EventArgs e)
        {
            //get data
            string
              email = txbx_loginEmail.Text,//
              password = txbx_loginPassword.Text;//
            //validate data
            //check data - database
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

                else if(currentUser.UserType == UserType.Admin)
                {
                    new MainForm().Show();
                    Hide();
                }
            }
                
            }
            else
            {
                MessageBox.Show("Your email or password is wrong!");
            }
            //go to new form or XXX
        }

        private void btn_register_clicked(object sender, EventArgs e)
        {
            //get data
            string
                 email = txbx_registerEmail.Text,//
                 password = txbx_registerPassword.Text;//

            //register
            
            if(dbContext.Users.FindItem(u => u.Email == email) == null)
            {
                User user = new User { Id = Identificator<User>.GetId(), Email = email, Password = password, UserType = UserType.User };
                dbContext.Users.Add(user);
                MessageBox.Show("You successfully registered!");
            }
           
        }
        private void LogForm_Load(object sender, EventArgs e)
        {

        }
    }
}
