using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attractions
{
    public class RollerCoaster : Ride
    {
        public RollerCoaster(string name, bool cardioRisk) : base(name, cardioRisk)
        {
            cardioRisk = true;
        }
    }
}
