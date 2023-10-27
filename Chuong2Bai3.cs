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
    public partial class Chuong2Bai3 : Form
    {
        Random ran= new Random();
        int so1;
        int so2;
        int so3;
        int kq;
        public Chuong2Bai3()
        {
            InitializeComponent();
        }
        void init()
        {
            kq=so1=    so2 = so3 = 0;
            lbSo1.Text=so1.ToString();
            lbSo2.Text = so2.ToString();
            lbSo3.Text = so3.ToString();
        }
        private void btPlay_Click(object sender, EventArgs e)
        {
            so1 = ran.Next(0, 10);
            so2 = ran.Next(0, 10);
            so3 = ran.Next(0, 10);
            lbSo1.Text = so1.ToString();
            lbSo2.Text = so2.ToString();
            lbSo3.Text = so3.ToString();
            if (so1 == so2 && so1 == so3)
            {
                kq += 10;
            }
            else
            {
                kq-= 10;
            }    
            lbKetQua.Text=kq.ToString();
        }

        private void Chuong2Bai3_Load(object sender, EventArgs e)
        {
            init();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
