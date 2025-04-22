using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38_2
{
    class Maz: Avto, ITurbo
    {
        bool turbomode;

        public bool Turbomode { get => turbomode; set => turbomode = value; }

        public Maz(int engine_power, int fuel_consumption, string model, int speed, int i, bool turbomode) : base(engine_power, fuel_consumption, model, speed, i)
        {
            this.Turbomode = turbomode;
        }
        public string Turbo()
        {
            if (turbomode == true)
            {
                return "вкл";
            }
            else if (turbomode == false)
            {
                return "выкл";
            }
            else
            {
                return "Значение ТУРБО не указано";
            }
        }
        public override void Show()
        {
            Console.WriteLine($"МАЗ {I}:\nМодель: {Model}, Мощность: {Engine_power} л.с, Расход топлива на 100км: {Fuel_consumption} л., Скорость: {Speed} км/ч, {Drive(25)}, ТУРБО: {Turbo()}");
        }
        public override string Drive(int d)
        {
            return $"Пробег: {d} км";
        }
    }
}