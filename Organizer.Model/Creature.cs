using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Organizer.Model
{
    [DataContract]
    public class Creature
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int Attack { get; set; }
        [DataMember]
        public int Defense { get; set; }
        [DataMember]
        public int Health { get; set; }
    }
}
