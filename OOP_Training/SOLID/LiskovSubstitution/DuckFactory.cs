using System;

namespace OOP_Training.SOLID.LiskovSubstitution
{
    public class DuckFactory
    {
        public static Duck GetDuck(DuckType muscovy)
        {
            switch (muscovy)
            {
                case DuckType.Muscovy:
                    return new MuscovyDuck();
                case DuckType.Plastic:
                    return new PlasticDuck();
                default:
                    return null;
            }
        }
    }
}