using Lab5_Balls.Objects;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Balls
{
    public class Target : BaseObject
    {
        private int radius = 25;
        public Target(float x, float y, float angle) : base(x, y, angle) { }
        public Action<Target> onTargetOverlap;

        public override void render(Graphics g)
        {
            if (color == Color.White)
            {
                g.FillEllipse(new SolidBrush(color), -this.radius, -this.radius, this.radius * 2, this.radius * 2);
            }
            else
            {
                g.FillEllipse(new SolidBrush(Color.Green), -this.radius, -this.radius, this.radius * 2, this.radius * 2);
            }
        }

        public override GraphicsPath getGraphicsPath()
        {
            var path = base.getGraphicsPath();
            path.AddEllipse(-this.radius, -this.radius, this.radius * 2, this.radius * 2);
            return path;
        }

        public bool canResize()
        {
            if (this.radius > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void resize()
        {
            --this.radius;
        }
    }
}
