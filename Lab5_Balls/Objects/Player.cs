using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Balls.Objects
{
    public class Player : BaseObject
    {
        public Player(float x, float y, float angle) : base(x, y, angle) { }
        public Action<Marker> onMarkerOverlap;
        public Action<Target> onObjectOverlap;
        public float vX, vY;

        public override void render(Graphics g)
        {
            if (color == Color.White)
            {
                g.FillEllipse(new SolidBrush(color), -15, -15, 30, 30);
                g.DrawEllipse(new Pen(color), -15, -15, 30, 30);
                g.DrawLine(new Pen(color), 0, 0, 25, 0);
            }
            else
            {
                g.FillEllipse(new SolidBrush(Color.DeepSkyBlue), -15, -15, 30, 30);
                g.DrawEllipse(new Pen(Color.Black), -15, -15, 30, 30);
                g.DrawLine(new Pen(Color.Black, 2), 0, 0, 25, 0);
            }
        }

        public override GraphicsPath getGraphicsPath()
        {
            var path = base.getGraphicsPath();
            path.AddEllipse(-15, -15, 30, 30);
            return path;
        }

        public override void overlap(BaseObject obj)
        {
            base.overlap(obj);

            if (obj is Marker)
            {
                onMarkerOverlap(obj as Marker);
            }

            else if (obj is Target)
            {
                onObjectOverlap(obj as Target);
            }
        }
    }
}
