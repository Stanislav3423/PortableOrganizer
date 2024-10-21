using Organizer.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xceed.Wpf.Toolkit.Zoombox;

namespace Organizer.UI.ViewModels
{
    public class DataViewModel : ViewModelBase
    {
        public DataViewModel()
        {
            SetControlVisibility = new Command(ControlVisibility);
            HeroStatusCommand = new Command(ChangeHeroStatus);
            BuildingStatusCommand = new Command(ChangeBuildingsStatus);
            ElementDeleteCommand = new Command(ElementDelete);
            AddCreatureToHeroCommand = new Command(AddCreatureToHero);
            SetHomeCastleCommand = new Command(SetHomeCastle);
            CastleUpdateCommand = new Command(CastleUpdate);
        }

        private string _visibleControl;
        public string VisibleControl
        {
            get
            {
                return _visibleControl;
            }
            set
            {
                _visibleControl = value;
                OnPropertyChanged("VisibleControl");
            }
        }

        public ICommand SetControlVisibility { get; set; }

        public void ControlVisibility(object args)
        {
            VisibleControl = args.ToString();
        }

        public ICommand HeroStatusCommand { get; set; }

        public void ChangeHeroStatus(object args)
        {
            if (SelectedHero != null)
            {
                if (args is HeroStatus newStatus)
                { SelectedHero.Status = newStatus; }
            }
        }


        public ICommand AddCreatureToHeroCommand { get; set; }

        public void AddCreatureToHero(object args)
        {
            if (SelectedCreatureNumber > 0 && SelectedHero!=null && SelectedCreature!=null)
            {
                SelectedHero.UnitName = SelectedCreature.Name;
                SelectedHero.UnitNumber = SelectedCreatureNumber;
            }
        }

        public ICommand ElementDeleteCommand { get; set; }

        public void ElementDelete(object selectedElement)
        {
            if (selectedElement is HeroViewModel hero)
            {
                if (Heroes.Contains(hero))
                {
                    Heroes.Remove(hero);
                }
            }
            else if (selectedElement is CreatureViewModel creature)
            {
                if (Creatures.Contains(creature))
                {
                    Creatures.Remove(creature);
                }
            }
            else if (selectedElement is CastleViewModel castle)
            {
                if (Castles.Contains(castle))
                {
                    Castles.Remove(castle);
                }
            }
            else if (selectedElement is BuildingViewModel building)
            {
                if (Buildings.Contains(building))
                {
                    Buildings.Remove(building);
                }
            }
        }

        public ICommand CastleUpdateCommand { get; set; }

        public void CastleUpdate(object args)
        {
            if (SelectedCastle != null)
            {
                SelectedCastle.Level++;
            }
        }

        public ICommand BuildingStatusCommand { get; set; }

        public void ChangeBuildingsStatus(object args)
        {
            if (SelectedBuilding != null)
            {
                CastleViewModel castle = GetCastleByName(SelectedBuilding.HomeCastle);
                if (args is BuildingStatus newStatus && castle!=null && castle.Gold >= SelectedBuilding.Cost)
                {
                    if (newStatus == BuildingStatus.Built)
                    {
                        castle.Gold -= SelectedBuilding.Cost;
                    }
                    else if (newStatus == BuildingStatus.NotBuilt)
                    {
                        castle.Gold += SelectedBuilding.Cost;
                    }
                    SelectedBuilding.Status = newStatus;
                }
            }
        }

        public CastleViewModel GetCastleByName(string name)
        {
            return _Castles.FirstOrDefault(c => c.Name == name);
        }

        public ICommand SetHomeCastleCommand { get; set; }

        public void SetHomeCastle(object args)
        {
            if (SelectedBuilding != null && SelectedCastle != null)
            {
                SelectedBuilding.HomeCastle = SelectedCastle.Name;
            }
        }

        private HeroViewModel _selectedHero;

        public HeroViewModel SelectedHero
        {
            get
            {
                return _selectedHero;
            }
            set
            {
                _selectedHero = value;
                OnPropertyChanged("SelectedHero");
            }
        }

        private CreatureViewModel _selectedCreature;

        public CreatureViewModel SelectedCreature
        {
            get
            {
                return _selectedCreature;
            }
            set
            {
                _selectedCreature = value;
                OnPropertyChanged("SelectedCreature");
            }
        }

        private CastleViewModel _selectedCastle;

        public CastleViewModel SelectedCastle
        {
            get
            {
                return _selectedCastle;
            }
            set
            {
                _selectedCastle = value;
                OnPropertyChanged("SelectedCastle");
            }
        }

        private BuildingViewModel _selectedBuilding;

        public BuildingViewModel SelectedBuilding
        {
            get
            {
                return _selectedBuilding;
            }
            set
            {
                _selectedBuilding = value;
                OnPropertyChanged("SelectedBuilding");
            }
        }


        private int _selectedCreatureNumber;
        public int SelectedCreatureNumber
        {
            get => _selectedCreatureNumber;
            set
            {
                _selectedCreatureNumber = value;
                OnPropertyChanged("SelectedCreatureNumber");
            }
        }

        private ObservableCollection<HeroViewModel> _Heroes { get; set; }
        public ObservableCollection<HeroViewModel> Heroes
        {
            get
            {
                return _Heroes;
            }
            set
            {
                _Heroes = value;
                OnPropertyChanged("Heroes");
            }
        }

        private ObservableCollection<CreatureViewModel> _Creatures { get; set; }
        public ObservableCollection<CreatureViewModel> Creatures
        {
            get
            {
                return _Creatures;
            }
            set
            {
                _Creatures = value;
                OnPropertyChanged("Creatures");
            }
        }

        private ObservableCollection<BuildingViewModel> _Buildings { get; set; }
        public ObservableCollection<BuildingViewModel> Buildings
        {
            get
            {
                return _Buildings;
            }
            set
            {
                _Buildings = value;
                OnPropertyChanged("Buildings");
            }
        }

        private ObservableCollection<CastleViewModel> _Castles { get; set; }
        public ObservableCollection<CastleViewModel> Castles
        {
            get
            {
                return _Castles;
            }
            set
            {
                _Castles = value;
                OnPropertyChanged("Castles");
            }
        }
    }
}
