using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace OOPLab4
{
    abstract class Shape
    {
        public abstract int Kol_Ver();
        public abstract string Name { get; }
        public abstract double Perimetr();
        public abstract double Area();
        public abstract Panel Paint(Panel P);
    }
    class Square : Shape
    {
        public double a { get; set; }
        public Square(double a)
        {
            this.a = a;
        }
        public override int Kol_Ver()
        {
            return 4;
        }
        public override string Name
        {
            get { return "Квадрат"; }
        }
        public override double Perimetr()
        {
            return 4 * a;
        }
        public override double Area()
        {
            return a * a;
        }
        public override Panel Paint(Panel P)
        {
            Graphics myGraphics = P.CreateGraphics();
            myGraphics.Clear(SystemColors.Control);
            if ((Convert.ToSingle(a) * 2 <= P.Width))
            {
                myGraphics.FillRectangle(Brushes.Green, 0, 0, Convert.ToSingle(a) * 2, Convert.ToSingle(a) * 2);
            }
            else myGraphics.FillRectangle(Brushes.Green, 0, 0, P.Width, P.Height);
            return P;
        }
    }
    class Krug : Shape
    {
        const double PI = 3.14;
        public double a { get; set; }
        public Krug(double a)
        {
            this.a = a;
        }
        public override int Kol_Ver()
        {
            return 0;
        }
        public override string Name
        {
            get { return "Круг"; }
        }
        public override double Perimetr()
        {
            return 2 * PI * a;
        }
        public override double Area()
        {
            return PI * a * a;
        }
        public override Panel Paint(Panel P)
        {
            Graphics myGraphics = P.CreateGraphics();
            myGraphics.Clear(SystemColors.Control);
            if ((Convert.ToSingle(a) * 2 <= P.Width))
            {
                myGraphics.FillEllipse(Brushes.Red, 0, 0, Convert.ToSingle(a) * 2, Convert.ToSingle(a) * 2);
            }
            else myGraphics.FillEllipse(Brushes.Red, 0, 0, P.Width, P.Height);
            return P;
        }
    }
    class Traingle : Shape
    {
        const double Koreni3 = 1.73;
        public double a { get; set; }
        public Traingle(double a)
        {
            this.a = a;
        }
        public override int Kol_Ver()
        {
            return 3;
        }
        public override string Name
        {
            get { return "Треугольник"; }
        }
        public override double Perimetr()
        {
            return 3 * a;
        }
        public override double Area()
        {
            return a * a * Koreni3 / 4;
        }

        public double Visota()
        {
            return a * Koreni3 / 2;
        }
        public override Panel Paint(Panel P)
        {
            Graphics myGraphics = P.CreateGraphics();
            myGraphics.Clear(SystemColors.Control);
            SolidBrush blueBrush = new SolidBrush(Color.Blue);
            if (Convert.ToInt32(a) <= 128)
            {
                Point point1 = new Point(0, Convert.ToInt32(Visota()) * 2);
                Point point2 = new Point(Convert.ToInt32(a) * 2, Convert.ToInt32(Visota()) * 2);
                Point point3 = new Point(Convert.ToInt32(a), 0);
                Point[] curvePoints = { point1, point2, point3 };
                myGraphics.FillPolygon(blueBrush, curvePoints);
            }
            else
            {
                Point point1 = new Point(128, 0);
                Point point2 = new Point(0, 222);
                Point point3 = new Point(256, 222);
                Point[] curvePoints = { point1, point2, point3 };
                myGraphics.FillPolygon(blueBrush, curvePoints);
            }
            return P;
        }
    }
}

