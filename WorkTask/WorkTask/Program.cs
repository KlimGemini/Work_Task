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
            List<AbstractCar> cars = new List<AbstractCar>
            {
                new SmallCar(5000, 5, 90, 250, "Ford Focus"),
                new SmallCar(5500, 6, 95, 300, "Shkoda Rapid"),
                new SmallCar(6000, 5, 100, 320, "Mazda 323"),

                

            };
            //-------------------------------------------------
            
            GetSummaryCost(cars);

            //---------------------------------------
            //Сортировка по расходу топлива
            Console.WriteLine("Сортировка автомобилей по расходу топлива:");

            var sortFuel = cars.OrderBy(taxi => taxi.fuel);
            foreach (AbstractCar taxi in sortFuel)
            Console.WriteLine($"{taxi.fuel}, л/100км");

            Console.ReadKey();
        }

        //Стоимость парка автомобилей
        static void GetSummaryCost(List<AbstractCar> cars)
        {
            int sum = 0;
            for (int i = 0; i < cars.Count - 1; i++)
            {
                sum += cars[i].cost;
            }
            Console.WriteLine("Суммарная стоимость автомобилей");
            Console.WriteLine($"{sum:### ### ###}, $\n");
        }

        //Поиск авто по максимальной скорости
        public static List<AbstractCar> SearchCarMaxSpeed(List <AbstractCar> carValue, int minSpeedValue, int maxSpeedValue)
        {
            return carValue.Where(t => t.maxSpeed > minSpeedValue && t.maxSpeed < maxSpeedValue).ToList();
        }
    }
}
