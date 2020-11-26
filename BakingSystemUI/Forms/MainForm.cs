using BakingSystemUI.Core;
using BakingSystemUI.Models;
using BakingSystemUI.Roles;
using BakingSystemUI.Data;
using BakingSystemUI.Validation;
using BakingSystemUI.Controls;
using System.Windows.Forms;

namespace BakingSystemUI.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void lnLbl_settings_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new ConfigureForm().ShowDialog();
        }

        private void lnLbl_myCards_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new CardsForm().ShowDialog();
        }

        private void lnLbl_orderCards_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new CardManagerForm().ShowDialog();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Session.LogForm.Close();
        }
    }
}
