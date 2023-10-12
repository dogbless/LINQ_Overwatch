using System;
using System.Collections.Generic;

namespace ConsoleApp38
{
	public class Characters 
	{
		private string heroName;
		private string heroType;
		private int heroHp;
		private List<string> HeroAbilities;

		public string HeroName
		{
			get { return heroName; }
			set { heroName = value; }
		}

		

		public string HeroType
		{
			get { return heroType; }
			set { heroType = value; }
		}
		

		public int HeroHp
		{
			get { return heroHp; }
			set { heroHp = value; }
		}

		

		public List<string> heroAbilities
		{
			get { return HeroAbilities; }
			set { HeroAbilities = value; }
		}

		public static void Display(List<Characters> characters)
		{
			foreach (var item in characters)
			{
                if (item.HeroName == "Junkrat")
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Hero name: " + item.heroName);
                    Console.WriteLine("Hero type: " + item.heroType);
                    Console.WriteLine("Hero Health: " + item.heroHp);
                    Console.WriteLine("----------------------------");


                }
                else if (item.HeroName == "Lucio")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Hero name: " + item.heroName);
                    Console.WriteLine("Hero type: " + item.heroType);
                    Console.WriteLine("Hero Health: " + item.heroHp);
                    Console.WriteLine("----------------------------");

                }
                else if (item.HeroName == "Roadhog")
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Hero name: " + item.heroName);
                    Console.WriteLine("Hero type: " + item.heroType);
                    Console.WriteLine("Hero Health: " + item.heroHp);
                    Console.WriteLine("----------------------------");

                }
                else if (item.HeroName == "Mercy")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Hero name: " + item.heroName);
                    Console.WriteLine("Hero type: " + item.heroType);
                    Console.WriteLine("Hero Health: " + item.heroHp);
                    Console.WriteLine("----------------------------");

                }
                else if (item.HeroName == "Reinhardt")
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Hero name: " + item.heroName);
                    Console.WriteLine("Hero type: " + item.heroType);
                    Console.WriteLine("Hero Health: " + item.heroHp);
                    Console.WriteLine("----------------------------");

                }
                else if (item.HeroName == "Bastion")
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Hero name: " + item.heroName);
                    Console.WriteLine("Hero type: " + item.heroType);
                    Console.WriteLine("Hero Health: " + item.heroHp);
                    Console.WriteLine("----------------------------");
                }
                else if (item.HeroName == "Torbjorn")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Hero name: " + item.heroName);
                    Console.WriteLine("Hero type: " + item.heroType);
                    Console.WriteLine("Hero Health: " + item.heroHp);
                    Console.WriteLine("----------------------------");

                }
                else if (item.HeroName == "Widow maker")
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Hero name: " + item.heroName);
                    Console.WriteLine("Hero type: " + item.heroType);
                    Console.WriteLine("Hero Health: " + item.heroHp);
                    Console.WriteLine("----------------------------");

                }
                else if (item.HeroName == "Tracer")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Hero name: " + item.heroName);
                    Console.WriteLine("Hero type: " + item.heroType);
                    Console.WriteLine("Hero Health: " + item.heroHp);
                    Console.WriteLine("----------------------------");

                }
                Console.ForegroundColor = ConsoleColor.White;







            }
		}










	}
}
