using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsPlane
{
    class Plane : Vehicle, IEquatable<Plane>
    {
        protected int planeWidth = 170;
        protected int planeHeight = 80;
        protected readonly char separator = ';';
        public Plane(int maxSpeed, float weight, Color mainColor) {
            base.maxSpeed = maxSpeed;
            base.weight = weight;
            base.mainColor = mainColor;
        }
        public Plane(string info) {
            string[] strs = info.Split(separator);
            if (strs.Length == 3) {
                maxSpeed = Convert.ToInt32(strs[0]);
                weight = Convert.ToInt32(strs[1]);
                mainColor = Color.FromName(strs[2]);
            }
        }
        protected Plane(int maxSpeed, float weight, Color mainColor, int planeWidth, int planeHeight) {
            base.maxSpeed = maxSpeed;
            base.weight = weight;
            base.mainColor = mainColor;
            this.planeWidth = planeWidth;
            this.planeHeight = planeHeight;
        }
        public override void MoveTransport(Direction direction) {
            float step = maxSpeed * 100 / weight;
            switch (direction) {
                case Direction.Right:
                    if (startPosX + step <= pictureWidth - planeWidth) {
                        startPosX += step;
                    }
                    break;
                case Direction.Left:
                    if (startPosX - step >= 0) {
                        startPosX -= step;
                    }
                    break;
                case Direction.Up:
                    if (startPosY - step >= 0) {
                        startPosY -= step;
                    }
                    break;
                case Direction.Down:
                    if (startPosY + step <= pictureHeight - planeHeight) {
                        startPosY += step;
                    }
                    break;
            }
        }
        public override void DrawTransport(Graphics gr) {
            Pen pen = new Pen(Color.Black);
            Brush mainBrush = new SolidBrush(mainColor);
            //корпус
            gr.FillRectangle(mainBrush, startPosX + planeHeight * 1 / 5, startPosY + planeHeight * 2 / 5, planeWidth - planeHeight * 2 / 5, planeHeight * 2 / 5);
            gr.FillEllipse(mainBrush, startPosX, startPosY + planeHeight * 2 / 5, planeHeight * 2 / 5, planeHeight * 2 / 5);
            Point[] bufPointO = { new Point((int)startPosX + planeWidth - planeHeight / 5, (int)startPosY + planeHeight * 2 / 5),
                                 new Point((int)startPosX + planeWidth - planeHeight / 5, (int)startPosY + planeHeight * 4 / 5),
                                 new Point((int)startPosX + planeWidth, (int)startPosY + planeHeight * 3 / 5)};
            gr.FillPolygon(mainBrush, bufPointO);
            gr.DrawPolygon(pen, bufPointO);
            gr.DrawLine(pen, startPosX + planeWidth - planeHeight / 5, startPosY + planeHeight * 3 / 5, startPosX + planeWidth, startPosY + planeHeight * 3 / 5);
            //крылья
            Point[] bufPointT = { new Point((int)startPosX + planeHeight / 5, (int)startPosY),
                                 new Point((int)startPosX + planeHeight / 5, (int)startPosY + planeHeight * 2 / 5),
                                 new Point((int)startPosX + planeHeight * 3 / 5, (int)startPosY + planeHeight * 2 / 5)};
            gr.FillPolygon(mainBrush, bufPointT);
            gr.FillEllipse(new SolidBrush(Color.Black), startPosX + planeHeight / 10, startPosY + planeHeight * 7 / 20, planeHeight * 2 / 5, planeHeight / 10);
            gr.FillEllipse(new SolidBrush(Color.Black), startPosX + planeWidth / 4, startPosY + planeHeight / 2, planeWidth / 2, planeHeight / 5);
            //шасси
            gr.DrawLine(pen, startPosX + planeWidth / 4, startPosY + planeHeight * 4 / 5, startPosX + planeWidth / 4, startPosY + planeHeight * 19 / 20);
            gr.DrawEllipse(pen, startPosX + planeWidth / 4 - planeHeight / 10, startPosY + planeHeight * 9 / 10, planeHeight / 10, planeHeight / 10);
            gr.DrawEllipse(pen, startPosX + planeWidth / 4, startPosY + planeHeight * 9 / 10, planeHeight / 10, planeHeight / 10);
            gr.DrawLine(pen, startPosX + planeWidth * 3 / 4, startPosY + planeHeight * 4 / 5, startPosX + planeWidth * 3 / 4, startPosY + planeHeight * 9 / 10);
            gr.DrawEllipse(pen, startPosX + planeWidth * 3 / 4 - planeHeight / 20, startPosY + planeHeight * 9 / 10, planeHeight / 10, planeHeight / 10);
        }
        public override string ToString() {
            return $"{maxSpeed}{separator}{weight}{separator}{mainColor.Name}";
        }

        public bool Equals(Plane other) {
            if (other == null) {
                return false;
            }
            if (GetType().Name != other.GetType().Name) {
                return false;
            }
            if (maxSpeed != other.maxSpeed) {
                return false;
            }
            if (weight != other.weight) {
                return false;
            }
            if (mainColor != other.mainColor) {
                return false;
            }
            return true;
        }
        public override bool Equals(object obj) {
            if (obj == null) {
                return false;
            }
            if (!(obj is Plane)) {
                return false;
            }
            else {
                return Equals((Plane)obj);
            }
        }
    }
}
