using Organizer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizer.UI.ViewModels
{
    public class BuildingViewModel : ViewModelBase
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

        private BuildingType _type;
        public BuildingType Type
        {
            get => _type;
            set
            {
                _type = value;
                OnPropertyChanged("Type");
            }
        }

        private string _homeCastle;
        public string HomeCastle
        {
            get => _homeCastle;
            set
            {
                _homeCastle = value;
                OnPropertyChanged("HomeCastle");
            }
        }

        private int _cost;
        public int Cost
        {
            get => _cost;
            set
            {
                _cost = value;
                OnPropertyChanged("Cost");
            }
        }

        private BuildingStatus _status;
        public BuildingStatus Status
        {
            get => _status;
            set
            {
                _status = value;
                OnPropertyChanged("Status");
            }
        }
    }

}
