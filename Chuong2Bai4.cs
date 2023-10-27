using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
namespace BaiTapLamTHem
{
    public partial class Chuong2Bai4 : Form
    {
        public Chuong2Bai4()
        {
            InitializeComponent();
        }  
        void init()
        {
            lbHienThi.Text = "";
        }
        private void btDEL_Click(object sender, EventArgs e)
        {
            init();
        }

        private void Chuong2Bai4_Load(object sender, EventArgs e)
        {
            init();
            lbHienThi.Text = "7+3x3/3-2";
        }

        private void btNhap_Click(object sender, EventArgs e)
        {
            if(!timDauBang(lbHienThi.Text))
            {
                Button button = (Button)sender;
                lbHienThi.Text += button.Text;
            }  
            else
            {
                init();
            }    
        }
        private void btNhapToanTu_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            lbHienThi.Text += button.Text;
        }

        private void btR_Click(object sender, EventArgs e)
        {
            if (lbHienThi.Text != "")
            {
                lbHienThi.Text = lbHienThi.Text.Substring(0, lbHienThi.Text.Length - 1);
            }
        }
        bool timDauBang(string s)
        {
            for(int i=0;i<s.Length;i++)
            {
                if (s[i] == '=')
                    return true;
            }    
            return false;
        }
        int timNhan(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'x')
                    return i;
            }
            return -1;
        }
        int timChia(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '/')
                    return i;
            }
            return -1;
        }
        int timCong(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '+')
                    return i;
            }
            return -1;
        }
        int timTru(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '-')
                    return i;
            }
            return -1;
        }
        int diToanTuTuViTri(string s,int index)
        {
            for(int i=index;i<s.Length;i++)
            {
                if (s[i] == '+'|| s[i] == '-'|| s[i] == 'x'|| s[i] == '/')
                    return i;
            }    
            return s.Length;
        }
        int diToanTuTuViTriNguoc(string s, int index)
        {
            for (int i = index; i >0; i--)
            {
                if (s[i] == '+' || s[i] == '-' || s[i] == 'x' || s[i] == '/')
                    return i;
            }
            return -1;
        }
        private void btBang_Click(object sender, EventArgs e)
        {

            try
            {
                int kq = 0;
                string s = lbHienThi.Text;
                if (!timDauBang(s))
                {
                    //Nhân chia trước
                    int count1 = 0;
                    int count2 = 0;
                        while(s.Contains("x")||s.Contains("/"))
                        {
                            count1++;
                            if (count1 > 50)
                            {
                            MessageBox.Show("Nhập Phép Toán sai");
                            break;
                            }    
                            
                            if (s.IndexOf("x")>0)
                            {
                                int i=s.IndexOf("x");
                            int a;
                            if (diToanTuTuViTriNguoc(s, i - 1) > 0)
                            {
                                a = int.Parse(s.Substring(diToanTuTuViTriNguoc(s, i - 1), i - diToanTuTuViTriNguoc(s, i - 1)));
                            }
                            else
                            {
                                a = int.Parse(s.Substring(0, i));
                            }
                            int b = int.Parse(s.Substring(i + 1, diToanTuTuViTri(s,i+1) - i -1));
                                string temp = s.Substring(diToanTuTuViTriNguoc(s, i - 1)+1, i - diToanTuTuViTriNguoc(s, i - 1)+1);
                                kq= (a * b);
                                s = s.Replace(temp,kq.ToString());
                            }
                            if (s.IndexOf("/") > 0)
                            {
                                int i = s.IndexOf("/");
                            int a;
                            if (diToanTuTuViTriNguoc(s, i - 1) > 0)
                            {
                                a = int.Parse(s.Substring(diToanTuTuViTriNguoc(s, i - 1), i - diToanTuTuViTriNguoc(s, i - 1)));
                            }
                            else
                            {
                                a = int.Parse(s.Substring(0, i));
                            }
                            int b = int.Parse(s.Substring(i + 1, diToanTuTuViTri(s,i+1) - i -1));
                                 string temp = s.Substring(diToanTuTuViTriNguoc(s, i - 1)+1, i - diToanTuTuViTriNguoc(s, i - 1)+1);
                                kq= (a / b);
                                s = s.Replace(temp,kq.ToString());
                            }
                        }
                    //cộng trừ sau
                    while (s.Contains("+") || s.Contains("-"))
                    {
                        count2++;
                        if (count2 > 50)
                        {
                            MessageBox.Show("Nhập Phép Toán sai");
                            break;
                        }
                        if (s.IndexOf("+") > 0)
                        {
                            int i = s.IndexOf("+");
                            int a;
                            if(diToanTuTuViTriNguoc(s, i - 1)>0)
                            {
                                 a = int.Parse(s.Substring(diToanTuTuViTriNguoc(s, i - 1), i - diToanTuTuViTriNguoc(s, i - 1)));
                            }    
                            else
                            {
                                 a = int.Parse(s.Substring(0, i));
                            }    
                            int b = int.Parse(s.Substring(i + 1, diToanTuTuViTri(s, i + 1) - i - 1)); kq = (a * b);
                            string temp = s.Substring(diToanTuTuViTriNguoc(s, i - 1) +1 , i - diToanTuTuViTriNguoc(s, i - 1) + 1);
                            kq = (a + b);
                            s = s.Replace(temp, kq.ToString());
                        }
                        if (s.IndexOf("-") > 0)
                        {
                            int i = s.IndexOf("-");
                            int a;
                            if (diToanTuTuViTriNguoc(s, i - 1) > 0)
                            {
                                a = int.Parse(s.Substring(diToanTuTuViTriNguoc(s, i - 1), i - diToanTuTuViTriNguoc(s, i - 1)));
                            }
                            else
                            {
                                a = int.Parse(s.Substring(0, i));
                            }
                            int b = int.Parse(s.Substring(i + 1, diToanTuTuViTri(s, i + 1) - i - 1));
                            string temp = s.Substring(diToanTuTuViTriNguoc(s, i - 1)+1 , i - diToanTuTuViTriNguoc(s, i - 1) + 1);
                            kq = (a - b);
                            s = s.Replace(temp, kq.ToString());
                        }
                    }
                    lbHienThi.Text += "=" + kq;
                }                   
                else
                {
                    lbHienThi.Text = "";
                }    
            }
            catch (FormatException)
            {
                MessageBox.Show("Nhập Phép Toán sai");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Không thể chia cho 0");
            }
        }
    }
}
