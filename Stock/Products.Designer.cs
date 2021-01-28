
﻿namespace Stock
{
    partial class Products
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.pro_code = new System.Windows.Forms.TextBox();
            this.pro_status = new System.Windows.Forms.ComboBox();
            this.del_btn = new System.Windows.Forms.Button();
            this.products_tbl = new System.Windows.Forms.DataGridView();
            this.Product_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pro_name = new System.Windows.Forms.TextBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.reset_btn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.products_tbl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Code";
            // 
            // pro_code
            // 
            this.pro_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pro_code.Location = new System.Drawing.Point(51, 91);
            this.pro_code.Name = "pro_code";
            this.pro_code.Size = new System.Drawing.Size(219, 30);
            this.pro_code.TabIndex = 1;
            // 
            // pro_status
            // 
            this.pro_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pro_status.FormattingEnabled = true;
            this.pro_status.Items.AddRange(new object[] {
            "Active",
            "Deactive"});
            this.pro_status.Location = new System.Drawing.Point(551, 88);
            this.pro_status.Name = "pro_status";
            this.pro_status.Size = new System.Drawing.Size(219, 33);
            this.pro_status.TabIndex = 3;
            // 
            // del_btn
            // 
            this.del_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del_btn.Location = new System.Drawing.Point(790, 86);
            this.del_btn.Name = "del_btn";
            this.del_btn.Padding = new System.Windows.Forms.Padding(2);
            this.del_btn.Size = new System.Drawing.Size(104, 41);
            this.del_btn.TabIndex = 5;
            this.del_btn.Text = "Delete";
            this.del_btn.UseVisualStyleBackColor = true;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // products_tbl
            // 
            this.products_tbl.AllowUserToAddRows = false;
            this.products_tbl.AllowUserToResizeRows = false;
            this.products_tbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.products_tbl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product_Code,
            this.Product_Name,
            this.Product_status});
            this.products_tbl.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.products_tbl.Location = new System.Drawing.Point(51, 163);
            this.products_tbl.Margin = new System.Windows.Forms.Padding(0);
            this.products_tbl.Name = "products_tbl";
            this.products_tbl.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.products_tbl.RowHeadersVisible = false;
            this.products_tbl.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.products_tbl.RowTemplate.Height = 20;
            this.products_tbl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.products_tbl.Size = new System.Drawing.Size(1043, 375);
            this.products_tbl.TabIndex = 4;
            this.products_tbl.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.products_tbl_MouseDoubleClick);
            // 
            // Product_Code
            // 
            this.Product_Code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Product_Code.HeaderText = "Product Code";
            this.Product_Code.Name = "Product_Code";
            this.Product_Code.Width = 142;
            // 
            // Product_Name
            // 
            this.Product_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Product_Name.HeaderText = "Product Name";
            this.Product_Name.Name = "Product_Name";
            // 
            // Product_status
            // 
            this.Product_status.HeaderText = "Status";
            this.Product_status.Name = "Product_status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(296, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Product Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(547, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Status";
            // 