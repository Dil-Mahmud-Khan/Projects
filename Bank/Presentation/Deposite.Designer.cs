﻿
namespace BankManagementSystem.Presentation_Layer
{
    partial class Deposite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deposite));
            this.Titlepanel = new System.Windows.Forms.Panel();
            this.BackpictureBox = new System.Windows.Forms.PictureBox();
            this.Minimizelabel1 = new System.Windows.Forms.Label();
            this.Maximizelabel1 = new System.Windows.Forms.Label();
            this.Crosslabel1 = new System.Windows.Forms.Label();
            this.Titlelabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Depositlabel = new System.Windows.Forms.Label();
            this.AccountNumbertextBox = new System.Windows.Forms.TextBox();
            this.AccountNumberlabel = new System.Windows.Forms.Label();
            this.SearchpictureBox = new System.Windows.Forms.PictureBox();
            this.AccountsdataGridView = new System.Windows.Forms.DataGridView();
            this.TransactionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Datelabel = new System.Windows.Forms.Label();
            this.CurrentBalancetextBox = new System.Windows.Forms.TextBox();
            this.Balancelabel = new System.Windows.Forms.Label();
            this.AmounttextBox = new System.Windows.Forms.TextBox();
            this.Amountlabel = new System.Windows.Forms.Label();
            this.BranchNamecomboBox = new System.Windows.Forms.ComboBox();
            this.BranchNamelabel = new System.Windows.Forms.Label();
            this.Depositbutton = new System.Windows.Forms.Button();
            this.AccountTypecomboBox = new System.Windows.Forms.ComboBox();
            this.AccountTypelabel = new System.Windows.Forms.Label();
            this.Titlepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchpictureBox)).BeginInit();
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
            this.Titlepanel.TabIndex = 50;
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
            this.Titlelabel.Location = new System.Drawing.Point(314, 20);
            this.Titlelabel.Name = "Titlelabel";
            this.Titlelabel.Size = new System.Drawing.Size(253, 28);
            this.Titlelabel.TabIndex = 0;
            this.Titlelabel.Text = "Parrot Bank Limited";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(356, 75);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 55;
            this.pictureBox2.TabStop = false;
            // 
            // Depositlabel
            // 
            this.Depositlabel.AutoSize = true;
            this.Depositlabel.Font = new System.Drawing.Font("Lucida Sans", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Depositlabel.Location = new System.Drawing.Point(379, 74);
            this.Depositlabel.Name = "Depositlabel";
            this.Depositlabel.Size = new System.Drawing.Size(84, 22);
            this.Depositlabel.TabIndex = 54;
            this.Depositlabel.Text = "Deposit";
            // 
            // AccountNumbertextBox
            // 
            this.AccountNumbertextBox.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountNumbertextBox.Location = new System.Drawing.Point(334, 112);
            this.AccountNumbertextBox.Name = "AccountNumbertextBox";
            this.AccountNumbertextBox.Size = new System.Drawing.Size(233, 27);
            this.AccountNumbertextBox.TabIndex = 57;
            // 
            // AccountNumberlabel
            // 
            this.AccountNumberlabel.AutoSize = true;
            this.AccountNumberlabel.Font = new System.Drawing.Font("Dutch801 Rm BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountNumberlabel.Location = new System.Drawing.Point(174, 117);
            this.AccountNumberlabel.Name = "AccountNumberlabel";
            this.AccountNumberlabel.Size = new System.Drawing.Size(154, 22);
            this.AccountNumberlabel.TabIndex = 56;
            this.AccountNumberlabel.Text = "Account Number:";
            // 
            // SearchpictureBox
            // 
            this.SearchpictureBox.Image = ((System.Drawing.Image)(resources.GetObject("SearchpictureBox.Image")));
            this.SearchpictureBox.Location = new System.Drawing.Point(565, 112);
            this.SearchpictureBox.Name = "SearchpictureBox";
            this.SearchpictureBox.Size = new System.Drawing.Size(31, 27);
            this.SearchpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SearchpictureBox.TabIndex = 58;
            this.SearchpictureBox.TabStop = false;
            this.SearchpictureBox.Click += new System.EventHandler(this.SearchpictureBox_Click);
            // 
            // AccountsdataGridView
            // 
            this.AccountsdataGridView.BackgroundColor = System.Drawing.Color.Silver;
            this.AccountsdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AccountsdataGridView.Location = new System.Drawing.Point(17, 156);
            this.AccountsdataGridView.Name = "AccountsdataGridView";
            this.AccountsdataGridView.RowHeadersWidth = 62;
            this.AccountsdataGridView.Size = new System.Drawing.Size(761, 102);
            this.AccountsdataGridView.TabIndex = 59;
            this.AccountsdataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AccountsdataGridView_CellClick);
            // 
            // TransactionDateTimePicker
            // 
            this.TransactionDateTimePicker.Font = new System.Drawing.Font("Dutch801 Rm BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionDateTimePicker.Location = new System.Drawing.Point(205, 426);
            this.TransactionDateTimePicker.MaxDate = new System.DateTime(2030, 2, 28, 0, 0, 0, 0);
            this.TransactionDateTimePicker.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.TransactionDateTimePicker.Name = "TransactionDateTimePicker";
            this.TransactionDateTimePicker.Size = new System.Drawing.Size(233, 27);
            this.TransactionDateTimePicker.TabIndex = 63;
            this.TransactionDateTimePicker.Value = new System.DateTime(2021, 4, 25, 0, 0, 0, 0);
            // 
            // Datelabel
            // 
            this.Datelabel.AutoSize = true;
            this.Datelabel.Font = new System.Drawing.Font("Dutch801 Rm BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datelabel.Location = new System.Drawing.Point(42, 431);
            this.Datelabel.Name = "Datelabel";
            this.Datelabel.Size = new System.Drawing.Size(159, 22);
            this.Datelabel.TabIndex = 62;
            this.Datelabel.Text = "Transaction Date:";
            // 
            // CurrentBalancetextBox
            // 
            this.CurrentBalancetextBox.Font = new System.Drawing.Font("Dutch801 Rm BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentBalancetextBox.Location = new System.Drawing.Point(205, 278);
            this.CurrentBalancetextBox.Name = "CurrentBalancetextBox";
            this.CurrentBalancetextBox.Size = new System.Drawing.Size(233, 27);
            this.CurrentBalancetextBox.TabIndex = 61;
            // 
            // Balancelabel
            // 
            this.Balancelabel.AutoSize = true;
            this.Balancelabel.Font = new System.Drawing.Font("Dutch801 Rm BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Balancelabel.Location = new System.Drawing.Point(42, 283);
            this.Balancelabel.Name = "Balancelabel";
            this.Balancelabel.Size = new System.Drawing.Size(153, 22);
            this.Balancelabel.TabIndex = 60;
            this.Balancelabel.Text = "Current Balance:";
            // 
            // AmounttextBox
            // 
            this.AmounttextBox.Font = new System.Drawing.Font("Dutch801 Rm BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmounttextBox.Location = new System.Drawing.Point(205, 373);
            this.AmounttextBox.Name = "AmounttextBox";
            this.AmounttextBox.Size = new System.Drawing.Size(233, 27);
            this.AmounttextBox.TabIndex = 65;
            // 
            // Amountlabel
            // 
            this.Amountlabel.AutoSize = true;
            this.Amountlabel.Font = new System.Drawing.Font("Dutch801 Rm BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amountlabel.Location = new System.Drawing.Point(42, 378);
            this.Amountlabel.Name = "Amountlabel";
            this.Amountlabel.Size = new System.Drawing.Size(81, 22);
            this.Amountlabel.TabIndex = 64;
            this.Amountlabel.Text = "Amount:";
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
            this.BranchNamecomboBox.Location = new System.Drawing.Point(205, 474);
            this.BranchNamecomboBox.Name = "BranchNamecomboBox";
            this.BranchNamecomboBox.Size = new System.Drawing.Size(233, 27);
            this.BranchNamecomboBox.TabIndex = 67;
            // 
            // BranchNamelabel
            // 
            this.BranchNamelabel.AutoSize = true;
            this.BranchNamelabel.Font = new System.Drawing.Font("Dutch801 Rm BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BranchNamelabel.Location = new System.Drawing.Point(42, 479);
            this.BranchNamelabel.Name = "BranchNamelabel";
            this.BranchNamelabel.Size = new System.Drawing.Size(130, 22);
            this.BranchNamelabel.TabIndex = 66;
            this.BranchNamelabel.Text = "Branch Name:";
            // 
            // Depositbutton
            // 
            this.Depositbutton.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.Depositbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Depositbutton.Font = new System.Drawing.Font("Dutch801 Rm BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Depositbutton.ForeColor = System.Drawing.Color.White;
            this.Depositbutton.Location = new System.Drawing.Point(549, 483);
            this.Depositbutton.Name = "Depositbutton";
            this.Depositbutton.Size = new System.Drawing.Size(209, 35);
            this.Depositbutton.TabIndex = 68;
            this.Depositbutton.Text = "Deposit";
            this.Depositbutton.UseVisualStyleBackColor = false;
            this.Depositbutton.Click += new System.EventHandler(this.Depositbutton_Click);
            // 
            // AccountTypecomboBox
            // 
            this.AccountTypecomboBox.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountTypecomboBox.FormattingEnabled = true;
            this.AccountTypecomboBox.Items.AddRange(new object[] {
            "Savings Account",
            "Checking Account"});
            this.AccountTypecomboBox.Location = new System.Drawing.Point(205, 323);
            this.AccountTypecomboBox.Name = "AccountTypecomboBox";
            this.AccountTypecomboBox.Size = new System.Drawing.Size(233, 27);
            this.AccountTypecomboBox.TabIndex = 70;
            // 
            // AccountTypelabel
            // 
            this.AccountTypelabel.AutoSize = true;
            this.AccountTypelabel.Font = new System.Drawing.Font("Dutch801 Rm BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountTypelabel.Location = new System.Drawing.Point(42, 328);
            this.AccountTypelabel.Name = "AccountTypelabel";
            this.AccountTypelabel.Size = new System.Drawing.Size(126, 22);
            this.AccountTypelabel.TabIndex = 69;
            this.AccountTypelabel.Text = "Account Type:";
            // 
            // Deposite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(798, 541);
            this.Controls.Add(this.AccountTypecomboBox);
            this.Controls.Add(this.AccountTypelabel);
            this.Controls.Add(this.Depositbutton);
            this.Controls.Add(this.BranchNamecomboBox);
            this.Controls.Add(this.BranchNamelabel);
            this.Controls.Add(this.AmounttextBox);
            this.Controls.Add(this.Amountlabel);
            this.Controls.Add(this.TransactionDateTimePicker);
            this.Controls.Add(this.Datelabel);
            this.Controls.Add(this.CurrentBalancetextBox);
            this.Controls.Add(this.Balancelabel);
            this.Controls.Add(this.AccountsdataGridView);
            this.Controls.Add(this.SearchpictureBox);
            this.Controls.Add(this.AccountNumbertextBox);
            this.Controls.Add(this.AccountNumberlabel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Depositlabel);
            this.Controls.Add(this.Titlepanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Deposite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deposite";
            this.Load += new System.EventHandler(this.Deposite_Load);
            this.Titlepanel.ResumeLayout(false);
            this.Titlepanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchpictureBox)).EndInit();
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
        public System.Windows.Forms.Label Depositlabel;
        private System.Windows.Forms.TextBox AccountNumbertextBox;
        private System.Windows.Forms.Label AccountNumberlabel;
        private System.Windows.Forms.PictureBox SearchpictureBox;
        private System.Windows.Forms.DataGridView AccountsdataGridView;
        private System.Windows.Forms.DateTimePicker TransactionDateTimePicker;
        private System.Windows.Forms.Label Datelabel;
        private System.Windows.Forms.TextBox CurrentBalancetextBox;
        private System.Windows.Forms.Label Balancelabel;
        private System.Windows.Forms.TextBox AmounttextBox;
        private System.Windows.Forms.Label Amountlabel;
        private System.Windows.Forms.ComboBox BranchNamecomboBox;
        private System.Windows.Forms.Label BranchNamelabel;
        private System.Windows.Forms.Button Depositbutton;
        private System.Windows.Forms.ComboBox AccountTypecomboBox;
        private System.Windows.Forms.Label AccountTypelabel;
    }
}