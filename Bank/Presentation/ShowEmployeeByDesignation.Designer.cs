﻿
namespace BankManagementSystem.Presentation_Layer
{
    partial class ShowEmployeeByDesignation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowEmployeeByDesignation));
            this.Titlepanel = new System.Windows.Forms.Panel();
            this.BackpictureBox = new System.Windows.Forms.PictureBox();
            this.Minimizelabel1 = new System.Windows.Forms.Label();
            this.Maximizelabel1 = new System.Windows.Forms.Label();
            this.Crosslabel1 = new System.Windows.Forms.Label();
            this.Titlelabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ShowAllAccountlabel = new System.Windows.Forms.Label();
            this.EmployeesdataGridView = new System.Windows.Forms.DataGridView();
            this.DesignationcomboBox = new System.Windows.Forms.ComboBox();
            this.Designationlabel = new System.Windows.Forms.Label();
            this.SalarytextBox = new System.Windows.Forms.TextBox();
            this.Salarylabel = new System.Windows.Forms.Label();
            this.EmployeeNametextBox = new System.Windows.Forms.TextBox();
            this.EmployeeNamelabel = new System.Windows.Forms.Label();
            this.Titlepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesdataGridView)).BeginInit();
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
            this.Titlepanel.TabIndex = 6;
            this.Titlepanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Titlepanel_Paint);
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
            this.Titlelabel.Location = new System.Drawing.Point(301, 21);
            this.Titlelabel.Name = "Titlelabel";
            this.Titlelabel.Size = new System.Drawing.Size(253, 28);
            this.Titlelabel.TabIndex = 0;
            this.Titlelabel.Text = "Parrot Bank Limited";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(272, 86);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // ShowAllAccountlabel
            // 
            this.ShowAllAccountlabel.AutoSize = true;
            this.ShowAllAccountlabel.Font = new System.Drawing.Font("Lucida Sans", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowAllAccountlabel.Location = new System.Drawing.Point(295, 85);
            this.ShowAllAccountlabel.Name = "ShowAllAccountlabel";
            this.ShowAllAccountlabel.Size = new System.Drawing.Size(241, 22);
            this.ShowAllAccountlabel.TabIndex = 24;
            this.ShowAllAccountlabel.Text = " Employees Information";
            // 
            // EmployeesdataGridView
            // 
            this.EmployeesdataGridView.BackgroundColor = System.Drawing.Color.Silver;
            this.EmployeesdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeesdataGridView.Location = new System.Drawing.Point(12, 187);
            this.EmployeesdataGridView.Name = "EmployeesdataGridView";
            this.EmployeesdataGridView.RowHeadersWidth = 62;
            this.EmployeesdataGridView.Size = new System.Drawing.Size(775, 265);
            this.EmployeesdataGridView.TabIndex = 44;
            this.EmployeesdataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeesdataGridView_CellClick);
            // 
            // DesignationcomboBox
            // 
            this.DesignationcomboBox.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesignationcomboBox.FormattingEnabled = true;
            this.DesignationcomboBox.Items.AddRange(new object[] {
            "Manager",
            "Assistant Manager",
            "Accountant",
            "Security Guard",
            "Maid Servant"});
            this.DesignationcomboBox.Location = new System.Drawing.Point(331, 143);
            this.DesignationcomboBox.Name = "DesignationcomboBox";
            this.DesignationcomboBox.Size = new System.Drawing.Size(233, 27);
            this.DesignationcomboBox.TabIndex = 74;
            this.DesignationcomboBox.SelectedIndexChanged += new System.EventHandler(this.DesignationcomboBox_SelectedIndexChanged);
            // 
            // Designationlabel
            // 
            this.Designationlabel.AutoSize = true;
            this.Designationlabel.Font = new System.Drawing.Font("Dutch801 Rm BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Designationlabel.Location = new System.Drawing.Point(210, 148);
            this.Designationlabel.Name = "Designationlabel";
            this.Designationlabel.Size = new System.Drawing.Size(115, 22);
            this.Designationlabel.TabIndex = 73;
            this.Designationlabel.Text = "Designation:";
            // 
            // SalarytextBox
            // 
            this.SalarytextBox.BackColor = System.Drawing.Color.Silver;
            this.SalarytextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SalarytextBox.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalarytextBox.Location = new System.Drawing.Point(107, 520);
            this.SalarytextBox.Multiline = true;
            this.SalarytextBox.Name = "SalarytextBox";
            this.SalarytextBox.Size = new System.Drawing.Size(233, 20);
            this.SalarytextBox.TabIndex = 78;
            // 
            // Salarylabel
            // 
            this.Salarylabel.AutoSize = true;
            this.Salarylabel.Font = new System.Drawing.Font("Dutch801 Rm BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salarylabel.Location = new System.Drawing.Point(19, 517);
            this.Salarylabel.Name = "Salarylabel";
            this.Salarylabel.Size = new System.Drawing.Size(68, 22);
            this.Salarylabel.TabIndex = 77;
            this.Salarylabel.Text = "Salary:";
            // 
            // EmployeeNametextBox
            // 
            this.EmployeeNametextBox.BackColor = System.Drawing.Color.Silver;
            this.EmployeeNametextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmployeeNametextBox.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeNametextBox.Location = new System.Drawing.Point(176, 483);
            this.EmployeeNametextBox.Multiline = true;
            this.EmployeeNametextBox.Name = "EmployeeNametextBox";
            this.EmployeeNametextBox.Size = new System.Drawing.Size(233, 20);
            this.EmployeeNametextBox.TabIndex = 76;
            // 
            // EmployeeNamelabel
            // 
            this.EmployeeNamelabel.AutoSize = true;
            this.EmployeeNamelabel.Font = new System.Drawing.Font("Dutch801 Rm BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeNamelabel.Location = new System.Drawing.Point(19, 481);
            this.EmployeeNamelabel.Name = "EmployeeNamelabel";
            this.EmployeeNamelabel.Size = new System.Drawing.Size(151, 22);
            this.EmployeeNamelabel.TabIndex = 75;
            this.EmployeeNamelabel.Text = "Employee Name:";
            // 
            // ShowEmployeeByDesignation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(798, 581);
            this.Controls.Add(this.SalarytextBox);
            this.Controls.Add(this.Salarylabel);
            this.Controls.Add(this.EmployeeNametextBox);
            this.Controls.Add(this.EmployeeNamelabel);
            this.Controls.Add(this.DesignationcomboBox);
            this.Controls.Add(this.Designationlabel);
            this.Controls.Add(this.EmployeesdataGridView);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.ShowAllAccountlabel);
            this.Controls.Add(this.Titlepanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShowEmployeeByDesignation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowEmployeeByDesignation";
            this.Titlepanel.ResumeLayout(false);
            this.Titlepanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesdataGridView)).EndInit();
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
        private System.Windows.Forms.DataGridView EmployeesdataGridView;
        private System.Windows.Forms.ComboBox DesignationcomboBox;
        private System.Windows.Forms.Label Designationlabel;
        private System.Windows.Forms.TextBox SalarytextBox;
        private System.Windows.Forms.Label Salarylabel;
        private System.Windows.Forms.TextBox EmployeeNametextBox;
        private System.Windows.Forms.Label EmployeeNamelabel;
    }
}