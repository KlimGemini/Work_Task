using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkTask.Classes
{
    class LuxuryCar : AbstractCar
    {
        public string privateDriver;
        public LuxuryCar(int cost, int fuel, int speed, int luggage, string model, string driver)
            : base (cost, fuel, speed, luggage, model)
        {
            privateDriver = driver;
        }

        public override void CarInfo()
        {
            Console.WriteLine(this.cost+"\t" + ""); ;
        }
    }
}
