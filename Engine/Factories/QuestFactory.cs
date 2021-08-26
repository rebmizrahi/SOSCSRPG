using System;
using System.Collections.Generic;
using System.Text;
using Engine.Models;
using System.Linq;

namespace Engine.Factories
{
    internal static class QuestFactory
    {
        private static readonly List<Quest> quests = new List<Quest>();

        static QuestFactory()
        {


            //Declaring items needed to complete quests and corresponding reward items
            List<ItemQuantity> itemsToComplete = new List<ItemQuantity>();
            List<ItemQuantity> rewardItems = new List<ItemQuantity>();

            //one quest:
            itemsToComplete.Add(new ItemQuantity(9001, 5));
            rewardItems.Add(new ItemQuantity(1002, 1));

            //create quest
            quests.Add(new Quest(1, "Clear the herb garden",
                "Defeat snakes in the herbalist's garden",
                itemsToComplete,
                25, 10, rewardItems));
        }

        internal static Quest GetQuestByID(int id)
        {
            return quests.FirstOrDefault(quest => quest.ID == id);
        }
    }
}
