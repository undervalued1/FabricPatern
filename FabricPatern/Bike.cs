using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricPatern
{
    public class Bike : Transport
    {
        public override void Move()
        {
            Console.WriteLine("врум-врум Мотоцикл едет");
        }
    }
}
