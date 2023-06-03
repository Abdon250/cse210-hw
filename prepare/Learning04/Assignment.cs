using System;

public class Assignment
{
    protected string _studentName;
    protected string _topic;

    public Assignment(string studentName, string topic)
    {
        studentName = _studentName;
        topic = _topic;

    }
    public string GetstudentName()
    {
        return _studentName;
    }

    public string GetTopic()
    {
        return _topic;
    }


    public string getSummary()
    {
        return _studentName +"-" +_topic;
    }
   
    
    



}