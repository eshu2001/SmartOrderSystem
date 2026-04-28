//using System;
//using System.Linq;

//public class Filtering
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
//        var Gre = students.Where(l => l.Marks > 80).Select(l => l.Name);

//        foreach (var r in Gre)
//        {
//            Console.WriteLine(r);
//        }
//    }


//}

//public class Student
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public int Age { get; set; }
//    public int Marks { get; set; }
//}

