using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BouncingBall
{
    class Circle : IShape
    {
        Pen pen;
        float px;
        float py;
        float vy;
        const float G = 0.068f;

        public Circle()
        {
            Random r = new Random();
            px = r.Next(10, 250);
            py = r.Next(0, 100);
            vy = 0f;
            pen = new Pen(Color.Green, 2);
        }

        public void Update()
        {
            vy += G;
            py += vy;

            if (py + 25f >= 238f)
            {
                py = 238f - 25f; 
                vy *= -1;
            }
       
        }


        public void Draw(PaintEventArgs e)
        {
            e.Graphics.DrawEllipse(pen, px, py, 25f, 25f);
        }
    }
}
