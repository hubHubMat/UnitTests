namespace StudentGrades.MSTest
{
    [TestClass]
    public class GradeCalcTests
    {
        private GradeCalc _gradeCalc { get; set; } = null!;

        [TestInitialize]
        public void Setup()
        {
            _gradeCalc = new GradeCalc();
        }

        [TestMethod]
        public void GetGradeFromPercentage_EqualityTest()
        {
            int percentage = 81;

            var grade = _gradeCalc.GetGradeFromPercentage(percentage);

            Assert.AreEqual("B", grade);
        }

        [TestMethod]
        public void GetGradeFromPercentage_EqualityFailTest()
        {
            int percentage = 81;

            var grade = _gradeCalc.GetGradeFromPercentage(percentage);

            Assert.AreEqual("C", grade);
        }
    }
}
