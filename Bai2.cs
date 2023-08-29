using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuiQuocCong
{
    class Bai2
    {
        int ma;
        string ten;
        double lt, th;
        public int maSV
        {
            get { return ma; }
            set
            {
                if (value <= 0)
                    throw new Exception("ma sinh vien khong hop le (songuyen > 0)");
                value = ma;
            }
        }
        public string tenSV
        {
            get { return ten; }
            set
            {
                if (value.Length == 0)
                    throw new Exception("ten sinh vien khong de rong");
                value = ten;
            }
        }
        public double diemLT
        {
            get { return lt; }
            set
            {
                if (value < 0.0 && value > 10.0)
                    throw new Exception("diem khong hop le [0.0,10.0]");
                value = lt; 
              }
        }
        public double diemTH
        {
            get { return th; }
            set
            {
                if (value < 0.0 && value > 10.0)
                    throw new Exception("diem khong hop le [0.0,10.0]");
                value = th;
            }
        }
        public Bai2()
        {
            this.ma = 2001210455;
            this.ten = "Bui Quoc Cong";
            this.lt = 10;
            this.th = 7.5;
        }
        public Bai2(int ma, string ten, double lt, double th)
        {
            this.ma = ma;
            this.ten = ten;
            this.lt = lt;
            this.th = th;
        }
        public double DTB()
        {
            return (lt + th) / 2;
        }
        public override string ToString()
        {

            return c;
        }
    }
}
