using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bus_truck
{
    internal class Avto
    {
        protected int bak_max;
        protected double bak;
        protected double weight;
        protected double speed;
        protected double rashod;
        protected double km_max = 0;
        protected double km = 0;
        protected Random random = new Random();
        protected virtual void InfoIn()
        {
            do
            {
                Console.Write("Введите объём бака (не больше 55 литров): ");
                bak_max = Convert.ToInt32(Console.ReadLine());
                if (bak_max > 55)
                    Console.WriteLine("ОШИБКА!!! Попробуйте ещё раз");
            } while (bak_max > 55);
            bak = random.Next(0, bak_max + 1);
            Console.WriteLine("\n(Скорость <= 40 км/ч  --  топливо тратится в 2 раза больше. Скорость > 90 км/ч  --  в 1,5 раза больше)");
            do
            {
                Console.Write("Введите скорость (не больше 110 км/ч): ");
                speed = Convert.ToDouble(Console.ReadLine());
                if (speed > 110)
                    Console.WriteLine("ОШИБКА!!! Попробуйте ещё раз");
            } while (speed > 110);
            do
            {
                Console.Write("\nВведите расход топлива на 100 км (от 7 до 15 литров): ");
                rashod = Convert.ToDouble(Console.ReadLine());
                if (rashod < 7 || rashod > 15)
                    Console.WriteLine("ОШИБКА!!! Попробуйте ещё раз");
            } while (rashod < 7 || rashod > 15);
        }
        protected void InfoOut()
        {
            Console.WriteLine($"\nВес: {weight} кг\nРеальная скорость: {speed} км/ч\nРеальный расход: {rashod} л/100км\nПройдено: {km} км\nОсталось: {km_max - km} км\nТопливо: {bak}/{bak_max} л");
        }
        protected void Trip()
        {
            km = 0;
            km_max = random.Next(10, 751);
            Console.WriteLine($"\nВы собираетесь проехать такое расстояние:\n{km_max} км\n\nПоехали! (Нажмите Enter, чтобы продолжить)");
            Console.ReadKey();
            do
            {
                km += bak / (rashod / 100);
                if (km < km_max)
                {
                    bak = 0;
                    InfoOut();
                    Refueling();
                    InfoOut();
                    Console.WriteLine("\nНажмите Enter, чтобы продолжить");
                    Console.ReadKey();
                }
                else
                {
                    bak = (km - km_max) * (rashod / 100);
                    km = km_max;
                    InfoOut();
                    Console.WriteLine("\nЖелаете продолжить?\n1. Продолжить    Другое. Выйти");
                    string input = Console.ReadLine();
                    if (input == "1")
                    {
                        Console.WriteLine("\nХотите заправиться?\n1. Да    Другое. Нет");
                        input = Console.ReadLine();
                        if (input == "1")
                        {
                            Refueling();
                        }
                        InfoOut();
                        Trip();
                    }
                    else
                    {
                        Console.WriteLine("\nИГРА ОКОНЧЕНА");
                        break;
                    }
                }
            } while (km < km_max);
        }
        protected void Refueling()
        {
            Console.Write($"\nНа сколько литров хотите заправиться? (Не больше {bak_max - bak} л)\nВвод: ");
            double input = Convert.ToDouble(Console.ReadLine());
            if (input <= bak_max - bak)
            {
                bak += input;
            }
            else
            {
                Console.WriteLine("ОШИБКА!!! Попробуйте ещё раз");
                Refueling();
            }
        }
    }
}