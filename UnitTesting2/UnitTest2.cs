using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App02;

namespace UnitTesting2
{
    [TestClass]
    public class TestBMICalculator
    {
        [TestMethod]
        public void UnderweightLow()
        {
            BMI calculator = new BMI();

            calculator.Convention = BMI.METRIC;

            calculator.HeightValue = 193;
            calculator.WeightValue = 45.5;

            calculator.CalculateIndex();
            calculator.OutputBMIResult();

            double expectedBMI = 12.2;

            Assert.AreEqual(expectedBMI, calculator.BMIValue);
        }
        [TestMethod]
        public void UnderweightHigh()
        {
            BMI calculator = new BMI();

            calculator.Convention = BMI.METRIC;

            calculator.HeightValue = 193;
            calculator.WeightValue = 65.9;

            calculator.CalculateIndex();
            calculator.OutputBMIResult();

            double expectedBMI = 17.7;

            Assert.AreEqual(expectedBMI, calculator.BMIValue);
        }
        [TestMethod]
        public void HealthyLow()
        {
            BMI calculator = new BMI();

            calculator.Convention = BMI.METRIC;

            calculator.HeightValue = 152.4;
            calculator.WeightValue = 45.5;

            calculator.CalculateIndex();
            calculator.OutputBMIResult();

            double expectedBMI = 19.6;

            Assert.AreEqual(expectedBMI, calculator.BMIValue);
        }
        [TestMethod]
        public void HealthyHigh()
        {
            BMI calculator = new BMI();

            calculator.Convention = BMI.METRIC;

            calculator.HeightValue = 193;
            calculator.WeightValue = 88.6;

            calculator.CalculateIndex();
            calculator.OutputBMIResult();

            double expectedBMI = 23.8;

            Assert.AreEqual(expectedBMI, calculator.BMIValue);
        }
        [TestMethod]
        public void OverweightLow()
        {
            BMI calculator = new BMI();

            calculator.Convention = BMI.METRIC;

            calculator.HeightValue = 152.4;
            calculator.WeightValue = 59.1;

            calculator.CalculateIndex();
            calculator.OutputBMIResult();

            double expectedBMI = 25.4;

            Assert.AreEqual(expectedBMI, calculator.BMIValue);
        }
        [TestMethod]
        public void OverweightHigh()
        {
            BMI calculator = new BMI();

            calculator.Convention = BMI.METRIC;

            calculator.HeightValue = 182.8;
            calculator.WeightValue = 97.7;

            calculator.CalculateIndex();
            calculator.OutputBMIResult();

            double expectedBMI = 29.2;

            Assert.AreEqual(expectedBMI, calculator.BMIValue);
        }
        [TestMethod]
        public void ObeseClassILow()
        {
            BMI calculator = new BMI();

            calculator.Convention = BMI.METRIC;

            calculator.HeightValue = 152.4;
            calculator.WeightValue = 70.5;

            calculator.CalculateIndex();
            calculator.OutputBMIResult();

            double expectedBMI = 30.4;

            Assert.AreEqual(expectedBMI, calculator.BMIValue);
        }
        [TestMethod]
        public void ObeseClassIHigh()
        {
            BMI calculator = new BMI();

            calculator.Convention = BMI.METRIC;

            calculator.HeightValue = 167.6;
            calculator.WeightValue = 97.7;

            calculator.CalculateIndex();
            calculator.OutputBMIResult();

            double expectedBMI = 34.8;

            Assert.AreEqual(expectedBMI, calculator.BMIValue);
        }
        [TestMethod]
        public void ObeseClassIILow()
        {
            BMI calculator = new BMI();

            calculator.Convention = BMI.METRIC;

            calculator.HeightValue = 152.4;
            calculator.WeightValue = 81.8;

            calculator.CalculateIndex();
            calculator.OutputBMIResult();

            double expectedBMI = 35.2;

            Assert.AreEqual(expectedBMI, calculator.BMIValue);
        }
        [TestMethod]
        public void ObeseClassIIHigh()
        {
            BMI calculator = new BMI();

            calculator.Convention = BMI.METRIC;

            calculator.HeightValue = 157.4;
            calculator.WeightValue = 97.7;

            calculator.CalculateIndex();
            calculator.OutputBMIResult();

            double expectedBMI = 39.4;

            Assert.AreEqual(expectedBMI, calculator.BMIValue);
        }
        [TestMethod]
        public void ObeseClassIIILow()
        {
            BMI calculator = new BMI();

            calculator.Convention = BMI.METRIC;

            calculator.HeightValue = 152.4;
            calculator.WeightValue = 93.2;

            calculator.CalculateIndex();
            calculator.OutputBMIResult();

            double expectedBMI = 40.1;

            Assert.AreEqual(expectedBMI, calculator.BMIValue);
        }
        [TestMethod]
        public void ObeseClassIIIHigh()
        {
            BMI calculator = new BMI();

            calculator.Convention = BMI.METRIC;

            calculator.HeightValue = 152.4;
            calculator.WeightValue = 97.7;

            calculator.CalculateIndex();
            calculator.OutputBMIResult();

            double expectedBMI = 42.1;

            Assert.AreEqual(expectedBMI, calculator.BMIValue);
        }
    }
}