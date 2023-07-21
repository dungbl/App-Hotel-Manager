using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DoAnQUanLyKhachSan.DTO;

namespace DoAnQUanLyKhachSan.DAO
{
    public class RoomDAO
    {
        private static RoomDAO instance;//Ctrl + r + e

        public static RoomDAO Instance
        {
            get { if (instance == null) instance = new RoomDAO(); return RoomDAO.instance; }
            private set { RoomDAO.instance = value; }
        }
        //chiều dài và rộng của các ô "Phòng"
        public static int RoomWidth = 90;

        public static int RoomHeight = 90;

        private RoomDAO() { }
        // lấy dữ liệu cho vào
        public List<Room> LoadRoomList()
        {
            List<Room> roomList = new List<Room>();

            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetRoomList");

            foreach (DataRow item in data.Rows)
            {
                Room room = new Room(item);

                roomList.Add(room);
            }

            return roomList;
        }
        // lấy giá theo id

    }
}
