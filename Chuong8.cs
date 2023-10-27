using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLamTHem
{
    public partial class Chuong8 : Form
    {
        public Chuong8()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Chuong8_Load(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Rectangle rect = new Rectangle(ClientRectangle.Width / 2 -
            50, ClientRectangle.Height / 2 - 50, 100, 100);
            Pen p = new Pen(Brushes.Red);
            g.DrawEllipse(p, rect);
        }

        private void drawTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DrawText f= new DrawText();
            f.MdiParent = this;
            f.Show();
        }

        private void drawImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DrawImage f = new DrawImage();
            f.MdiParent = this;
            f.Show();
        }

        private void drawByMouseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DrawMouse f = new DrawMouse();
            f.MdiParent = this;
            f.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt1.Text = listBox1.SelectedIndex.ToString();
            txt1.Text += listBox1.SelectedItem.ToString();
        }
    }
}
