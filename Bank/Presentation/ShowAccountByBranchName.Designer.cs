﻿
namespace BankManagementSystem.Presentation_Layer
{
    partial class ShowAccountByBranchName
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowAccountByBranchName));
            this.Titlepanel = new System.Windows.Forms.Panel();
            this.BackpictureBox = new System.Windows.Forms.PictureBox();
            this.Minimizelabel1 = new System.Windows.Forms.Label();
            this.Maximizelabel1 = new System.Windows.Forms.Label();
            this.Crosslabel1 = new System.Windows.Forms.Label();
            this.Titlelabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ShowAllAccountlabel = new System.Windows.Forms.Label();
            this.BranchNamelabel = new System.Windows.Forms.Label();
            this.BranchNamecomboBox = new System.Windows.Forms.ComboBox();
            this.AccountsdataGridView = new System.Windows.Forms.DataGridView();
            this.BalancetextBox = new System.Windows.Forms.TextBox();
            this.Balancelabel = new System.Windows.Forms.Label();
            this.AccountNametextBox = new System.Windows.Forms.TextBox();
            this.AccountNamelabel = new System.Windows.Forms.Label();
            this.Titlepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountsdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Titlepanel
            // 
            this.Titlepanel.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.Titlepanel.Controls.Add(this.BackpictureBox);
            this.Titlepanel.Controls.Add(this.Minimizelabel1);
            this.Titlepanel.Controls.Add(this.Maximizelabel1);
            this.Titlepanel.Controls.Add(this.Crosslabel1);
            this.Titlepanel.Controls.Add(this.Titlelabel);
            this.Titlepanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Titlepanel.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titlepanel.ForeColor = System.Drawing.Color.White;
            this.Titlepanel.Location = new System.Drawing.Point(0, 0);
            this.Titlepanel.Name = "Titlepanel";
            this.Titlepanel.Size = new System.Drawing.Size(798, 71);
            this.Titlepanel.TabIndex = 5;
            // 
            // BackpictureBox
            // 
            this.BackpictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.BackpictureBox.Image = ((System.Drawing.Image)(resources.GetObject("BackpictureBox.Image")));
            this.BackpictureBox.Location = new System.Drawing.Point(0, 0);
            this.BackpictureBox.Name = "BackpictureBox";
            this.BackpictureBox.Size = new System.Drawing.Size(33, 71);
            this.BackpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BackpictureBox.TabIndex = 5;
            this.BackpictureBox.TabStop = false;
            this.BackpictureBox.Click += new System.EventHandler(this.BackpictureBox_Click);
            // 
            // Minimizelabel1
            // 
            this.Minimizelabel1.AutoSize = true;
            this.Minimizelabel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.Minimizelabel1.ForeColor = System.Drawing.Color.Green;
            this.Minimizelabel1.Location = new System.Drawing.Point(738, 0);
            this.Minimizelabel1.Name = "Minimizelabel1";
            this.Minimizelabel1.Size = new System.Drawing.Size(20, 18);
            this.Minimizelabel1.TabIndex = 3;
            this.Minimizelabel1.Text = "O";
            this.Minimizelabel1.Click += new System.EventHandler(this.Minimizelabel1_Click);
            // 
            // Maximizelabel1
            // 
            this.Maximizelabel1.AutoSize = true;
            this.Maximizelabel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.Maximizelabel1.ForeColor = System.Drawing.Color.Goldenrod;
            this.Maximizelabel1.Location = new System.Drawing.Point(758, 0);
            this.Maximizelabel1.Name = "Maximizelabel1";
            this.Maximizelabel1.Size = new System.Drawing.Size(20, 18);
            this.Maximizelabel1.TabIndex = 2;
            this.Maximizelabel1.Text = "O";
            this.Maximizelabel1.Click += new System.EventHandler(this.Maximizelabel1_Click);
            // 
            // Crosslabel1
            // 
            this.Crosslabel1.AutoSize = true;
            this.Crosslabel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.Crosslabel1.ForeColor = System.Drawing.Color.Red;
            this.Crosslabel1.Location = new System.Drawing.Point(778, 0);
            this.Crosslabel1.Name = "Crosslabel1";
            this.Crosslabel1.Size = new System.Drawing.Size(20, 18);
            this.Crosslabel1.TabIndex = 1;
            this.Crosslabel1.Text = "O";
            this.Crosslabel1.Click += new System.EventHandler(this.Crosslabel1_Click);
            // 
            // Titlelabel
            // 
            this.Titlelabel.AutoSize = true;
            this.Titlelabel.Font = new System.Drawing.Font("Lucida Bright", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titlelabel.Location = new System.Drawing.Point(305, 21);
            this.Titlelabel.Name = "Titlelabel";
            this.Titlelabel.Size = new System.Drawing.Size(253, 28);
            this.Titlelabel.TabIndex = 0;
            this.Titlelabel.Text = "Parrot Bank Limited";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(283, 86);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // ShowAllAccountlabel
            // 
            this.ShowAllAccountlabel.AutoSize = true;
            this.ShowAllAccountlabel.Font = new System.Drawing.Font("Lucida Sans", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowAllAccountlabel.Location = new System.Drawing.Point(306, 85);
            this.ShowAllAccountlabel.Name = "ShowAllAccountlabel";
            this.ShowAllAccountlabel.Size = new System.Drawing.Size(220, 22);
            this.ShowAllAccountlabel.TabIndex = 22;
            this.ShowAllAccountlabel.Text = "Accounts Information";
            // 
            // BranchNamelabel
            // 
            this.BranchNamelabel.AutoSize = true;
            this.BranchNamelabel.Font = new System.Drawing.Font("Dutch801 Rm BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BranchNamelabel.Location = new System.Drawing.Point(208, 133);
            this.BranchNamelabel.Name = "BranchNamelabel";
            this.BranchNamelabel.Size = new System.Drawing.Size(130, 22);
            this.BranchNamelabel.TabIndex = 47;
            this.BranchNamelabel.Text = "Branch Name:";
            // 
            // BranchNamecomboBox
            // 
            this.BranchNamecomboBox.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BranchNamecomboBox.FormattingEnabled = true;
            this.BranchNamecomboBox.Items.AddRange(new object[] {
            "Chawrasta",
            "Joydeppur",
            "Boardbazar",
            "Uttara",
            "Badda",
            "Tongi",
            "Bashundhara"});
            this.BranchNamecomboBox.Location = new System.Drawing.Point(344, 128);
            this.BranchNamecomboBox.Name = "BranchNamecomboBox";
            this.BranchNamecomboBox.Size = new System.Drawing.Size(233, 27);
            this.BranchNamecomboBox.TabIndex = 54;
            this.BranchNamecomboBox.SelectedIndexChanged += new System.EventHandler(this.BranchNamecomboBox_SelectedIndexChanged);
            // 
            // AccountsdataGridView
            // 
            this.AccountsdataGridView.BackgroundColor = System.Drawing.Color.Silver;
            this.AccountsdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AccountsdataGridView.Location = new System.Drawing.Point(29, 172);
            this.AccountsdataGridView.Name = "AccountsdataGridView";
            this.AccountsdataGridView.RowHeadersWidth = 62;
            this.AccountsdataGridView.Size = new System.Drawing.Size(749, 261);
            this.AccountsdataGridView.TabIndex = 55;
            this.AccountsdataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AccountsdataGridView_CellClick);
            // 
            // BalancetextBox
            // 
            this.BalancetextBox.BackColor = System.Drawing.Color.Silver;
            this.BalancetextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BalancetextBox.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalancetextBox.Location = new System.Drawing.Point(118, 491);
            this.BalancetextBox.Multiline = true;
            this.BalancetextBox.Name = "BalancetextBox";
            this.BalancetextBox.Size = new System.Drawing.Size(233, 20);
            this.BalancetextBox.TabIndex = 63;
            // 
            // Balancelabel
            // 
            this.Balancelabel.AutoSize = true;
            this.Balancelabel.Font = new System.Drawing.Font("Dutch801 Rm BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Balancelabel.Location = new System.Drawing.Point(30, 488);
            this.Balancelabel.Name = "Balancelabel";
            this.Balancelabel.Size = new System.Drawing.Size(82, 22);
            this.Balancelabel.TabIndex = 62;
            this.Balancelabel.Text = "Balance:";
            // 
            // AccountNametextBox
            // 
            this.AccountNametextBox.BackColor = System.Drawing.Color.Silver;
            this.AccountNametextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AccountNametextBox.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountNametextBox.Location = new System.Drawing.Point(171, 454);
            this.AccountNametextBox.Multiline = true;
            this.AccountNametextBox.Name = "AccountNametextBox";
            this.AccountNametextBox.Size = new System.Drawing.Size(233, 20);
            this.AccountNametextBox.TabIndex = 61;
            // 
            // AccountNamelabel
            // 
            this.AccountNamelabel.AutoSize = true;
            this.AccountNamelabel.Font = new System.Drawing.Font("Dutch801 Rm BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountNamelabel.Location = new System.Drawing.Point(30, 452);
            this.AccountNamelabel.Name = "AccountNamelabel";
            this.AccountNamelabel.Size = new System.Drawing.Size(135, 22);
            this.AccountNamelabel.TabIndex = 60;
            this.AccountNamelabel.Text = "Account Name:";
            // 
            // ShowAccountByBranchName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(798, 541);
            this.Controls.Add(this.BalancetextBox);
            this.Controls.Add(this.Balancelabel);
            this.Controls.Add(this.AccountNametextBox);
            this.Controls.Add(this.AccountNamelabel);
            this.Controls.Add(this.AccountsdataGridView);
            this.Controls.Add(this.BranchNamecomboBox);
            this.Controls.Add(this.BranchNamelabel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.ShowAllAccountlabel);
            this.Controls.Add(this.Titlepanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShowAccountByBranchName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowAccountByBranchName";
            this.Load += new System.EventHandler(this.ShowAccountByBranchName_Load);
            this.Titlepanel.ResumeLayout(false);
            this.Titlepanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountsdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Titlepanel;
        private System.Windows.Forms.PictureBox BackpictureBox;
        private System.Windows.Forms.Label Minimizelabel1;
        private System.Windows.Forms.Label Maximizelabel1;
        private System.Windows.Forms.Label Crosslabel1;
        private System.Windows.Forms.Label Titlelabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label ShowAllAccountlabel;
        private System.Windows.Forms.Label BranchNamelabel;
        private System.Windows.Forms.ComboBox BranchNamecomboBox;
        private System.Windows.Forms.DataGridView AccountsdataGridView;
        private System.Windows.Forms.TextBox BalancetextBox;
        private System.Windows.Forms.Label Balancelabel;
        private System.Windows.Forms.TextBox AccountNametextBox;
        private System.Windows.Forms.Label AccountNamelabel;
    }
}