using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClass
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfCars = 0;
            Car[] myfirstArray;

            do
            {
                Console.Write("Bitte geben Sie die Anzahl der Autos ein! ");
            } while (!int.TryParse(Console.ReadLine(), out sizeOfCars));

            Console.WriteLine($"Sie moechten gerne {sizeOfCars} Autos anlegen");
            myfirstArray = new Car[sizeOfCars];

            for (int i = 0; i < myfirstArray.Length; i++)
            {
                // lange version
                // anlegen einer variable ist zugleich eine instanz
                //Car myCar = new Car(GetCarType());
                //myfirstArray[i] = myCar;
                //// kurze version
                myfirstArray[i] = new Car(GetCarType());
                myfirstArray[i].NumberOfWheel = i + 2;
            }

            PrintArray(myfirstArray);

            ////////////////////
            //Car myfirstCar = new Car();
            //myfirstCar.NumberOfWheel = 3;
            //myfirstCar.PrintCar();

            //Car mynextCar = new Car("Tesla");
            //mynextCar.NumberOfWheel = 9;
            //mynextCar.PrintCar();
            Console.ReadKey();
        }

        static string GetCarType()
        {
            Console.WriteLine("Bitte genen Sie eine Autotype ein");
            return Console.ReadLine();
        }

        static void PrintArray(Car[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i].PrintCar();
            }
        }
    }
}
