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

                new MediumCar(16000, 12, 200, 300, "Ford Mondeo"),
                new MediumCar(18000, 9, 205, 310, "Mazda 6"),
                new MediumCar(19000, 11, 245, 315, "Volvo S60"),

                new LuxuryCar(700000, 22, 240, 460, "Rolls-Royce Phantom", "Закреплен"),
                new LuxuryCar(600000, 20, 295, 440, "Bentley Mulsanne", "Закреплен"),
                new LuxuryCar(650000, 15, 230, 430, "Mercedes-Benz Pullman", "Закреплен")

            };
            //-------------------------------------------------
            string[] Label = { "Модель", "Стоимость, $", "Расход топлива, л", "Скорость, км/ч", "Багажник, л", "Личный водитель" };
            Console.WriteLine("Таксопарк Fresh_Way:\n");
            Console.WriteLine($"{Label[0],-20}\t|{Label[1],-12}\t|{Label[2],-15}\t|{Label[3],-15}\t|{Label[4],-12}\t|{Label[5],-15}\n");

            foreach (AbstractCar item in cars)
            {
                item.CarInfo();
            }

            //-------------------------------------------------

            CalcSummaryCost(cars);
           
            Console.WriteLine("Суммарная стоимость автомобилей\n");
            Console.WriteLine("{0:### ### ###}, $\n", cars.Sum(t => t.cost));
            //---------------------------------------
            //Сортировка по расходу топлива
            Console.WriteLine("Сортировка автомобилей по расходу топлива:\n");

            var sortFuel = cars.OrderBy(taxi => taxi.fuel);
            foreach (AbstractCar taxi in sortFuel)
            Console.WriteLine($"{taxi.model, -20}\t{taxi.fuel}, л/100км");

            Console.WriteLine();
            //--------------------------------------
            Console.WriteLine($"Поиск по интервалу скорости, 150-220 км\\ч\n");
            
            List<AbstractCar> temp = SearchCarByMaxSpeed(cars, 150, 220);
            foreach (var item in temp)
            {
                Console.WriteLine($"Искомый автомобиль с интервалом скорости  --> {item.model, -15}\t| {item.maxSpeed}");
            }

            Console.ReadKey();
        }


        //---------------------------------------------------
        //Стоимость парка автомобилей
        static void CalcSummaryCost(List<AbstractCar> cars)
        {
            int sum = 0;
            //for (int i = 0; i < cars.Count - 1; i++)
            //{
            //    sum += cars[i].cost;
            //}
            foreach (AbstractCar item in cars)
            {
                sum += item.cost;
            }
            Console.WriteLine("Суммарная стоимость автомобилей\n");
            Console.WriteLine($"{sum:### ### ###}, $\n");
        }


        //----------------------------------------------------
        //Поиск авто по максимальной скорости        

        public static List<AbstractCar> SearchCarByMaxSpeed(List<AbstractCar> carListValue,int minSpeed, int maxSpeed)
        {
            List<AbstractCar> _carList = carListValue;
            return _carList.Where(t => t.maxSpeed > minSpeed && t.maxSpeed < maxSpeed).ToList();
        }

    }
}
