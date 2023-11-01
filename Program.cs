using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bus_truck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Поездка";
            Random random = new Random();
            Console.WriteLine("Выберите транспорт\n1. Автобус    2. Грузовик");
            string input = Console.ReadLine();
            if (input == "1")
            {
                Console.Clear();
                Console.WriteLine("АВТОБУС\n");
                int avgWeight = 62;
                Console.Write("Введите объём бака: ");
                int bak_max = Convert.ToInt32(Console.ReadLine());
                double bak = random.Next(0, bak_max + 1);
                Console.Write($"\n(Вес >= 1000 кг  --  скорость в 1,5 раза меньше. Вес >= 2000  --  скорость в 2 раза меньше)\n(Средний вес человека - {avgWeight} кг)\nВведите количество пассажиров (не больше 50): ");
                int people = Convert.ToInt32(Console.ReadLine()); ;
                while (people > 50)
                {
                    Console.Write("ОШИБКА!!! Попробуйте ещё раз\nКол-во пассажиров: ");
                    people = Convert.ToInt32(Console.ReadLine());
                }
                double weight = people * avgWeight;
                Console.Write("\n(Скорость <= 60 км/ч  --  топливо тратится в 1,5 раза меньше. Скорость > 90 км/ч  --  в 1,5 раза больше)\nВведите скорость: ");
                double speed = Convert.ToDouble(Console.ReadLine());
                if (weight >= 1000)
                    speed /= 1.5;
                else if (weight >= 2000)
                    speed /= 2;
                Console.Write("\nВведите расход топлива на 100 км: ");
                double rashod;
                if (speed <= 60)
                    rashod = Convert.ToDouble(Console.ReadLine()) / 1.5;
                else if (speed > 90)
                    rashod = Convert.ToDouble(Console.ReadLine()) * 1.5;
                else
                    rashod = Convert.ToDouble(Console.ReadLine());
                Bus bus = new Bus(bak_max, bak, weight, speed, rashod);
                bus.InfoOut();
            }
            else if (input == "2")
            {
                Console.Clear();
                Console.WriteLine("ГРУЗОВИК\n");
                Console.Write("Введите объём бака: ");
                int bak_max = Convert.ToInt32(Console.ReadLine());
                double bak = random.Next(0, bak_max + 1);
                Console.Write($"\n(Вес >= 2500 кг  --  скорость в 1,5 раза меньше. Вес >= 4000  --  скорость в 2 раза меньше)\nВведите вес груза (не больше 5000): ");
                double weight = Convert.ToDouble(Console.ReadLine());
                while (weight > 5000)
                {
                    Console.Write("ОШИБКА!!! Попробуйте ещё раз\nВес: ");
                    weight = Convert.ToDouble(Console.ReadLine());
                }
                Console.Write("\n(Скорость <= 60 км/ч  --  топливо тратится в 1,5 раза меньше. Скорость > 90 км/ч  --  в 1,5 раза больше)\nВведите скорость: ");
                double speed;
                if (weight >= 2500)
                    speed = Convert.ToDouble(Console.ReadLine()) / 1.5;
                else if (weight >= 4000)
                    speed = Convert.ToDouble(Console.ReadLine()) / 2;
                else
                    speed = Convert.ToDouble(Console.ReadLine());
                Console.Write("\nВведите расход топлива на 100 км: ");
                double rashod;
                if (speed <= 60)
                    rashod = Convert.ToDouble(Console.ReadLine()) / 1.5;
                else if (speed > 90)
                    rashod = Convert.ToDouble(Console.ReadLine()) * 1.5;
                else
                    rashod = Convert.ToDouble(Console.ReadLine());
                Truck truck = new Truck(bak_max, bak, weight, speed, rashod);
                truck.InfoOut();
            }
            else
            {
                Console.WriteLine("ОШИБКА!!! Нажмите любую клавишу и попробуйте ещё раз");
                Console.ReadKey();
                Console.Clear();
                Main(args);
            }
        }
    }
}