namespace DoAnQUanLyKhachSan
{
    partial class fAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAdmin));
            this.tbRoom123 = new System.Windows.Forms.TabControl();
            this.tbAcc = new System.Windows.Forms.TabPage();
            this.dtAcc = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btSaveAcc = new System.Windows.Forms.Button();
            this.btChange = new System.Windows.Forms.Button();
            this.btRemoveAcc = new System.Windows.Forms.Button();
            this.btAddAcc = new System.Windows.Forms.Button();
            this.tbRoom = new System.Windows.Forms.TabPage();
            this.tbSupport = new System.Windows.Forms.TabPage();
            this.dtSp = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btFindSp = new System.Windows.Forms.Button();
            this.txtFindSp = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btSaveSp = new System.Windows.Forms.Button();
            this.btChangeSp = new System.Windows.Forms.Button();
            this.btRemoveSp = new System.Windows.Forms.Button();
            this.btAddSp = new System.Windows.Forms.Button();
            this.tbRoom123.SuspendLayout();
            this.tbAcc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtAcc)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tbSupport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtSp)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbRoom123
            // 
            this.tbRoom123.Controls.Add(this.tbAcc);
            this.tbRoom123.Controls.Add(this.tbRoom);
            this.tbRoom123.Controls.Add(this.tbSupport);
            this.tbRoom123.Location = new System.Drawing.Point(2, 12);
            this.tbRoom123.Name = "tbRoom123";
            this.tbRoom123.SelectedIndex = 0;
            this.tbRoom123.Size = new System.Drawing.Size(782, 461);
            this.tbRoom123.TabIndex = 0;
            // 
            // tbAcc
            // 
            this.tbAcc.Controls.Add(this.dtAcc);
            this.tbAcc.Controls.Add(this.panel3);
            this.tbAcc.Controls.Add(this.panel2);
            this.tbAcc.Location = new System.Drawing.Point(4, 22);
            this.tbAcc.Name = "tbAcc";
            this.tbAcc.Padding = new System.Windows.Forms.Padding(3);
            this.tbAcc.Size = new System.Drawing.Size(774, 435);
            this.tbAcc.TabIndex = 0;
            this.tbAcc.Text = "Tài khoản";
            this.tbAcc.UseVisualStyleBackColor = true;
            // 
            // dtAcc
            // 
            this.dtAcc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtAcc.Location = new System.Drawing.Point(3, 3);
            this.dtAcc.Name = "dtAcc";
            this.dtAcc.Size = new System.Drawing.Size(551, 429);
            this.dtAcc.TabIndex = 5;
            this.dtAcc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtAccount_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(560, 164);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(211, 268);
            this.panel3.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Loạt tài khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên hiển thị";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên tài khoản";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btSaveAcc);
            this.panel2.Controls.Add(this.btChange);
            this.panel2.Controls.Add(this.btRemoveAcc);
            this.panel2.Controls.Add(this.btAddAcc);
            this.panel2.Location = new System.Drawing.Point(560, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(211, 154);
            this.panel2.TabIndex = 2;
            // 
            // btSaveAcc
            // 
            this.btSaveAcc.Location = new System.Drawing.Point(109, 73);
            this.btSaveAcc.Name = "btSaveAcc";
            this.btSaveAcc.Size = new System.Drawing.Size(91, 70);
            this.btSaveAcc.TabIndex = 3;
            this.btSaveAcc.Text = "Lưu";
            this.btSaveAcc.UseVisualStyleBackColor = true;
            // 
            // btChange
            // 
            this.btChange.Location = new System.Drawing.Point(4, 73);
            this.btChange.Name = "btChange";
            this.btChange.Size = new System.Drawing.Size(99, 70);
            this.btChange.TabIndex = 2;
            this.btChange.Text = "Thay đổi tài khoản";
            this.btChange.UseVisualStyleBackColor = true;
            // 
            // btRemoveAcc
            // 
            this.btRemoveAcc.Location = new System.Drawing.Point(109, 4);
            this.btRemoveAcc.Name = "btRemoveAcc";
            this.btRemoveAcc.Size = new System.Drawing.Size(91, 63);
            this.btRemoveAcc.TabIndex = 1;
            this.btRemoveAcc.Text = "Xóa tài khoản";
            this.btRemoveAcc.UseVisualStyleBackColor = true;
            // 
            // btAddAcc
            // 
            this.btAddAcc.Location = new System.Drawing.Point(4, 4);
            this.btAddAcc.Name = "btAddAcc";
            this.btAddAcc.Size = new System.Drawing.Size(99, 63);
            this.btAddAcc.TabIndex = 0;
            this.btAddAcc.Text = "Thêm tài khoản";
            this.btAddAcc.UseVisualStyleBackColor = true;
            this.btAddAcc.Click += new System.EventHandler(this.btAddAcc_Click);
            // 
            // tbRoom
            // 
            this.tbRoom.Location = new System.Drawing.Point(4, 22);
            this.tbRoom.Name = "tbRoom";
            this.tbRoom.Padding = new System.Windows.Forms.Padding(3);
            this.tbRoom.Size = new System.Drawing.Size(739, 435);
            this.tbRoom.TabIndex = 1;
            this.tbRoom.Text = "Phòng";
            this.tbRoom.UseVisualStyleBackColor = true;
            this.tbRoom.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // tbSupport
            // 
            this.tbSupport.Controls.Add(this.dtSp);
            this.tbSupport.Controls.Add(this.panel1);
            this.tbSupport.Controls.Add(this.panel5);
            this.tbSupport.Controls.Add(this.panel6);
            this.tbSupport.Location = new System.Drawing.Point(4, 22);
            this.tbSupport.Name = "tbSupport";
            this.tbSupport.Size = new System.Drawing.Size(739, 435);
            this.tbSupport.TabIndex = 0;
            this.tbSupport.Text = "Dịch vụ";
            this.tbSupport.UseVisualStyleBackColor = true;
            // 
            // dtSp
            // 
            this.dtSp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtSp.Location = new System.Drawing.Point(3, 65);
            this.dtSp.Name = "dtSp";
            this.dtSp.Size = new System.Drawing.Size(516, 366);
            this.dtSp.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btFindSp);
            this.panel1.Controls.Add(this.txtFindSp);
            this.panel1.Location = new System.Drawing.Point(4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(515, 56);
            this.panel1.TabIndex = 8;
            // 
            // btFindSp
            // 
            this.btFindSp.Location = new System.Drawing.Point(430, 3);
            this.btFindSp.Name = "btFindSp";
            this.btFindSp.Size = new System.Drawing.Size(75, 50);
            this.btFindSp.TabIndex = 1;
            this.btFindSp.Text = "Tìm";
            this.btFindSp.UseVisualStyleBackColor = true;
            // 
            // txtFindSp
            // 
            this.txtFindSp.Location = new System.Drawing.Point(3, 19);
            this.txtFindSp.Name = "txtFindSp";
            this.txtFindSp.Size = new System.Drawing.Size(421, 20);
            this.txtFindSp.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Location = new System.Drawing.Point(525, 163);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(211, 268);
            this.panel5.TabIndex = 7;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label1);
            this.panel7.Controls.Add(this.textBox1);
            this.panel7.Location = new System.Drawing.Point(4, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 30);
            this.panel7.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(54, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 20);
            this.textBox1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btSaveSp);
            this.panel6.Controls.Add(this.btChangeSp);
            this.panel6.Controls.Add(this.btRemoveSp);
            this.panel6.Controls.Add(this.btAddSp);
            this.panel6.Location = new System.Drawing.Point(525, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(211, 154);
            this.panel6.TabIndex = 6;
            // 
            // btSaveSp
            // 
            this.btSaveSp.Location = new System.Drawing.Point(109, 73);
            this.btSaveSp.Name = "btSaveSp";
            this.btSaveSp.Size = new System.Drawing.Size(91, 70);
            this.btSaveSp.TabIndex = 3;
            this.btSaveSp.Text = "Lưu";
            this.btSaveSp.UseVisualStyleBackColor = true;
            // 
            // btChangeSp
            // 
            this.btChangeSp.Location = new System.Drawing.Point(4, 73);
            this.btChangeSp.Name = "btChangeSp";
            this.btChangeSp.Size = new System.Drawing.Size(99, 70);
            this.btChangeSp.TabIndex = 2;
            this.btChangeSp.Text = "Thay đổi dịch vụ";
            this.btChangeSp.UseVisualStyleBackColor = true;
            this.btChangeSp.Click += new System.EventHandler(this.button3_Click);
            // 
            // btRemoveSp
            // 
            this.btRemoveSp.Location = new System.Drawing.Point(109, 4);
            this.btRemoveSp.Name = "btRemoveSp";
            this.btRemoveSp.Size = new System.Drawing.Size(91, 63);
            this.btRemoveSp.TabIndex = 1;
            this.btRemoveSp.Text = "Xóa dịch vụ";
            this.btRemoveSp.UseVisualStyleBackColor = true;
            // 
            // btAddSp
            // 
            this.btAddSp.Location = new System.Drawing.Point(4, 4);
            this.btAddSp.Name = "btAddSp";
            this.btAddSp.Size = new System.Drawing.Size(99, 63);
            this.btAddSp.TabIndex = 0;
            this.btAddSp.Text = "Thêm dịch vụ";
            this.btAddSp.UseVisualStyleBackColor = true;
            // 
            // fAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 476);
            this.Controls.Add(this.tbRoom123);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fAdmin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.fAdmin_Load);
            this.tbRoom123.ResumeLayout(false);
            this.tbAcc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtAcc)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tbSupport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtSp)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbRoom123;
        private System.Windows.Forms.TabPage tbAcc;
        private System.Windows.Forms.TabPage tbRoom;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabPage tbSupport;
        private System.Windows.Forms.Button btSaveAcc;
        private System.Windows.Forms.Button btChange;
        private System.Windows.Forms.Button btRemoveAcc;
        private System.Windows.Forms.Button btAddAcc;
        private System.Windows.Forms.DataGridView dtAcc;
        private System.Windows.Forms.DataGridView dtSp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btFindSp;
        private System.Windows.Forms.TextBox txtFindSp;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btSaveSp;
        private System.Windows.Forms.Button btChangeSp;
        private System.Windows.Forms.Button btRemoveSp;
        private System.Windows.Forms.Button btAddSp;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}