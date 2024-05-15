using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    //The View can know about changes to properties, if the ViewModel (or Model) classes implement the INotifyPropertyChanged interface.
    //When a class implements INotifyPropertyChanged, its properties “raise” a PropertyChanged “event”. The View “listens” for that event,
    //and updates the UI, when it receives notification of the change.
    public class Player : INotifyPropertyChanged
    {
        private string name;
        private string characterClass;
        private int hitPoints;
        private int experiencePoints;
        private int level;
        private int gold;

        //To make the property raise the PropertyChanged event, when it gets a new value, they cannot be auto-properties.
        public string Name 
        {
            get { return name; }
            set {
                name = value;
                //We need to add extra code to the property “set”, to raise the Property Changed event, when the property is set to a new value.
                onPropertyChanged("ExperiencePoints");
            } 
        }
        public string CharacterClass
        {
            get { return characterClass; }
            set
            {
                characterClass = value;
                onPropertyChanged("ExperiencePoints");
            }
        }
        
        public int HitPoints
        {
            get { return hitPoints; }
            set
            {
                hitPoints = value;
                onPropertyChanged("ExperiencePoints");
            }
        }
        public int ExperiencePoints
        {
            get { return experiencePoints; }
            set
            { 
                experiencePoints = value;
                onPropertyChanged("ExperiencePoints");
            }
        }
        
        public int Level
        {
            get { return level; }
            set
            {
                level = value;
                onPropertyChanged("ExperiencePoints");
            }
        }
        
        public int Gold
        {
            get { return gold; }
            set
            {
                gold = value;
                onPropertyChanged("ExperiencePoints");
            }
        }


        //Then, we need to add a code to raise the PropertyChanged event, for anything that may be subscribed to the eventhandler, such as the View.
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void onPropertyChanged(string propertyName) //notifica o client que a propriedade mudou
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
