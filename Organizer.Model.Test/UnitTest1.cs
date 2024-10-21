using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Organizer.Model.Serialization;

namespace Organizer.Model.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodSerialize()
        {
            var model = new DataModel();
            model.Heroes = new List<Hero>() { new Hero() { Name = "Adela" }, new Hero() { Name = "Derek" } };
            DataSerializer.SerializeData(@"D:\Universe\Sem5\KPZ\Labs\Lab2\PortableOrganizerProject\PortableOrganizer\Organizer.UI\bin\Debug\organizer.dat", model);
        }

        [TestMethod]
        public void TestMethodDeserialize()
        {
            var model = DataSerializer.DeserializeItem(@"D:\Universe\Sem5\KPZ\Labs\Lab2\PortableOrganizerProject\PortableOrganizer\Organizer.UI\bin\Debug\organizer.dat");
        }
    }
}
