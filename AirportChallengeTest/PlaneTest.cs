using Microsoft.VisualStudio.TestTools.UnitTesting;
using AirportChallengeLib;

namespace AirportChallengeTest
{
    [TestClass]
    public class PlaneTest
    {

        Plane testPlane;

        [TestMethod]
        public void PlaneHasNameThatCanBePassedIn()
        {
            testPlane = new Plane("BA077");
            Assert.AreEqual("BA077", testPlane.getName());
        }

    }

}
