using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoopyLandscape {
	public partial class Form1 : Form {
		Graphics graphics;
		public Form1() {
			InitializeComponent();
		}

		protected override void OnPaint(PaintEventArgs e) {
			graphics = e.Graphics;
			graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

			Pen pen = new Pen(Brushes.BlueViolet, 8);
            // Упростите код с помощью цикла for
            int y = 20;
            int yy = 80;
            for (int i = 1; i <= 7; i++)
            {
                graphics.DrawLine(pen, y, 40, yy, 80); // первая пара чисел - координаты начала отрезка, вторая - координаты конца
                y = y + 60;
                yy = yy + 60;
            }
		}
	}
}
