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
        private readonly AirfieldCollection airfieldCollection;
        public FormAirfield() {
            InitializeComponent();
            airfieldCollection = new AirfieldCollection(pictureBoxAirfield.Width, pictureBoxAirfield.Height);
            Draw();
        }
        private void ReloadAirfields() {
            int index = listBoxAirfields.SelectedIndex;
            listBoxAirfields.Items.Clear();
            for (int i = 0; i < airfieldCollection.Keys.Count; i++) {
                listBoxAirfields.Items.Add(airfieldCollection.Keys[i]);
            }
            if (listBoxAirfields.Items.Count > 0 && (index == -1 || index >= listBoxAirfields.Items.Count)) {
                listBoxAirfields.SelectedIndex = 0;
            }
            else
                if (listBoxAirfields.Items.Count > 0 && index > -1 && index < listBoxAirfields.Items.Count) {
                    listBoxAirfields.SelectedIndex = index;
                }
        }
        private void Draw() {
            Bitmap bmp = new Bitmap(pictureBoxAirfield.Width, pictureBoxAirfield.Height); //для правильной отрисовки при удалении единственного аэродрома перенесено
            Graphics gr = Graphics.FromImage(bmp);
            if (listBoxAirfields.SelectedIndex > -1) {
                airfieldCollection[listBoxAirfields.SelectedItem.ToString()].Draw(gr);
            }
            pictureBoxAirfield.Image = bmp;
        }
        private void buttonAddAirfield_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(textBoxNewAirfield.Text)) {
                MessageBox.Show("Введите название аэродрома", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            airfieldCollection.AddAirfield(textBoxNewAirfield.Text);
            ReloadAirfields();
        }
        private void buttonDelAirfield_Click(object sender, EventArgs e) {
            if (listBoxAirfields.SelectedIndex > -1) {
                if (MessageBox.Show($"Удалить аэродром { listBoxAirfields.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes) {
                    airfieldCollection.DelAirfield(listBoxAirfields.SelectedItem.ToString());
                    ReloadAirfields();
                }
                Draw();                                                             //для удаления единственного
            }
        }
        private void buttonSetPlane_Click(object sender, EventArgs e) {
            if (listBoxAirfields.SelectedIndex > -1) {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK) {
                    var plane = new Plane(100, 1000, dialog.Color);
                    if ((airfieldCollection[listBoxAirfields.SelectedItem.ToString()] + plane) > -1) {
                        Draw();
                    }
                    else {
                        MessageBox.Show("Аэродром переполнен");
                    }
                }
            }
        }
        private void buttonSetPlaneRadar_Click(object sender, EventArgs e) {
            if (listBoxAirfields.SelectedIndex > -1) {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK) {
                    ColorDialog dialogDop = new ColorDialog();
                    if (dialogDop.ShowDialog() == DialogResult.OK) {
                        var plane = new PlaneRadar(100, 1000, dialog.Color, dialogDop.Color, true, true);
                        if ((airfieldCollection[listBoxAirfields.SelectedItem.ToString()] + plane) > -1) {
                            Draw();
                        }
                        else {
                            MessageBox.Show("Аэродром переполнен");
                        }
                    }
                }
            }
        }
        private void buttonTakePlane_Click(object sender, EventArgs e) {
            if (listBoxAirfields.SelectedIndex > -1 && maskedTextBoxDelPlane.Text != "") {
                var plane = airfieldCollection[listBoxAirfields.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBoxDelPlane.Text);
                if (plane != null) {
                    FormPlane form = new FormPlane();
                    form.SetPlane(plane);
                    form.ShowDialog();//нижняя форма не активна, если просто шоу, то активны обе
                }
                Draw();
            }
        }
        private void listBoxAirfields_SelectedIndexChanged(object sender, EventArgs e) {
            Draw();
        }
    }
}
