using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Balls.Objects
{
    public class BaseObject
    {
        public float x;
        public float y;
        public float angle;
        public bool color;

        public Action<BaseObject, BaseObject> onOverlap;

        public BaseObject(float x, float y, float angle)
        {
            this.x = x;
            this.y = y;
            this.angle = angle;
        }

        public virtual void render(Graphics g)
        {
        }

        public Matrix getTransform()
        {
            var matrix = new Matrix();
            matrix.Translate(this.x, this.y);
            matrix.Rotate(this.angle);

            return matrix;
        }

        public virtual GraphicsPath getGraphicsPath()
        {
            return new GraphicsPath();
        }

        public virtual bool overlaps(BaseObject obj, Graphics g)
        {
            var path1 = this.getGraphicsPath();
            var path2 = obj.getGraphicsPath();

            path1.Transform(this.getTransform());
            path2.Transform(obj.getTransform());

            var region = new Region(path1);
            region.Intersect(path2);
            return !region.IsEmpty(g);
        }

        public virtual void overlap(BaseObject obj) 
        {
            if (this.onOverlap != null)
            {
                this.onOverlap(this, obj);
            }
        }
    }
}
