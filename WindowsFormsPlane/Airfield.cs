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
        private readonly List<T> places;
        private readonly int maxCount;
        private readonly int pictureWidth;
        private readonly int pictureHeight;
        private readonly int placeSizeWidth = 330;
        private readonly int placeSizeHeight = 90;
        private readonly int airfieldWidth;
        private readonly int airfieldHeight;
        public Airfield(int picWidth, int picHeight) {
            airfieldWidth = picWidth / placeSizeWidth;
            airfieldHeight = picHeight / placeSizeHeight;
            maxCount = airfieldWidth * airfieldHeight;
            pictureWidth = picWidth;
            pictureHeight = picHeight;
            places = new List<T>();
        }
        public static int operator +(Airfield<T> p, T plane) {
            if (p.places.Count >= p.maxCount) {
                throw new AirfieldOverflowException();
            }
            p.places.Add(plane);
            return p.places.Count - 1;
        }
        public static T operator -(Airfield<T> p, int index) {
            if (index <= -1 || index >= p.places.Count) {
                throw new AirfieldVehicleNotFoundException(index);
            }
            T bufPlane = p.places[index];
            p.places.RemoveAt(index);
            return bufPlane;
        }
        public void Draw(Graphics gr) {
            DrawMarking(gr);
            for (int i = 0; i < places.Count; i++) {
                places[i].SetPosition(i % airfieldWidth * placeSizeWidth + 10, i / airfieldWidth * placeSizeHeight + 5, pictureWidth, pictureHeight);
                places[i]?.DrawTransport(gr);
            }
        }
        private void DrawMarking(Graphics gr) {
            Pen pen = new Pen(Color.Black, 3);
            for (int i = 0; i < airfieldWidth; i++) {
                for (int j = 0; j < airfieldHeight + 1; ++j) {
                    gr.DrawLine(pen, i * placeSizeWidth, j * placeSizeHeight, i * placeSizeWidth + placeSizeWidth / 2, j * placeSizeHeight);
                }
                gr.DrawLine(pen, i * placeSizeWidth, 0, i * placeSizeWidth,
               (airfieldHeight) * placeSizeHeight);
            }
        }
        public T this[int index]{
            get{
                if (index > -1 && index < places.Count) {
                    return places[index];
                }
                else {
                    return null;
                }
            }
        }
    }
}
