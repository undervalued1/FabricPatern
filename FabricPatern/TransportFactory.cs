using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricPatern
{
    public class TransportFactory
    {
        public Transport CreateTransport(string transportType)
        {
            return transportType.ToLower() switch
            {
                "car" => new Car(),
                "bike" => new Bike(),
                _ => throw new ArgumentException("Неизвестный тип транспорта")
            };
        }
    }
}
