using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming_Fundamentals_Lab02
{
    public class Vehicle
    {
        public HashSet<ParkingSpot> ParkingSpots = new HashSet<ParkingSpot>();
        private string _license;
        public string License { get { return _license; } }
        public void UpdateLicenseNumber(string license)
        {
            if (license.Length < 3 || license.Length > 7 || !license.All(c => char.IsLetter(c)))
            {
                throw new Exception("License number must be between 3 and 7 alphanumeric characters long");
            }
            else
            {
                _license = license;
            }

        }

        public Vehicle(string license)
        {
            UpdateLicenseNumber(license);

        }
    }
}
