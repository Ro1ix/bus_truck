using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bus_truck
{
    internal class Truck : Avto
    {
        public override void InfoIn()
        {
            base.InfoIn();
            Console.Write($"\n(Вес >= 2500 кг  --  скорость в 1,5 раза меньше. Вес >= 4000  --  скорость в 2 раза меньше)\nВведите вес груза (не больше 5000): ");
            weight = Convert.ToDouble(Console.ReadLine());
            while (weight > 5000)
            {
                Console.Write("ОШИБКА!!! Попробуйте ещё раз\nВведите вес груза (не больше 5000): ");
                weight = Convert.ToDouble(Console.ReadLine());
            }
            if (weight >= 4000)
                speed = Math.Round(speed / 2, 2);
            else if (weight >= 2500)
                speed = Math.Round(speed / 1.5, 2);
            if (speed <= 60)
                rashod = Math.Round(rashod * 2, 2);
            else if (speed > 90)
                rashod = Math.Round(rashod * 1.5, 2);
        }
    }
}