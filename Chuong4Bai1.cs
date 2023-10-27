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
    public partial class Chuong4Bai1 : Form
    {
        public Chuong4Bai1()
        {
            InitializeComponent();
        }
        void init()
        {
            txtNhap.Text = "";
            lv1.Items.Clear();
            lv2.Items.Clear();
            lv2.BackColor = Color.White;
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            if(txtNhap.Text!="")
            {
                ListViewItem item = new ListViewItem(txtNhap.Text);
                lv1.Items.Add(item);
            }
        }

        private void btPhai_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in lv1.SelectedItems)
            {
                lv1.Items.Remove(item);
                lv2.Items.Add(item);
            }    
        }

        private void btTrai_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lv2.SelectedItems)
            {
                lv2.Items.Remove(item);
                lv1.Items.Add(item);
            }
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            if(lv1.Items.Count >0)
            lv1.Items.RemoveAt(lv1.Items.Count-1);
        }

        private void btClearAll_Click(object sender, EventArgs e)
        {
            init();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lv2.BackColor = Color.FromName(comboBox1.SelectedItem.ToString());
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Chuong4Bai1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn Đóng ưng dụng không","Đóng",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.No)
            {
                e.Cancel=true;
            }    
        }
    }
}
