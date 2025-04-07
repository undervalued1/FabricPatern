using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricPatern
{
    
    public class Car : Transport
    {
        public override void Move()
        {
            Console.WriteLine("жух-жух Машина едет");
        }
    }
}

