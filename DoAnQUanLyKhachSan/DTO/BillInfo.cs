using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQUanLyKhachSan.DTO
{
    public class Support
    {
        public Support(int id, int idSupport, int idBill)
        {
            this.ID = id;
            this.IdBill = idBill;
            this.IdSupport = idSupport;
        }

        public Support(DataRow Row)
        {
            this.ID = (int)Row["id"];
            this.IdBill = (int)Row["idBill"];
            this.IdSupport = (int)Row["idSupport"];
        }

        private int idSupport;

        private int idBill;

        private int iD;

        public int ID
        {
            get
            {
                return iD;
            }

            set
            {
                iD = value;
            }
        }

        public int IdBill
        {
            get
            {
                return idBill;
            }

            set
            {
                idBill = value;
            }
        }


        public int IdSupport
        {
            get
            {
                return idSupport;
            }

            set
            {
                idSupport = value;
            }
        }
    }
}
