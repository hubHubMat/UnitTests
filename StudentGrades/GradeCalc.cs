namespace StudentGrades
{
    public class GradeCalc
    {
        public string GetGradeFromPercentage(int percentage) 
        {
            if (percentage >= 90 ) return "A";
            else if (percentage <= 90 && percentage > 75) return "B";
            else if (percentage <= 75 && percentage > 50) return "C";
            else if (percentage <= 50 && percentage > 33) return "D";
            else if (percentage <= 33) return "F";
            else return "Invalid";
        }
    }
}
