
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
                    sqlQuery = "UPDATE [tbl_products] SET [product_name] = '" + pro_name.Text + "',[product_status] = '" + status + "' WHERE [product_id] = '" + pro_code.Text + "'";
                }
                else
                {
                    sqlQuery = "INSERT INTO [dbo].[tbl_products] ([product_id],[product_name],[product_status]) VALUES ('" + pro_code.Text + "','" + pro_name.Text + "','" + status + "')";
                }
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                cmd.ExecuteNonQuery();
                con.Close();
                // Get Products
                loadData();
                resetData(); 
            }
        }
        private bool isProductExists(SqlConnection con, string pro_code)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [dbo].[tbl_products] WHERE [product_id] = '" + pro_code + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }
        public void loadData()
        {
            SqlConnection con = MyConnection.GetConnection();
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT * FROM [dbo].[tbl_products]", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            products_tbl.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = products_tbl.Rows.Add();
                products_tbl.Rows[n].Cells[0].Value = item["product_id"].ToString();
                products_tbl.Rows[n].Cells[1].Value = item["product_name"].ToString();
                if ((bool)item["product_status"])
                    products_tbl.Rows[n].Cells[2].Value = "Active";
                else
                    products_tbl.Rows[n].Cells[2].Value = "Deactive";
            }
        }

        private void products_tbl_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            pro_code.Text = products_tbl.SelectedRows[0].Cells[0].Value.ToString();
            pro_name.Text = products_tbl.SelectedRows[0].Cells[1].Value.ToString();
            if (products_tbl.SelectedRows[0].Cells[2].Value.ToString() == "Active")
                pro_status.SelectedIndex = 0;
            else
                pro_status.SelectedIndex = 1;
            add_btn.Text = "Update";
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure to delete?", "Message", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                if (validation())
                {
                    SqlConnection con = MyConnection.GetConnection();
                    if (isProductExists(con, pro_code.Text))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM [tbl_products] WHERE [product_id] = '" + pro_code.Text + "'", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Record Not Found!");
                    }
                    loadData();
                    resetData();
                } 
            }