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
    public partial class Chuong3Bai2 : Form
    {
        public Chuong3Bai2()
        {
            InitializeComponent();
        }
        void init()
        {
            txtA.Text=txtB.Text=txtC.Text="";
            rtbKetQua.Text = "";
        }
        private void btXacNhan_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(txtA.Text);
                int b = int.Parse(txtB.Text);
                int c = int.Parse(txtC.Text);
                TamGiac tamGiac = new TamGiac(a,b,c);
                int loai = TamGiac.LoaiTamGiac(tamGiac);
                switch (loai)
                {
                    case -1: rtbKetQua.Text = "Không Phải Tam Giác"; break;
                    case 0: 
                    rtbKetQua.Text = string.Format("Đây là Tam Giác Thường:\nDiện Tích:{0:00.00}\nChu Vi:{1:00.00}", TamGiac.DienTich(tamGiac),TamGiac.ChuVi(tamGiac)); 
                    break;
                    case 1: 
                    rtbKetQua.Text = string.Format("Đây là Tam Giác Đều:\nDiện Tích:{0:00.00}\nChu Vi:{1:00.00}", TamGiac.DienTich(tamGiac),TamGiac.ChuVi(tamGiac)); 
                    break;
                    case 2: 
                    rtbKetQua.Text = string.Format("Đây là Tam Giác Cân:\nDiện Tích:{0:00.00}\nChu Vi:{1:00.00}", TamGiac.DienTich(tamGiac),TamGiac.ChuVi(tamGiac)); 
                    break;
                }
            }  
            catch(FormatException)
            {
                MessageBox.Show("Phải Nhập Đúng Số");
            }
        }

        private void Chuong3Bai2_Load(object sender, EventArgs e)
        {
            init();
        }
    }
}
