﻿using System;
using BankManagementSystem.Business_Logic_Layer;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManagementSystem.Presentation_Layer
{
    public partial class DeleteEmployee : Form
    {
        public DeleteEmployee()
        {
            InitializeComponent();
            EmployeeService employeeService = new EmployeeService();
            EmployeesdataGridView.DataSource = employeeService.GetAllEmployees();
        }

        private void Crosslabel1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Maximizelabel1_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void Minimizelabel1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BackpictureBox_Click(object sender, EventArgs e)
        {
            AdminAccessForm adminAccessForm = new AdminAccessForm();
            this.Hide();
            adminAccessForm.Show();
        }

        void UpdateEmployeeList()
        {
            EmployeeService employeeService = new EmployeeService();
            EmployeesdataGridView.DataSource = employeeService.GetAllEmployees();
        }
        private void Deletebutton_Click(object sender, EventArgs e)
        {
            EmployeeService employeeService = new EmployeeService();
            int result= employeeService.DeleteEmployee(Convert.ToInt32(EmployeeIdtextBox.Text));
            if (result > 0)
            {
                MessageBox.Show("Information Deleted Successfully!!!");
                UpdateEmployeeList();
            }
            else
            {
                MessageBox.Show("Information Delete Unsuccessfull!!!");
            }
        }

        private void DeleteEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
