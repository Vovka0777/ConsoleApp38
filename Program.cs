using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Triangle triangle = new Triangle(0, 0, 0);
            //Disk disk = new Disk(0);
            Shapes shapes = new Shapes();

            bool flag = true;
            while (flag) 
            {
                Console.WriteLine(@"Выберите нужное вам действие:
1.Добавить треугольник;
2.Добавить круг;
3.Вывести все треугольники;
4.Вывести все круги;
5.Выход");
                string s = Console.ReadLine();
                Console.WriteLine();
                switch (s)
                {
                    case "1":
                        shapes.AddTriangle();
                        Console.WriteLine();
                        break;
                    case "2":
                        shapes.AddDisk();
                        Console.WriteLine();
                        break;
                    case "3":
                        shapes.GetTriangles();
                        Console.WriteLine();
                        break;
                        case "4":
                            shapes.GetDisks();
                        Console.WriteLine();
                        break;
                    case "5":
                        Console.WriteLine("Выход из программы");
                        flag = false;
                        Console.Read();
                        return;
                    default:
                        Console.WriteLine("Неверный ввод. Попробуйте ещё раз");
                        break;
                }
            }
            Console.Read();
        }
    }
}
