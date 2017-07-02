using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Training.SOLID.LeastKnowledge
{
    public class FriendlyStaff
    {
        public void BookDoctor(DateTime date)
        {            
            if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
            {
                new Doctor("Brett").BookTimeByPhone(date);
            }
            else
            {
                new Doctor("Eric").BookTimeByPhone(date);
            }            
        }
    }
}
