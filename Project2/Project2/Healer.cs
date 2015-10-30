using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project2
{
    class Healer : Players
    {
        //Healer unique stat
        int Mana { get; set; }

        public Healer(string nameIn, int healthIn, int staminaIn, int attackIn, int defenseIn, int MagicIn, int manaIn)
        {
            Name = nameIn;
            Health = healthIn;
            Stamina = staminaIn;
            Attack = attackIn;
            Defense = defenseIn;
            Magic = MagicIn;
            Mana = manaIn;
            Experience = 0;
            ExperienceNeeded = 100;
        }

        //Default Object
        public Healer()
        {
            Name = "DefaultHealer";
            Health = 200;
            Stamina = 150;
            Attack = 20;
            Defense = 1;
            Magic = 20;
            Mana = 400;
            Experience = 0;
            ExperienceNeeded = 100;
        }
    }
}
