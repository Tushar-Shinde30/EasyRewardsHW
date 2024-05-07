using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

//          HW- Task: Retrieve data from a JSON file using LINQ and perform data
//                    analysis (e.g., find the average age of users).

class Program
{
    static void Main(string[] args)
    {
        string jsonFilePath = @"D:\\EasYRewardsTrainingAll\\EasyRewardsHomeWorkAll\\Day_7\\HW\\LINQ_HW_Task_JSON_3\\Data.json"; // Path to the JSON file

        List<User> users = JsonConvert.DeserializeObject<List<User>>(File.ReadAllText(jsonFilePath));

        double averageAge = users.Average(user => user.Age);

        foreach (User user in users)
        {
            Console.WriteLine(user.Name);
        }

        Console.WriteLine($"Average age of users: {averageAge}");
        
    }
}

class User
{
    public string Name { get; set; }
    public int Age { get; set; }
}
