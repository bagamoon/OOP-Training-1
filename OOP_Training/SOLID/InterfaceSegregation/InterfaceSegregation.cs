namespace OOP_Training.SOLID.InterfaceSegregation
{
    public class BasicVersionProduct : IBasicFeature
    {
        public void BasicFeature()
        {            
        }
    }

    public class ProfessionalVersionProduct : IProfessionalFeature
    {
        public void BasicFeature()
        {            
        }

        public void ProfessionalFeature()
        {
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