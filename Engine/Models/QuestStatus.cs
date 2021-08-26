using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.Models
{
    public class QuestStatus
    {
        public Quest PlayerQuest { get; set; }
        public bool IsComplete { get; set; }
        
        public QuestStatus(Quest quest)
        {
            PlayerQuest = quest;
            IsComplete = false; //always incomplete upon creation
        }
    }
}
