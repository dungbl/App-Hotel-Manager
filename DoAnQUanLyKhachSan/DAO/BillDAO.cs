using DoAnQUanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQUanLyKhachSan.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance
        {
            get{ if (instance == null) instance = new BillDAO();return BillDAO.instance; }

            private set{ BillDAO.instance = value;}
        }

        //chiều dài và rộng của các ô "Phòng"
        public static int BillWidth = 135;

        public static int BillHeight = 135;

        private BillDAO() { }
        // chạy thành công thì trả về BillId
        // thất bại trả về -1
        public int GetUncheckBillIDByTableID(int ID)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Bill where idRoom = "+ ID +" and status = 0");

            if(data.Rows.Count >0)
            {
                Bill bill = new Bill(data.Rows[0]);

                return bill.ID;
            }
            return -1;
        }
        public List<Bill> LoadBillList()
        {
            List<Bill> billList = new List<Bill>();

            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetBillList");

            foreach (DataRow item in data.Rows)
            {
                Bill bill = new Bill(item);

                billList.Add(bill);
            }

            return billList;
        }

        public List<Bill> LoadFormationBillList(int ID)
        {
            List<Bill> billList = new List<Bill>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Bill where idBill ="+ID);

            foreach (DataRow item in data.Rows)
            {
                Bill bill = new Bill(item);

                billList.Add(bill);
            }

            return billList;
        }
    }
}
