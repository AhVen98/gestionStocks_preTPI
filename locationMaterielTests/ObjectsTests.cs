using Microsoft.VisualStudio.TestTools.UnitTesting;
using locationMateriel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace locationMateriel.Tests
{
    [TestClass()]
    public class ObjectsTests
    {
        Objects testObject;
        [TestInitialize]
        public void Init()
        {
            testObject = new Objects("test1", "test2",DateTime.Now, "essai");
        }

        [TestMethod]
        public void addObjects_allData_OK()
        {
            bool resExpected = true;

            bool resCalculated = Employees.AddObject(testObject);

            Assert.AreEqual(resExpected, resCalculated);
        }
    }
}
