using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurtureGame
{
    class Bot : Character
    {
        public override void DisplayInformation()
        {
            Console.WriteLine($"Бот: {Nickname} - {HealtPoint}HP");
        }
    }
}
