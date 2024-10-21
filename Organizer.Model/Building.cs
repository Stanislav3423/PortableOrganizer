using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Organizer.Model
{
    [DataContract]
    public class Building
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public BuildingType Type { get; set; }
        [DataMember]
        public string HomeCastle { get; set; }
        [DataMember]
        public int Cost { get; set; }
        [DataMember]
        public BuildingStatus Status { get; set; }
    }

    [DataContract]
    public enum BuildingType
    {
        [EnumMember]
        Hiring,
        [EnumMember]
        Resources,
        [EnumMember]
        Magic
    }

    [DataContract]
    public enum BuildingStatus
    {
        [EnumMember]
        NotBuilt,
        [EnumMember]
        Built
    }
}
