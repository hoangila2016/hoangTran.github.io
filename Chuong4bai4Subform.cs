using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
namespace BaiTapLamTHem
{
    public partial class Chuong4bai4Subform : Form
    {
        Image img;
        public Chuong4bai4Subform()
        {
            InitializeComponent();
        }
        void loadIMG(string name)
        {
            img = Image.FromFile(name);
            pictureBox1.Image = img;     
        }
        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadIMG(Application.StartupPath+ @"\Images C#\cat.png");
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "file hinh anh|*.png;*.jpg;*.gif|hinh png|*.png|hinh jpg|*.jpg|hinh gif|*.gif";
            if(dlg.ShowDialog()==DialogResult.OK)
            {
                loadIMG(dlg.FileName);
            }    
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg=new SaveFileDialog();
            dlg.Filter = "file hinh anh|*.png;*.jpg;*.gif|hinh png|*.png|hinh jpg|*.jpg|hinh gif|*.gif";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                if(dlg.FileName.ToLower().EndsWith(".png"))
                    img.Save(dlg.FileName,ImageFormat.Png);
                if (dlg.FileName.ToLower().EndsWith(".jpg"))
                    img.Save(dlg.FileName, ImageFormat.Jpeg);
                if (dlg.FileName.ToLower().EndsWith(".gif"))
                    img.Save(dlg.FileName, ImageFormat.Gif);
            }    
        }
    }
}
