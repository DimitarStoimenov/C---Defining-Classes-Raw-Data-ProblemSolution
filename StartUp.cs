using System;
using System.Collections.Generic;
using System.Linq;

namespace Generics
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] inputDates = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();


                string name = inputDates[0];
                int engineSpeed = int.Parse(inputDates[1]);
                int enginePower = int.Parse(inputDates[2]);
                int cargoWeight = int.Parse(inputDates[3]);
                string cargoType = inputDates[4];
                List<Tire> tires = new List<Tire>();
                for (int tireIndex = 5; tireIndex <= 12; tireIndex += 2)
                {
                   

                    double tirePressure = double.Parse(inputDates[tireIndex]);
                    int tireAge = int.Parse(inputDates[tireIndex + 1]);

                    Tire newTire = new Tire(tirePressure, tireAge);
                    tires.Add(newTire);
                    

                }

                Engine newEngine = new Engine(engineSpeed, enginePower);
                Cargo newCargo = new Cargo(cargoWeight, cargoType);
                Car car = new Car(name, newEngine, newCargo, tires);
                cars.Add(car);


            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                List<Car> fragileCars = cars.Where(x => x.Cargo.Type == "fragile" && x.Tires.Any(x => x.Preassure < 1)).ToList();
                foreach (var item in fragileCars)
                {
                    Console.WriteLine(item.Model);
                }
            }

            else if (command == "flammable")
            {
                List<Car> flammableCars = cars.Where(x => x.Cargo.Type == "flammable" && x.Engine.Power > 250).ToList();
                foreach (var item in flammableCars)
                {
                    Console.WriteLine(item.Model);
                }
            }

        }
    }
}
