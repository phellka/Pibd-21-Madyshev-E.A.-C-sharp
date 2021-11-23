using System;
using NLog;
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
        private readonly Logger logger;
        public FormAirfield() {
            InitializeComponent();
            airfieldCollection = new AirfieldCollection(pictureBoxAirfield.Width, pictureBoxAirfield.Height);
            logger = LogManager.GetCurrentClassLogger();
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
            logger.Info($"Добавили аэродром {textBoxNewAirfield.Text}");
            airfieldCollection.AddAirfield(textBoxNewAirfield.Text);
            ReloadAirfields();
        }
        private void buttonDelAirfield_Click(object sender, EventArgs e) {
            if (listBoxAirfields.SelectedIndex > -1) {
                if (MessageBox.Show($"Удалить аэродром { listBoxAirfields.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes) {
                    logger.Info($"Удалили аэродром{ listBoxAirfields.SelectedItem.ToString()}");
                    airfieldCollection.DelAirfield(listBoxAirfields.SelectedItem.ToString());
                    ReloadAirfields();
                }
                Draw();                                                             //для удаления единственного
            }
        }
        private void buttonAddPlane_Click(object sender, EventArgs e) {
            if (listBoxAirfields.SelectedIndex > -1) {
                var formPlaneConfig = new FormPlaneConfig();
                formPlaneConfig.addEvent(addPlane);
                formPlaneConfig.Show();
            }
        }
        private void buttonTakePlane_Click(object sender, EventArgs e) {
            if (listBoxAirfields.SelectedIndex > -1 && maskedTextBoxDelPlane.Text != "") {
                try {
                    var plane = airfieldCollection[listBoxAirfields.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBoxDelPlane.Text);
                    if (plane != null) {
                        FormPlane form = new FormPlane();
                        form.SetPlane(plane);
                        form.ShowDialog();
                        logger.Info($"Изъят самолет {plane} с места{ maskedTextBoxDelPlane.Text}");
                    }
                    Draw();
                }
                catch (AirfieldVehicleNotFoundException ex) {
                    logger.Warn(ex);
                    MessageBox.Show(ex.Message, "Не найден", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex) {
                    logger.Warn(ex);
                    MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void listBoxAirfields_SelectedIndexChanged(object sender, EventArgs e) {
            logger.Info($"Перешли на аэродром{ listBoxAirfields.SelectedItem.ToString()}");
            Draw();
        }
        private void addPlane(Vehicle plane) {
            if (plane != null && listBoxAirfields.SelectedIndex > -1) {
                try {
                    if ((airfieldCollection[listBoxAirfields.SelectedItem.ToString()]) + plane > -1) {
                        Draw();
                        logger.Info($"Добавлен самолет {plane}");
                    }
                    else {
                        MessageBox.Show("Самолет не удалось поставить");
                    }   
                }
                catch (AirfieldOverflowException ex) {
                    logger.Warn(ex);
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex) {
                    logger.Warn(ex);
                    MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                try {
                    airfieldCollection.saveData(saveFileDialog.FileName);
                    MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Сохранено в файл " + saveFileDialog.FileName);
                }
                catch (Exception ex) {
                    logger.Warn(ex);
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e) {
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                try {
                    airfieldCollection.loadData(openFileDialog.FileName);
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Загружено из файла " + openFileDialog.FileName);
                    ReloadAirfields();
                    Draw();
                }
                catch (FormatException ex) {
                    logger.Warn(ex);
                    MessageBox.Show(ex.Message, "Ошибка формата", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (AirfieldOverflowException ex) {
                    logger.Warn(ex);
                    MessageBox.Show(ex.Message, "Переполнение при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex) {
                    logger.Warn(ex);
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}