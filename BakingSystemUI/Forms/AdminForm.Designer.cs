namespace BakingSystemUI.Forms
{
    partial class AdminForm
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
            this.grbx_stats = new System.Windows.Forms.GroupBox();
            this.lnLbl_cards = new System.Windows.Forms.LinkLabel();
            this.lnLbl_users = new System.Windows.Forms.LinkLabel();
            this.lnLbl_refresh = new System.Windows.Forms.LinkLabel();
            this.lnLbl_logOut = new System.Windows.Forms.LinkLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grbx_stats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbx_stats
            // 
            this.grbx_stats.Controls.Add(this.lnLbl_refresh);
            this.grbx_stats.Controls.Add(this.lnLbl_logOut);
            this.grbx_stats.Controls.Add(this.lnLbl_cards);
            this.grbx_stats.Controls.Add(this.lnLbl_users);
            this.grbx_stats.Location = new System.Drawing.Point(4, 2);
            this.grbx_stats.Name = "grbx_stats";
            this.grbx_stats.Size = new System.Drawing.Size(629, 68);
            this.grbx_stats.TabIndex = 4;
            this.grbx_stats.TabStop = false;
            this.grbx_stats.Text = "Stats";
            // 
            // lnLbl_cards
            // 
            this.lnLbl_cards.AutoSize = true;
            this.lnLbl_cards.Location = new System.Drawing.Point(101, 30);
            this.lnLbl_cards.Name = "lnLbl_cards";
            this.lnLbl_cards.Size = new System.Drawing.Size(34, 13);
            this.lnLbl_cards.TabIndex = 1;
            this.lnLbl_cards.TabStop = true;
            this.lnLbl_cards.Text = "Cards";
            this.lnLbl_cards.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnLbl_cards_LinkClicked);
            // 
            // lnLbl_users
            // 
            this.lnLbl_users.AutoSize = true;
            this.lnLbl_users.Location = new System.Drawing.Point(15, 30);
            this.lnLbl_users.Name = "lnLbl_users";
            this.lnLbl_users.Size = new System.Drawing.Size(34, 13);
            this.lnLbl_users.TabIndex = 0;
            this.lnLbl_users.TabStop = true;
            this.lnLbl_users.Text = "Users";
            this.lnLbl_users.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnLbl_users_LinkClicked);
            // 
            // lnLbl_refresh
            // 
            this.lnLbl_refresh.AutoSize = true;
            this.lnLbl_refresh.Location = new System.Drawing.Point(539, 16);
            this.lnLbl_refresh.Name = "lnLbl_refresh";
            this.lnLbl_refresh.Size = new System.Drawing.Size(44, 13);
            this.lnLbl_refresh.TabIndex = 3;
            this.lnLbl_refresh.TabStop = true;
            this.lnLbl_refresh.Text = "Refresh";
            this.lnLbl_refresh.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnLbl_refresh_LinkClicked);
            // 
            // lnLbl_logOut
            // 
            this.lnLbl_logOut.AutoSize = true;
            this.lnLbl_logOut.Location = new System.Drawing.Point(562, 41);
            this.lnLbl_logOut.Name = "lnLbl_logOut";
            this.lnLbl_logOut.Size = new System.Drawing.Size(42, 13);
            this.lnLbl_logOut.TabIndex = 2;
            this.lnLbl_logOut.TabStop = true;
            this.lnLbl_logOut.Text = "LogOut";
            this.lnLbl_logOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnLbl_logOut_LinkClicked);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(650, 281);
            this.dataGridView1.TabIndex = 5;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 358);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grbx_stats);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.grbx_stats.ResumeLayout(false);
            this.grbx_stats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbx_stats;
        private System.Windows.Forms.LinkLabel lnLbl_refresh;
        private System.Windows.Forms.LinkLabel lnLbl_logOut;
        private System.Windows.Forms.LinkLabel lnLbl_cards;
        private System.Windows.Forms.LinkLabel lnLbl_users;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}