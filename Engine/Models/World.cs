using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class World
    {
        private List<Location> locations = new List<Location>();


        internal void AddLocation(int xCoord, int yCoord, string name, string description, string imageName)
        {
            Location location = new Location();
            location.XCoordinate = xCoord;
            location.YCoordinate = yCoord;
            location.Name = name;
            location.Description = description;
            location.ImageName = imageName;

            locations.Add(location);
        }

        public Location locationAt(int xCoord, int yCoord)
        {
            // nesse lugar era melhor usar foreach, pois apenas faco uma comparacao simples e nao quero manipular nenhum tipo de dado
            var location = from loc in locations
                           where loc.XCoordinate == xCoord && loc.YCoordinate == yCoord
                           select loc;

            return location.FirstOrDefault();

            /*
             *  foreach(Location loc in locations)
            {
                if(loc.XCoordinate == xCoordinate && loc.YCoordinate == yCoordinate)
                {
                    return loc;
                }
            }
            return null;
            */
        }
    }
}
