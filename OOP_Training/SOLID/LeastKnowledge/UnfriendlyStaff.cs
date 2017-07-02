using System;

namespace OOP_Training.SOLID.LeastKnowledge
{
    public class UnfriendlyStaff
    {
        public Doctor GetAvailableDoctor(DateTime date)
        {
            if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
            {
                return new Doctor("Brett");
            }

            return new Doctor("Eric");
        }
    }
}