﻿using System;
using System.Collections.Generic;
using System.Text;
using Engine.Models;
using System.Linq;

namespace Engine.Factories
{
    public static class ItemFactory
    {
        private static List<GameItem> standardGameItems;

        static ItemFactory()
        {
            standardGameItems = new List<GameItem>();
            standardGameItems.Add(new Weapon(1001, "Pointy Stick", 1, 1, 2));
            standardGameItems.Add(new Weapon(1002, "Rusty Sword", 5, 1, 3));
            standardGameItems.Add(new GameItem(9001, "Snake fang", 1));
            standardGameItems.Add(new GameItem(9002, "Snakeskin", 2));
            standardGameItems.Add(new GameItem(9003, "Rat tail", 1));
            standardGameItems.Add(new GameItem(9004, "Rat fur", 2));
            standardGameItems.Add(new GameItem(9005, "Spider fang", 1));
            standardGameItems.Add(new GameItem(9006, "Spider silk", 2));

        }

        public static GameItem CreateGameItem(int itemTypeID) //creates new item from all possible items
        {
            GameItem standardItem = standardGameItems.FirstOrDefault //default is null
                (item => item.ItemTypeID == itemTypeID);
            if (standardItem != null)
            {
                return standardItem.Clone();
            }
            return null;
        }
    }
}
