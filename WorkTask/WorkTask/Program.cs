using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkTask.Classes;

namespace WorkTask
{
    class Program
    {
        static void Main(string[] args)
        {

            LuxuryCar lux = new LuxuryCar(700000, 22, 240, 460, "Rolls-Royce Phantom", "Закреплен");
            Console.WriteLine(lux.model);
            Console.ReadKey();
        }
    }
}
