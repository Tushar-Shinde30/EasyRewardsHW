using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// --------->>>>> Write a LINQ Query to group students by their department and <<<<<-------
//  //              calculate the average score for each department 


namespace LINQ_CW_Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student{Name = "Tushar",Department = "CSE",Score = 50},
                new Student{Name = "Akash",Department = "IT",Score = 56},
                new Student { Name = "Radha", Department = "ME" ,Score = 45},
                new Student { Name = "Ram", Department = "Chemical" ,Score = 80},
                new Student { Name = "Sham", Department = "Diploma" ,Score = 85},
                new Student { Name = "Ravi", Department = "Chemical" ,Score = 90 },
                new Student { Name = "Rani", Department = "Comp",Score = 78 },
                new Student { Name = "Neha", Department = "Comp" ,Score = 70}

            };

            var averageScoresByDepartment = students
            .GroupBy(s => s.Department) // Group by department
            .Select(g => new
            {
                Department = g.Key,
                AverageScore = g.Average(s => s.Score)
            });


            foreach (var department in averageScoresByDepartment)
            {
                Console.WriteLine($"Department: {department.Department}, Average Score: {department.AverageScore}");
            }
        }


    }
}

class Student
{
    public string Name { get; set; }
    public string Department { get; set; }
    public int Score { get; set; }


}

