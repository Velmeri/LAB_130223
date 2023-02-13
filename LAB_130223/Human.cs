using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_130223
{
    internal class Human
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, Address: {Address}";
        }
    }

    internal class Builder : Human
    {
        public string Tools { get; set; }
        public int YearsOfExperience { get; set; }
        public override string ToString()
        {
            return $"{base.ToString()}, Tools: {Tools}, Years Of Experience: {YearsOfExperience}";
        }
    }

    internal class Sailor : Human
    {
        public string BoatName { get; set; }
        public int YearsAtSea { get; set; }
        public override string ToString()
        {
            return $"{base.ToString()}, Boat Name: {BoatName}, Years At Sea: {YearsAtSea}";
        }
    }

    internal class Pilot : Human
    {
        public string LicenseNumber { get; set; }
        public int FlightHours { get; set; }
        public override string ToString()
        {
            return $"{base.ToString()}, License Number: {LicenseNumber}, Flight Hours: {FlightHours}";
        }
    }
}
