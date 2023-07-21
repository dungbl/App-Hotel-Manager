using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQUanLyKhachSan.DTO
{
    public class Bill
    {
        public Bill(int iD, DateTime? dateIn,DateTime? dateOut,int idRoom, string idCus ,int status )
        {
            this.ID = iD;
            this.DateIn = dateIn;
            this.DateOut = dateOut;
            this.IdRoom = idRoom;
            this.IdCus = idCus;
            this.Status = status;

        }

        public Bill(DataRow row)
        {
            this.ID = (int)row["id"];

            this.DateIn = (DateTime?)row["dateIn"];

            var dateOutTemp = row["dateOut"];

            if(dateOutTemp.ToString() != "")
                this.DateOut = (DateTime?)dateOutTemp;


            this.IdRoom = (int)row["idRoom"];

            this.IdCus = (string)row["idCus"];

            this.Status = (int)row["status"];
        }
        private string idCus;

        private int idRoom;

        private int status;

        private DateTime? dateIn;

        private DateTime? dateOut;

        private int iD;

        public DateTime? DateIn
        {
            get{return dateIn;}

            set{dateIn = value;}
        }

        public DateTime? DateOut
        {
            get{return dateOut;}

            set{dateOut = value;}
        }

        public int ID
        {
            get{return iD;}

            set{iD = value;}
        }

        public int Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }

        public int IdRoom
        {
            get
            {
                return idRoom;
            }

            set
            {
                idRoom = value;
            }
        }

        public string IdCus
        {
            get
            {
                return idCus;
            }

            set
            {
                idCus = value;
            }
        }
    }
}
