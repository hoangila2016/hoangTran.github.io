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
    public partial class Chuong4Bai2 : Form
    {
        public Chuong4Bai2()
        {
            InitializeComponent();
        }
        void changeSize(RichTextBox b, int a)
        {
            Font font = new Font(b.SelectionFont.FontFamily, a, b.SelectionFont.Style);
            b.SelectionFont = font;
        }
        void changeStyleeBold(RichTextBox b)
        {
            Font font = new Font(b.SelectionFont.FontFamily, b.Font.Size,FontStyle.Bold);
            b.SelectionFont = font;
        }
        void changeStyleItalic(RichTextBox b)
        {
            Font font = new Font(b.SelectionFont.FontFamily, b.Font.Size, FontStyle.Italic);
            b.SelectionFont = font;
        }
        void changeStyleUnderline(RichTextBox b)
        {
            Font font = new Font(b.SelectionFont.FontFamily, b.Font.Size, FontStyle.Underline);
            b.SelectionFont = font;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            changeStyleeBold(rtContent);
        }

        private void cbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            int a = int.Parse(cbSize.SelectedItem.ToString());
            changeSize(rtContent, a);
        }

        private void bti_Click(object sender, EventArgs e)
        {
            changeStyleItalic(rtContent);
        }

        private void btU_Click(object sender, EventArgs e)
        {
            changeStyleUnderline(rtContent);
        }

        private void Chuong4Bai2_Load(object sender, EventArgs e)
        {
            rtContent.Text = "ashuodhasuodhuashd\nhúahduiashd";
        }
        void ChangeColor(RichTextBox b,int red,int green, int blue)
        {
            b.SelectionColor=Color.FromArgb(red,green,blue);
        }
        private void hscRed_Scroll(object sender, ScrollEventArgs e)
        {
            int red = hscRed.Value; int green=hscGreen.Value; int blue=hscBlue.Value;
            ChangeColor( rtContent,red,green,blue);
        }
        void ChangeFontFamily(RichTextBox b, string text)
        {
            Font font = new Font(text,b.SelectionFont.Size,b.SelectionFont.Style);
            b.SelectionFont = font;
        }
        private void lbFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = lbFont.SelectedItem.ToString();
            ChangeFontFamily(rtContent, s);
        }
    }
}
