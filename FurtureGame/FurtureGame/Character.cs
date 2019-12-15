using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurtureGame
{
    abstract class Character
    {
        public string Nickname { get; set; }
        public int HealtPoint { get; set; }

        public abstract void DisplayInformation();
        
    }
}
