using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Training.Composite_Inheritance
{
    public abstract class Bird_C
    {        
    }

    public interface IFly
    {
        void Fly(int x, int y, int z);
    }

    public class Swallow_C : Bird_C
    {
        public IFly Fly { get; private set; }

        public Swallow_C(IFly fly)
        {
            this.Fly = fly;
        }

        public void FlyToSouth()
        {
            Fly.Fly(0, -1000, 1);
        }
    }

    public class Wings : IFly
    {
        public void Fly(int x, int y, int z)
        {
            //implement of fly here
        }
    }

    public class Pilot
    {
        public IFly Fly { get; private set; }

        public Pilot(IFly fly)
        {
            this.Fly = fly;
        }

        public void FlyToEurope()
        {
            Fly.Fly(-6000, 3000, 1500);
        }
    }

    public class Plane : IFly
    {
        public void Fly(int x, int y, int z)
        {
            //implement of fly here
        }
    }


    public abstract class Penguin_C : Bird
    {

    }
}
