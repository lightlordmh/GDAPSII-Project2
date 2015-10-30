using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project2
{
    class Player : Actor
    {
        public Player(string nameIn, int healthIn, int staminaIn, int attackIn, int dodgeIn, int MagicIn)
        {
            Name = nameIn;
            Health = healthIn;
            Stamina = staminaIn;
            Attack = attackIn;
            Dodge = dodgeIn;
            Magic = MagicIn;
        }

        //Default Object
        public Player()
        {
            Name = "DefaultTank";
            Health = 150;
            Stamina = 150;
            Attack = 10;
            Dodge = 3;
            Magic = 150;
        }
    }
}
