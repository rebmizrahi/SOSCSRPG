using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Engine.Models;
using Engine.Factories;
using System.Linq;

namespace Engine.ViewModels
{
    public class GameSession : BaseNotificationClass
    {
        private Location currentLocation;

        public Player CurrentPlayer { get; set; }
        public Location CurrentLocation
        {
            get { return currentLocation; }
            set
            {
                currentLocation = value;
                OnPropertyChanged(nameof(CurrentLocation));
                OnPropertyChanged(nameof(hasNorthLoc));
                OnPropertyChanged(nameof(hasSouthLoc));
                OnPropertyChanged(nameof(hasWestLoc));
                OnPropertyChanged(nameof(hasEastLoc));

                GivePlayerQuestsAtLocation();
            }
        }
        public World CurrentWorld { get; set; }

        public bool hasNorthLoc
        {
            get { return CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate + 1) != null; }
        } 
        public bool hasSouthLoc
        {
            get { return CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate - 1) != null; }
        } public bool hasEastLoc
        {
            get { return CurrentWorld.LocationAt(CurrentLocation.XCoordinate + 1, CurrentLocation.YCoordinate) != null; }
        } public bool hasWestLoc
        {
            get { return CurrentWorld.LocationAt(CurrentLocation.XCoordinate - 1, CurrentLocation.YCoordinate) != null; }
        }


        public GameSession()
        {
            CurrentPlayer = new Player
            {
                Name = "Billy",
                CharacterClass = "Fighter",
                Gold = 1000000,
                Level = 1,
                HitPoints = 10,
                ExperiencePoints = 0
            };

            CurrentWorld = WorldFactory.CreateWorld();

            CurrentLocation = CurrentWorld.LocationAt(0, -1);

        }

        public void MoveNorth()
        {
            if (hasNorthLoc)
            {
                CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate + 1);
            }
        }
        public void MoveSouth()
        {
            if (hasSouthLoc)
            {
                CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate - 1);
            }
        }
        public void MoveEast()
        {
            if (hasEastLoc)
            {
                CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate + 1, CurrentLocation.YCoordinate);

            }
        }
        public void MoveWest()
        {   
            if (hasWestLoc)
            {
                CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate - 1, CurrentLocation.YCoordinate);
            }
        }
     
        public void GivePlayerQuestsAtLocation()
        {
            foreach(Quest quest in CurrentLocation.QuestsAvailable)
            {
                //if current player does not have that quest already
                    //if !any quest ID of current player's quests q matches Quest quest
                if (!CurrentPlayer.Quests.Any(q => q.PlayerQuest.ID == quest.ID))
                {
                    CurrentPlayer.Quests.Add(new QuestStatus(quest));
                }
            }
        }
    }
}
