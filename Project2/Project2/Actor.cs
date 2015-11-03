﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Project2
{
    class Actor
    {
        //Shared Stats
        public string Name { get; set; }
        public int curHealth { get; set; }
        public int maxHealth { get; set; }
        public int Stamina { get; set; }
        public int Attack { get; set; }
        public int Dodge { get; set; }
        public int Magic { get; set; }
        public int Experience { get; set; }

        //List of stats
        private List<string> dataOrganized;
        //List of moves
        private List<string> moveList;


        //Status Aligments
        public bool Poisoned { get; set; }
        public bool Burned { get; set; }
        public bool Stun { get; set; }

        public Actor(string actorName)
        {
            StreamReader mySR = null;
            try
            {
                mySR = new StreamReader("Actor.txt");
                string line;
                while((line = mySR.ReadLine()) != actorName)
                {
                    //Skip all character data before specified character
                }
                while((line = mySR.ReadLine()) != null)
                {
                        dataOrganized.Add(line);
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
            Name = dataOrganized[0];
            maxHealth = int.Parse(dataOrganized[1]);
            curHealth = maxHealth;
            Stamina = int.Parse(dataOrganized[2]);
            Attack = int.Parse(dataOrganized[3]);
            Dodge = int.Parse(dataOrganized[4]);
            Magic = int.Parse(dataOrganized[5]);
            Experience = int.Parse(dataOrganized[6]);

            //Sets up move list so characters can pull from common move .txt
            for(int j = 0; j < dataOrganized.Count() - 7;j++)
            {
                moveList[j] = dataOrganized[j + 7];
            }
        }
    }
}
