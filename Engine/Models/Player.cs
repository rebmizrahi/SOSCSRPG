using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Text;

namespace Engine.Models
{
    public class Player : BaseNotificationClass
    {
        private string characterClass;
        private int hitPoints;
        private int experiencePoints;
        private int level;
        private int gold;

        public string Name { get; set; }
        public string CharacterClass
        {
            get { return characterClass; }
            set
            {
                characterClass = value;
                OnPropertyChanged(nameof(CharacterClass));
            }
        }
        public int HitPoints 
        {
            get { return hitPoints; }
            set
            {
                hitPoints = value;
                OnPropertyChanged(nameof(HitPoints));
            }
        }
        public int ExperiencePoints 
        { 
            get { return experiencePoints; }
            set 
            { 
                experiencePoints = value;
                OnPropertyChanged(nameof(ExperiencePoints));
            } 
        }

        public int Level 
        {
            get { return level; }
            set
            {
                level = value;
                OnPropertyChanged(nameof(Level));
            }
        }
        public int Gold
        {
            get { return gold; }
            set
            {
                gold = value;
                OnPropertyChanged(nameof(Gold));
            }
        }

        public ObservableCollection<GameItem> Inventory { get; set; } //handles OnPropertyChanged/updates
        public ObservableCollection<QuestStatus> Quests { get; set; } //handles OnPropertyChanged/updates

        public Player()
        {
            Inventory = new ObservableCollection<GameItem>();
            Quests = new ObservableCollection<QuestStatus>();
        }


     
    }
}
