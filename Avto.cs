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
        public Avto(int bak_max, double bak, double weight, double speed, double rashod)
        {
            this.bak_max = bak_max;
            this.bak = bak;
            this.weight = weight;
            this.speed = speed;
            this.rashod = rashod;
        }
        public void InfoOut()
        {
            Console.WriteLine($"Топливо: {bak}/{bak_max}\nВес: {weight}\nСкорость: {speed}\nРасход: {rashod}");
        }
    }
}