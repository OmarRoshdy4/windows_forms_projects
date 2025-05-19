//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace ToDoApp
//{
//    class Task
//    {
//    }
//}
using System;

public class Task
{
    public string Description { get; set; }
    public string Priority { get; set; }
    public DateTime DueDate { get; set; }
    public bool IsCompleted { get; set; }
    public string ImagePath { get; set; }

    public override string ToString()
    {
        return Description + "|" + Priority + "|" + DueDate + "|" + IsCompleted + "|" + ImagePath;
    }

    public static Task FromString(string line)
    {
        var parts = line.Split('|');
        return new Task
        {
            Description = parts[0],
            Priority = parts[1],
            DueDate = DateTime.Parse(parts[2]),
            IsCompleted = bool.Parse(parts[3]),
            ImagePath = parts[4]
        };
    }
}
