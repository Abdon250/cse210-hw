using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment s1 = new Assignment("Abdon","csharp");
        

        Console.WriteLine(s1.getSummary());

        MathAssignment s2 = new MathAssignment("TUYIZERE","trigometry", "3", "4");
        Console.WriteLine(s2.getSummary());
        Console.WriteLine(s2.GetHomeworkList());

    

        WritingAssignment s3 = new WritingAssignment("Abdon","logarithim","log10");
        Console.WriteLine(s3.getSummary());
        Console.WriteLine(s3.GetWritingInformation());

        
        

    }
}