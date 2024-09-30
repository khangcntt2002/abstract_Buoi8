using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_Buoi8
{
    public class SinhVienIT : SinhVien 
    {
        public double diemjava;
        public double diemcss;

        public override double getdiemtb()
        {
            return (diemjava + diemcss);
        }
    }
}
