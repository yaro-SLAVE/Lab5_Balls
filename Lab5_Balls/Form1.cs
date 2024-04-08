using Lab5_Balls.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_Balls
{
    public partial class Form1 : Form
    {
        private int formId = 1;
        private static List<BaseObject> objects = new List<BaseObject>();
        private static List<BaseObject> negativeObjects = new List<BaseObject>();
        private Player player;
        private Marker marker;
        private Target target;
        private DangerZone danZone;
        private NegativeWall wall;
        private int scores = 0;
        private int version;
        private static Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
            updateScores();
            player = new Player(mainField.Width / 2, mainField.Height / 2, 0);
            marker = new Marker(mainField.Width / 2 + 50, mainField.Height / 2 + 50, 0);
            danZone = new DangerZone(0, 0, 0);
            wall = new NegativeWall(0, mainField.Height / 2, 0, mainField.Height, mainField.Width);

            version = Properties.Settings.Default.version;

            timer1.Enabled = true;
            targetTimer.Enabled = true;

            switch (version)
            {
                case 0:
                    objects.Add(danZone);
                    updateDangerZone();
                    danZoneTimer.Enabled = true;
                    break;
                case 1:
                    objects.Add(wall);
                    wallTimer.Enabled = true;
                    break;
            }

            int n = Properties.Settings.Default.countEll;
            for (int i = 0; i < n; ++i)
            {
                addTarget();
            }

            player.onOverlap += (p, obj) =>
            {
                logBox.Text = $"[{DateTime.Now:HH:mm:ss:ff}] Игрок пересекся с {obj}\n" + logBox.Text;
            };

            danZone.onPlayerOverlap += (p) =>
            {
                updateDangerZone();
                --scores;
                updateScores();
            };

            player.onMarkerOverlap += (m) =>
            {
                objects.Remove(m);
                marker = null;
            };

            player.onObjectOverlap += (t) =>
            {
                objects.Remove(t);
                t = null;
                addTarget();
                ++scores;
                updateScores();
            };

            target.onTargetOverlap += (t) =>
            {
                objects.Remove(t);
                t = null;
                addTarget();
            };

            wall.onObjectOverlap += (o) =>
            {
                negativeObjects.Add(o);
            };

           /* wall.dontObjectOverlap += (o) =>
            {
                negativeObjects.Remove(o);
            };*/

            objects.Add(marker);
            objects.Add(player);
        }

        private void mainField_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;

            g.Clear(Color.White);

            updatePlayer();
            negativeObjects.Clear();

            foreach (var obj1 in objects.ToList())
            {
                foreach (var obj2 in objects.ToList())
                {
                    if (obj1 != obj2 && obj1.overlaps(obj2, g))
                    {
                        obj1.overlap(obj2);
                    }
                }
            }

            foreach (var obj in objects)
            {
                g.Transform = obj.getTransform();
                obj.color = negativeObjects.Contains(obj);
                obj.render(g);

            }
        }

        private void updatePlayer()
        {
            if (marker != null)
            {
                float dx = marker.x - player.x;
                float dy = marker.y - player.y;

                float length = (float)Math.Sqrt(dx * dx + dy * dy);
                dx /= length;
                dy /= length;

                player.x += dx * 2;
                player.y += dy * 2;

                float vCoef = Properties.Settings.Default.vCoef * 0.25f;

                player.vX += dx * vCoef;
                player.vY += dy * vCoef;

                player.angle = (float)(90 - Math.Atan2(player.vX, player.vY) * 180 / Math.PI);

              
            }
            player.vX += -player.vX * 0.1f;
            player.vY += -player.vY * 0.1f;

            player.x += player.vX;
            player.y += player.vY;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            mainField.Invalidate();
        }

        private void mainField_MouseClick(object sender, MouseEventArgs e)
        {

            if (marker == null)
            {
                marker = new Marker(0, 0, 0);
                objects.Add(marker);
            }

            marker.x = e.X;
            marker.y = e.Y;
        }

        private void addTarget()
        {

            var d = 70;

            var x = rand.Next() % (mainField.Width - d) + d;
            var y = rand.Next() % (mainField.Height - d) + d;
            this.target = new Target(x, y, 0);

            objects.Add(target);
        }

        private void updateScores()
        {
            labelScores.Text = "Очки: " + scores;
        }

        private void targetTimer_Tick(object sender, EventArgs e)
        {
            Target t = null;
            foreach (var obj in objects.ToList())
            {
                if (obj is Target && (obj as Target).canResize())
                {
                    (obj as Target).resize();
                }
                else if (obj is Target && !(obj as Target).canResize())
                {
                    objects.Remove(obj);
                    t = (obj as Target);
                    t = null;
                    addTarget();
                }
            }
        }

        private void danZoneTimer_Tick(object sender, EventArgs e)
        {
            this.danZone.resize();
        }

        private void wallTimer_Tick(object sender, EventArgs e)
        {
            wall.move();
        }

        private void updateDangerZone()
        {
            var rand = new Random(Guid.NewGuid().GetHashCode());

            var d = 2;

            var x = rand.Next() % (mainField.Width - d) + d;
            var y = rand.Next() % (mainField.Height - d) + d;

            danZone.radius = 2;
            danZone.x = x;
            danZone.y = y;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
