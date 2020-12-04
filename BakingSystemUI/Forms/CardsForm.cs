using BakingSystemUI.Core;
using BakingSystemUI.Managers;
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
    public partial class CardsForm : Form
    {
        public CardsForm()
        {
            InitializeComponent();
        }

        private void CardsForm_Load(object sender, EventArgs e)
        {
            //get all cards by User's id
            var dgv = sender as DataGridView;
            dgv.DataSource = Session.Data.Cards.GetAllBy(card => card.CardHolderId == Session.User.Id)
                                                               .Select(card => new { card.Id, card.CardHolder, card.Bank, card.CardType, card.CardNumber, card.CVC, card.ExpiredDate})
                                                               .ToList();
        }

        private void dgv_cards_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("");
        }
    }
}
