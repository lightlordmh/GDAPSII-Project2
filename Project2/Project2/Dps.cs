﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project2
{
    class Dps : NPC
    {
        public Dps(string nameIn, int healthIn, int staminaIn, int attackIn, int dodgeIn)
        {
            Name = nameIn;
            Health = healthIn;
            Stamina = staminaIn;
            Attack = attackIn;
            Dodge = dodgeIn;
        }

        //Default Object
        public Dps()
        {
            Name = "DefaultDps";
            Health = 150;
            Stamina = 150;
            Attack = 10;
            Dodge = 3;
        }
    }
}
