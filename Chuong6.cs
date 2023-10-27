using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLamTHem
{
    public partial class Chuong6 : Form
    {
        public Chuong6()
        {
            InitializeComponent();
        }

        private void Chuong6_Load(object sender, EventArgs e)
        {
            initTree();
        }
        void initTree()
        {
            TreeNode node = null;
            string[] arrayFileDisc = Directory.GetLogicalDrives();
            foreach(string file in arrayFileDisc)
            {
                node = new TreeNode(file);
                treeView1.Nodes.Add(node);
                node.Nodes.Add("temp");
            }    

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                string[] arrayFile = Directory.GetFiles(e.Node.FullPath);
                flowLayoutPanel1.Controls.Clear();
                foreach (string s in arrayFile)
                {
                    if (s.ToLower().EndsWith(".png") ||
                        s.ToLower().EndsWith(".jpg") ||
                        s.ToLower().EndsWith(".gif"))
                    {
                        PictureBox pc = new PictureBox();
                        pc.Image = Image.FromFile(s);
                        pc.SizeMode = PictureBoxSizeMode.StretchImage;
                        pc.Width = flowLayoutPanel1.Width / 4;
                        pc.Height = flowLayoutPanel1.Height - 10;
                        flowLayoutPanel1.Controls.Add(pc);
                        pc.Cursor = Cursors.Hand;
                        pc.Click += Pc_Click;
                    }

                }
            }
            catch
            { }   
        }

        private void Pc_Click(object sender, EventArgs e)
        {
            PictureBox pc = (PictureBox) sender;
            pictureBox1.Image = pc.Image;
        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode node = e.Node;
            node.Nodes.Clear(); 
            node.ImageIndex = 1;
            try
            {
                foreach (string file in Directory.GetDirectories(node.FullPath))
                {
                    TreeNode n = node.Nodes.Add(Path.GetFileName(file));
                    n.Nodes.Add("temp");
                }
            }
            catch
            {

            }
        }

        private void treeView1_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode node = e.Node;
            node.ImageIndex = 0;
        }
    }
}
