using DoAnQUanLyKhachSan.DAO;
using DoAnQUanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListViewItem;

namespace DoAnQUanLyKhachSan
{
    public partial class fManager : Form
    {
        public fManager()
        {
            InitializeComponent();

            //LoadServicesList();
            LoadRoom();

            LoadListSup();

        }

        private void LoadServicesList()
        {
            //string query = "SELECT name FROM dbo.Support";

           // DataProvider provider = new DataProvider();

            //cklServices.DataSource = provider.ExecuteQuery(query);
        }

        private void fManager_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lvBill_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void fAddRoom_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccountProfile f = new fAccountProfile();
            f.ShowDialog();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            f.ShowDialog();
        }

        private void bAddRoom_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbStatus_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

       private void cklServices_SelectedIndexChanged(object sender, EventArgs e)
        {
          // string query = "SELECT name FROM dbo.Support";

           // DataProvider provider = new DataProvider();

           // cklServices.DataSource = provider.ExecuteQuery(query);
        }

        private void dtRoom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        // tải danh sách dịch vụ từ sql
        void LoadListSup()
        {
            List<Sup> supList = SupDAO.Instance.GetListSupport();
            cbSup.DataSource = supList;
            cbSup.DisplayMember = "name";
        }

        // giá thành của dịch vụ :
        void LoadPrice(int id)
        {
            List<Sup> supList = SupDAO.Instance.GetPriceSupport(id);
            cbSup.DataSource = supList;
            cbSup.DisplayMember = "price";
        }

        void LoadRoom() // xuất các ô "Phòng" dưới đạng hình vuông và có thông tin
        {
            List<Room> roomList = RoomDAO.Instance.LoadRoomList();

            foreach (Room item in roomList)
            {
                Button btn = new Button() { Width = RoomDAO.RoomWidth, Height = RoomDAO.RoomHeight };

                btn.Text = item.Name + Environment.NewLine + item.Status;

                btn.Click += Btn_Click;// nếu bấm vào các ô Phòng thì sẽ hiện ra danh sách

                btn.Tag = item;

                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.LightPink;
                        break;

                    case "Đang sửa":
                        btn.BackColor = Color.LightGray;
                        break;

                    default:
                        btn.BackColor = Color.LightGreen;
                        break;
                }

                flbRoom.Controls.Add(btn);
            }
        }
        void ShowBill(int id)// lấy danh sách bill
        {
            lvBill.Items.Clear();

            List<Sup> listBillInfo = SupDAO.Instance.GetListSupportByRoom(id);

            float total=1000000;

            foreach(Sup item in listBillInfo)
            {
                ListViewItem lvItem = new ListViewItem(item.Name.ToString());

                lvItem.SubItems.Add(item.Price.ToString());

                //lvItem.SubItems.Add(item.ID.ToString());

                total += item.Price;

                lvBill.Items.Add(lvItem);
            }

            txbTotal.Text = total.ToString();
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            int roomID = ((sender as Button).Tag as Room).ID;
            ShowBill(roomID);
        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        } 

        private void flbRoom_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btShowBill_Click(object sender, EventArgs e)
        {
            fShowBill f = new DoAnQUanLyKhachSan.fShowBill();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
        // hàm comboBox2_... chạy sẽ gọi hàm LoadListSup()
         private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        int id = 0;

        ComboBox box = sender as ComboBox;

        if (box.SelectedItem == null)
        {
            return ;
        }

        Sup selected = box.SelectedItem as Sup;

           //id = selected.ID;

        LoadPrice(id);
        

        }
    }
}
