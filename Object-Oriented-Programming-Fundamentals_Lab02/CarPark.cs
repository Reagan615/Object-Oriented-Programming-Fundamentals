using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming_Fundamentals_Lab02
{
    public class CarPark
    {
        private HashSet<ParkingSpot> _parkingspots = new HashSet<ParkingSpot>();
        private int _capacity;
        public int Capacity
        {
            get { return _capacity; }
            set
            {
                if (value > 0)
                {
                    _capacity = value;
                }
                else
                {
                    throw new Exception("Capacity must exceed 0");
                }
            }
        }
        private void _initializeEmptySpots(int capacity)
        {
            Capacity = capacity;
            _parkingspots = new HashSet<ParkingSpot>();
            for (int i = 1; i <= capacity; i++)
            {
                _parkingspots.Add(new ParkingSpot(i, this));
            }

        }

        public void ParkVehicle(Vehicle vehicle)
        {
            foreach (ParkingSpot spot in _parkingspots)
            {
                if (spot.Vehicle == null)
                {
                    spot.Vehicle = vehicle;
                    vehicle.ParkingSpots.Add(spot);

                    Console.WriteLine($"Vehicle with license {vehicle.License} parking in sopt：{spot.Number}");
                    break;
                }
            }
        }
        public void RemoveVehicle(string license)
        {
            foreach (ParkingSpot spot in _parkingspots)
            {
                if (spot.Vehicle?.License == license && spot.Vehicle != null)
                {
                    Vehicle vehicle = spot.Vehicle;
                    vehicle.ParkingSpots.Remove(spot);
                    spot.Vehicle = null;
                    Console.WriteLine($"Vehicle with license {license} removed from spot : {spot.Number}");
                }

            }
        }
        public CarPark(int capacity)
        {
            _initializeEmptySpots(capacity);
        }

    }
}

