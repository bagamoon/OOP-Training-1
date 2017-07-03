using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Training.IoC
{
    public class InjectBySetter
    {
        public IRun Run { get; set; }
        public IRideBike RideBike { get; set; }
        public ISwim Swim { get; set; }

        public InjectBySetter()
        {

        }

        public void Running()
        {
            if (Run != null)
                Run.Running();
        }

        public void RidingBike()
        {
            if (RideBike != null)
                RideBike.RidingBike();
        }

        public void Swimming()
        {
            if (Swim != null)
                Swim.Swimming();
        }
    }
}
