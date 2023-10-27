using Microsoft.SqlServer.Server;
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
    public partial class DrawText : Form
    {
        public DrawText()
        {
            InitializeComponent();
        }

        private void DrawText_Paint(object sender, PaintEventArgs e)
        {
            Font f = new Font("Arial",36,FontStyle.Bold);
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Far;
            e.Graphics.DrawString("Hello", f, Brushes.Green,ClientRectangle,format);

            TextureBrush br1 = new TextureBrush(Image.FromFile(Application.StartupPath+ @"\Images C#\cat.png"));
            format.Alignment = StringAlignment.Near;
            format.LineAlignment=StringAlignment.Far;
            e.Graphics.DrawString("hello", f, br1, ClientRectangle, format);

            HatchBrush br2 = new HatchBrush(HatchStyle.DarkDownwardDiagonal, Color.Yellow, Color.YellowGreen);
            format.FormatFlags = StringFormatFlags.DirectionVertical;
            format.Alignment= StringAlignment.Near;
            format.LineAlignment=StringAlignment.Near;
            e.Graphics.DrawString("hello", f, br2, ClientRectangle, format);

            LinearGradientBrush br3 = new LinearGradientBrush(ClientRectangle,Color.Silver,Color.Red,45);
            format.Alignment=StringAlignment.Far;
            format.LineAlignment=StringAlignment.Far;
            e.Graphics.DrawString("hello", f, br3, ClientRectangle, format);
        }

        private void DrawText_SizeChanged(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}
