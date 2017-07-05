using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Training.SOLID.InterfaceSegregation
{
    public class Product : IFeature
    {
        private static readonly string _versionNotSupportMsg = "Your version is not support this feature";
        public ProductVersion Version { get; private set; }
        public Product(ProductVersion version)
        {
            this.Version = version;
        }

        public void BasicFeature()
        {
            //implement code here
        }

        public void ProfessionalFeature()
        {
            if(Version == ProductVersion.Basic)
                throw new Exception(_versionNotSupportMsg);

            //implement code here
        }

        public void PremiumFeature()
        {
            if (Version == ProductVersion.Basic || Version == ProductVersion.Professional)
                throw new Exception(_versionNotSupportMsg);

            //implement code here
        }
    }

    public interface IFeature
    {
        void BasicFeature();
        void ProfessionalFeature();
        void PremiumFeature();
    }
}
