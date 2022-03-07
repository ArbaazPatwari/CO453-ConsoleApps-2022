using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App01;

namespace UnitTesting
{
    [TestClass]
    public class TestDistanceConverter
    {
        [TestMethod]
        public void TestMilesToFeet()
        {
            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceConverter.MILES;
            converter.ToUnit = DistanceConverter.FEET;

            converter.FromDistance = 2.0;
            converter.CalculateDistance();

            double expectedDistance = 10560;

            Assert.AreEqual(expectedDistance, converter.ToDistance);
        }
        public void TestFeetToMiles()
        {
        }
        [TestMethod]
        public void TestMilesToMetres()
        {
        }
        [TestMethod]
        public void TestMetresToMiles()
        {
        }
        [TestMethod]
        public void TestMetresToFeet()
        {
        }
        [TestMethod]
        public void TestFeetToMetres()
        {
        }
        [TestMethod]
        public void TestYardsToKilometres()
        {
        }
        [TestMethod]
        public void TestKilometresToYards()
        {
        }
    }
}