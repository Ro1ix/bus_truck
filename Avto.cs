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
        protected double km_max;
        protected double km;
        protected Random random = new Random();
        //public Avto(int bak_max, double bak, double weight, double speed, double rashod)
        //{
        //    this.bak_max = bak_max;
        //    this.bak = bak;
        //    this.weight = weight;
        //    this.speed = speed;
        //    this.rashod = rashod;
        //}
        public virtual void InfoIn()
        {
            Console.Write("Введите объём бака: ");
            bak_max = Convert.ToInt32(Console.ReadLine());
            bak = random.Next(0, bak_max + 1);
            Console.Write("\n(Скорость <= 60 км/ч  --  топливо тратится в 1,5 раза меньше. Скорость > 90 км/ч  --  в 1,5 раза больше)\nВведите скорость: ");
            speed = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nВведите расход топлива на 100 км: ");
            rashod = Convert.ToDouble(Console.ReadLine());
            if (speed <= 60)
                rashod = Math.Round(rashod / 1.5, 2);
            else if (speed > 90)
                rashod = Math.Round(rashod * 1.5, 2);
        }
        public void InfoOut()
        {
            Console.WriteLine($"Топливо: {bak}/{bak_max}\nВес: {weight}\nРеальная скорость: {speed}\nРеальный расход: {rashod}");
        }
    }
}