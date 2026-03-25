//using System;
//using System.Linq;

//public class Aggregation
//{
//    static void Main(string[] argrs)
//    {
//        List<Student> students = new List<Student>()
//    {
//        new Student{Id=1,Name="Arjun",Age=25, Marks= 80},
//        new Student { Id = 2, Name = "Sara", Age = 22, Marks = 70 },
//        new Student { Id = 3, Name = "Mike", Age = 21, Marks = 90 },
//        new Student { Id = 4, Name = "Emma", Age = 23, Marks = 60 },
//        new Student { Id = 5, Name = "David", Age = 20, Marks = 75 }
//    };
//        var Tstudents = students.Count();
//        var Gmarks = students.Where(l => l.Marks > 75).Count();
//        var Sum = students.Sum(l => l.Marks);
//        var Average = students.Average(l => l.Age);
//        var Maxmarks = students.Max(l => l.Marks);
//        var Minmarks = students.Min(l => l.Marks);

//        Console.WriteLine("Total number of students: " + Tstudents);
//        Console.WriteLine("No of students got more than 75marks: " + Gmarks);
//        Console.WriteLine("Sum of marks: " + Sum);
//        Console.WriteLine("Average: " + Average);
//        Console.WriteLine("Max Marks: " + Maxmarks);
//        Console.WriteLine("Min Marks: " + Minmarks);
//    }


//}

//public class Student
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public int Age { get; set; }
//    public int Marks { get; set; }
//}

