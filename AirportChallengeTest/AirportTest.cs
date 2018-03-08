using AirportChallengeLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
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

        [TestMethod]
        public void AirportCanTakePlaneThatGoesToHangar()
        {
            var mockPlane = new Mock<Plane>("TestPlane");
            testAirport.Take(mockPlane.Object);
            Assert.IsTrue(testAirport.GetHangar().Contains(mockPlane.Object));
        }

        [TestMethod]
        public void AirportTakingPlaneCallsLandOnPlaneOnce()
        {
            var mockPlane = new Mock<Plane>("TestPlane");
            testAirport.Take(mockPlane.Object);
            mockPlane.Verify(mock => mock.Land(), Times.Once());
        }

        [TestMethod]
        public void AirportCanTakeOffSpecificPlaneThatIsRemovedFromHangar()
        {
            var mockPlane = new Mock<Plane>("TestPlane");
            testAirport.Take(mockPlane.Object);
            testAirport.TakeOff("TestPlane");
            Assert.IsFalse(testAirport.GetHangar().Contains(mockPlane.Object));
        }

        [TestMethod]
        public void AirportTakeOffCallsFlyOnPlaneOnce()
        {
            var mockPlane = new Mock<Plane>("TestPlane");
            testAirport.Take(mockPlane.Object);
            testAirport.TakeOff("TestPlane");
            mockPlane.Verify(mock => mock.Fly(), Times.Once());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
        "Cannot take off a plane that isn't present in hangar")]
        public void AirportTakeOffThrowsExceptionIfPlaneNotPresentInHangar()
        {
            testAirport.TakeOff("Plane that does not exist");
        }

    }
}