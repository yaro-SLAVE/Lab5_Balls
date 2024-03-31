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
    public class DangerZone : BaseObject
    {
        public int radius = 2;
        public DangerZone(float x, float y, float angle) : base(x, y, angle) { }
        public Action<Player> onPlayerOverlap;

        public override void render(Graphics g)
        {
            if (color == Color.White)
            {
                g.FillEllipse(new SolidBrush(color), -this.radius, -this.radius, this.radius * 2, this.radius * 2);
                g.DrawEllipse(new Pen(color), -this.radius, -this.radius, this.radius * 2, this.radius * 2);
            }
            else
            {
                g.FillEllipse(new SolidBrush(Color.MistyRose), -this.radius, -this.radius, this.radius * 2, this.radius * 2);
                g.DrawEllipse(new Pen(Color.Red), -this.radius, -this.radius, this.radius * 2, this.radius * 2);
            }
        }

        public override GraphicsPath getGraphicsPath()
        {
            var path = base.getGraphicsPath();
            path.AddEllipse(-this.radius, -this.radius, this.radius * 2, this.radius * 2);
            return path;
        }

        public void resize()
        {
            ++radius;
        }

        public override void overlap(BaseObject obj)
        {
            base.overlap(obj);

            if (obj is Player)
            {
                onPlayerOverlap(obj as Player);
            }
        }
    }
}
