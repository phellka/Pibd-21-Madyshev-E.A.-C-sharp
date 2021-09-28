using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsPlane
{
    class PlaneRadar
    {
        private float startPosX;
        private float startPosY;
        private int pictureWidth;
        private int pictureHeight;
        private readonly int planeWidth = 170;
        private readonly int planeHeight = 80;
        public int maxSpeed { private set; get; }
        public float weight { private set; get; }
        public Color mainColor { private set; get; }
        public Color dopColor { private set; get; }
        public bool hvRadar { private set; get; }
        public bool hvEngine { private set; get; }

        public void Init(int maxSpeed, float weight, Color mainColor, Color dopColor,
                        bool hvRadar, bool hvEngine) {
            this.maxSpeed = maxSpeed;
            this.weight = weight;
            this.mainColor = mainColor;
            this.dopColor = dopColor;
            this.hvRadar = hvRadar;
            this.hvEngine = hvEngine;
        }
        public void SetPosition(int x, int y, int width, int height) {
            startPosX = x;
            startPosY = y;
            pictureWidth = width;
            pictureHeight = height;
        }
        public void MoveTransport(Direction direction) {
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
        public void DrawTransport(Graphics gr) {
            Pen pen = new Pen(Color.Black);
            Brush mainBrush = new SolidBrush(mainColor);
            Brush dopBrush = new SolidBrush(dopColor);
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
            //двиигатель
            if (hvEngine) {
                gr.FillEllipse(dopBrush, startPosX + planeWidth * 6 / 16, startPosY + planeHeight * 7 / 10, planeHeight * 1 / 5, planeHeight * 1 / 5);
                gr.FillEllipse(dopBrush, startPosX + planeWidth * 9 / 16, startPosY + planeHeight * 7 / 10, planeHeight * 1 / 5, planeHeight * 1 / 5);
                gr.FillRectangle(dopBrush, startPosX + planeWidth * 6 / 16 + planeHeight * 1 / 10, startPosY + planeHeight * 7 / 10,
                                           planeWidth * 3 / 16, planeHeight * 1 / 5);
            }
            //радар
            if (hvRadar) {
                gr.DrawLine(pen, startPosX + planeWidth * 3 / 4, startPosY + planeHeight * 1 / 5, startPosX + planeWidth * 3 / 4, startPosY + planeHeight * 2 / 5);
                gr.FillPie(dopBrush, startPosX + planeWidth * 3 / 4 - planeHeight / 10, startPosY + planeHeight * 1 / 5, planeHeight / 5, planeHeight / 10, 180, 180);
            }
        }
    }
}
//dop????
