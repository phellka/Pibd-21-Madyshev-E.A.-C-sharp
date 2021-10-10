using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsPlane
{
    class Airfield<T> where T : class, ITransport{
        private readonly T[] places;
        private readonly int pictureWidth;
        private readonly int pictureHeight;
        private readonly int placeSizeWidth = 330;
        private readonly int placeSizeHeight = 90;
        private readonly int airfieldWidth;
        private readonly int airfieldHeight;
        public Airfield(int picWidth, int picHeight) {
            airfieldWidth = picWidth / placeSizeWidth;
            airfieldHeight = picHeight / placeSizeHeight;
            places = new T[airfieldWidth * airfieldHeight];
            pictureWidth = picWidth;
            pictureHeight = picHeight;
        }
        public static int operator +(Airfield<T> p, T plane) {
            int i = 0;
            while (i < p.places.Length && p.places[i] != null) {
                i++;
            }
            if (i < p.places.Length && p.places[i] == null) {
                plane.SetPosition(i % p.airfieldWidth * p.placeSizeWidth + 10, i / p.airfieldWidth * p.placeSizeHeight + 5, p.pictureWidth, p.pictureHeight);
                p.places[i] = plane;
                return i;
            }
            else {
                return -1;
            }
        }
        public static T operator -(Airfield<T> p, int index) {
            if (index > -1 && index < p.places.Length && p.places[index] != null) {
                T bufPlane = p.places[index];
                p.places[index] = null;
                return bufPlane;
            }
            else {
                return null;
            }
        }
        public void Draw(Graphics gr) {
            DrawMarking(gr);
            for (int i = 0; i < places.Length; i++) {
                places[i]?.DrawTransport(gr);
            }
        }
        private void DrawMarking(Graphics gr) {
            Pen pen = new Pen(Color.Black, 3);
            for (int i = 0; i < airfieldWidth; i++) {
                for (int j = 0; j < airfieldHeight + 1; ++j) {
                    gr.DrawLine(pen, i * placeSizeWidth, j * placeSizeHeight, i *
                   placeSizeWidth + placeSizeWidth / 2, j * placeSizeHeight);
                }
                gr.DrawLine(pen, i * placeSizeWidth, 0, i * placeSizeWidth,
               (airfieldHeight) * placeSizeHeight);
            }
        }
    }
}
