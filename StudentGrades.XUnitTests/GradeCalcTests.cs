namespace StudentGrades.XUnitTests
{
    public class GradeCalcTests
    {
        private GradeCalc _gradeCalc { get; set; } = null!;

        [Fact]
        public void GetGradeFromPercentage_EqualityTest()
        {
            _gradeCalc = new GradeCalc();

            int percentage = 81;

            var grade = _gradeCalc.GetGradeFromPercentage(percentage);

            Assert.Equal("B", grade);
        }
        [Fact]
        public void GetGradeFromPercentage_EqualityFailTest()
        {
            _gradeCalc = new GradeCalc();
            int percentage = 81;

            var grade = _gradeCalc.GetGradeFromPercentage(percentage);

            Assert.Equal("C", grade);
        }
    }
}