using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38_2
{
    class Cars
    {
        public List<Vaz> vazes = new List<Vaz>();
        public List<Bmw> bmws = new List<Bmw>();
        public List<Maz> mazes = new List<Maz>();

        public void AddVaz()
        {
            int engine_power, fuel_consumption, speed = 0;
            string model = "";
            bool ecomode = false;
            int i;
            Console.Write("Введите мощность двигателя - ");
            engine_power = int.Parse(Console.ReadLine());
            Console.Write("Введите расход топлива - ");
            fuel_consumption = int.Parse(Console.ReadLine());
            Console.Write("Введите модель - ");
            model = Console.ReadLine();
            Console.Write("Введите скорость - ");
            speed = int.Parse(Console.ReadLine());
            Console.Write("Режим ЭКО (Вкл,Выкл) - ");
            string choise = Console.ReadLine();
            if (choise == "Вкл")
            {
                ecomode = true;
            }
            else if (choise == "Выкл")
            {
                ecomode = false;
            }
            i = vazes.Count+1;
            vazes.Add(new Vaz(engine_power, fuel_consumption, model, speed, i,ecomode));
        }
        public void AddBmw()
        {
            int engine_power, fuel_consumption, speed = 0;
            string model = "";
            bool turbomode = false;
            bool ecomode = false;
            int i;
            Console.Write("Введите мощность двигателя - ");
            engine_power = int.Parse(Console.ReadLine());
            Console.Write("Введите расход топлива - ");
            fuel_consumption = int.Parse(Console.ReadLine());
            Console.Write("Введите модель - ");
            model = Console.ReadLine();
            Console.Write("Введите скорость - ");
            speed = int.Parse(Console.ReadLine());
            i = bmws.Count + 1;
            Console.Write("Режим ЭКО (Вкл,Выкл) - ");
            string choise1 = Console.ReadLine();
            if (choise1 == "Вкл")
            {
                ecomode = true;
            }
            else if (choise1 == "Выкл")
            {
                ecomode = false;
            }
            Console.WriteLine("Режим ТУРБО (Вкл,Выкл) - ");
            string choise2 = Console.ReadLine();
            if (choise2 == "Вкл")
            {
                turbomode = true;
            }
            else if (choise2 == "Выкл")
            {
                turbomode = true;
            }
            bmws.Add(new Bmw(engine_power, fuel_consumption, model, speed, i,ecomode,turbomode));
        }
        public void AddMaz()
        {
            int engine_power, fuel_consumption, speed = 0;
            string model = "";
            bool turbomode = false;
            int i;
            Console.Write("Введите мощность двигателя - ");
            engine_power = int.Parse(Console.ReadLine());
            Console.Write("Введите расход топлива - ");
            fuel_consumption = int.Parse(Console.ReadLine());
            Console.Write("Введите модель - ");
            model = Console.ReadLine();
            Console.Write("Введите скорость - ");
            speed = int.Parse(Console.ReadLine());
            Console.Write("Режим ТУРБО (Вкл,Выкл) - ");
            string choise = Console.ReadLine();
            if (choise == "Вкл")
            {
                turbomode = true;
            }
            else if (choise == "Выкл")
            {
                turbomode = false;
            }
            i = mazes.Count + 1;
            mazes.Add(new Maz(engine_power, fuel_consumption, model, speed, i,turbomode));
        }
        public void ShowVaz()
        {
            foreach (var vaz in vazes)
            {
                vaz.Show();
            }
        }
        public void ShowBmw()
        {
            foreach (var bmw in bmws)
            {
                bmw.Show();
            }
        }
        public void ShowMaz()
        {
            foreach (var maz in mazes)
            {
                maz.Show();
            }
        }
        public void DelMaz()
        {
            Console.Write("Введите номер удаляемого автомобиля - ");
            int i = int.Parse(Console.ReadLine()) - 1;
            if (i < mazes.Count && i >= 0)
            {
                mazes.RemoveAt(i);
                Console.WriteLine("Удалено");
            }
            else
            {
                Console.WriteLine("Такого автомобиля нет");
            }
        }
        public void DelBmw()
        {
            Console.WriteLine("Введите номер удаляемого автомобиля");
            int i = int.Parse(Console.ReadLine()) - 1;
            if (i < bmws.Count && i >= 0)
            {
                bmws.RemoveAt(i);
                Console.WriteLine("Удалено");
            }
            else
            {
                Console.WriteLine("Такого автомобиля нет");
            }
        }
        public void DelVaz()
        {
            Console.WriteLine("Введите номер удаляемого автомобиля");
            int i = int.Parse(Console.ReadLine()) - 1;
            if (i < vazes.Count && i >= 0)
            {
                vazes.RemoveAt(i);
                Console.WriteLine("Удалено");
            }
            else
            {
                Console.WriteLine("Такого автомобиля нет");
            }
        }
        public void DelAll()
        {
            vazes.Clear();
            bmws.Clear();
            mazes.Clear();
            Console.WriteLine("Все автомобили удалены");
        }
        public void ShowAll()
        {
            Console.WriteLine("Все автомобили:");
            foreach (var vaz in vazes)
            {
                vaz.Show();
            }
            foreach (var bmw in bmws)
            {
                bmw.Show();
            }
            foreach (var maz in mazes)
            {
                maz.Show();
            }
        }
    }
}
