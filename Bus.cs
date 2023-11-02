using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bus_truck
{
    internal class Bus : Avto
    {
        public override void InfoIn()
        {
            base.InfoIn();
            int avgWeight = 62;
            Console.Write($"\n(Вес >= 1000 кг  --  скорость в 1,5 раза меньше. Вес >= 2000  --  скорость в 2 раза меньше)\n(Средний вес человека - {avgWeight} кг)\nВведите кол-во пассажиров (не больше 50): ");
            int people = Convert.ToInt32(Console.ReadLine()); ;
            while (people > 50)
            {
                Console.Write("ОШИБКА!!! Попробуйте ещё раз\nВведите кол-во пассажиров (не больше 50): ");
                people = Convert.ToInt32(Console.ReadLine());
            }
            weight = people * avgWeight;
            if (weight >= 2000)
                speed = Math.Round(speed / 2, 2);
            else if (weight >= 1000)
                speed = Math.Round(speed / 1.5, 2);
            if (speed <= 60)
                rashod = Math.Round(rashod * 2, 2);
            else if (speed > 90)
                rashod = Math.Round(rashod * 1.5, 2);
        }
    }
}