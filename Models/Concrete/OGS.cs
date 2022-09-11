using PatikaDev_Akbank.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaDev_Akbank.Models.Concrete
{
    public class OGS
    {
        public List<Vehicle> vehicleList { get; set; }
        int DailyToll;
        public void SetDailyToll(int toll)
        {
            this.DailyToll += toll;
        }
        public int GetDailyToll()
        {
            return this.DailyToll;
        }
    }
}
