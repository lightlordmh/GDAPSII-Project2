using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project2
{
    class Equipment : Items
    {
        public int Health { get; set; }
        public int Stamina { get; set; }
        public int Attack { get; set; }
        public int Dodge { get; set; }
        public int Magic { get; set; }

        public string Type { get; set; }
    }
}
