using System;
using System.Collections.Generic;
using System.Text;
using Engine.Models;

namespace Engine.ViewModels
{
    public class GameSession
    {
        public Player CurrentPlayer { get; set; }
        public Location CurrentLocation { get; set; }

        public GameSession()
        {
            CurrentPlayer = new Player();
            CurrentPlayer.Name = "Billy";
            CurrentPlayer.CharacterClass = "Fighter";
            CurrentPlayer.Gold = 1000000;
            CurrentPlayer.Level = 1;
            CurrentPlayer.HitPoints = 10;
            CurrentPlayer.ExperiencePoints = 0;

            CurrentLocation = new Location();
            CurrentLocation.Name = "home";
            CurrentLocation.XCoordinate = 0;
            CurrentLocation.YCoordinate = -1;
            CurrentLocation.Description = "This is your house.";




        }

    }
}
