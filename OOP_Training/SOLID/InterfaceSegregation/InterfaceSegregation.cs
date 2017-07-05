namespace OOP_Training.SOLID.InterfaceSegregation
{
    public class BasicVersionProduct : IBasicFeature
    {
        public void BasicFeature()
        {
            //implement code here
        }
    }

    public class ProfessionalVersionProduct : IProfessionalFeature
    {
        public void BasicFeature()
        {
            //implement code here
        }

        public void ProfessionalFeature()
        {
            //implement code here
        }
    }

    public interface IBasicFeature
    {
        void BasicFeature();        
    }
    public interface IProfessionalFeature : IBasicFeature
    {
        void ProfessionalFeature();
    }

    public interface IPremiumFeature : IProfessionalFeature
    {
        void PremiumFeature();
    }
}