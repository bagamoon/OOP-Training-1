namespace OOP_Training.IoC
{
    public class NoIoC
    {
        public IRun Run { get; private set; }
        public IRideBike RideBike { get; private set; }
        public ISwim Swim { get; private set; }

        public NoIoC()
        {
            Run = new Sprint();
            RideBike = new RideRoadBike();
            Swim = new FreeStyleSwim();
        }

        public void Running()
        {
            Run.Running();
        }

        public void RidingBike()
        {
            RideBike.RidingBike();
        }

        public void Swimming()
        {
            Swim.Swimming();
        }
    }
}