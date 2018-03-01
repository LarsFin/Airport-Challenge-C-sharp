using Microsoft.VisualStudio.TestTools.UnitTesting;
using AirportChallengeLib;

namespace AirportChallengeTest
{
    [TestClass]
    public class AirportTest
    {

        Airport testAirport;

        [TestMethod]
        public void airportIsInitialisedWithName()
        {
            testAirport = new Airport("Heathrow");
            Assert.AreEqual("Heathrow", testAirport.getName());
        }

    }
}