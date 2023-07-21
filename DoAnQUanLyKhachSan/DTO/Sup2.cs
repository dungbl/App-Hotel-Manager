using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQUanLyKhachSan.DTO
{
    public class Sup2
    {
        public Sup2(string name, float price)
        {
           // this.ID = id;
            this.Name = name;
            this.Price = price;
        }

        public Sup2(DataRow row)
        {
          //  this.ID = (int)row["id"];
            this.Name = (string)row["name"];
            this.Price = (float)Convert.ToDouble(row["price"].ToString());
        }


      //  private int iD;

        private string name;

        private float price;

      //  public int ID
       // {
       //     get
         //   {
        //        return iD;
         //   }

         //   set
          //  {
          //      iD = value;
          //  }
      //  }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public float Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }
    }
}
