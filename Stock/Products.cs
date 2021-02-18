
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
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            pro_status.SelectedIndex = 0;
            loadData();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (validation())
            {
                //Insert Product
                //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-BJH69LU\ASHISSQL;Initial Catalog=Stock;Integrated Security=True");
                SqlConnection con = MyConnection.GetConnection();
                con.Open();
                bool status = false;
                if (pro_status.SelectedIndex == 0)
                    status = true;
                else
                    status = false;
                string sqlQuery = "";
                if (isProductExists(con, pro_code.Text))
                {