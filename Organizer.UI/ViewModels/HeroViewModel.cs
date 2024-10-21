using Organizer.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizer.UI.ViewModels
{
    public class HeroViewModel : ViewModelBase
    {
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }

        private HeroClass _class;
        public HeroClass Class
        {
            get
            {
                return _class;
            }
            set
            {
                _class = value;
                OnPropertyChanged("Class");
            }
        }

        private HeroSpeciality _speciality;
        public HeroSpeciality Speciality
        {
            get
            {
                return _speciality;
            }
            set
            {
                _speciality = value;
                OnPropertyChanged("Speciality");
            }
        }

        private HeroSkill _skill;
        public HeroSkill Skill
        {
            get
            {
                return _skill;
            }
            set
            {
                _skill = value;
                OnPropertyChanged("Speciality");
            }
        }

        private HeroStatus _status;
        public HeroStatus Status
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
                OnPropertyChanged("Status");
            }
        }

        /*private Dictionary<string, int> _heroCreatures = new Dictionary<string, int>();
        public Dictionary<string, int> HeroCreatures
        {
            get
            {
                return _heroCreatures;
            }
            set
            {
                _heroCreatures = value;
                OnPropertyChanged(nameof(HeroCreatures));
            }
        }*/

        private string _unitName;
        public string UnitName
        {
            get
            {
                return _unitName;
            }
            set
            {
                _unitName = value;
                OnPropertyChanged("UnitName");
            }
        }

        private int _unitNumber;
        public int UnitNumber
        {
            get
            {
                return _unitNumber;
            }
            set
            {
                _unitNumber = value;
                OnPropertyChanged("UnitNumber");
            }
        }

    }
}
