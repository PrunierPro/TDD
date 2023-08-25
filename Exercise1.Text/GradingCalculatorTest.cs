using ExerciseLibrary;

namespace Exercise1.Test
{
    [TestClass]
    public class GradingCalculatorTest
    {
        GradingCalculator Calculator { get; set; }
        [TestInitialize]
        public void Setup()
        {
            Calculator = new GradingCalculator();
        }

        [TestMethod]
        public void WhenScore_95_AndAttendance90_Then_GradeA()
        {
            Calculator.AttendancePercentage = 90;
            Calculator.Score = 95;
            Assert.AreEqual(Calculator.GetGrade(), 'A');
        }

        [TestMethod]
        public void WhenScore_85_AndAttendance90_Then_GradeB()
        {
            Calculator.AttendancePercentage = 90;
            Calculator.Score = 85;
            Assert.AreEqual(Calculator.GetGrade(), 'B');
        }

        [TestMethod]
        public void WhenScore_65_AndAttendance90_Then_GradeC()
        {
            Calculator.AttendancePercentage = 90;
            Calculator.Score = 65;
            Assert.AreEqual(Calculator.GetGrade(), 'C');
        }

        [TestMethod]
        public void WhenScore_95_AndAttendance65_Then_GradeB()
        {
            Calculator.AttendancePercentage = 65;
            Calculator.Score = 95;
            Assert.AreEqual(Calculator.GetGrade(), 'B');
        }

        [TestMethod]
        public void WhenScore_95_AndAttendance55_Then_GradeF()
        {
            Calculator.AttendancePercentage = 55;
            Calculator.Score = 95;
            Assert.AreEqual(Calculator.GetGrade(), 'F');
        }

        [TestMethod]
        public void WhenScore_65_AndAttendance55_Then_GradeF()
        {
            Calculator.AttendancePercentage = 55;
            Calculator.Score = 65;
            Assert.AreEqual(Calculator.GetGrade(), 'F');
        }

        [TestMethod]
        public void WhenScore_50_AndAttendance90_Then_GradeF()
        {
            Calculator.AttendancePercentage = 90;
            Calculator.Score = 50;
            Assert.AreEqual(Calculator.GetGrade(), 'F');
        }
    }
}