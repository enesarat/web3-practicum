using PatikaDev_Akbank.Models.Abstract;
using PatikaDev_Akbank.Models.Concrete.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaDev_Akbank.Models.Concrete
{
    public class Counter
    {
        public OGS manageOGS;
        public void PaymentAcceptance(Vehicle vehicle)
        {
            string vehicleClass = vehicle.HgsNumber.VehicleClass.ToString();
            bool check = Enum.IsDefined(typeof(Toll), vehicleClass);
            if (check)
            {
                vehicle.HgsNumber.TransitionDate = DateTime.Now;
                var value = Convert.ToInt32(Enum.Parse(typeof(Toll), vehicleClass));
                vehicle.HgsNumber.balance -= value;
                manageOGS.vehicleList.Add(vehicle);
                manageOGS.SetDailyToll(value);
            }
        }
    }
}
