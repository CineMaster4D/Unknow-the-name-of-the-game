using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurtureGame
{
    class Person : Character
    {
        public override void DisplayInformation()
        {
            Console.WriteLine($"Человек: {Nickname} - {HealtPoint}HP");
        }

    }
}
