using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkTask.Classes
{
    class SmallCar : AbstractCar
    {
        public SmallCar(int cost, int fuel, int speed, int luggage, string model)
            : base(cost, fuel, speed, luggage, model) { }

        public override void CarInfo()
        {
            Console.WriteLine($"{model,-20}\t|{cost,-12}\t|{fuel,-15}\t|{maxSpeed,-15}\t|{luggage,-12}\n");
        }
    }
}
