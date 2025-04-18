using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
{
    internal class Shapes
    {
        public List<Triangle> triangles = new List<Triangle>();
        public List<Disk> disks = new List<Disk>();

        public void AddTriangle()
        {
            int side1, side2, side3 = 0;

            Console.WriteLine("Введите длины сторон треугольника:");
            Console.Write("Side1: ");
            side1 = int.Parse(Console.ReadLine());
            Console.Write("Side2: ");
            side2 = int.Parse(Console.ReadLine());
            Console.Write("Side3: ");
            side3 = int.Parse(Console.ReadLine());
            triangles.Add(new Triangle(side1, side2, side3));
        }
        public void AddDisk()
        {
            double radius = 0;
            Console.WriteLine("Введите радиус круга:");
            Console.Write("Radius: ");
            radius = double.Parse(Console.ReadLine());
            disks.Add(new Disk(radius));
        }

        public void GetTriangles()
        {
            foreach (Triangle triangle in triangles)
            {
                Console.WriteLine("Треугольник:");
                Console.WriteLine($"Side1={triangle.Side1}\tSide2={triangle.Side2}\tSide3={triangle.Side3}");
                Console.WriteLine($"Площадь треугольника: {triangle.Area():f4}");
                Console.WriteLine($"Периметр треугольника: {triangle.Perimeter()}");
            }
        }
        public void GetDisks()
        {
            foreach (Disk disk in disks)
            {
                Console.WriteLine("Круг:");
                Console.WriteLine($"Radius={disk.Radius}");
                Console.WriteLine($"Площадь круга: {disk.Area():f2}");
                Console.WriteLine($"Периметр круга: {disk.Perimeter():f2}");
            }
        }
    }
}
