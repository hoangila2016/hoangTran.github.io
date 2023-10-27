using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLamTHem
{
    public partial class Chuong5bai1 : Form
    {
        public Chuong5bai1()
        {
            InitializeComponent();
        }
        int count = 0;
        Point Pold;
        string[] ArrayFile;
        Random ran=new Random();
        void addPic()
        {
            count++;
            string file = ArrayFile[ran.Next(0,ArrayFile.Length)];
            Image img = Image.FromFile(file);
            PictureBox pic = new PictureBox();
            pic.BackgroundImage = img;
            pic.Name=count.ToString();
            pic.Location = new Point(0,0);
            pic.Width = 100;
            pic.Height = 90;
            pic.BackgroundImageLayout = ImageLayout.Stretch;
            pic.MouseDown += Pic_MouseDown;
            pic.MouseMove += Pic_MouseMove;
            pic.MouseUp += Pic_MouseUp;
            this.Controls.Add(pic);
            this.Controls.SetChildIndex(flowLayoutPanel1, this.Controls.Count-1);
            this.Controls.SetChildIndex(label1,this.Controls.Count);
        }

        private void Pic_MouseUp(object sender, MouseEventArgs e)
        {
            PictureBox a= (PictureBox)sender;
            if(flowLayoutPanel1.Bounds.Contains(a.Left,a.Top))
            {
                flowLayoutPanel1.Controls.Add(a);
                addPic();
            }    
        }
        private void Pic_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Left)
            {
                PictureBox a = (PictureBox)sender;
                int dx = e.X - Pold.X;
                int dy = e.Y - Pold.Y;
                a.Left += dx;
                a.Top += dy;
            }    
        }

        private void Pic_MouseDown(object sender, MouseEventArgs e)
        {
            Pold= e.Location;
        }

        private void Chuong5bai1_Load(object sender, EventArgs e)
        {
            ArrayFile = Directory.GetFiles(Application.StartupPath+ @"\Images C#");
            addPic();
        }

        private void Chuong5bai1_KeyDown(object sender, KeyEventArgs e)
        {
            Control[] a = this.Controls.Find(count.ToString(),true); 
            PictureBox b= (PictureBox)a[0];
            switch(e.KeyCode)
            {
                case Keys.Up: if(b.Top>0) b.Top -= 10; break;
                case Keys.Down: if(b.Bottom<this.ClientRectangle.Height) b.Top += 10; break;
                case Keys.Left: if(b.Left>0)b.Left -= 10; break;
                case Keys.Right: if(b.Right<this.ClientRectangle.Width)b.Left += 10; break;
            }
            if (flowLayoutPanel1.Bounds.Contains(b.Left, b.Top))
            {
                flowLayoutPanel1.Controls.Add(b);
                addPic();
            } 
                
        }

        private void flowLayoutPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            Pold = e.Location;
        }

        private void flowLayoutPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button== MouseButtons.Left)
            {
                FlowLayoutPanel a = (FlowLayoutPanel)sender;
                int dx = e.X - Pold.X;
                    int dy= e.Y-Pold.Y;
                a.Left += dx;
                a.Top+= dy;
            }    
        }
    }
}
