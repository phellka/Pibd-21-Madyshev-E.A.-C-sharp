using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsPlane
{
    public abstract class Vehicle : ITransport
    {
        protected float startPosX;
        protected float startPosY;
        protected int pictureWidth;
        protected int pictureHeight;
        public int maxSpeed { protected set; get; }
        public float weight { protected set; get; }
        public Color mainColor { protected set; get; }
        public void SetPosition(int x, int y, int width, int height) {
            startPosX = x;
            startPosY = y;
            pictureWidth = width;
            pictureHeight = height;
        }
        public abstract void MoveTransport(Direction direction);
        public abstract void DrawTransport(Graphics gr);
        public void SetMainColor(Color mainColor) {
            this.mainColor = mainColor;
        }
    }
}
