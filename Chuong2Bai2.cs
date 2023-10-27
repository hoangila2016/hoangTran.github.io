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
    public partial class Chuong2Bai2 : Form
    {
        public Chuong2Bai2()
        {
            InitializeComponent();
        }

        private void btGiai_Click(object sender, EventArgs e)
        {
            try
            {
                double a = 0; 
                double b = 0; 
                double c = 0; 
                if (txtA.Text != null)
                {
                    a = double.Parse(txtA.Text);
                }
                if (txtB.Text != null)
                {
                    b = double.Parse(txtB.Text);
                }
                if (txtC.Text != null)
                {
                    c = double.Parse(txtC.Text);
                }
                if(a!=0)
                {
                    double delta = b * b - 4 * (a * c);
                    if (delta > 0)
                    {
                        lbKetQua.Text = string.Format("x1={0}     x2={1}", ((-b + Math.Sqrt(delta)) / (2 * a)), ((-b - Math.Sqrt(delta)) / (2 * a)));
                    }
                    else if (delta < 0)
                    {
                        lbKetQua.Text = string.Format("Vô nghiệm");
                    }
                    else
                    {
                        lbKetQua.Text = string.Format("Nghiệm Kép x={0}", -b / (2 * a));
                    }
                }  
                else
                {
                    lbKetQua.Text = string.Format("A Khác 0");
                }    
            }
            catch (FormatException)
            {
                lbKetQua.Text = string.Format("Nhập Đúng số");
            }
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
