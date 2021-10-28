using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsPlane
{
    public partial class FormPlaneConfig :Form
    {
        ITransport plane = null;
        private Action<Vehicle> eventAddPlane;
        public void addEvent(Action<Vehicle> ev) {
            if (eventAddPlane == null) {
                eventAddPlane = new Action<Vehicle>(ev);
            }
            else {
                eventAddPlane += ev;
            }
        }
        public FormPlaneConfig() {
            InitializeComponent();
            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
            panelRed.MouseDown += panelColor_MouseDown;
            panelBlack.MouseDown += panelColor_MouseDown;
            panelGreen.MouseDown += panelColor_MouseDown;
            panelNavy.MouseDown += panelColor_MouseDown;
            panelOrange.MouseDown += panelColor_MouseDown;
            panelPink.MouseDown += panelColor_MouseDown;
            panelWhite.MouseDown += panelColor_MouseDown;
            panelYellow.MouseDown += panelColor_MouseDown;
        }
        private void drawPlane() {
            if (plane != null) {
                Bitmap bmp = new Bitmap(pictureBoxShowPlane.Width, pictureBoxShowPlane.Height);
                Graphics gr = Graphics.FromImage(bmp);
                plane.SetPosition(5, 5, pictureBoxShowPlane.Width, pictureBoxShowPlane.Height);
                plane.DrawTransport(gr);
                pictureBoxShowPlane.Image = bmp;
            }
        }
        private void labelPlane_MouseDown(object sender, MouseEventArgs e) {
            labelPlane.DoDragDrop(labelPlane.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }
        private void labelPlaneRadar_MouseDown(object sender, MouseEventArgs e) {
            labelPlaneRadar.DoDragDrop(labelPlaneRadar.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }
        private void panelShowPlane_DragEnter(object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.Text)) {
                e.Effect = DragDropEffects.Copy;
            }
            else {
                e.Effect = DragDropEffects.None;
            }
        }
        private void panelShowPlane_DragDrop(object sender, DragEventArgs e) {
            switch (e.Data.GetData(DataFormats.Text).ToString()) {
                case "Обычный самолет":
                    plane = new Plane((int)numericUpDownMaxSpeed.Value, (int)numericUpDownWeight.Value, Color.White);
                    break;
                case "Самолет с радаром":
                    plane = new PlaneRadar((int)numericUpDownMaxSpeed.Value, (int)numericUpDownWeight.Value, Color.White, Color.Black,
                        checkBoxRadar.Checked, checkBoxEngine.Checked);
                    break;
            }
            drawPlane();
        }
        private void panelColor_MouseDown(object sender, MouseEventArgs e) {
            if (plane != null) {
                (sender as Panel).DoDragDrop((sender as Panel).BackColor, DragDropEffects.Move | DragDropEffects.Copy); //??
            }
        }
        private void labelColor_DragEnter(object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(typeof(Color))) {
                e.Effect = DragDropEffects.Copy;
            }
            else {
                e.Effect = DragDropEffects.None;
            }
        }
        private void labelMainColor_DragDrop(object sender, DragEventArgs e) {
            plane.SetMainColor((Color)e.Data.GetData(typeof(Color)));
            drawPlane();
        }
        private void labelDopColor_DragDrop(object sender, DragEventArgs e) {
            if (plane is PlaneRadar) {
                (plane as PlaneRadar).SetDopColor((Color)e.Data.GetData(typeof(Color)));
            }
            drawPlane();
        }

        private void buttonAddPlane_Click(object sender, EventArgs e) {
            eventAddPlane?.Invoke((Vehicle)plane);
            Close();
        }
    }
}
