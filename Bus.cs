using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bus_truck
{
    internal class Bus : Avto
    {
        //public Bus(int bak_max, double bak, double weight, double speed, double rashod) : base (bak_max, bak, weight, speed, rashod)
        //{

        //}
        public override void InfoIn()
        {
            base.InfoIn();
            int avgWeight = 62;
            Console.Write($"\n(Вес >= 1000 кг  --  скорость в 1,5 раза меньше. Вес >= 2000  --  скорость в 2 раза меньше)\n(Средний вес человека - {avgWeight} кг)\nВведите количество пассажиров (не больше 50): ");
            int people = Convert.ToInt32(Console.ReadLine()); ;
            while (people > 50)
            {
                Console.Write("ОШИБКА!!! Попробуйте ещё раз\nКол-во пассажиров: ");
                people = Convert.ToInt32(Console.ReadLine());
            }
            weight = people * avgWeight;
            if (weight >= 2000)
                speed = Math.Round(speed / 2, 2);
            else if (weight >= 1000)
                speed = Math.Round(speed / 1.5, 2);
        }
    }
}