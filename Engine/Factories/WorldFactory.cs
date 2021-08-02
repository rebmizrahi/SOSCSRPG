using System;
using System.Collections.Generic;
using System.Text;
using Engine.Models;

namespace Engine.Factories
{
    internal static class WorldFactory
    {
        internal static World CreateWorld()
        {
            World newWorld = new World();
            newWorld.addLocation(0, -1, "Home", "This is your home", 
                "pack://application:,,,/Engine;component/Graphics/Locations/Home.png");
            newWorld.addLocation(-1, -1, "Farmer's House", "This your neighbor's house, Farmer Ted.", 
                "/Engine;component/Graphics/Locations/Farmhouse.png");
            newWorld.addLocation(-2, -1, "Farmer's Field", "There are rows of corn growing here, with giant rats hiding between them.", 
                "/Engine;component/Graphics/Locations/FarmFields.png");
            
            return newWorld;
        }
    }
}
