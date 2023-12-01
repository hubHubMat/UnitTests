using StudentGrades;

var gradeCalc = new GradeCalc();
Console.WriteLine("Enter the percentage : ");
var percentage = Convert.ToInt32(Console.ReadLine());

var grade = gradeCalc.GetGradeFromPercentage(percentage);
Console.WriteLine($"Student grade : {grade}");
