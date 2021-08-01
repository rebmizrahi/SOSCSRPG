using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.Models
{
    public class World
    {
        private List<Location> locations = new List<Location>();

        internal void addLocation(int xCoord, int yCoord, string name, string descr, string imageName)
        {
            Location loc = new Location();
            loc.XCoordinate = xCoord;
            loc.YCoordinate = yCoord;
            loc.Description = descr;
            loc.Name = name;
            loc.ImageName = imageName;

            locations.Add(loc);
        }

        public Location LocationAt(int xCoord, int yCoord)
        {
            foreach(Location location in this.locations)
            {
                if (location.XCoordinate == xCoord && location.YCoordinate == yCoord)
                {
                    return location;
                }
            }
            return null;
        }
    }
}
