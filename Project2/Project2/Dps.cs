using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project2
{
    class Dps : Players
    {
        public Dps(string nameIn, int healthIn, int staminaIn, int attackIn, int defenseIn, int MagicIn)
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
        public Dps()
        {
            Name = "DefaultDps";
            Health = 100;
            Stamina = 100;
            Attack = 200;
            Defense = 1;
            Magic = 10;
            Experience = 0;
            ExperienceNeeded = 100;
        }
    }
}
