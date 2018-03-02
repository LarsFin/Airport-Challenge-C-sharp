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

        [TestCategory("Instantiation)")]
        [TestMethod]
        public void PlaneHasNameThatCanBePassedIn()
        {
            Assert.AreEqual("BA077", testPlane.GetName());
        }

        [TestMethod]
        public void PlaneIsInitiallyFlying()
        {
            Assert.IsTrue(testPlane.IsFlying());
        }

        [TestCategory("land()")]
        [TestMethod]
        public void PlaneHasLandMethodThatMakesFlyingFalse()
        {

        }

    }

}
