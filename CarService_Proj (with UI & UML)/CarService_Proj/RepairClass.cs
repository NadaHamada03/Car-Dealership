using System;
namespace Codes
{
    public class RepairClass : RepairServiceClass
    {
        public int Tyres(int numtyres, int size)
        {
            int sizeA = 215;
            int priceA = 500;

            int sizeB = 235;
            int priceB = 700;

            if (size == sizeA)
            {
                return numtyres * priceA;
            }
            else if (size == sizeB)
            {
                return numtyres * priceB;
            }
            else return 0;
        }

        public int Lights(string type)
        {
            if (type == "HeadLights")
                return 800;
            if (type == "TailLights")
                return 300;
            if (type == "FogLights")
                return 300;
            else return 0;
        }

        public int Bumpers(string type)
        {
            if (type == "Rear")
                return 100;
            if (type == "Front")
                return 100;
            else return 0;
        }
    }
}

