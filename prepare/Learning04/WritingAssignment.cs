using System;

public class WritingAssignment: Assignment
{
    private string _title;

    public WritingAssignment(string studentName, string topic, string title):base(studentName, topic)
    {
        title = _title;

    }


    public string GetWritingInformation()
    {
        string studentName = GetstudentName();
        return $"{_studentName}, {_title}";
    }
}