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
    class Sprite
    {
        private double x, y;
        private double imgAngle, moveAngle;
        private double speed;
        private double dx, dy;
        private int width, height;
        private Image sprite;

        public Sprite(Image imageFile, int width, int height)
        {
            x = 200;
            y = 200;
            dx = 0;
            dy = 0;
            speed = 0;
            imgAngle = 0;
            moveAngle = 0;
            this.width = width;
            this.height = height;
            sprite = imageFile;
        }

        public void move()
        {
            x += dx;
            if (x > width)
            {
                x = 0;
            }
            if (x < 0)
            {
                x = width;
            }

            y += dy;
            if (y > height)
            {
                y = 0;
            }
            if (y < 0)
            {
                y = height;
            }
            //picCar.Location = new Point((int)x, (int)y);

        }
        public void setX(double newX)
        { x = newX; }
        public void setY(double newY)
        { y = newY; }
        //something
        public void setDX(double newDX)
        { dx = newDX; }
        public void setDY(double newDY)
        { dy = newDY; }
        public void changeX(double tempDX)
        { x += tempDX; }
        public void changeY(double tempDY)
        { y += tempDY; }
        //hide and show for future
        public void calcVector()
        {
            dx = speed * Math.Cos(moveAngle);
            dy = speed * Math.Sin(moveAngle);
        }

        public void calcSpeedAngle()
        {
            speed = Math.Sqrt((dx * dx) + (dy * dy));
            moveAngle = Math.Atan2(dy, dx);
        }

        public void setSpeed(double speed)
        {
            this.speed = speed;
            calcVector();
        }

        public double getSpeed()
        {
            speed = Math.Sqrt((dx * dx) + (dy * dy));
            return speed;
        }

        public void changeSpeed(double amt)
        {
            speed += amt;
            calcVector();
        }
        public double getImgAngle()
        {
            return (imgAngle * 180.0 / Math.PI) + 90;
        }

        public void setImgAngle(double degrees)
        {
            degrees = degrees - 90;
            imgAngle = degrees * Math.PI / 180;
        }

        public void changeImgAngle(double degrees)
        {
            double radians = degrees * Math.PI / 180;
            imgAngle = +radians;
        }

        public void setMoveAngle(double degrees)
        {
            degrees = degrees - 90;
            moveAngle = degrees * Math.PI / 180;
            calcVector();
        }

        public void changeMoveAngle(double degrees)
        {
            double radian = degrees * Math.PI / 180;
            moveAngle += radian;
            calcVector();
        }
        public void setAngle(double degrees)
        {
            setImgAngle(degrees);
            setMoveAngle(degrees);
        }
        public void changeAngle(double degrees)
        {
            changeImgAngle(degrees);
            changeMoveAngle(degrees);
        }
    }
}
