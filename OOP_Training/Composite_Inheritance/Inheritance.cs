using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Training.Composite_Inheritance
{
    public abstract class Bird
    {
        public virtual void Fly(int x, int y, int z)
        {

        }
    }

    public class Swallow : Bird
    {
        public void FlyToSouth(int x, int y, int z)
        {
            base.Fly(0, -1000, 1);
        }
    }

    public abstract class Penguin : Bird
    {
        public override void Fly(int x, int y, int z)
        {
            Console.WriteLine("I cannot fly");
        }
    }

    public abstract class Turkey : Bird
    {
        public override void Fly(int x, int y, int z)
        {
            Console.WriteLine("I cannot fly");
        }
    }

    public abstract class Chicken : Bird
    {
        public override void Fly(int x, int y, int z)
        {
            Console.WriteLine("I cannot fly");
        }
    }
}
