using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLamTHem
{
    internal class TamGiac
    {
        public int a, b, c;
        public TamGiac() { 
            a=b=c=0;
        }
        public TamGiac(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public static double DienTich(TamGiac tg)
        {
            int p = (tg.a + tg.b + tg.c) / 2;
            return Math.Sqrt(p * (p - tg.a) * (p - tg.b) * (p - tg.c));
        }
        public static double ChuVi(TamGiac tg)
        {
            return tg.a+tg.b + tg.c;
        }
        public static int LoaiTamGiac(TamGiac tg)
        {
            int a=tg.a;
            int b=tg.b;
            int c=tg.c;
            if (a + b > c && a + c > b && b + c > a)
            {
                //tamGiac Đều
                if (a == b && a == c && b == c)
                {
                    return 1;
                }
                //tamGiac Cân
                if (a == b || a == c || b == c)
                {
                    return 2;
                }
                return 0;
            }
            else
                return -1;
        }

    }
}
