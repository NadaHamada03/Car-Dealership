using System;
namespace Codes
{
    public abstract class KiaClass : NewCarsClass
    {
        public string Make;

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

        int price;
        public override int Price()
        {
            return 50000;
        }

        public string model;
        public override string Model()
        {
            return "Sportage";
        }

        public int year;
        public override int ModelYear()
        {
            return 2020;
        }

        public string colour;
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

        int price;
        public override int Price()
        {
            return 50000;
        }

        public string model;
        public override string Model()
        {
            return "Cerato";
        }

        public int year;
        public override int ModelYear()
        {
            return 2019;
        }

        public string colour;
        public override string Color()
        {
            return "White";
        }
    }

}


