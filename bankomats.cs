using System;
public class Program
{
	public static void Main()
	{
		int nauda=10;
		int pin=1234;
		int meginajumi = 0;


	    for (int i = 0; i < 3; i++)
   		{
        	Console.WriteLine("Ievadiet 4 ciparu PIN kodu");
        	int ievade = Convert.ToInt32(Console.ReadLine());

        	if (ievade != pin)
			{
            meginajumi++;
			}
        	else
			{
            	break;
			}
    	}


	    if (meginajumi > 2)
    	    Console.WriteLine("ha netiksiet iekšā 🤣🤣");
    	else
		{
			Console.WriteLine("1.Apskatīt cik naudas ir kontā?");
			Console.WriteLine("2.Cik daudz gribat izņemt naudu?");
			Console.WriteLine("3.Cik daudz gribat ieskaitīt naudu?");
			Console.WriteLine("Izvēlaties variantu");
			int izvele = Convert.ToInt32(Console.ReadLine());
			switch(izvele)
			{
				case 1:
					Console.WriteLine("Jums ir: "+nauda+"€");
				break;
				
				case 2:
				Console.WriteLine("Cik gribat izņemt?");
				{
					int X = Convert.ToInt32(Console.ReadLine());
					if(X<=nauda)
					{
						Console.WriteLine("Savāciet jūsu "+X+"€");
						int tgd=nauda-X;
						if(0<tgd)
						{
							Console.WriteLine("Jums tagad ir "+tgd+"€");
						}
						else
						{
							Console.WriteLine("Jums nav naudas");
						}
					}
					else
					{
					Console.WriteLine("Jums nav tik daudz naudas");
					}
				}
				break;

				case 3:
				Console.WriteLine("Cik gribat ieskaitīt?");
				int Y = Convert.ToInt32(Console.ReadLine());
				int tagad=nauda+Y;
				Console.WriteLine("Jums tagad ir "+tagad+"€");
				break;
			}
		}
	}
}
