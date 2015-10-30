using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project2
{
    class Equipment : Items
    {
        public int Health { get; }
        public int Stamina { get; }
        public int Attack { get; }
        public int Defense { get; }
        public int Magic { get; }

        public string Type { get; }
    }
}
