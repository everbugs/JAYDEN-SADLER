
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

namespace Stock
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            username.Text = "";
            password.Clear();
            username.Focus();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-BJH69LU\ASHISSQL;Initial Catalog=Stock;Integrated Security=True");
            SqlConnection con = MyConnection.GetConnection();
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT * FROM[dbo].[tbl_login] WHERE username = '" + username.Text + "' AND password = '" + password.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            //CTRL + KD To align
            if (dt.Rows.Count == 1)
            {
                this.Hide();
                StockMain main = new StockMain();
                main.Show();
            }
            else
            {
                MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clear_btn_Click(sender, e);
            }
        }
    }
}