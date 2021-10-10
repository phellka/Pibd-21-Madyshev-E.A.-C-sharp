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
    public partial class FormAirfield :Form
    {
        private readonly Airfield<Plane> airfield;
        public FormAirfield() {
            InitializeComponent();
            airfield = new Airfield<Plane>(pictureBoxAirfield.Width,
                pictureBoxAirfield.Height);
            Draw();
        }
        private void Draw() {
            Bitmap bmp = new Bitmap(pictureBoxAirfield.Width, pictureBoxAirfield.Height);
            Graphics gr = Graphics.FromImage(bmp);
            airfield.Draw(gr);
            pictureBoxAirfield.Image = bmp;
        }
        private void buttonSetPlane_Click(object sender, EventArgs e) {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK) {
                var plane = new Plane(100, 1000, dialog.Color);
                if ((airfield + plane) > -1) {
                    Draw();
                }
                else {
                    MessageBox.Show("Аэродром переполнен");
                }
            }
        }
        private void buttonSetPlaneRadar_Click(object sender, EventArgs e) {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK) {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK) {
                    var plane = new PlaneRadar(100, 1000, dialog.Color, dialogDop.Color,
                        true, true);
                    if ((airfield + plane) > -1) {
                        Draw();
                    }
                    else {
                        MessageBox.Show("Аэродром переполнен");
                    }
                }
            }
        }
        private void buttonTakePlane_Click(object sender, EventArgs e) {
            if (maskedTextBoxDelPlane.Text != "") {
                var plane = airfield - Convert.ToInt32(maskedTextBoxDelPlane.Text);
                if (plane != null) {
                    FormPlane form = new FormPlane();
                    form.SetPlane(plane);
                    form.ShowDialog();//нижняя форма не активна, если просто шоу, то активны обе
                }
                Draw();
            }
        }
    }
}
