namespace DoAnQUanLyKhachSan
{
    partial class fShowBill
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
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txbTotalBill = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lvSup = new System.Windows.Forms.ListView();
            this.T = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.flbBill = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(415, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 54);
            this.button1.TabIndex = 2;
            this.button1.Text = "In hóa đơn";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Location = new System.Drawing.Point(3, 1);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(533, 229);
            this.tabControl2.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txbTotalBill);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.lvSup);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(525, 203);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Chi tiết hóa đơn";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txbTotalBill
            // 
            this.txbTotalBill.Location = new System.Drawing.Point(71, 169);
            this.txbTotalBill.Name = "txbTotalBill";
            this.txbTotalBill.ReadOnly = true;
            this.txbTotalBill.Size = new System.Drawing.Size(231, 20);
            this.txbTotalBill.TabIndex = 2;
            this.txbTotalBill.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tổng tiền :";
            // 
            // lvSup
            // 
            this.lvSup.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.T,
            this.columnHeader7});
            this.lvSup.Location = new System.Drawing.Point(3, 3);
            this.lvSup.Name = "lvSup";
            this.lvSup.Size = new System.Drawing.Size(500, 153);
            this.lvSup.TabIndex = 0;
            this.lvSup.UseCompatibleStateImageBehavior = false;
            this.lvSup.View = System.Windows.Forms.View.Details;
            // 
            // T
            // 
            this.T.Text = "Tên dịch vụ";
            this.T.Width = 400;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Giá thành";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(538, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(333, 466);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.flbBill);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(325, 440);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Danh sách hóa đơn";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // flbBill
            // 
            this.flbBill.Location = new System.Drawing.Point(6, 3);
            this.flbBill.Name = "flbBill";
            this.flbBill.Size = new System.Drawing.Size(353, 434);
            this.flbBill.TabIndex = 0;
            // 
            // fShowBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 468);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.tabControl1);
            this.Name = "fShowBill";
            this.Text = "Danh sách hóa đơn";
            this.Load += new System.EventHandler(this.fShowBill_Load);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.FlowLayoutPanel flbBill;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txbTotalBill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvSup;
        private System.Windows.Forms.ColumnHeader T;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button button1;
    }
}