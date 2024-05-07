using System;


//---------------------->>>create a linq query to filter out student who scored below 60 <<<-------
//                             in a list of student object

class program
 {
    public static void Main(string[] args)
    {
        List<Student> students = new List<Student>
        { 
        new Student { Name = "Tushar", Score = 60 },
        new Student { Name = "Ram", Score = 60 },
        new Student { Name = "Sham", Score = 55 },
        new Student { Name = "Ravi", Score = 45 },       
        new Student { Name = "Rani", Score = 80 },
        new Student { Name = "Neha", Score = 70 },
        new Student { Name = "Pooja", Score = 23 },
        new Student { Name = "Akash", Score = 85 },
        new Student { Name = "Kiran", Score = 43 },
        new Student { Name = "Karan", Score = 59 }
        };

            var result = students.Where(s => s.Score < 60);
            
            foreach (Student student in result)
            {
                Console.WriteLine(student.Name);

            }


        }
    }

    class Student
    {
      public string Name { get; set; }
       public int Score { get; set; }
    }

