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
        [TestMethod]
        public void TestFeetToMiles()
        {
            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceConverter.FEET;
            converter.ToUnit = DistanceConverter.MILES;

            converter.FromDistance = 10560;
            converter.CalculateDistance();

            double expectedDistance = 2.0;

            Assert.AreEqual(expectedDistance, converter.ToDistance);
        }
        [TestMethod]
        public void TestMilesToMetres()
        {
            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceConverter.MILES;
            converter.ToUnit = DistanceConverter.METRES;

            converter.FromDistance = 2.0;
            converter.CalculateDistance();

            double expectedDistance = 3218.68;

            Assert.AreEqual(expectedDistance, converter.ToDistance);
        }
        [TestMethod]
        public void TestMetresToMiles()
        {
            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceConverter.METRES;
            converter.ToUnit = DistanceConverter.MILES;

            converter.FromDistance = 3218.68;
            converter.CalculateDistance();

            double expectedDistance = 2.0;

            Assert.AreEqual(expectedDistance, converter.ToDistance);
        }
        [TestMethod]
        public void TestMetresToFeet()
        {
            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceConverter.METRES;
            converter.ToUnit = DistanceConverter.FEET;

            converter.FromDistance = 2.0;
            converter.CalculateDistance();

            double expectedDistance = 6.56168;

            Assert.AreEqual(expectedDistance, converter.ToDistance);
        }
        [TestMethod]
        public void TestFeetToMetres()
        {
            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceConverter.FEET;
            converter.ToUnit = DistanceConverter.METRES;

            converter.FromDistance = 6.56168;
            converter.CalculateDistance();

            double expectedDistance = 2.0;

            Assert.AreEqual(expectedDistance, converter.ToDistance);
        }
        [TestMethod]
        public void TestYardsToKilometres()
        {
            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceConverter.YARDS;
            converter.ToUnit = DistanceConverter.KILOMETRES;

            converter.FromDistance = 6000;
            converter.CalculateDistance();

            double expectedDistance = 5.486416547032307;

            Assert.AreEqual(expectedDistance, converter.ToDistance);
        }
        [TestMethod]
        public void TestKilometresToYards()
        {
            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceConverter.KILOMETRES;
            converter.ToUnit = DistanceConverter.YARDS;

            converter.FromDistance = 5.486416547032307;
            converter.CalculateDistance();

            double expectedDistance = 6000;

            Assert.AreEqual(expectedDistance, converter.ToDistance);
        }
    }
}