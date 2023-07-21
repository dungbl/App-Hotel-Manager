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

namespace DoAnQUanLyKhachSan
{
    public partial class fShowBill : Form
    {
        public fShowBill()
        {
            InitializeComponent();

            LoadBill();
        }
        private void LoadBill()
        {
            List<Bill> billList = BillDAO.Instance.LoadBillList();

            foreach (Bill item in billList)
            {
                Button btn = new Button() { Width = BillDAO.BillWidth, Height = BillDAO.BillHeight };

                string b = "";

                if (item.Status.ToString().Equals("0"))
                    b = "Chưa trả tiền phòng";
                else
                    b = "Đã trả tiền phòng";

                btn.Text = "Mã phòng: " + item.ID + Environment.NewLine + "Ngày vào: " + item.DateIn + Environment.NewLine + "Ngày ra: " + item.DateOut + Environment.NewLine + "Mã phòng: " + item.IdRoom + Environment.NewLine + b + Environment.NewLine + "Mã khách: " + item.IdCus;

                btn.Click += Btn_Click;// nếu bấm vào các ô bill thì sẽ hiện ra danh sách

                btn.Tag = item;

                switch (item.Status)
                {
                    case 0:
                        btn.BackColor = Color.LightPink;
                        break;
                    default:
                        btn.BackColor = Color.LightGray;
                        break;
                }

                flbBill.Controls.Add(btn);
            }
        }

        void ShowAllBill(int id)// lấy danh sách bill
        {
            lvSup.Items.Clear();

            List<Sup> listBill = SupDAO.Instance.GetListSupportByBill(id);

            float total = 1000000;

            foreach (Sup item in listBill)
            {
                ListViewItem lvItem = new ListViewItem(item.Name.ToString());



                lvItem.SubItems.Add(item.Price.ToString());

                total += item.Price;

                lvSup.Items.Add(lvItem);

            }

            txbTotalBill.Text = total.ToString();
        }

        

        private void Btn_Click(object sender, EventArgs e)
        {
            int billID = ((sender as Button).Tag as Bill).ID;
            //ShowDetailBill(billID);
            ShowAllBill(billID);
        
        }

        //void ShowDetailBill(int billID)
       // {

    // tính giá trị hóa đơn
         //   List<Sup> listBillInfo = SupDAO.Instance.GetListSupportByRoom(ID);

          //  float totalBill = 0;

          //  foreach (Sup itemSp in listBillInfo)
          //  {
            ///     ListViewItem lvItem = new ListViewItem(items.Name.ToString());

           //      lvItem.SubItems.Add(items.Price.ToString());

          //      total += items.Price;

         ////        lvBill.Items.Add(lvItem);
         //   }

          //  txbTotal.Text = total.ToString();

          //  lvAllBill.Items.Add(lvItem);
          //  }

private void fShowBill_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
