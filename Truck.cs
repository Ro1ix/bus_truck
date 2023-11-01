using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bus_truck
{
    internal class Truck : Avto
    {
        public Truck(int bak_max, double bak, double weight, double speed, double rashod) : base(bak_max, bak, weight, speed, rashod)
        {

        }
    }
}