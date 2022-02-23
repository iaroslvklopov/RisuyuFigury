using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RisuyuFigury
{
    public partial class Form1 : Form
    {
        private Bitmap bitmap;
        private Pen pen;
        static class Init
        {
            public static Bitmap bitmap;
            public static PictureBox picB;
            public static Pen pen;
        }
        public Form1()
        {
            InitializeComponent();
            Bitmap bitmap = new Bitmap(picB.ClientSize.Width, picB.ClientSize.Height);
            Pen pen = new Pen(Color.Black, 5);
            Init.bitmap = bitmap;
            Init.picB = picB;
            Init.pen = pen;

        }
        private void Narisovatbtn_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(Init.bitmap);
            g.DrawLine(Init.pen, 100, 150, 200, 250);
            Init.picB.Image = Init.bitmap;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Steret_btn_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(Init.bitmap);
            g.Clear(Color.White);
            Init.picB.Image = Init.bitmap;

        }
    }
}
