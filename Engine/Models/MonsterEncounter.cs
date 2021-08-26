using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.Models
{
    public class MonsterEncounter
    {
        public int MonsterID { get; set; }
        public int ChanceOfEncountering { get; set; }

        public MonsterEncounter(int monsterID, int chance)
        {
            MonsterID = monsterID;
            ChanceOfEncountering = chance;
        }
    }
}
