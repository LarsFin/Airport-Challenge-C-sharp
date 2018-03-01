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
            Assert.AreEqual("Heathrow", testAirport.getName());
        }

        [TestMethod]
        public void AirportHasHangarOfPlanes()
        {
            Assert.IsInstanceOfType(testAirport.getHangar(), typeof(List<Plane>));
        }

    }
}