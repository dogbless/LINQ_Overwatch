using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
{

    internal class Program
    {
        static void Main(string[] args)
        {
            var weakHeroes = new List<Characters>();
            var AlottaHealht = new List<Characters>();
            var filterList = new List<Characters>();
            var listOfHeroes = new List<Characters>
            
            {
                 new Characters { HeroName="Junkrat", HeroType="Dps",HeroHp=200, heroAbilities=new List<string>{"mine","riptire","trap"} },
                 new Characters { HeroName="Roadhog", HeroType="Tank",HeroHp=600, heroAbilities=new List<string>{"Hook","Heal","Whole-hog"} },
                 new Characters { HeroName="Mercy", HeroType="Support",HeroHp=200, heroAbilities=new List<string>{"Heal Boost","Glide","Revive","Fly"} },
                 new Characters { HeroName="Reinhardt", HeroType="Tank",HeroHp=500, heroAbilities=new List<string>{"Shield","Hammer","Firestrike"} },
                 new Characters { HeroName="Bastion", HeroType="Dps",HeroHp=300, heroAbilities=new List<string>{"Turret transformation","Grenade","Tank"} },
                 new Characters { HeroName="Torbjorn", HeroType="Dps",HeroHp=200, heroAbilities=new List<string>{"Turret","Bolt gun","Molten Core"} },
                 new Characters { HeroName="Widow maker", HeroType="Dps",HeroHp=175, heroAbilities=new List<string>{"Sniper","Venom mine","Grapple Hook"} },
                 new Characters { HeroName="Tracer", HeroType="Dps",HeroHp=150, heroAbilities=new List<string>{"Rewind","Blink","PulseBomb"} },
                 new Characters { HeroName="Lucio", HeroType="Support",HeroHp=200, heroAbilities=new List<string>{"Heal","Speed","Boop","Wall ride"} }


            } ;
            Characters.Display(listOfHeroes);

            filterList = listOfHeroes.Where(e => e.HeroType == "Dps" ).ToList();
            Console.WriteLine("\n(Dps Heroes)");
            foreach (var item in filterList)
            {

                Console.WriteLine( item.HeroName);
            }
            Console.WriteLine("\n");
            AlottaHealht = listOfHeroes.Where(n => n.HeroHp > 200).ToList();
            Console.WriteLine("(Characters with health over 200)");
            foreach (var item2 in AlottaHealht)
            {
                Console.WriteLine(item2.HeroName + ": Health = " + item2.HeroHp);


            }
            Console.WriteLine("\n");
            Console.WriteLine("(Characters with health under 200)");
            weakHeroes = listOfHeroes.Where(l => l.HeroHp < 200).ToList();
            foreach (var item in weakHeroes)
            {
                Console.WriteLine($"{item.HeroName}: Health = {item.HeroHp}");
            }

            










        }
    }
}
