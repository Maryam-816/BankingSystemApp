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
           
        }

        private void btn_register_clicked(object sender, EventArgs e)
        {
           
        }

        private void LogForm_Load(object sender, EventArgs e)
        {

        }
    }
}
