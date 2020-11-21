﻿namespace BakingSystemUI.Forms
{
    partial class ConfigureForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbx_user = new System.Windows.Forms.GroupBox();
            this.lbl_age = new System.Windows.Forms.Label();
            this.lbl_surname = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.grbx_cards = new System.Windows.Forms.GroupBox();
            this.lnLbl_orderCards = new System.Windows.Forms.LinkLabel();
            this.lnLbl_myCards = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.grbx_user.SuspendLayout();
            this.grbx_cards.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbx_user
            // 
            this.grbx_user.Controls.Add(this.lbl_age);
            this.grbx_user.Controls.Add(this.lbl_surname);
            this.grbx_user.Controls.Add(this.lbl_name);
            this.grbx_user.Location = new System.Drawing.Point(12, 46);
            this.grbx_user.Name = "grbx_user";
            this.grbx_user.Size = new System.Drawing.Size(187, 113);
            this.grbx_user.TabIndex = 0;
            this.grbx_user.TabStop = false;
            this.grbx_user.Text = "User";
            this.grbx_user.Enter += new System.EventHandler(this.grbx_user_Enter);
            // 
            // lbl_age
            // 
            this.lbl_age.AutoSize = true;
            this.lbl_age.Location = new System.Drawing.Point(6, 84);
            this.lbl_age.Name = "lbl_age";
            this.lbl_age.Size = new System.Drawing.Size(32, 13);
            this.lbl_age.TabIndex = 3;
            this.lbl_age.Text = "Age: ";
            // 
            // lbl_surname
            // 
            this.lbl_surname.AutoSize = true;
            this.lbl_surname.Location = new System.Drawing.Point(6, 55);
            this.lbl_surname.Name = "lbl_surname";
            this.lbl_surname.Size = new System.Drawing.Size(55, 13);
            this.lbl_surname.TabIndex = 2;
            this.lbl_surname.Text = "Surname: ";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(6, 26);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(41, 13);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "Name: ";
            // 
            // grbx_cards
            // 
            this.grbx_cards.Controls.Add(this.lnLbl_orderCards);
            this.grbx_cards.Controls.Add(this.lnLbl_myCards);
            this.grbx_cards.Location = new System.Drawing.Point(12, 210);
            this.grbx_cards.Name = "grbx_cards";
            this.grbx_cards.Size = new System.Drawing.Size(200, 100);
            this.grbx_cards.TabIndex = 1;
            this.grbx_cards.TabStop = false;
            this.grbx_cards.Text = "Cards";
            // 
            // lnLbl_orderCards
            // 
            this.lnLbl_orderCards.AutoSize = true;
            this.lnLbl_orderCards.Location = new System.Drawing.Point(9, 68);
            this.lnLbl_orderCards.Name = "lnLbl_orderCards";
            this.lnLbl_orderCards.Size = new System.Drawing.Size(62, 13);
            this.lnLbl_orderCards.TabIndex = 1;
            this.lnLbl_orderCards.TabStop = true;
            this.lnLbl_orderCards.Text = "Order cards";
            // 
            // lnLbl_myCards
            // 
            this.lnLbl_myCards.AutoSize = true;
            this.lnLbl_myCards.Location = new System.Drawing.Point(9, 31);
            this.lnLbl_myCards.Name = "lnLbl_myCards";
            this.lnLbl_myCards.Size = new System.Drawing.Size(50, 13);
            this.lnLbl_myCards.TabIndex = 0;
            this.lnLbl_myCards.TabStop = true;
            this.lnLbl_myCards.Text = "My cards";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // ConfigureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 328);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grbx_cards);
            this.Controls.Add(this.grbx_user);
            this.Name = "ConfigureForm";
            this.Text = "ConfigureForm";
            this.grbx_user.ResumeLayout(false);
            this.grbx_user.PerformLayout();
            this.grbx_cards.ResumeLayout(false);
            this.grbx_cards.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbx_user;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_age;
        private System.Windows.Forms.Label lbl_surname;
        private System.Windows.Forms.GroupBox grbx_cards;
        private System.Windows.Forms.LinkLabel lnLbl_orderCards;
        private System.Windows.Forms.LinkLabel lnLbl_myCards;
        private System.Windows.Forms.Label label1;
    }
}