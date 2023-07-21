using DoAnQUanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQUanLyKhachSan.DAO
{
    public class BillInfoDAO
    {
        private static BillInfoDAO instance;

        public static BillInfoDAO Instance
        {
            get { if (instance == null) instance = new BillInfoDAO(); return BillInfoDAO.instance; }

            private set { BillInfoDAO.instance = value; }
        }

        private BillInfoDAO() { }

        public List<Support> GetListBillInfo(int id)
        {
            List<Support> listBillInfo = new List<Support>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.BillInfo where idBill = " +id);

            foreach ( DataRow item in data.Rows )
            {
                Support info = new Support(item);

                listBillInfo.Add(info);
            }

            return listBillInfo;
        }
    }
}
