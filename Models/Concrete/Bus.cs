using PatikaDev_Akbank.Models.Abstract;
using PatikaDev_Akbank.Models.Concrete.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatikaDev_Akbank.Models.Concrete
{
    public class Bus : Vehicle
    {
        public HGS HgsNumber { get; set; }
        public Bus(string HgsNumber, string DriverFirstName, string DriverLastName, VehicleClass VehicleClass, DateTime TransitionDate, float balance) : base(HgsNumber, DriverFirstName, DriverLastName, VehicleClass, TransitionDate:DateTime.Now, balance:150) { }
    }
}