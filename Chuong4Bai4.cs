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
    public partial class Chuong4Bai4 : Form
    {
        public Chuong4Bai4()
        {
            InitializeComponent();
        }

        private void tileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Chuong4bai4Subform f= new Chuong4bai4Subform();
            f.MdiParent = this;
            f.Show();
        }

        private void casscadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(Form f in MdiChildren)
                f.Close();
        }
    }
}
