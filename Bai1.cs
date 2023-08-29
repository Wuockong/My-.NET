using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuiQuocCong
{
    class Bai1
    {
        int x, y;
        string ten;
        public int toaDoX
        {
            get { return x; }
            set { value = x; }
        }
        public int toaDoY
        {
            get { return y; }
            set { value = y; }
        }
        public string tenToaDo
        {
            get { return ten; }
            set { value = ten; }
        }
        public Bai1()
        {
            this.x = 0;
            this.y = 0;
            this.ten = "Unknown";
        }
        public Bai1(int x, int y, string ten)
        {
            this.x = x;
            this.y = y;
            this.ten = ten;
        }
        public void toString()
        {
            Console.WriteLine("Toa do: " + ten.ToString() + "(" + x.ToString() + "," + y.ToString() + ")");
        }

        public void nhap()
        {
            Console.WriteLine("Nhap ten toa do: ");
            ten = Console.ReadLine();
            Console.WriteLine("Nhap toa do diem x: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap toa do diem y: ");
            y = int.Parse(Console.ReadLine());
        }
    }
}
