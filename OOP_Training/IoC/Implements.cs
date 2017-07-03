using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Training.IoC
{
    public class Sprint : IRun
    {
        public void Running()
        {
        }
    }

    public class RideRoadBike : IRideBike
    {
        public void RidingBike()
        {
        }
    }

    public class FreeStyleSwim : ISwim
    {
        public void Swimming()
        {
        }
    }
}
