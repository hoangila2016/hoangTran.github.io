using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLamTHem
{
    public partial class DrawMouse : Form
    {
        Color color=Color.Black;
        int width=1;
        Bitmap bmp= new Bitmap(Screen.PrimaryScreen.Bounds.Width,Screen.PrimaryScreen.Bounds.Height);
        Point Pold;
        public DrawMouse()
        {
            InitializeComponent();
        }

        private void DrawMouse_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bmp,0,0);
        }

        private void DrawMouse_MouseDown(object sender, MouseEventArgs e)
        {
            Pold =e.Location;
        }
        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch(keyData)
            {
                case Keys.R: color= Color.Red; break;
                    case Keys.G: color= Color.Green;
                    break;
                    case Keys.B: color= Color.Blue; break;
                    case Keys.Up: width+=3; break;
                    case Keys.Down: width-=3; break;
            }    
            return true ;
        }
        private void DrawMouse_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Left)
            {
                
                Pen pen = new Pen(color,width);
                pen.EndCap= System.Drawing.Drawing2D.LineCap.Round;
                pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                Graphics g = Graphics.FromImage(bmp);
                g.DrawLine(pen,Pold,e.Location);
                Pold =e.Location;
                Invalidate();
            }    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "file image|*.png;*.jpg;|.png|*.png|.jpg|*.jpg";
            if(dlg.ShowDialog()==DialogResult.OK)
            {
                if(dlg.FileName.ToLower().ToString().EndsWith(".png"))
                {
                    bmp.Save(dlg.FileName,ImageFormat.Png);
                }
                if (dlg.FileName.ToLower().ToString().EndsWith(".jpg"))
                {
                    bmp.Save(dlg.FileName, ImageFormat.Jpeg);
                }
            }    
        }
    }
}
