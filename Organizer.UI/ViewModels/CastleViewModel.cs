using Organizer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizer.UI.ViewModels
{
    public class CastleViewModel : ViewModelBase
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

        private int _gold;
        public int Gold
        {
            get => _gold;
            set
            {
                _gold = value;
                OnPropertyChanged("Gold");
            }
        }

        private int _wood;
        public int Wood
        {
            get => _wood;
            set
            {
                _wood = value;
                OnPropertyChanged("Wood");
            }
        }

        private int _ore;
        public int Ore
        {
            get => _ore;
            set
            {
                _ore = value;
                OnPropertyChanged("Ore");
            }
        }

        private int _level;
        public int Level
        {
            get => _level;
            set
            {
                _level = value;
                OnPropertyChanged("Level");
            }
        }
    }
}
