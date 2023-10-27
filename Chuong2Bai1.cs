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
    public partial class Chuong2Bai1 : Form
    {
        public Chuong2Bai1()
        {
            InitializeComponent();
        }

        private void btChuyenASCII_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtASCII.Text != null)
                {
                    char a = (char)Convert.ToInt64(txtASCII.Text);
                    lbkq1.Text = a.ToString();
                }
            }
            catch (FormatException )
            {
                lbkq1.Text = "Phải Nhập Số";
            }
        }

        private void btChuyenKyTu_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtKyTu.Text != null)
                {
                    char a = char.Parse(txtKyTu.Text);
                    int a2 = (int)a;
                    lbkq2.Text = a2.ToString();
                }
            }
            catch (FormatException)
            {
                lbkq2.Text = "Phải Nhập Ký Tự";
            }

        }
    }
}
