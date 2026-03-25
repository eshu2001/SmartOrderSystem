using System;
using System.Linq;
using System.Collections.Generic;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}

public class Score
{
    public int StudentId { get; set; }
    public int Marks { get; set; }
}

public class StudentScore
{
    public string Name { get; set; }
    public int Marks { get; set; }
}

public class Program
{
    static void Main()
    {
        
        List<Student> students = new List<Student>()
        {
            new Student{Id=1, Name="Arjun", Age=25},
            new Student{Id=2, Name="Sara", Age=22},
            new Student{Id=3, Name="Mike", Age=21},
            new Student{Id=4, Name="Emma", Age=23},
            new Student{Id=5, Name="David", Age=24} 
        };

        
        List<Score> scores = new List<Score>()
        {
            new Score{StudentId=1, Marks=80},
            new Score{StudentId=2, Marks=70},
            new Score{StudentId=3, Marks=90},
            new Score{StudentId=4, Marks=60}
        };

        //Inner Join: Student Name + Marks
        var innerJoin = students.Join(
            scores,
            s => s.Id,
            sc => sc.StudentId,
            (s, sc) => new { s.Name, sc.Marks }
        );

        Console.WriteLine("----- Inner Join (Students with Scores) -----");
        foreach (var item in innerJoin)
        {
            Console.WriteLine($"Name: {item.Name}, Marks: {item.Marks}");
        }


    }
}