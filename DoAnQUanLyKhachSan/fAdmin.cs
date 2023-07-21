using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using DoAnQUanLyKhachSan.DAO;

namespace DoAnQUanLyKhachSan
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();

            LoadAccountList();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btAddAcc_Click(object sender, EventArgs e)
        {

        }

        private void dtAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        void LoadAccountList()
        {

            string query = "SELECT * FROM dbo.Account";

            DataProvider provider = new DataProvider();

            dtAcc.DataSource = provider.ExecuteQuery(query);

        }
    }
}
