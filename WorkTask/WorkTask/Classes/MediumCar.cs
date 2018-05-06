using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkTask.Classes
{
    class MediumCar : AbstractCar
    {
        public MediumCar(int cost, int fuel, int speed, int luggage, string model)
            : base(cost, fuel, speed, luggage, model) { }

        public override void CarInfo()
        {
            throw new NotImplementedException();
        }
    }
}
