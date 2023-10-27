using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLamTHem
{
    public partial class DrawImage : Form
    {
        public DrawImage()
        {
            InitializeComponent();
        }

        private void DrawImage_Load(object sender, EventArgs e)
        {

        }

        private void DrawImage_SizeChanged(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void DrawImage_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rc1= new Rectangle(0,0,ClientRectangle.Width/2,ClientRectangle.Height/2);
            Rectangle rc2 = new Rectangle(0, ClientRectangle.Height / 2, ClientRectangle.Width / 2, ClientRectangle.Height / 2);
            draw1(rc1, e.Graphics);
            draw2(rc2, e.Graphics);
        }
        void draw1(Rectangle rc, Graphics g)
        {
            Image a = Image.FromFile(Application.StartupPath + @"\Images C#\cat.png");
            g.DrawImage(a, rc);
            LinearGradientBrush br1 = new LinearGradientBrush(rc,Color.AliceBlue,Color.Red,45);
            Font f = new Font("Arial", 35, FontStyle.Bold);
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Near;
            sf.LineAlignment = StringAlignment.Far;
            g.DrawString("Con mèo",f,br1,rc,sf);

        }
        void draw2(Rectangle rc, Graphics g)
        {
            Image i = Image.FromFile(Application.StartupPath + @"\Images C#\cat.png");
            TextureBrush br = new TextureBrush(i);
            g.FillRectangle(br,rc);
        }
    }
}
