using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38_2
{
    class Bmw:Avto,IEco,ITurbo
    {
        bool ecomode;
        bool turbomode;

        public bool Ecomode { get => ecomode; set => ecomode = value; }
        public bool Turbomode { get => turbomode; set => turbomode = value; }

        public Bmw(int engine_power, int fuel_consumption, string model, int speed, int i, bool ecomode, bool turbomode) : base(engine_power, fuel_consumption, model, speed, i)
        {
            this.Ecomode = ecomode;
            this.Turbomode = turbomode;
        }
        public string Eco()
        {
            if (ecomode == true)
            {
                return "вкл";
            }
            else if (ecomode == false)
            {
                return "выкл";
            }
            else
            {
                return "Значение ЭКО не указано";
            }
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
            Console.WriteLine($"БМВ {I}:\nМодель: {Model}, Мощность: {Engine_power} л.с, Расход топлива на 100км: {Fuel_consumption} л., Скорость: {Speed} км/ч, {Drive(25)}, ТУРБО: {Turbo()}, ЭКО: {Eco()}");
        }
        public override string Drive(int d)
        {
            return $"Пробег: {d} км";
        }
    }
}
