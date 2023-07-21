using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQUanLyKhachSan.DTO
{
    public class Room
    {
        public Room(int id, string name, string status)
        {
            this.ID = id;
            this.Name = name;
            this.Status = status;

        }
        public Room(DataRow row)    
        {
            this.ID = (int)row["id"]; // Ép về kiểu int
            this.Name = row["name"].ToString();
            this.Status = row["status"].ToString();
        }

        private string status;

        private string name;        

        private int iD;

        public int ID
        {
            get{return iD;}
            set{iD = value;}
        }

        public string Status
        {
            get{return status;}
            set{status = value;}
        }

        public string Name
        {
            get{return name;}
            set{name = value;}
        }
    }
}
