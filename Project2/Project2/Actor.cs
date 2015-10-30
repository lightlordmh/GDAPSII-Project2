using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project2
{
    class Actor
    {
        //Shared Stats
        public string Name { get; set; }
        public int Health { get; set; }
        public int Stamina { get; set; }
        public int Attack { get; set; }
        public int Dodge { get; set; }
        public int Magic { get; set; }
        public int Experience { get; set; }


        //Status Aligments
        public bool Poisoned { get; set; }
        public bool Burned { get; set; }
        public bool Stun { get; set; }
    }
}
