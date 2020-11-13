/* 
Josh Bartlett
26July2019
Assignment 6.2
Declare several valid and invalid ReportCard objects and checks if the grades are not within range 
and throws exceptions. Calculates the average of the midterm and final exam grades and associates 
that average with a letter grade. If the instantiation is successful, display all data.
*/

using System;
using static System.Console;

class StudentGradeDemo
{
    static void Main()
    {
        // 9 try catch blocks that create valid and invalid objects to test 5 letter grades
        // and 4 exception cases
        try
        {
            ReportCard student1 = new ReportCard("Shawn Spencer", 63, 69);
        }
        catch(Exception re)
        {
            WriteLine(re.Message);
        }

        try
        {
            ReportCard student2 = new ReportCard("Burton Guster", 101, 98);
        }
        catch(Exception re)
        {
            WriteLine(re.Message);
        }

        try
        {
            ReportCard student3 = new ReportCard("Juliet O'Hara", 94, 87);
        }
        catch(Exception re)
        {
            WriteLine(re.Message);
        }

        try
        {
            ReportCard student4 = new ReportCard("Buzz McNab", 61, 54);
        }
        catch(Exception re)
        {
            WriteLine(re.Message);
        }

        try
        {
            ReportCard student5 = new ReportCard("Abigail Lytar", 80, 101);
        }
        catch(Exception re)
        {
            WriteLine(re.Message);
        }

        try
        {
            ReportCard student6 = new ReportCard("Pierre Desperaux", -95, 93);
        }
        catch(Exception re)
        {
            WriteLine(re.Message);
        }

        try
        {
            ReportCard student7 = new ReportCard("Ewan O'Hara", 84, 71);
        }
        catch(Exception re)
        {
            WriteLine(re.Message);
        }

        try
        {
            ReportCard student8 = new ReportCard("Carlton Lassiter", 83, -76);
        }
        catch(Exception re)
        {
            WriteLine(re.Message);
        }

        try
        {
            ReportCard student9 = new ReportCard("Henery Spencer", 90, 80);
        }
        catch(Exception re)
        {
            WriteLine(re.Message);
        }
        // keeps console open until key is pressed
        ReadKey(true);
    }
}
// ReportCard class - in one document for ease of turning in assignment
class ReportCard
{
    // declare fields for student name, midterm grade, final exam grade, and a letter grade
    private string studentName;
    private int midtermGrade;
    private int finaExamGrade;
    private char letterGrade;
    // ReportCard constructor that requires values for the name and two grades
    public ReportCard(string name, int midterm, int final)
    {
        // checks that the midterm grade is not within the paramaters and 
        // throws a new argument exception if it's not
        if(midterm < 0 || midterm > 100)
        {
            throw new ArgumentException(name + "'s midterm exam grade is not within " +
                "acceptable range.\n");
        }
        // checks that the final exam grade is not within paramaters and 
        // throws a new argument exception if it's not
        else if(final < 0 || final > 100)
        {
            throw new ArgumentException(name + "'s final exam grade is not within " +
                "acceptable range.\n"); 
        }
        // if grades are valid then the fields are populated with the data
        else
        {
            this.studentName = name;
            this.midtermGrade = midterm;
            this.finaExamGrade = final;
        }
        // declares variable for and calcualtes the average of the 
        // midterm and final exams grades
        int examsAverage = (midtermGrade + finaExamGrade) / 2;
        // determines the letter grade associated with the average of the 
        // midterm and final exams grades
        if (examsAverage <= 100 && examsAverage >= 90)
        {
            letterGrade = 'A';
        }
        else if (examsAverage <= 89 && examsAverage >= 80)
        {
            letterGrade = 'B';
        }
        else if (examsAverage <= 79 && examsAverage >= 70)
        {
            letterGrade = 'C';
        }
        else if (examsAverage <= 69 && examsAverage >= 60)
        {
            letterGrade = 'D';
        }
        else
        {
            letterGrade = 'F';
        }
        // display all the data
        WriteLine("Student Name: {0}", studentName);
        WriteLine("Midterm Grade: {0}", midtermGrade);
        WriteLine("Final Exam Grade: {0}", finaExamGrade);
        WriteLine("Final Course Grade: {0}", letterGrade);
        WriteLine();
    }
     
}
