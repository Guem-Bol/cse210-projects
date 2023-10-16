using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment();
        assignment1.SetStudent("Roberto Rodriguez");
        assignment1.Settopic("The Pardise");

        Console.WriteLine(assignment1.GetSummary());

        Mathassignment assignment2 = new Mathassignment();
        assignment2.Setproblem($"{8}-{19}");
        assignment2.Settextsection($"{7.3}");

        Console.WriteLine(assignment2.GetHomeworkList());

        WritingAssignment assignment3 = new WritingAssignment();
        assignment3.Settitle("The love of God");

        Console.WriteLine(assignment3.GetWritingInformation());

    }
}