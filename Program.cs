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
                Bus bus = new Bus();
                bus.Start();
            }
            else if (input == "2")
            {
                Console.Clear();
                Console.WriteLine("ГРУЗОВИК\n");
                Truck truck = new Truck();
                truck.Start();
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