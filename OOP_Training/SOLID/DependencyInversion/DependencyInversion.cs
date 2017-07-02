using System;

namespace OOP_Training.SOLID.DependencyInversion
{
    public class DependencyInversion
    {
        public void Execute(ExecuteType executeType)
        {
            IExecutable executor = GetExecutor(executeType);
            Console.WriteLine(executor.GetResult());
        }
        private static IExecutable GetExecutor(ExecuteType executeType)
        {
            switch (executeType)
            {
                case ExecuteType.Alpha:
                    return new Alpha();
                case ExecuteType.Beta:
                    return new Beta();
                case ExecuteType.Gamma:
                    return new Gamma();
                default:
                    return null;
            }
        }
    }

    public interface IExecutable
    {
        string GetResult();
    }

    public class Alpha : IExecutable
    {
        public string GetResult()
        {
            return "alpha alpha";
        }
    }

    public class Beta : IExecutable
    {
        public string GetResult()
        {
            return "beta beta";
        }
    }

    public class Gamma : IExecutable
    {
        public string GetResult()
        {
            return "gamma gamma";
        }
    }
}