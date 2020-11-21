﻿namespace BakingSystemUI.Forms
{
    partial class CardsForm
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
            this.grbx_card = new System.Windows.Forms.GroupBox();
            this.btn_order = new System.Windows.Forms.Button();
            this.txbx_expiredDate = new System.Windows.Forms.TextBox();
            this.lbl_expiredDate = new System.Windows.Forms.Label();
            this.txbx_duration = new System.Windows.Forms.TextBox();
            this.lbl_duration = new System.Windows.Forms.Label();
            this.txbx_type = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbx_number = new System.Windows.Forms.TextBox();
            this.lbl_number = new System.Windows.Forms.Label();
            this.txbx_cvc = new System.Windows.Forms.TextBox();
            this.lbl_cvc = new System.Windows.Forms.Label();
            this.txbx_bank = new System.Windows.Forms.TextBox();
            this.lbl_bank = new System.Windows.Forms.Label();
            this.grbx_card.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbx_card
            // 
            this.grbx_card.Controls.Add(this.btn_order);
            this.grbx_card.Controls.Add(this.txbx_expiredDate);
            this.grbx_card.Controls.Add(this.lbl_expiredDate);
            this.grbx_card.Controls.Add(this.txbx_duration);
            this.grbx_card.Controls.Add(this.lbl_duration);
            this.grbx_card.Controls.Add(this.txbx_type);
            this.grbx_card.Controls.Add(this.label5);
            this.grbx_card.Controls.Add(this.txbx_number);
            this.grbx_card.Controls.Add(this.lbl_number);
            this.grbx_card.Controls.Add(this.txbx_cvc);
            this.grbx_card.Controls.Add(this.lbl_cvc);
            this.grbx_card.Controls.Add(this.txbx_bank);
            this.grbx_card.Controls.Add(this.lbl_bank);
            this.grbx_card.Location = new System.Drawing.Point(309, 12);
            this.grbx_card.Name = "grbx_card";
            this.grbx_card.Size = new System.Drawing.Size(280, 288);
            this.grbx_card.TabIndex = 2;
            this.grbx_card.TabStop = false;
            this.grbx_card.Text = "Card";
            // 
            // btn_order
            // 
            this.btn_order.Location = new System.Drawing.Point(89, 234);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(153, 48);
            this.btn_order.TabIndex = 14;
            this.btn_order.Text = "Order";
            this.btn_order.UseVisualStyleBackColor = true;
            // 
            // txbx_expiredDate
            // 
            this.txbx_expiredDate.Location = new System.Drawing.Point(89, 199);
            this.txbx_expiredDate.Multiline = true;
            this.txbx_expiredDate.Name = "txbx_expiredDate";
            this.txbx_expiredDate.Size = new System.Drawing.Size(153, 20);
            this.txbx_expiredDate.TabIndex = 13;
            // 
            // lbl_expiredDate
            // 
            this.lbl_expiredDate.AutoSize = true;
            this.lbl_expiredDate.Location = new System.Drawing.Point(9, 206);
            this.lbl_expiredDate.Name = "lbl_expiredDate";
            this.lbl_expiredDate.Size = new System.Drawing.Size(74, 13);
            this.lbl_expiredDate.TabIndex = 12;
            this.lbl_expiredDate.Text = "Expired Date: ";
            // 
            // txbx_duration
            // 
            this.txbx_duration.Location = new System.Drawing.Point(89, 59);
            this.txbx_duration.Multiline = true;
            this.txbx_duration.Name = "txbx_duration";
            this.txbx_duration.Size = new System.Drawing.Size(153, 20);
            this.txbx_duration.TabIndex = 11;
            // 
            // lbl_duration
            // 
            this.lbl_duration.AutoSize = true;
            this.lbl_duration.Location = new System.Drawing.Point(6, 66);
            this.lbl_duration.Name = "lbl_duration";
            this.lbl_duration.Size = new System.Drawing.Size(53, 13);
            this.lbl_duration.TabIndex = 10;
            this.lbl_duration.Text = "Duration: ";
            // 
            // txbx_type
            // 
            this.txbx_type.Location = new System.Drawing.Point(89, 94);
            this.txbx_type.Multiline = true;
            this.txbx_type.Name = "txbx_type";
            this.txbx_type.Size = new System.Drawing.Size(153, 20);
            this.txbx_type.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Type: ";
            // 
            // txbx_number
            // 
            this.txbx_number.Location = new System.Drawing.Point(89, 129);
            this.txbx_number.Multiline = true;
            this.txbx_number.Name = "txbx_number";
            this.txbx_number.Size = new System.Drawing.Size(153, 20);
            this.txbx_number.TabIndex = 7;
            // 
            // lbl_number
            // 
            this.lbl_number.AutoSize = true;
            this.lbl_number.Location = new System.Drawing.Point(6, 136);
            this.lbl_number.Name = "lbl_number";
            this.lbl_number.Size = new System.Drawing.Size(50, 13);
            this.lbl_number.TabIndex = 6;
            this.lbl_number.Text = "Number: ";
            // 
            // txbx_cvc
            // 
            this.txbx_cvc.Location = new System.Drawing.Point(89, 164);
            this.txbx_cvc.Multiline = true;
            this.txbx_cvc.Name = "txbx_cvc";
            this.txbx_cvc.Size = new System.Drawing.Size(153, 20);
            this.txbx_cvc.TabIndex = 5;
            // 
            // lbl_cvc
            // 
            this.lbl_cvc.AutoSize = true;
            this.lbl_cvc.Location = new System.Drawing.Point(9, 171);
            this.lbl_cvc.Name = "lbl_cvc";
            this.lbl_cvc.Size = new System.Drawing.Size(34, 13);
            this.lbl_cvc.TabIndex = 4;
            this.lbl_cvc.Text = "CVC: ";
            // 
            // txbx_bank
            // 
            this.txbx_bank.Location = new System.Drawing.Point(90, 23);
            this.txbx_bank.Multiline = true;
            this.txbx_bank.Name = "txbx_bank";
            this.txbx_bank.Size = new System.Drawing.Size(153, 20);
            this.txbx_bank.TabIndex = 1;
            // 
            // lbl_bank
            // 
            this.lbl_bank.AutoSize = true;
            this.lbl_bank.Location = new System.Drawing.Point(6, 30);
            this.lbl_bank.Name = "lbl_bank";
            this.lbl_bank.Size = new System.Drawing.Size(38, 13);
            this.lbl_bank.TabIndex = 0;
            this.lbl_bank.Text = "Bank: ";
            // 
            // CardsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 323);
            this.Controls.Add(this.grbx_card);
            this.Name = "CardsForm";
            this.Text = "CardsForm";
            this.grbx_card.ResumeLayout(false);
            this.grbx_card.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbx_card;
        private System.Windows.Forms.Button btn_order;
        private System.Windows.Forms.TextBox txbx_expiredDate;
        private System.Windows.Forms.Label lbl_expiredDate;
        private System.Windows.Forms.TextBox txbx_duration;
        private System.Windows.Forms.Label lbl_duration;
        private System.Windows.Forms.TextBox txbx_type;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbx_number;
        private System.Windows.Forms.Label lbl_number;
        private System.Windows.Forms.TextBox txbx_cvc;
        private System.Windows.Forms.Label lbl_cvc;
        private System.Windows.Forms.TextBox txbx_bank;
        private System.Windows.Forms.Label lbl_bank;
    }
}