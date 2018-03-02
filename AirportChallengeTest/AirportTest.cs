using Microsoft.VisualStudio.TestTools.UnitTesting;
using AirportChallengeLib;
using System.Collections.Generic;

namespace AirportChallengeTest
{
    [TestClass]
    public class AirportTest
    {

        Airport testAirport;

        [TestInitialize]
        public void Setup()
        {
            testAirport = new Airport("Heathrow");
        }

        [TestMethod]
        public void AirportIsInitialisedWithName()
        {
            Assert.AreEqual("Heathrow", testAirport.GetName());
        }

        [TestMethod]
        public void AirportHasHangarOfPlanes()
        {
            Assert.IsInstanceOfType(testAirport.GetHangar(), typeof(List<Plane>));
        }

    }
}