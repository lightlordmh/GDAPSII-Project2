using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project2
{
    class Tank : Players
    {
        public Tank(string nameIn, int healthIn, int staminaIn, int attackIn, int defenseIn, int MagicIn)
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
        public Tank()
        {
            Name = "DefaultTank";
            Health = 300;
            Stamina = 200;
            Attack = 10;
            Defense = 2;
            Magic = 10;
            Experience = 0;
            ExperienceNeeded = 100;
        }
    }
}
