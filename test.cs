using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLamTHem
{
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }

        private void test_Load(object sender, EventArgs e)
        {

            int[] arrInt = { 1, 2, 3 };
            Console.Write("Mang khoi tao: ");
            foreach (int n in arrInt)
                Console.Write("{0,4}", n);
            DoubleArray(arrInt);
            Console.Write("\nMang sau khi goi DoubleArray: ");
            foreach (int n in arrInt)
                Console.Write("{0,4}", n);
            Console.ReadLine();


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            SolidBrush redBr = new SolidBrush(Color.Red);
            g.FillEllipse(redBr, 50, 20, 30, 30);
        }

        private void test_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("down");
        }

        private void test_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("press");
        }

        private void test_KeyUp(object sender, KeyEventArgs e)
        {
            MessageBox.Show("up");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        static void DoubleArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                arr[i] = arr[i] * 2;
            arr = new int[] { 10, 11, 12 };
        }

    }
}
