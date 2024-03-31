using Lab5_Balls.Objects;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_Balls
{
    public class NegativeWall : BaseObject
    {
        private float fieldHeight;
        private float fieldWidth;
        private float width = 1;
        private float x1;
        private float maxWidth = 100;

        public NegativeWall(float x, float y, float angle, float height, float width) : base(x, y, angle) 
        {
            this.fieldHeight = height;
            this.fieldWidth = width;
            color = Color.Black;
            x1 = x;
        }
        public Action<BaseObject> onObjectOverlap;

        public override void render(Graphics g)
        {
            g.FillRectangle(new SolidBrush(color), x1, y, width, fieldHeight);
            g.DrawRectangle(new Pen(color), x1, y, width, fieldHeight);
        }

        public override GraphicsPath getGraphicsPath()
        {
            var path = base.getGraphicsPath();
            path.AddEllipse(x1, y, width, fieldHeight);
            return path;
        }

        public override void overlap(BaseObject obj)
        {
            base.overlap(obj);

            if (obj != null)
            {
                onObjectOverlap(obj);
            }
        }

        public void move()
        {
            if (width < maxWidth && x1 < maxWidth / 2)
            {
                ++width;
                x1 = width / 2;
            }
            else if(width == maxWidth && x1 <= fieldWidth - maxWidth / 2)
            {
                ++x1;
            }
            else if (x1 > fieldWidth - maxWidth / 2)
            {
                --width;
                ++x1;
            }
            else if (x1 == fieldWidth)
            {
                x1 = 0;
                width = 0;
            }
        }
    }
}
