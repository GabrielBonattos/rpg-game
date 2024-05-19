using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Factories;
using Engine.Models;

namespace Engine.Controllers
{
     public class GameSessionController : INotifyPropertyChanged
    {
        public World CurrentWorld { get; set; }
        public Player CurrentPlayer { get; set; }

        private Location currentLocation;

        public Location CurrentLocation {
            get { return currentLocation; } 
            set 
            {
                currentLocation = value;

                OnPropertyChanged("CurrentLocation");
                OnPropertyChanged("HasLocationToNorth");
                OnPropertyChanged("HasLocationToEast");
                OnPropertyChanged("HasLocationToWest");
                OnPropertyChanged("HasLocationToSouth");
            }
        }
        public bool HasLocationToNorth
        {
            get
            {
                return CurrentWorld.locationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate + 1) != null;
            }
        }
        public bool HasLocationToEast
        {
            get
            {
                return CurrentWorld.locationAt(CurrentLocation.XCoordinate + 1, CurrentLocation.YCoordinate) != null;
            }
        }
        public bool HasLocationToSouth
        {
            get
            {
                return CurrentWorld.locationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate - 1) != null;
            }
        }
        public bool HasLocationToWest
        {
            get
            {
                return CurrentWorld.locationAt(CurrentLocation.XCoordinate - 1, CurrentLocation.YCoordinate) != null;
            }
        }

        public GameSessionController()
        {
            CurrentPlayer = new Player();
            CurrentPlayer.Name = "Gabriel";
            CurrentPlayer.CharacterClass = "Monk";
            CurrentPlayer.HitPoints = 10;
            CurrentPlayer.Gold = 1000000;
            CurrentPlayer.ExperiencePoints = 0;
            CurrentPlayer.Level = 1; 

            WorldFactory factory = new WorldFactory();
            CurrentWorld = factory.CreateWorld();

            CurrentLocation = CurrentWorld.locationAt(0, -1);


        }

        public void MoveNorth()
        {
            
            CurrentLocation = CurrentWorld.locationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate + 1);
            
        }
        public void MoveWest()
        {
       
            CurrentLocation = CurrentWorld.locationAt(CurrentLocation.XCoordinate - 1, CurrentLocation.YCoordinate);
            
        }
        public void MoveEast()
        {
            CurrentLocation = CurrentWorld.locationAt(CurrentLocation.XCoordinate + 1, CurrentLocation.YCoordinate);
            
        }
        public void MoveSouth()
        {
            CurrentLocation = CurrentWorld.locationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate - 1);
            
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName) //notifica o client que a propriedade mudou
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
