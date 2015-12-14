using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Graphics;
using System.Linq;
using System.Text;

namespace Project2
{
    public class Potions : Items
    {
        //All colored besides black are randomized, milk and black have set stats
        public bool Aoe { get; set; }
        public int amountHealed { get; set; }
        public int amountStamina { get; set; }
        public bool Poisons { get; set; }
        public Texture2D picture;

        public List<string> potionList { get; set; }

        public void ListIntialization()
        {
            potionList = new List<string>();
            potionList.Add("Regular");
            potionList.Add("AoeHealing");
            potionList.Add("Damage");
            potionList.Add("Weak");
            potionList.Add("Strong");
            potionList.Add("Poisons");
            potionList.Add("Milk");
            potionList.Add("Increbile");
        }

        public Potions(int IndexIn, Texture2D pictureIn)
        {
            picture = pictureIn;
            ListIntialization();
            Index = IndexIn;
            Random rand = new Random();
            int assignedArchetype = rand.Next(0, potionList.Count-2);
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
            if(IndexIn == 6)
            {
                Aoe = true;
                amountStamina = 100;
                potionList.Remove("Milk");
            }
            if (IndexIn ==7)
            {
                Aoe = true;
                amountHealed = 120;
                amountStamina = 120;
                potionList.Remove("Increbile");

            }
        }
    }
}
