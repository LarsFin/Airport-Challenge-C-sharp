using Microsoft.VisualStudio.TestTools.UnitTesting;
using AirportChallengeLib;

namespace AirportChallengeTest
{
    [TestClass]
    public class PlaneTest
    {

        Plane testPlane;

        [TestInitialize]
        public void setup()
        {
            testPlane = new Plane("BA077");
        }

        [TestMethod]
        public void PlaneHasNameThatCanBePassedIn()
        {
            Assert.AreEqual("BA077", testPlane.getName());
        }

        [TestMethod]
        public void PlaneIsInitiallyFlying()
        {
            Assert.IsTrue(testPlane.isFlying());
        }

    }

}
