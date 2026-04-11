using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");

        Assignment test = new Assignment("Albert Antwi", "How to take a test");

        Console.WriteLine(test.GetSummary());

        MathAssignment mathHomework = new MathAssignment("Albert", "Algebra 2", "6.3", "1-100");
        Console.WriteLine(mathHomework.GetHomeworkList());

        WritingAssignment paper = new WritingAssignment("Albert Antwi", "English 121", "10 Tips for Getting an A on that Test");
        Console.WriteLine(paper.GetWritingInformation()); 
    }
}