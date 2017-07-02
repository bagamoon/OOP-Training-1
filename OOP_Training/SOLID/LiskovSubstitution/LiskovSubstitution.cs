using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace OOP_Training.SOLID
{
    public abstract class Duck
    {
        public decimal Weight { get; protected set; }

        public string Name { get; private set; }

        protected Duck(string name, decimal weight)
        {
            this.Name = name;
            this.Weight = weight;
        }

        public void Move()
        {
            Console.WriteLine(Name + " Moved");
        }

        public virtual void Quark()
        {
            Console.WriteLine(Name + " Quarked");
        }

        public virtual void Eat()
        {
            Weight ++;
        }
    }

    public class MuscovyDuck : Duck
    {
        public MuscovyDuck()
            : base("Muscovy Duck", 7)
        {
        }

        public override void Eat()
        {
            Weight += 0.5M;
            Console.WriteLine("Eating");
        }
    }

    public class PlasticDuck : Duck
    {
        public PlasticDuck()
            : base("Plastic Duck", 0.5M)
        {
        }

        public override void Quark()
        {
            Console.WriteLine("Plastic Duck Beep");
        }
        public override void Eat()
        {
            //Plastic Duct doesn't eat, do nothing
            Console.WriteLine("I don't eat");
        }

    }
}
