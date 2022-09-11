using PatikaDev_Akbank.Models.Concrete;
using PatikaDev_Akbank.Models.Concrete.Enums;
using System;

namespace PatikaDev_Akbank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Car mycar = new Car("123456789abc","Enes","Arat",VehicleClass.Car,DateTime.Now,250);
            Counter counter01 = new Counter();
            counter01.PaymentAcceptance(mycar);
            counter01.manageOGS.GetDailyToll();
        }
    }
}
