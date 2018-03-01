using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class PlaneTest
    {
        Plane plane;

        [TestMethod]
        public void planeHasName()
        {
            plane = new Plane();
        }
    }
}