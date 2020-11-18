using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClass
{
    class Car
    {
        private string _typeOfCar;
        private int nrOfWheel;

        public int NumberOfWheel 
        {
            get { return nrOfWheel; }

            set { nrOfWheel = value; } 
        }

        public Car()
        {
            _typeOfCar = "dummy";
        }

        public Car(string typeOfCar)
        {
            _typeOfCar = typeOfCar;
        }

        public void PrintCar()
        {
            Console.WriteLine($"Type of Car {_typeOfCar} and number of wheels {NumberOfWheel}");
        }
    }
}
