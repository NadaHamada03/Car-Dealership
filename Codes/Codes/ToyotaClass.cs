using System;
namespace Codes
{
    public abstract class ToyotaClass : NewCarsClass
    {
        public override string Manufacturer()
        {
            return "Toyota";
        }

        public abstract string Model();
        public abstract int ModelYear();
        public abstract string Color();
        public abstract int Price();

    }

    public class CorollaClass : ToyotaClass
    {
        public override string Manufacturer()
        {
            return "Toyota";
        }

        public override int Price()
        {
            return 50000;
        }

        public override string Model()
        {
            return "Corolla";
        }

        public override int ModelYear()
        {
            return 2022;
        }

        public override string Color()
        {
            return "Red";
        }
    }

    public class YarisClass : ToyotaClass
    {
        public override string Manufacturer()
        {
            return "Toyota";
        }

        public override int Price()
        {
            return 50000;
        }

        public override string Model()
        {
            return "Yaris";
        }

        public override int ModelYear()
        {
            return 2022;
        }

        public override string Color()
        {
            return "Red";
        }
    }
}

