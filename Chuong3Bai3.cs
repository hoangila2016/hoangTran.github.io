using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLamTHem
{
    public partial class Chuong3Bai3 : Form
    {
        public Chuong3Bai3()
        {
            InitializeComponent();
        }

        private void btKiemTra_Click(object sender, EventArgs e)
        {

        }
        HinhTron hinhTron ;
        private void btTinhToan_Click(object sender, EventArgs e)
        {
            try
            {
                double r = double.Parse(txtBanKinh.Text);
                int x= int.Parse(txtX.Text);
                int y = int.Parse(txtY.Text);
                if(r<0)
                {
                    MessageBox.Show("Bán Kính Lớn Hơn 0");
                }    
                else
                {
                    Diem diem = new Diem(x,y);
                    hinhTron=new HinhTron(diem,r);
                    txtDienTich.Text = HinhTron.DienTich(hinhTron.r).ToString();
                    txtChuVi.Text = HinhTron.ChuVi(hinhTron.r).ToString();
                }    
            }
            catch (FormatException) {
                MessageBox.Show("Nhập Đúng Số!");
            }
        }

        private void btKiemTra_Click_1(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(txtXnew.Text);
                int y = int.Parse(txtYnew.Text);
                Diem N= new Diem(x,y);
                if (HinhTron.CoTrongHinhTron(hinhTron, N))
                {
                    txtKiemTra.Text = "có trong hình tròn";
                }
                else
                    txtKiemTra.Text = "Không có trong hình tròn";
            }
            catch (FormatException)
            {
                MessageBox.Show("Nhập Đúng Số!");
            }
        }
    }
}
