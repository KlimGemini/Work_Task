using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkTask
{
    abstract class AbstractCar
    {
        public int Cost { get; set; }
        public int Fuel { get; set; }        
        public readonly int maxSpeed;
        public readonly int luggage;
        public readonly string model;        

        public AbstractCar (int _cost, int _fuel, int _speed, int _luggage, string _model)
        {
            Cost = _cost;
            Fuel = _fuel;
            maxSpeed = _speed;
            luggage = _luggage;
            model = _model;
        }
    }
}
