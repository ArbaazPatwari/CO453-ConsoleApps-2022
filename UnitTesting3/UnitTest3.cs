using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App03;

namespace UnitTesting3
{
    [TestClass]
    public class UnitTest3
    {
        private readonly StudentMarks marker = new StudentMarks();

        [TestMethod]
        public void TestLowFail()
        {
            Grades expectedGrade = Grades.F;

            Grades actualGrade = marker.ConvertToGrade(0);

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestHighFail()
        {
            Grades expectedGrade = Grades.F;

            Grades actualGrade = marker.ConvertToGrade(39);

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestLowPass()
        {
            Grades expectedGrade = Grades.E;

            Grades actualGrade = marker.ConvertToGrade(40);

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestHighPass()
        {
            Grades expectedGrade = Grades.E;

            Grades actualGrade = marker.ConvertToGrade(44);

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestLowThirdClass()
        {
            Grades expectedGrade = Grades.D;

            Grades actualGrade = marker.ConvertToGrade(45);

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestHighThirdClass()
        {
            Grades expectedGrade = Grades.D;

            Grades actualGrade = marker.ConvertToGrade(45);

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestLowLowerSecond()
        {
            Grades expectedGrade = Grades.C;

            Grades actualGrade = marker.ConvertToGrade(50);

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestHighLowerSecond()
        {
            Grades expectedGrade = Grades.C;

            Grades actualGrade = marker.ConvertToGrade(59);

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestLowUpperSecond()
        {
            Grades expectedGrade = Grades.B;

            Grades actualGrade = marker.ConvertToGrade(60);

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestHighUpperSecond()
        {
            Grades expectedGrade = Grades.B;

            Grades actualGrade = marker.ConvertToGrade(69);

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestLowFirstClass()
        {
            Grades expectedGrade = Grades.A;

            Grades actualGrade = marker.ConvertToGrade(70);

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestHighFirstClass()
        {
            Grades expectedGrade = Grades.A;

            Grades actualGrade = marker.ConvertToGrade(100);

            Assert.AreEqual(expectedGrade, actualGrade);
        }
    }
}