using System;
namespace Codes
{
    public abstract class RenaultClass : NewCarsClass
    {
        public override string Manufacturer()
        {
            return "Renault";
        }

        public abstract string Model();
        public abstract int ModelYear();
        public abstract string Color();
        public abstract int Price();
    }

    public class LoganClass : RenaultClass
    {
        public override string Manufacturer()
        {
            return "Renault";
        }

        public override int Price()
        {
            return 50000;
        }

        public override string Model()
        {
            return "Logan";
        }

        public override int ModelYear()
        {
            return 2020;
        }

        public override string Color()
        {
            return "Black";
        }
    }

    public class MeganeClass : RenaultClass
    {
        public override string Manufacturer()
        {
            return "Renault";
        }

        public override int Price()
        {
            return 50000;
        }

        public override string Model()
        {
            return "Megane";
        }

        public override int ModelYear()
        {
            return 2021;
        }

        public override string Color()
        {
            return "Red";
        }
    }
}

