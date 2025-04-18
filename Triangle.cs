using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
{
    class Triangle : IShape
    {
        int side1;
        int side2;
        int side3;

        public Triangle(int side1, int side2, int side3)
        {
            if ((side1<side2+side3)&(side2<side3+side1)&(side3<side1+side2))
            {
                this.Side1 = side1;
                this.Side2 = side2;
                this.Side3 = side3;
            }
            else
            {
                Console.WriteLine("Треугольник не существует");
            }
        }

        public int Side1 { get => side1; set => side1 = value; }
        public int Side2 { get => side2; set => side2 = value; }
        public int Side3 { get => side3; set => side3 = value; }

        public double Area()
        {
            double s = (Side1 + Side2 + Side3) / 2.0;
            return Math.Sqrt(s * (s - Side1) * (s - Side2) * (s - Side3));
        }
        public double Perimeter()
        {
            return Side1 + Side2 + Side3;
        }
    }
}
