using System;
namespace Codes
{
    class ServiceClass : RepairServiceClass
    {
        public int Filters(string type)
        {
            if (type == "Air Filters")
                return 600;
            if (type == "Fuel Filters")
                return 700;
            else return 0;
        }

        public int OilChange()
        {
            return 300;
        }
    }
}

