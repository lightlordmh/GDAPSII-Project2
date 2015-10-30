using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project2
{
    class Tank : NPC
    {
        public Tank(string nameIn, int healthIn, int staminaIn, int attackIn, int dodgeIn)
        {
            Name = nameIn;
            Health = healthIn;
            Stamina = staminaIn;
            Attack = attackIn;
            Dodge = dodgeIn;
        }

        //Default Object
        public Tank()
        {
            Name = "DefaultTank";
            Health = 300;
            Stamina = 200;
            Attack = 20;
            Dodge = 2;
        }
    }
}
