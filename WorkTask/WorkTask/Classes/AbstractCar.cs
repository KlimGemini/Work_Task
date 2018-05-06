using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkTask
{
    abstract class AbstractCar
    {
        public int cost { get; set; }
        public int fuel { get; set; }        
        public readonly int maxSpeed;
        public readonly int luggage;
        public readonly string model;        

        public AbstractCar (int _cost, int _fuel, int _speed, int _luggage, string _model)
        {
            cost = _cost;
            fuel = _fuel;
            maxSpeed = _speed;
            luggage = _luggage;
            model = _model;
        }

        public abstract void CarInfo();
    }
}
