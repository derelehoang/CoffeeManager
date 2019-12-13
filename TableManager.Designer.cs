namespace Coffee_Managerment
{
    partial class TableManager
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lsvBill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbTotalPrice = new System.Windows.Forms.TextBox();
            this.nmCount = new System.Windows.Forms.NumericUpDown();
            this.btnSwichTable = new System.Windows.Forms.Button();
            this.cbSwichTable = new System.Windows.Forms.ComboBox();
            this.btnGiamGia = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.nmDrink = new System.Windows.Forms.NumericUpDown();
            this.btnAddDrink = new System.Windows.Forms.Button();
            this.cbDrink = new System.Windows.Forms.ComboBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmCount)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDrink)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1074, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(77, 29);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lsvBill);
            this.panel2.Location = new System.Drawing.Point(608, 118);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(454, 409);
            this.panel2.TabIndex = 2;
            // 
            // lsvBill
            // 
            this.lsvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvBill.GridLines = true;
            this.lsvBill.Location = new System.Drawing.Point(0, 0);
            this.lsvBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(454, 403);
            this.lsvBill.TabIndex = 0;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            this.lsvBill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên món";
            this.columnHeader1.Width = 75;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.Width = 79;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.Width = 72;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            this.columnHeader4.Width = 91;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txbTotalPrice);
            this.panel3.Controls.Add(this.nmCount);
            this.panel3.Controls.Add(this.btnSwichTable);
            this.panel3.Controls.Add(this.cbSwichTable);
            this.panel3.Controls.Add(this.btnGiamGia);
            this.panel3.Controls.Add(this.btnThanhToan);
            this.panel3.Location = new System.Drawing.Point(608, 530);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(454, 70);
            this.panel3.TabIndex = 3;
            // 
            // txbTotalPrice
            // 
            this.txbTotalPrice.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTotalPrice.ForeColor = System.Drawing.Color.Red;
            this.txbTotalPrice.Location = new System.Drawing.Point(232, 18);
            this.txbTotalPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbTotalPrice.Name = "txbTotalPrice";
            this.txbTotalPrice.ReadOnly = true;
            this.txbTotalPrice.Size = new System.Drawing.Size(116, 32);
            this.txbTotalPrice.TabIndex = 3;
            this.txbTotalPrice.Text = "0";
            this.txbTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nmCount
            // 
            this.nmCount.Location = new System.Drawing.Point(116, 35);
            this.nmCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nmCount.Name = "nmCount";
            this.nmCount.Size = new System.Drawing.Size(109, 26);
            this.nmCount.TabIndex = 2;
            this.nmCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSwichTable
            // 
            this.btnSwichTable.Location = new System.Drawing.Point(0, 2);
            this.btnSwichTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSwichTable.Name = "btnSwichTable";
            this.btnSwichTable.Size = new System.Drawing.Size(109, 32);
            this.btnSwichTable.TabIndex = 1;
            this.btnSwichTable.Text = "Chuyển bàn";
            this.btnSwichTable.UseVisualStyleBackColor = true;
            // 
            // cbSwichTable
            // 
            this.cbSwichTable.FormattingEnabled = true;
            this.cbSwichTable.Location = new System.Drawing.Point(0, 36);
            this.cbSwichTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSwichTable.Name = "cbSwichTable";
            this.cbSwichTable.Size = new System.Drawing.Size(109, 28);
            this.cbSwichTable.TabIndex = 0;
            // 
            // btnGiamGia
            // 
            this.btnGiamGia.Location = new System.Drawing.Point(116, 1);
            this.btnGiamGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGiamGia.Name = "btnGiamGia";
            this.btnGiamGia.Size = new System.Drawing.Size(109, 32);
            this.btnGiamGia.TabIndex = 1;
            this.btnGiamGia.Text = "Giảm giá";
            this.btnGiamGia.UseVisualStyleBackColor = true;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(356, 2);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(94, 59);
            this.btnThanhToan.TabIndex = 1;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.nmDrink);
            this.panel4.Controls.Add(this.btnAddDrink);
            this.panel4.Controls.Add(this.cbDrink);
            this.panel4.Controls.Add(this.cbCategory);
            this.panel4.Location = new System.Drawing.Point(608, 36);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(454, 76);
            this.panel4.TabIndex = 4;
            // 
            // nmDrink
            // 
            this.nmDrink.Location = new System.Drawing.Point(378, 20);
            this.nmDrink.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nmDrink.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmDrink.Name = "nmDrink";
            this.nmDrink.Size = new System.Drawing.Size(76, 26);
            this.nmDrink.TabIndex = 2;
            this.nmDrink.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAddDrink
            // 
            this.btnAddDrink.Location = new System.Drawing.Point(254, 2);
            this.btnAddDrink.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddDrink.Name = "btnAddDrink";
            this.btnAddDrink.Size = new System.Drawing.Size(94, 59);
            this.btnAddDrink.TabIndex = 1;
            this.btnAddDrink.Text = "Add";
            this.btnAddDrink.UseVisualStyleBackColor = true;
            // 
            // cbDrink
            // 
            this.cbDrink.FormattingEnabled = true;
            this.cbDrink.Location = new System.Drawing.Point(3, 34);
            this.cbDrink.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDrink.Name = "cbDrink";
            this.cbDrink.Size = new System.Drawing.Size(245, 28);
            this.cbDrink.TabIndex = 0;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(3, 0);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(245, 28);
            this.cbCategory.TabIndex = 0;
            // 
            // flpTable
            // 
            this.flpTable.AutoScroll = true;
            this.flpTable.Location = new System.Drawing.Point(12, 36);
            this.flpTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(590, 564);
            this.flpTable.TabIndex = 5;
            // 
            // TableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 612);
            this.Controls.Add(this.flpTable);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TableManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "phần mềm quản lý coffee";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmCount)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmDrink)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lsvBill;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NumericUpDown nmCount;
        private System.Windows.Forms.Button btnSwichTable;
        private System.Windows.Forms.ComboBox cbSwichTable;
        private System.Windows.Forms.Button btnGiamGia;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown nmDrink;
        private System.Windows.Forms.Button btnAddDrink;
        private System.Windows.Forms.ComboBox cbDrink;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox txbTotalPrice;
    }
}