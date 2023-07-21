using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnQUanLyKhachSan.DTO
{
    public class Sup
    {
        public Sup(int id,string name, float price)
        {
           // this.ID = id;
            this.Name = name;
            this.Price = price;
        }
        // bị lỗi
        public Sup(DataRow Row)
        {
           // this.ID = (int)Row["id"];
            this.Name = (string)Row["name"];
            this.Price = (float)Convert.ToDouble(Row["price"].ToString()); 
        }

      

        private float price;

        private string name;

        private int iD;

      
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

       // public int ID
        //{
         //   get
          //  {
           //     return iD;
            //}

            //set
            //{
             //   iD = value;
            //}
       // }
    }
}
