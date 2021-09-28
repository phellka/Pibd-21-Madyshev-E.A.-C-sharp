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
	public partial class FormPlane :Form
	{
		private PlaneRadar plane;

		public FormPlane() {
			InitializeComponent();
		}
		private void Draw() {
			Bitmap bmp = new Bitmap(pictureBoxPlane.Width, pictureBoxPlane.Height);
			Graphics gr = Graphics.FromImage(bmp);
			plane.DrawTransport(gr);
			pictureBoxPlane.Image = bmp;
		}
		private void buttonCreate_Click(object sender, EventArgs e) {
			Random rnd = new Random();
			plane = new PlaneRadar();
			plane.Init(rnd.Next(1000, 3000), rnd.Next(10000, 20000), Color.BurlyWood,
				Color.Coral, true, true);
			plane.SetPosition(rnd.Next(0, 100),
				rnd.Next(0, 100), pictureBoxPlane.Width, pictureBoxPlane.Height);
			Draw();

		}
		private void buttonMove_Click(object sender, EventArgs e) {
			string name = (sender as Button).Name;
			switch (name) {
				case "buttonUp":
					plane.MoveTransport(Direction.Up);
					break;
				case "buttonDown":
					plane.MoveTransport(Direction.Down);
					break;
				case "buttonLeft":
					plane.MoveTransport(Direction.Left);
					break;
				case "buttonRight":
					plane.MoveTransport(Direction.Right);
					break;
			}
			Draw();
		}
	}
}
