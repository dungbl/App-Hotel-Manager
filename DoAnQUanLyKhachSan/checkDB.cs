using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DoAnQUanLyKhachSan
{
    public partial class checkDB : Form
    {
        public checkDB()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btSave_Click(object sender, EventArgs e)
        {
            {
                StreamWriter a = new StreamWriter("Config.txt");

                if(ckWin.Checked == true)
                {
                    a.WriteLine("window");
                    a.WriteLine(txtSVN.Text);
                    a.WriteLine(txtDBN.Text);
                }
                else
                {
                    a.WriteLine("sql");
                    a.WriteLine(txtSVN.Text);
                    a.WriteLine(txtDBN.Text);
                    a.WriteLine(txtUserID.Text);
                    a.WriteLine(txtPW.Text);
                }
                Login f = new DoAnQUanLyKhachSan.Login();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
        }
    }
}
