using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace Engine.Models
{
    public class Monster : BaseNotificationClass
    {
        private int hitPoints;

        public string Name { get; private set; }
        public string ImageName { get; set; }
        public int MaxHitPoints { get; private set; }
        public int HitPoints
        {
            get { return HitPoints; }
            private set
            {
                HitPoints = value;
                OnPropertyChanged(nameof(HitPoints));
            }
        }

        public int RewardXPPoints { get; private set; }
        public int RewardGold { get; private set; }

        public ObservableCollection<ItemQuantity> Inventory { get; set; } //loot items

        public Monster(string name, string imageName, int maxHitPoints, int hitPoints,
            int rewardXPPoints, int rewardGold)
        {
            Name = name;
            ImageName = string.Format("pack://application:,,,/Engine;component/Graphics/Monsters/{0}", imageName);
            MaxHitPoints = maxHitPoints;
            RewardXPPoints = rewardXPPoints;
            HitPoints = hitPoints;
            RewardGold = rewardGold;
            Inventory = new ObservableCollection<ItemQuantity>();

        }
    }
}
