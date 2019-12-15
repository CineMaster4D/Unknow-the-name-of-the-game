using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurtureGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Character("Wrigl", 100);
            var bot = new Character("Wingrada.Frima", 40);

            for(var i = 0; i < 10; i++)
            {
                var PossotionPerson = person.Run();
                Console.WriteLine(PossotionPerson);

                var PossotionBot = person.Run();
                Console.WriteLine(PossotionBot);
            }

            Console.ReadLine();
        }
    }
}
