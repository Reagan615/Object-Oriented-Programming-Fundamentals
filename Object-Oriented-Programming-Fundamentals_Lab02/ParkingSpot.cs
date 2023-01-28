using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming_Fundamentals_Lab02
{
    public class ParkingSpot
    {
        private int _number;

        public int Number
        {
            get { return _number; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("spot must be positive number");
                }
                else
                {
                    _number = value;
                }
            }

        }

        private Vehicle _vehicle;
        public Vehicle Vehicle
        {
            get { return _vehicle; }
            set { _vehicle = value; }
        }
        private CarPark _carPark;
        public CarPark CarPark { get { return _carPark; } }

        public ParkingSpot(int number, CarPark carPark)
        {
            _number = number;
            _carPark = carPark;
        }

        public ParkingSpot(int number)
        {
            Number = number;
        }
    }
}
