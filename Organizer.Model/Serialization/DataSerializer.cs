using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace Organizer.Model.Serialization
{
    public class DataSerializer
    {
        public static void SerializeData(string fileName, DataModel data)
        {
            var formatter = new System.Runtime.Serialization.DataContractSerializer(typeof(DataModel));
            var s = new FileStream(fileName, FileMode.Create);
            formatter.WriteObject(s, data);
            s.Close();
        }

        public static DataModel DeserializeItem(string fileName)
        {
            var s = new FileStream(fileName, FileMode.Open);
            var formatter = new System.Runtime.Serialization.DataContractSerializer(typeof(DataModel));
            return (DataModel)formatter.ReadObject(s);
        }
    }
}
