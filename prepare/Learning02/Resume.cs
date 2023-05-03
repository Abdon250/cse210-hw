using System;

public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();

    public string Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        foreach (Job job in _jobs)
        {
            
            Console.WriteLine(job.Display());
        }
        return "";
    }
}