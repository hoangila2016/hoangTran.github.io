using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windowform1
{
    public class PhanSo
    {
         public int TuSo, MauSo;
        public PhanSo()
        {
        }
        public PhanSo(int tuSo,int mauSo)
        { 
            TuSo= tuSo;
            MauSo= mauSo;
        }
        public static PhanSo CongPhanSo(PhanSo ps1, PhanSo ps2)
        {
            return new PhanSo(ps1.TuSo*ps2.MauSo+ps1.MauSo*ps2.TuSo,ps1.MauSo*ps2.MauSo);
        }
        public static PhanSo TruPhanSo(PhanSo ps1, PhanSo ps2)
        {
            return new PhanSo(ps1.TuSo * ps2.MauSo - ps1.MauSo * ps2.TuSo, ps1.MauSo * ps2.MauSo);
        }
        public static PhanSo NhanPhanSo(PhanSo ps1, PhanSo ps2)
        {
            return new PhanSo(ps1.TuSo * ps2.TuSo, ps1.MauSo * ps2.MauSo);
        }
        public static PhanSo ChiaPhanSo(PhanSo ps1, PhanSo ps2)
        {
            return new PhanSo(ps1.TuSo * ps2.MauSo , ps1.MauSo * ps2.TuSo);
        }
        public static void RutGon(ref PhanSo ps)
        {
            int max = Math.Abs(ps.TuSo);
            int rutgon = 1;
            if (Math.Abs(ps.TuSo) > Math.Abs(ps.MauSo))
            { 
                max= Math.Abs(ps.MauSo);
            }
            for (int i = 2; i <= max; i++)
            {
                if(ps.TuSo%i==0&&ps.MauSo%i==0)
                    rutgon= i;
            }
            if (ps.MauSo < 0)
            {
                ps.TuSo *= -1;
                ps.MauSo *= -1;
            }
            ps.TuSo /= rutgon;
            ps.MauSo /= rutgon;

        }
    }
}
