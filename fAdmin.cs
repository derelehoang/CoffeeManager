﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Managerment
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();
            LoadAccountList();
        }

        private void tpAccount_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void tpCategoryDrink_Click(object sender, EventArgs e)
        {

        }
        void LoadAccountList()
        {
            string connectionSTR = @"Data Source=HUYHOANG-PC\HUYHOANG;Initial Catalog=COFFEE_MANAGERMENT;Persist Security Info=True;User ID=sa; Password=12112000";
            SqlConnection connection = new SqlConnection(connectionSTR);

            string query = "SELECT * FROM ACCOUNT";

            connection.Open();

            SqlCommand command = new SqlCommand(query, connection);

            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            adapter.Fill(data);

            connection.Close();

            dtgvAccount.DataSource = data;
        }
    }
}
