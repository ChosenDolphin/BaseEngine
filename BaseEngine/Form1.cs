using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseEngine
{
    public partial class Form1 : Form
    {
        Sprite car;

        public Form1()
        {
            InitializeComponent();

            timer1.Enabled = true;
            car = new Sprite(Image.FromFile(@"C:\Users\Munch\source\repos\BaseEngine\BaseEngine\Properties\Assets\Sprites\Car.png"), Width, Height);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            car.move();
            double speed = car.getSpeed();
            lblSpeed.Text = "Speed: " + speed.ToString();
        }

        private void form1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Up:
                    car.changeSpeed(5);
                    break;
                case Keys.Down:
                    car.changeSpeed(-5);
                    break;
                case Keys.Right:
                    car.changeAngle(5);
                    break;
                case Keys.Left:
                    car.changeAngle(-5);
                    break;
                default:
                    break;
            }

        }

    }
}

