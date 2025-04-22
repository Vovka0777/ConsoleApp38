using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleApp38_2
{
    abstract class Avto
    {
        int i;
        int engine_power;
        int fuel_consumption;
        string model;
        int speed;

        public int Engine_power { get => engine_power; set
            {
                if (value > 1)
                {
                    i = value;
                }
                else
                {
                    Console.WriteLine("Значение мощности не может быть меньше 1");
                }
            }
        }
        public int Fuel_consumption { get => fuel_consumption; set
            {
                if (value > 1)
                {
                    i = value;
                }
                else
                {
                    Console.WriteLine("Значение расхода не может быть меньше 1");
                }
            }
        }
        public string Model { get => model; set
            {
                if (value == "")
                {
                    Console.WriteLine("Модель не может быть пустой");
                }
                else
                {
                    model = value;
                }
            }
        }
        public int Speed { get => speed; 
            set
            {
                if (value > 0)
                {
                    speed = value;
                }
                else
                {
                    Console.WriteLine("Значение скорости не может быть меньше 0");
                }
            }
        }
        public int I { get => i; 
            set 
            {
                if (value > 0)
                {
                    i = value;
                }
                else
                {
                    Console.WriteLine("Индекс не может быть меньше 1");
                }
            } 
        }

        public Avto(int engine_power, int fuel_consumption, string model, int speed, int i)
        {
            this.Engine_power = engine_power;
            this.Fuel_consumption = fuel_consumption;
            this.Model = model;
            this.Speed = speed;
            this.I = i;
        }

        public abstract void Show();
        public abstract string Drive(int d);
    }
}
