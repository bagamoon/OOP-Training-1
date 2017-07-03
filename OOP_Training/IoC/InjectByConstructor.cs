namespace OOP_Training.IoC
{
    public class InjectByConstructor
    {
        public IRun Run { get; private set; }
        public IRideBike RideBike { get; private set; }
        public ISwim Swim { get; private set; }

        public InjectByConstructor(IRun run, IRideBike rideBike, ISwim swim)
        {
            this.Run = run;
            this.RideBike = rideBike;
            this.Swim = swim;
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