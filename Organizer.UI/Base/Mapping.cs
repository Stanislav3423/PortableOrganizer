using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Organizer.Model;
using Organizer.UI.ViewModels;

namespace Organizer.UI.Base
{
    public class Mapping
    {
        public void Create()
        {
            Mapper.CreateMap<DataModel, DataViewModel>();
            Mapper.CreateMap<DataViewModel, DataModel>();

            /*Mapper.CreateMap<TaskViewModel, TaskData>();
            Mapper.CreateMap<TaskData, TaskViewModel>();

            Mapper.CreateMap<ProjectViewModel, ProjectData>();
            Mapper.CreateMap<ProjectData, ProjectViewModel>();*/

            Mapper.CreateMap<HeroViewModel, Hero>();
            Mapper.CreateMap<Hero, HeroViewModel>();

            Mapper.CreateMap<CreatureViewModel, Creature>();
            Mapper.CreateMap<Creature, CreatureViewModel>();

            Mapper.CreateMap<BuildingViewModel, Building>();
            Mapper.CreateMap<Building, BuildingViewModel>();

            Mapper.CreateMap<CastleViewModel, Model.Castle>();
            Mapper.CreateMap<Model.Castle, CastleViewModel>();
        }
    }
}
