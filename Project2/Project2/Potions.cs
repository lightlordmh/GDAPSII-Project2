using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project2
{
    class Potions : Items
    {
        public bool Aoe { get; set; }
        public int amountHealed { get; set; }
        public bool Poisons { get; set; }

        List<string> potionList;

        public void ListIntialization()
        {
            potionList = new List<string>();
            potionList.Add("Regular");
            potionList.Add("AoeHealing");
            potionList.Add("Damage");
            potionList.Add("Weak");
            potionList.Add("Strong");
            potionList.Add("Poisons");
            potionList.Add("Increbile");
        }

        public Potions()
        {
            Random rand = new Random();
            int assignedArchetype = rand.Next(0, potionList.Count);
            Poisons = false;
            if (potionList[assignedArchetype] =="Regular")
            {
                Aoe = false;
                amountHealed = 100;
                potionList.Remove("Regular");

            }
            if (potionList[assignedArchetype] == "AoeHealing")
            {
                Aoe = true;
                amountHealed = 40;
                potionList.Remove("AoeHealing");


            }
            if (potionList[assignedArchetype] == "Damage")
            {
                Aoe = false;
                amountHealed = -80;
                potionList.Remove("Damage");

            }
            if (potionList[assignedArchetype] == "Weak")
            {
                Aoe = false;
                amountHealed = 60;
                potionList.Remove("Weak");

            }
            if (potionList[assignedArchetype] == "Strong")
            {
                Aoe = false;
                amountHealed = 150;
                potionList.Remove("Strong");

            }
            if (potionList[assignedArchetype] == "Poisons")
            {
                Aoe = false;
                amountHealed = 100;
                Poisons = true;
                potionList.Remove("Poisons");

            }
            if (potionList[assignedArchetype] == "Incredible")
            {
                Aoe = true;
                amountHealed = 120;
                potionList.Remove("Increbile");

            }
        }
    }
}
