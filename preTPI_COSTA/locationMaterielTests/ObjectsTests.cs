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
        [TestMethod]
        public void Objects_AllParam_OK()
        {
            Objects testObject = new Objects("nom", "type", "état", 3, DateTime.Today, "locataire");

            string resExpected = "L'objet nom de type type à l'état état, avec le numéro 3, est loué à locataire et doit être retourné le 29.03.2021 00:00:00";

            string resCalculated = "L'objet " + testObject.Name + " de type " + testObject.Type + " à l'état " + testObject.State + ", avec le numéro " + testObject.ID + ", est loué à " + testObject.Renter + " et doit être retourné le " + testObject.ExpectedReturn ;

            Assert.AreEqual(resExpected, resCalculated);
        }

        [TestMethod]
        public void Objects_AllParamNoRenter_OK()
        {
            Objects testObject = new Objects("nom", "type", "état", 3, DateTime.Today);

            string resExpected = "L'objet nom de type type à l'état état, avec le numéro 3 doit être retourné le 29.03.2021 00:00:00";

            string resCalculated = "L'objet " + testObject.Name + " de type " + testObject.Type + " à l'état " + testObject.State + ", avec le numéro " + testObject.ID + " doit être retourné le " + testObject.ExpectedReturn;

            Assert.AreEqual(resExpected, resCalculated);
        }

        [TestMethod]
        public void Objects_AllParamNoDate_OK()
        {
            Objects testObject = new Objects("nom", "type", "état", 3, "locataire");

            string resExpected = "L'objet nom de type type à l'état état, avec le numéro 3, est loué à locataire";

            string resCalculated = "L'objet " + testObject.Name + " de type " + testObject.Type + " à l'état " + testObject.State + ", avec le numéro " + testObject.ID + ", est loué à " + testObject.Renter;

            Assert.AreEqual(resExpected, resCalculated);
        }


    }
}
