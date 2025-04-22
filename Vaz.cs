using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38_2
{
    class Vaz:Avto, IEco
    {
        bool ecomode;

        public bool Ecomode { get => ecomode; set => ecomode = value; }

        public Vaz(int engine_power, int fuel_consumption, string model, int speed, int i, bool ecomode) : base(engine_power, fuel_consumption, model, speed, i)
        {
            this.Ecomode = ecomode;
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
        public override void Show()
        {
            Console.WriteLine($"ВАЗ {I}:\nМодель: {Model}, Мощность: {Engine_power} л.с, Расход топлива на 100км: {Fuel_consumption} л., Скорость: {Speed} км/ч, {Drive(25)}, ЭКО: {Eco()}");
        }
        public override string Drive(int d)
        {
            return $"Пробег: {d} км";
        }
    }
}
