using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
{
    class Disk : IShape
    {
        double radius;

        public Disk(double radius)
        {
            this.Radius = radius;
        }

        public double Radius { get => radius; set => radius = value; }

        public double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
        public double Perimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
