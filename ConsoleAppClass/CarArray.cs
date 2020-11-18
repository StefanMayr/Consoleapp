using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClass
{
    class CarArray
    {
        private Car[] myArrayOfCars = new Car[0];
        //private List<Car> myListOfCars = new List<Car>();

        public CarArray()
        {

        }

        public void AddCarToArray(Car nextCar)
        {
            Array.Resize(ref myArrayOfCars, myArrayOfCars.Length + 1);
            myArrayOfCars[myArrayOfCars.Length - 1] = nextCar;
        }

        public void PrintCarArray()
        {
            for (int i = 0; i < myArrayOfCars.Length; i++)
            {
                Console.WriteLine($"The index of array: {i} and the number of wheels {myArrayOfCars[i].NumberOfWheel}");
            }
        }
    }
}
