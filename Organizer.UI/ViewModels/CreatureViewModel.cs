using System;
using Organizer.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizer.UI.ViewModels
{
    public class CreatureViewModel : ViewModelBase
    {
        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }

        private int _attack;
        public int Attack
        {
            get => _attack;
            set
            {
                _attack = value;
                OnPropertyChanged("Attack");
            }
        }

        private int _defense;
        public int Defense
        {
            get => _defense;
            set
            {
                _defense = value;
                OnPropertyChanged("Defense");
            }
        }

        private int _health;
        public int Health
        {
            get => _health;
            set
            {
                _health = value;
                OnPropertyChanged("Health");
            }
        }
    }
}
