using PatikaDev_Akbank.Models.Concrete;
using PatikaDev_Akbank.Models.Concrete.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatikaDev_Akbank.Models.Abstract
{
    public abstract class Vehicle
    {
        public HGS HgsNumber;
        public Vehicle(string HgsNumber, string DriverFirstName, string DriverLastName, VehicleClass VehicleClass, DateTime TransitionDate, float balance)
        {
            this.HgsNumber.HgsNumber=HgsNumber;
            this.HgsNumber.DriverFirstName = DriverFirstName;
            this.HgsNumber.DriverLastName = DriverLastName;
            this.HgsNumber.VehicleClass = VehicleClass;
            this.HgsNumber.TransitionDate = TransitionDate;
            this.HgsNumber.balance = balance;
        }
    }
}