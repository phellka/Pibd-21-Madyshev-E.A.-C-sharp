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
        private void buttonAddPlane_Click(object sender, EventArgs e) {
            if (listBoxAirfields.SelectedIndex > -1) {
                var formPlaneConfig = new FormPlaneConfig();
                formPlaneConfig.addEvent(addPlane);
                formPlaneConfig.Show();
            }
        }
        private void addPlane(Vehicle plane) {
            if (plane != null && listBoxAirfields.SelectedIndex > -1) {
                if ((airfieldCollection[listBoxAirfields.SelectedItem.ToString()]) + plane > -1) {
                    Draw();
                }
                else {
                    MessageBox.Show("Самолет не удалось поставить");
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                if (airfieldCollection.saveData(saveFileDialog.FileName)) {
                    MessageBox.Show("Сохранение прошло успешно", "Результат",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    MessageBox.Show("Не сохранилось", "Результат",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e) {
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                if (airfieldCollection.loadData(openFileDialog.FileName)) {
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    ReloadAirfields();
                    Draw();
                }
                else {
                    MessageBox.Show("Не загрузили", "Результат", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }
    }
}
