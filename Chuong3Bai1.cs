using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using windowform1;

namespace BaiTapLamTHem
{
    public partial class Chuong3Bai1 : Form
    {
        public Chuong3Bai1()
        {
            InitializeComponent();
        }
        Random random = new Random();
        PhanSo so3 = new PhanSo();
        void init()
        {
            lbMauSo1.Text = lbMauSo2.Text = lbMauSo3.Text = lbTuSo1.Text = lbTuSo2.Text = lbTuSo3.Text = lbKetQua.Text= "";
            txtTu.Text = txtMau.Text = "";
            lbToanTu.Text = "+";
        }
        private void Chuong3Bai1_Load(object sender, EventArgs e)
        {
            init();
        }
        void chonToanTu()
        {
            int toanTu=random.Next(0,4);
            if(toanTu==0)
            {
                lbToanTu.Text="+";
            }
            if (toanTu == 1)
            {
                lbToanTu.Text = "-";
            }
            if (toanTu == 2)
            {
                lbToanTu.Text = "x";
            }
            if (toanTu == 3)
            {
                lbToanTu.Text = "/";
            }
        }
        PhanSo PhanSoNgauNhien()
        {
            int tu=random.Next(1,100);
            int mau=random.Next(1,100);
            return new PhanSo(tu,mau);
        }
        private void btBatDau_Click(object sender, EventArgs e)
        {
            try
            {

                chonToanTu();
                //Nhap lieu
                PhanSo so1= PhanSoNgauNhien();
                PhanSo so2 = PhanSoNgauNhien();
                lbTuSo1.Text= so1.TuSo.ToString();
                lbTuSo2.Text = so2.TuSo.ToString();
                lbMauSo1.Text= so1.MauSo.ToString();
                lbMauSo2.Text = so2.MauSo.ToString();
                if(lbToanTu.Text=="+")
                {
                    so3 = PhanSo.CongPhanSo(so1, so2);
                }
                if (lbToanTu.Text == "-")
                {
                    so3 = PhanSo.TruPhanSo(so1, so2);
                }
                if (lbToanTu.Text == "x")
                {
                    so3 = PhanSo.NhanPhanSo(so1, so2);
                }
                if (lbToanTu.Text == "/")
                {
                    so3 = PhanSo.ChiaPhanSo(so1, so2);
                }
                PhanSo.RutGon(ref so3);   
            }
            catch(FormatException) 
            {
                MessageBox.Show("Nhập số");
            }
            catch(DivideByZeroException)
            {
                MessageBox.Show("Không thê chia cho 0");
            }
        }

        private void btXacNhan_Click(object sender, EventArgs e)
        {
            try
            {
                //kiem tra ket qua
                if (txtTu.Text != "" && txtMau.Text != "")
                {
                    PhanSo a = new PhanSo(int.Parse(txtTu.Text), int.Parse(txtMau.Text));
                    PhanSo.RutGon(ref a);
                    lbTuSo3.Text = so3.TuSo.ToString();
                    lbMauSo3.Text = so3.MauSo.ToString();
                    if (a.TuSo == int.Parse(lbTuSo3.Text) && a.MauSo == int.Parse(lbMauSo3.Text))
                    {
                        lbKetQua.Text = "Đúng";
                    }
                    else
                        lbKetQua.Text = "Sai";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Nhập số");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Không thê chia cho 0");
            }
        }
    }
}
