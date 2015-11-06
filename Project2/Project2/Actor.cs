using System;
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
        public int Health { get; set; }
        public int Stamina { get; set; }
        public int curStamina { get; set; }
        public int Attack { get; set; }
        public int Dodge { get; set; }
        public int Magic { get; set; }
        public int Experience { get; set; }

        //Status Aligments
        public bool Poisoned { get; set; }
        public bool Burned { get; set; }
        public bool Stun { get; set; }

        List<string> dataOrganized, moveList;

        public Actor(string actorName)
        {
            dataOrganized = new List<string>();
            moveList = new List<string>();

        }

        public void ActorFile(string actorName)
        {
            StreamReader mySR = null;
            try
            {
                mySR = new StreamReader("Actor.txt");
                string line;
                while ((line = mySR.ReadLine()) != actorName)
                {
                    //Skip all character data before specified character
                }
                int i = 0;
                while ((line = mySR.ReadLine()) != null && i<5)
                {
                    dataOrganized.Add(line);
                    i++;
                }
                //Name = dataOrganized[0];
                Health = int.Parse(dataOrganized[0]);
                curHealth = Health;
                Stamina = int.Parse(dataOrganized[1]);
                curStamina = Stamina;
                Attack = int.Parse(dataOrganized[2]);
                Dodge = int.Parse(dataOrganized[3]);
                Magic = int.Parse(dataOrganized[4]);
                Experience = int.Parse(dataOrganized[5]);
            }
            catch
            {
                Console.WriteLine("File not found");
            }
            finally
            {
                if (mySR != null) mySR.Close();
            }


            //Sets up move list so characters can pull from common move .txt
            for (int j = 0; j < dataOrganized.Count() - 7; j++)
            {
                moveList[j] = dataOrganized[j + 7];
            }
        }
    }
}
