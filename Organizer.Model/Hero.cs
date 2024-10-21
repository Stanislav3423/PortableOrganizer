using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Organizer.Model
{
    [DataContract]
    public class Hero
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public HeroClass Class { get; set; }
        [DataMember]
        public HeroSpeciality Speciality { get; set; }
        [DataMember]
        public HeroSkill Skill { get; set; }
        [DataMember]
        public HeroStatus Status { get; set; }
        [DataMember]
        public string UnitName { get; set; }
        [DataMember]
        public int UnitNumber { get; set; }
    }

    [DataContract]
    public enum HeroClass
    {
        [EnumMember]
        Cleric,
        [EnumMember]
        Wizard,
        [EnumMember]
        Knight,
        [EnumMember]
        Elementalist
    }

    [DataContract]
    public enum HeroSpeciality
    {
        [EnumMember]
        Bless,
        [EnumMember]
        Gold,
        [EnumMember]
        Ballista,
        [EnumMember]
        Cure,
        [EnumMember]
        Sulfur
    }

    [DataContract]
    public enum HeroSkill
    {
        [EnumMember]
        Basic_Wisdom,
        [EnumMember]
        Basic_Necromancy,
        [EnumMember]
        Basic_Leadership,
        [EnumMember]
        Basic_Offense,
        [EnumMember]
        Basic_Armorer
    }

    [DataContract]
    public enum HeroStatus
    {
        [EnumMember]
        InTavern,
        [EnumMember]
        InCastle,
        [EnumMember]
        OnMap
    }
}
