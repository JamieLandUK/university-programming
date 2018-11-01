using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLearrn
{
    class Car
    {
        private string _name;
        private string _manufacturer_name;
        private int _num_of_wheels;
        private string _colour;
        private int _mileage = 0;

        // Constructor
        public Car(string name, string manufacturer, int wheels, string colour)
        {
            _name = name;
            _manufacturer_name = manufacturer;
            _num_of_wheels = wheels;
            _colour = colour;
        }

        // Getters
        public string GetName()
        {
            return _name;
        }

        public string GetManufacturerName()
        {
            return _manufacturer_name;
        }

        public int GetNumOfWheels()
        {
            return _num_of_wheels;
        }

        public string GetColour()
        {
            return _colour;
        }

        public int GetMileage()
        {
            return _mileage;
        }

        // Methods
        public void DriveMiles( int milesDriven )
        {
            _mileage += milesDriven;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car sports = new Car("Sportsy G4500", "FastCo", 4, "Green");
            Car reliant = new Car("Robin", "Reliant", 3, "Taupe");
            
            sports.DriveMiles(150);
            reliant.DriveMiles(16);

            Console.WriteLine("The {0} {1} has driven {2} miles.", sports.GetManufacturerName(), sports.GetName(), sports.GetMileage());
            Console.WriteLine("The {0} {1} has driven {2} miles.", reliant.GetManufacturerName(), reliant.GetName(), reliant.GetMileage());
        }
    }
}
