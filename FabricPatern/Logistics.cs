using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricPatern
{
    public abstract class Logistics
    {
        public abstract Transport CreateTransport();

        public void PlanDelivery()
        {
            Transport transport = CreateTransport();
            transport.Move();
        }
    }
}
