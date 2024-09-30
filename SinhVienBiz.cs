using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_Buoi8
{
    public class SinhVienBiz : SinhVien
    {
        public double ketoan;
        public double Maketting;
        public double Banhang;

        public override double getdiemtb()
        {
            return (ketoan+Maketting+Banhang)/3;
        }
        
    }
}
