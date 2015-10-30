using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project2
{
    class Mage : NPC
    {
        public Mage(string nameIn, int healthIn, int staminaIn, int attackIn, int dodgeIn, int MagicIn)
        {
            Name = nameIn;
            Health = healthIn;
            Stamina = staminaIn;
            Attack = attackIn;
            Dodge = dodgeIn;
            Magic = MagicIn;
        }

        //Default Object
        public Mage()
        {
            Name = "DefaultMage";
            Health = 100;
            Stamina = 100;
            Attack = 15;
            Dodge = 4;
            Magic = 250;
        }
    }
}
