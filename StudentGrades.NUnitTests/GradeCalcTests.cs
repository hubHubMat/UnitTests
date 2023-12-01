namespace StudentGrades.NUnitTests

{
    public class GradeCalcTests
    {
        private GradeCalc _gradeCalc { get; set; } = null!;
        [SetUp]
        public void Setup()
        {
            _gradeCalc = new GradeCalc();
        }

        [Test]
        public void GetGradeFromPercentage_EqualityTest()
        {
            int percentage = 81;

            var grade = _gradeCalc.GetGradeFromPercentage(percentage);

            Assert.AreEqual("B", grade);
        }
        [Test]
        public void GetGradeFromPercentage_EqualityFailTest()
        {
            int percentage = 81;

            var grade = _gradeCalc.GetGradeFromPercentage(percentage);

            Assert.AreEqual("C", grade);
        }
    }
}