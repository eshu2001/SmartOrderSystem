//using System;
//using System.Linq;

//public class Sorting
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
//        var Amarks = students.OrderBy(l => l.Marks).ToList();
//        var Dmarks = students.OrderByDescending(l => l.Marks).ToList();
//        var Aname = students.OrderBy(l => l.Name).ToList();
//        var Tage = students.OrderBy(l => l.Marks).ThenBy(l => l.Age).ToList();

//        foreach (var r in Amarks)
//        {
//            Console.WriteLine("Name: " + r.Name + " Marks:" + r.Marks);
//        }
//        Console.WriteLine("------------------------Descending-----------------------------------");
//        foreach (var r in Dmarks)
//        {
//            Console.WriteLine("Name: " + r.Name + " Marks:" + r.Marks);
//        }
//        Console.WriteLine("-----------------------------Alphabets--------------------------------");
//        foreach (var r in Aname)
//        {
//            Console.WriteLine("Name: " + r.Name + " Marks:" + r.Marks);
//        }
//        Console.WriteLine("-----------------------------ThenBy--------------------------------");
//        foreach (var r in Tage)
//        {
//            Console.WriteLine("Marks: " + r.Marks + " Age:" + r.Age);
//        }

//        Aname.Reverse();
//        Console.WriteLine("------------------------Reverse--------------------------");
//        foreach (var r in Aname)
//        {
//            Console.WriteLine(r.Name);
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
