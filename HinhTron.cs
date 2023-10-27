using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLamTHem
{
    internal class HinhTron
    {
        public Diem Tam;
        public double r;
        public HinhTron()
        {
            Tam=new Diem();
            r=0;
        }
        public HinhTron(Diem tam, double r)
        {
            Tam = tam;
            this.r = r;
        }
        public static double DienTich(double r)
        {
            return Math.PI * r * r;
        }
        public static double ChuVi(double r)
        {
            return Math.PI * r *2 ;
        }
        public static bool CoTrongHinhTron(HinhTron hinhtron,Diem a)
        {
            double KhoangCach = Math.Sqrt(Math.Pow((hinhtron.Tam.x-a.x),2)+ Math.Pow((hinhtron.Tam.y - a.y), 2));
            if (KhoangCach<=hinhtron.r)
            {
                return true;
            }    
            return false;
        }
    }
}
