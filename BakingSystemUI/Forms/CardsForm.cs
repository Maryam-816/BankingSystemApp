using BakingSystemUI.Core;
using BakingSystemUI.Managers;
using BakingSystemUI.Data;
using BakingSystemUI.Models;
using BakingSystemUI.Roles;
using System.Configuration;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            //var dgv = sender as DataGridView;
            //dgv.DataSource = Session.Data.Cards.GetAllBy(card => card.CardHolderId == Session.User.Id)
            //                                                   .Select(card => new { card.Id, card.CardHolder, card.Bank, card.CardType, card.CardNumber, card.CVC, card.ExpiredDate})
            //                                                   .ToList();

            using (DatabaseManager db = new DatabaseManager("myDB"))
            {
                db.GetCards();
            }
        }

        private void dgv_cards_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var dgv = sender as DataGridView;

            int idColumn = default;
            if (int.TryParse(dgv[e.ColumnIndex, e.RowIndex].Value.ToString(), out idColumn)
            {
                Card card = null;
                using (DatabaseManager db = new DatabaseManager("myDB"))
                {
                    card = db.GetCardById(idColumn);
                }

                txbx_bank.Text = card.Bank.ToString();
                txbx_number.Text = card.CardNumber.ToString();
                txbx_cvc.Text = card.CVC.ToString();
                txbx_duration.Text = card.Duration.ToString();
                txbx_expiredDate.Text = card.ExpiredDate.ToString();
                txbx_type.Text = card.CardType.ToString();
            }
        }
    }
}
