using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsPlane
{
    class PlaneRadar :Plane
    {//перегрузить метод перемещения базового класса
        public Color dopColor { private set; get; }
        public bool hvRadar { private set; get; }
        public bool hvEngine { private set; get; }
        public PlaneRadar(int maxSpeed, float weight, Color mainColor, Color dopColor, bool hvRadar, bool hvEngine) :
                base(maxSpeed, weight, mainColor) {
            this.dopColor = dopColor;
            this.hvEngine = hvEngine;
            this.hvRadar = hvRadar;
        }
        public override void DrawTransport(Graphics gr) {
            Pen pen = new Pen(Color.Black);
            Brush dopBrush = new SolidBrush(dopColor);
            base.DrawTransport(gr);
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
