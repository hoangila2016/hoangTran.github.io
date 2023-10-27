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
    public partial class Chuong4Bai3 : Form
    {
        public Chuong4Bai3()
        {
            InitializeComponent();
        }
        Font a;
        private void Chuong4Bai3_Load(object sender, EventArgs e)
        {
            this.Enabled = false;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.05;
            if (this.Opacity>=1)
            {
                this.Enabled=true;
                timer1.Enabled=false;
                a = rtContent.Font;
            }    

        }

        private void btChon1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "File .exe|*.exe|File png|*.png";
            if(dlg.ShowDialog()==DialogResult.OK)
            {
                rtContent.Text = dlg.FileName;
            }    
        }
        void init()
        {
            rtContent.Text = "";
            rtContent.BackColor = Color.White;
            rtContent.ForeColor = Color.Black;
            rtContent.Font = a;
        }


        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        bool choice = false;
        private void Chuong4Bai3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(choice == false)
            {
                if (MessageBox.Show("Bạn có muốn đóng không", "Đóng", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    if (choice == false)
                    {
                        e.Cancel = true;
                        timer2.Enabled = true;
                    }
                }
            }       
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.05; 
            if (this.Opacity<=0) {
                choice = true;
                this.Close();
            }
        }

        private void btChonNhieu_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Multiselect = true;
            dlg.Filter = "file exe|*.exe|file png|*.png|tất cả|*.*";
            if(dlg.ShowDialog()==DialogResult.OK)
            {
                rtContent.Text = "Có " + dlg.FileNames.Length.ToString()+" file\n";
                foreach(string a in dlg.FileNames)
                {
                    
                    rtContent.Text += a + "\n";
                }   
                
            }    
        }

        private void btFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if(dialog.ShowDialog()==DialogResult.OK)
            {
                rtContent.Text=dialog.SelectedPath.ToString();
            }    
        }

        private void btMauNen_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if(dialog.ShowDialog()==DialogResult.OK)
            {
                rtContent.BackColor = dialog.Color;
            }    
        }

        private void btSize_Click(object sender, EventArgs e)
        {
            ColorDialog dialog= new ColorDialog();
            if(dialog.ShowDialog()==DialogResult.OK)
            {
                rtContent.ForeColor = dialog.Color;
            }    
        }

        private void btFont_Click(object sender, EventArgs e)
        {
            FontDialog dialog= new FontDialog();
            if(dialog.ShowDialog()==DialogResult.OK)
            {
                rtContent.Font=dialog.Font;
            }    
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            init();
        }

        private void rtContent_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
