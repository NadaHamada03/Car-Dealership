using System;
namespace Codes
{
    public abstract class KiaClass : NewCarsClass
    {

        public override string Manufacturer()
        {
            return "Kia";
        }

        public abstract string Model();
        public abstract int ModelYear();
        public abstract string Color();
        public abstract int Price();

    }
    
    public class SportageClass : KiaClass
    {
        public override string Manufacturer()
        {
            return "Kia";
        }

        public override int Price()
        {
            return 50000;
        }

        public override string Model()
        {
            return "Sportage";
        }

        public override int ModelYear()
        {
            return 2019;
        }

        public override string Color()
        {
            return "Grey";
        }
    }

    public class CeratoClass : KiaClass
    {
        public override string Manufacturer()
        {
            return "Kia";
        }

        public override int Price()
        {
            return 50000;
        }

        public override string Model()
        {
            return "Cerato";
        }

        public override int ModelYear()
        {
            return 2022;
        }

        public override string Color()
        {
            return "Blue";
        }
    }

}


