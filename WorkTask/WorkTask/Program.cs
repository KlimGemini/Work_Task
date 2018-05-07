﻿using System;
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
            
            GetSummaryCost(cars);

            //---------------------------------------
            //Сортировка по расходу топлива
            Console.WriteLine("Сортировка автомобилей по расходу топлива:");

            var sortFuel = cars.OrderBy(taxi => taxi.fuel);
            foreach (AbstractCar taxi in sortFuel)
            Console.WriteLine($"{taxi.fuel}, л/100км");
            //--------------------------------------

            

            Console.ReadKey();
        }


        //---------------------------------------------------
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


        //----------------------------------------------------
        //Поиск авто по максимальной скорости
        static void SearchCarMaxSpeed(List<AbstractCar> carsList, int speedMinValue, int speedMaxValue)
        {
            List <AbstractCar> cars = carsList;
            bool pointer1 = false;
            int val1 = speedMinValue;
            int val2 = speedMaxValue;

            //if ((speed1 < 0 || speed2 < 0) || (speed1 > speed2))
            //{
            //    Console.WriteLine("Условия поиска некорректны!");
            //    return;
            //}


            for (int i = 0; i < cars.Count - 1; i++)
            {
                if ((cars[i].maxSpeed >= val1) && (cars[i].maxSpeed <= val2))
                {
                    Console.WriteLine($"Искомый автомобиль с интервалом скорости {val1} - {val2} --> {cars[i].model}");
                    pointer1 = true;
                }
            }
            if (!pointer1)
            {
                Console.WriteLine("Автомобиль с заданным интервалом скорости не найден.");
            }
        }
    }
}
