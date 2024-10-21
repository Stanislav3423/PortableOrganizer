using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Organizer.Model
{
    [DataContract]
    public class Castle
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int Gold { get; set; }
        [DataMember]
        public int Wood { get; set; }
        [DataMember]
        public int Ore { get; set; }
        [DataMember]
        public int Level { get; set; }

    }
}
