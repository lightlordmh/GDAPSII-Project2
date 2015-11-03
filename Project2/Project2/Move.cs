using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Project2
{
    class Move
    {
        //How much Damage dealt/Health healed
        public int Attack { get; set; }
        //Move's chance to hit target
        public int Accuracy { get; set; }

        public int StatusChance { get; set; }

        public bool Aoe { get; set; }
        public string Name { get; set; }

        public string FlavorText { get; set; }

        private List<string> moveData;


        public Move(string moveName)
        {
            StreamReader mySR = null;
            try
            {
                mySR = new StreamReader("Actor.txt");
                string line;
                while ((line = mySR.ReadLine()) != moveName)
                {
                    //Skip all character data before specified move
                }
                while ((line = mySR.ReadLine()) != null)
                {
                    moveData.Add(line);
                }

            }
            catch
            {
                Console.WriteLine("File not found");
            }
            finally
            {
                if (mySR != null) mySR.Close();
            }

            Name = moveName;
            Attack = int.Parse(moveData[1]);
            Accuracy = int.Parse(moveData[2]);
            StatusChance = int.Parse(moveData[3]);
            Aoe = bool.Parse(moveData[4]);
            FlavorText = moveData[5];
        }
    }
}
