//using System;
//using System.Linq;

//public class GroupBy
//{
//    static void Main(string[] argrs)
//    {
//        List<Student> students = new List<Student>()
//{
//    new Student{Id=1, Name="Arjun", Age=25, Marks=80},
//    new Student{Id=2, Name="Sara", Age=22, Marks=70},
//    new Student{Id=3, Name="Mike", Age=21, Marks=90},
//    new Student{Id=4, Name="Emma", Age=23, Marks=60},
//    new Student{Id=5, Name="David", Age=20, Marks=75},
//    new Student{Id=6, Name="Alan", Age=25, Marks=85},
//    new Student{Id=7, Name="Mary", Age=22, Marks=65}
//};
//        var Gage = students.GroupBy(l => l.Age).ToList();
//        var Count= students.GroupBy(l => l.Age).Count();
//        var Average = students.GroupBy(s => s.Age).Select(g => new { Age = g.Key, AverageMarks = g.Average(s => s.Marks) });

//        foreach (var r in Gage)
//        {
//            Console.WriteLine("Age: " + r.Key);  
//            foreach (var s in r)
//            {
//                Console.WriteLine("  Name: " + s.Name + " Marks: " + s.Marks);
//            }
//        }
//        Console.WriteLine(" Count: " + Count);

//        foreach (var a in Average)
//        {
//            Console.WriteLine("Age: " + a.Age + " Average Marks: " + a.AverageMarks);
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


