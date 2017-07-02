using System;

namespace OOP_Training.SOLID.LeastKnowledge
{
    public class Doctor
    {
        public string Name { get; private set; }

        public Doctor(string name)
        {
            this.Name = name;
        }

        public void BookTimeByNetwork(DateTime date)
        {

        }

        public void BookTimeByPhone(DateTime date)
        {

        }

    }
}