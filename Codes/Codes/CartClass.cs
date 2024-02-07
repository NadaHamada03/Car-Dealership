using System;
namespace Codes
{
	public class CartClass
	{
		SportageClass sportage = new SportageClass();
		CeratoClass cerato = new CeratoClass();

		LoganClass logan = new LoganClass();
		MeganeClass megane = new MeganeClass();

		CorollaClass corolla = new CorollaClass();
		YarisClass yaris = new YarisClass();

		public int PreOrder(NewCarsClass sender)
		{
			if (sender is SportageClass)
				return sportage.Price();
			if (sender is CeratoClass)
				return cerato.Price();
            if (sender is LoganClass)
                return logan.Price();
            if (sender is MeganeClass)
                return megane.Price();
            if (sender is CorollaClass)
                return sportage.Price();
			if (sender is YarisClass)
				return cerato.Price();
			else return 0;
        }
	}
}

