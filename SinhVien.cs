using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_Buoi8
{
    abstract public class SinhVien
    {
        public String Hovaten;

        abstract public double getdiemtb();


        public virtual string xeploai()
        {
            if (getdiemtb() > 5 && getdiemtb() < 7)
            {
                return "Khá";
            }
            else if (getdiemtb() > 7)
            {
                return " Giỏi";

            }
            else
            {
                {
                    return "yeu";
                }


            }
            return " kém ";
        }
            
    }
}
