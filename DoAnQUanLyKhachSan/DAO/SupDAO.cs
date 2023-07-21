using DoAnQUanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnQUanLyKhachSan.DAO
{
    public class SupDAO
    {
        private static SupDAO instance;

        public static SupDAO Instance
        {
            get { if (instance == null) instance = new SupDAO(); return SupDAO.instance; }
            private set { SupDAO.instance = value; }
        }
        private SupDAO() { }
        // lấy dịch vụ theo mã phòng
        public List<Sup> GetListSupportByRoom(int ID)
        {
            List<Sup> listSupport = new List<Sup>();

            string query = "select s.name, bi.idBill,s.price from dbo.BillInfo as bi, dbo.Bill as b, dbo.Support as s where bi.idBill = b.id and bi.idSupport = s.id and idRoom =";

            DataTable data = DataProvider.Instance.ExecuteQuery(query + ID);

            foreach (DataRow item in data.Rows)
            {
               
                Sup sup = new Sup(item);

                listSupport.Add(sup);
            }

            return listSupport;
        }
        // lấy ds dịch vụ theo mã bill
        public List<Sup> GetListSupportByBill(int ID)
        {
            List<Sup> listSupport = new List<Sup>();

            string query = "select s.name, bi.idBill,s.price from dbo.BillInfo as bi, dbo.Bill as b, dbo.Support as s where bi.idBill = b.id and bi.idSupport = s.id and idBill =";

            DataTable data = DataProvider.Instance.ExecuteQuery(query + ID);

            foreach (DataRow item in data.Rows)
            {
                Sup sup = new Sup(item);

                listSupport.Add(sup);
            }

            return listSupport;
        }
        // hiển thị toàn bộ ds dịch vụ
        public List<Sup> GetListSupport()
        {
            List<Sup> listSupport = new List<Sup>();

            string query = "select * from dbo.Support";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Sup sup = new Sup(item);

                listSupport.Add(sup);
            }

            return listSupport;
        }
        // lấy gái theo id
        public List<Sup> GetPriceSupport(int id)
        {
            List<Sup> listSupport = new List<Sup>();

            string query = "select * from dbo.Support where id=" +id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Sup sup = new Sup(item);

                listSupport.Add(sup);
            }

            return listSupport;
        }
    }
}
