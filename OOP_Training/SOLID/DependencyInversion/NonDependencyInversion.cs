using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Training.SOLID.DependencyInversion
{
    public class NonDependencyInversion
    {
        public void Execute(ExecuteType executeType)
        {
            switch (executeType)
            {
                case ExecuteType.Alpha:
                    Console.WriteLine(new AlphaTool().GetString());
                    break;
                case ExecuteType.Beta:
                    Console.WriteLine(new BetaMachine().GenerateString());
                    break;
                case ExecuteType.Gamma:
                    Console.WriteLine(new GammaEquipment().GetResult());
                    break;                
            }
        }
    }

    public class AlphaTool
    {
        public string GetString()
        {
            return "alpha alpha";
        }
    }

    public class BetaMachine
    {
        public string GenerateString()
        {
            return "beta beta";
        }
    }

    public class GammaEquipment
    {
        public string GetResult()
        {
            return "gamma gamma";
        }
    }

}
