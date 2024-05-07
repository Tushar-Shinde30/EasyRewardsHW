using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
//   ------------>>>>  HW- Extended LINQ Queries:   <<<<<---------
//          Task 1: Write a LINQ query to find the three highest-scoring
//                  students from a list of student objects.

class Program
{
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>
        {
            new Student { Name = "Tushar", Score = 80 },
            new Student { Name = "Akash", Score = 90 },
            new Student { Name = "Ram", Score = 75 },
            new Student { Name = "Sita", Score = 85 },
            new Student { Name = "Sima", Score = 95 }
        };

        var highestScoringStudents = students.OrderByDescending(s => s.Score).Take(3);

        Console.WriteLine("Three highest scoring students:");
        foreach (var student in highestScoringStudents)
        {
            Console.WriteLine($"Name: {student.Name}, Score: {student.Score}");
        }
    }
}

class Student
{
    public string Name { get; set; }
    public int Score { get; set; }
}
