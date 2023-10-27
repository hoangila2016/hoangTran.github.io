using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace BaiTapLamTHem
{
    public partial class Chuong6bai1 : Form
    {
        public Chuong6bai1()
        {
            InitializeComponent();
        }

        private void Chuong6bai1_Load(object sender, EventArgs e)
        {
            initTree();
        }
        public void initTree()
        {
            string[] arrayFile = Directory.GetLogicalDrives();
            TreeNode node = null;
            foreach (string file in arrayFile) {
                node = new TreeNode(file);
                tvFile.Nodes.Add(node);
                node.Nodes.Add("temp");
            }
        }

        private void tvFile_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode node =e.Node;
            node.Nodes.Clear();
            node.ImageIndex = 1;
            try
            {
                foreach(string dir in Directory.GetDirectories(node.FullPath))
                {
                    TreeNode n = node.Nodes.Add(Path.GetFileName(dir));
                    n.Nodes.Add("temp");
                }    
            }
            catch { }
        }

        private void tvFile_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.ImageIndex = 0;
        }

        private void tvFile_AfterSelect(object sender, TreeViewEventArgs e)
        {
            picture.Image = null;
            string[] arrayFile = Directory.GetFiles(e.Node.FullPath);
            pnIcon.Controls.Clear();
            foreach (string file in arrayFile)
            {
                if(file.ToLower().EndsWith(".png")||
                   file.ToLower().EndsWith(".jpg")||
                   file.ToLower().EndsWith(".gif"))
                {
                    PictureBox pic =new PictureBox();
                    Image image = Image.FromFile(file);
                    pic.SizeMode=PictureBoxSizeMode.StretchImage;
                    pic.Image = image;
                    pic.Cursor = Cursors.Hand;
                    pnIcon.Controls.Add(pic);
                    pic.Click += Pic_Click;

                }    
            }
        }

        private void Pic_Click(object sender, EventArgs e)
        {
            PictureBox pc= (PictureBox) sender;
            picture.Image = pc.Image;
        }
    }
}
