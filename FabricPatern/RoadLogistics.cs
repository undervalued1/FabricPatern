using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricPatern
{
    public class RoadLogistics : Logistics
    {
        public override Transport CreateTransport()
        {
            return new Car();
        }
    }
}
