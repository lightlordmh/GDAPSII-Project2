using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project2
{
    class Mage : Players
    {
        public Mage(string nameIn, int healthIn, int staminaIn, int attackIn, int defenseIn, int MagicIn)
        {
            Name = nameIn;
            Health = healthIn;
            Stamina = staminaIn;
            Attack = attackIn;
            Defense = defenseIn;
            Magic = MagicIn;
            Experience = 0;
            ExperienceNeeded = 100;
        }

        //Default Object
        public Mage()
        {
            Name = "DefaultMage";
            Health = 80;
            Stamina = 30;
            Attack = 10;
            Defense = 1;
            Magic = 250;
            Experience = 0;
            ExperienceNeeded = 100;
        }
    }
}
