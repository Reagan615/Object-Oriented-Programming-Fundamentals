using Object_Oriented_Programming_Fundamentals_Lab03;

int courseNum = School.CreateCourse("course01", 11);
int studentNum = School.CreateStudent("jimmy", "Davy");
int courseNum2 = School.CreateCourse("course02", 12);
int studentNum2 = School.CreateStudent("jimmy02", "Davy");
int courseNum3 = School.CreateCourse("course03", 13);
int studentNum3 = School.CreateStudent("jimmy03", "Davy");

try
{
    School.EnrolStudent(studentNum, courseNum);
    School.EnrolStudent(studentNum2, courseNum2);
    School.EnrolStudent(studentNum3, courseNum3);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}