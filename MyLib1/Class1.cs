using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MyLib1
{
    public class Class1
    {

        abstract public class Figure
        {
            public int x;
            public int y;
            public int w;
            public int h;
            abstract public void Draw();
            //abstract public void MoveTo(int x, int y);
            public class Rectagle : Figure
            {
                public Rectagle(int x, int y, int w, int h)
                {
                    this.x = x;
                    this.y = y;
                    this.w = w;
                    this.h = h;
                }
                public Rectagle()
                {
                    this.x = 0;
                    this.y = 0;
                    this.w = 0;
                    this.h = 0;
                }
                public override void Draw()
                   {
                    Graphics g = Graphics.FromImage(Init.bitmap);
                    g.DrawRectangle(Init.pen, this.x, this.y, this.w,this.h);
                    Init.pictureBox.Image = Init.bitmap;
                   }


            }
        }
        
}
}
