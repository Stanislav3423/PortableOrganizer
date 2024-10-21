using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Organizer.Model.Serialization;

namespace Organizer.Model
{
    [DataContract]
    public class DataModel
    {
        // New
        [DataMember]
        public IEnumerable<Hero> Heroes { get; set; }
        [DataMember]
        public IEnumerable<Creature> Creatures { get; set; }
        [DataMember]
        public IEnumerable<Building> Buildings { get; set; }
        [DataMember]
        public IEnumerable<Castle> Castles { get; set; }

        public DataModel()
        {
            /*Tasks =  new List<TaskData>() { new TaskData() { Name = "Підг лаби" }, new TaskData() { Name = "Підг лаби2" } };
            Projects = new List<ProjectData>() { new ProjectData() { Name = "Project 1" }, new ProjectData() { Name = "Project 2" } };*/

            Heroes = new List<Hero>() { new Hero() { Name = "Adela" }, new Hero() { Name = "Derek" } };
            Creatures = new List<Creature>() { new Creature() { Name = "Archer" }, new Creature() { Name = "Pit Fiend" } };
            Buildings = new List<Building>() { new Building() { Name = "Halls" }, new Building() { Name = "Marketplace" } };
            Castles = new List<Castle>() { new Castle() { Name = "Rampart" }, new Castle() { Name = "Inferno" } };
        }

        public static string DataPath = "organizer.dat";

        public static DataModel Load()
        {
            if (File.Exists(DataPath))
            {
                return DataSerializer.DeserializeItem(DataPath);
            }

            return new DataModel();
        }

        public void Save()
        {
            DataSerializer.SerializeData(DataPath, this);
        }
    }
}
