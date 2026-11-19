//JOSN SERALIZE
//using System;
//using System.Text.Json;
//    public class Student
//    {
//        public int id { get; set; }
//        public string name { get; set; }
//        public string course { get; set; }
//    }

//    class Program
//    {
//        public static void Main()
//        {
//            Student s1 = new Student
//            {
//                id = 1,
//                name = "Abdul Rafay",
//                course = "AI/ML"
//            };
//            var options = new JsonSerializerOptions { WriteIndented = true };
//            string JsonOutput = JsonSerializer.Serialize(s1, options);

//            Console.WriteLine("Serialized JSON:");
//            Console.WriteLine(JsonOutput);
//        }
//    }

//using System;
//using System.Text.Json;

//public class Book
//{
//    public int BookId { get; set; }
//    public string BookName { get; set; }
//    public string Author { get; set; }
//    public int Price { get; set; }
//}
//class Program
//{
//    public static void Main()
//    {
//        Book b1 = new Book
//        {
//            BookId = 1,
//            BookName = "C# Programming",
//            Author = "Abdul Rafay",
//            Price = 1060
//        };
//        var options = new JsonSerializerOptions { WriteIndented = true };
//        string jsonOutput = JsonSerializer.Serialize(b1, options);

//        Console.WriteLine("JSON Serialized : ");
//        Console.WriteLine(jsonOutput);
//    }
//}


//JOSN DESERALIZE

//using System;
//using System.Text.Json;
//using System.Collections.Generic;


//class Student
//{
//    public int id { get; set; }
//    public string name { get; set; }
//    public string course { get; set; }
//}

//class Program
//{
//    public static void Main()
//    {
//        string rawJson = @"[
//{
//""id"" : 1,
//""name"" : ""Abdul Rafay"",
//""course"" : ""AI/ML""
//},
//{
//""id"" : 2,
//""name"" : ""Abdul Shafay"",
//""course"" : ""Data Science""
//}
//]";
//        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
//        //var st = JsonSerializer.Deserialize<Student>(rawJson, options);

//        List<Student> students = JsonSerializer.Deserialize<List<Student>>(rawJson, options);

//        Console.WriteLine("Deserialized JSON: ");


//        foreach (var st in students)
//        {
//            Console.WriteLine($"id : {st.id}, name : {st.name}, course : {st.course}");
//        }
//    }
//}

//using System;
//using System.Text.Json;

//public class Mobile
//{
//    public string brand { get; set; }
//    public string model { get; set; }
//    public int price { get; set; }
//}
//class Program
//{
//    public static void Main()
//    {
//        string rawJson = @"[
//{
//""brand"" : ""Samsung"",
//""model"" : ""Galaxy S1"",
//""price"" : 150000
//},
//{
//""brand"" : ""Infinix"",
//""model"" : ""Note 30"",
//""price"" : 40000
//},
//{
//""brand"" : ""Google Pixel"",
//""model"" : ""Pixel 10"",
//""price"" : 250000
//}

//]";

//        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
//        List<Mobile> mobile = JsonSerializer.Deserialize<List<Mobile>>(rawJson, options);
//        Console.WriteLine("Json Deserialized : ");
//        foreach(var mb in mobile)
//        {
//            if(mb.price > 50000)
//            {
//            Console.WriteLine($"brand : {mb.brand}, model : {mb.model}, price : {mb.price}");
//            }
//        }
//            }
//}

using System.Text.Json.Nodes;

//JSON FILE SAVE AND LOAD

//using System;
//using System.Text.Json;
//using System.IO;
//class Student
//{
//    public int id { get;set; }
//    public string name { get; set; }
//    public string course { get; set; }
//}
//class Program
//{
//    public static void Main()
//    {
//        string filePath = "student.json";

//        List<Student> students = new List<Student>
//        {
//            new Student {id =1,name = "Abdul Rafay",course = "AI/ML"},
//            new Student {id =2,name = "Abdul Shafay",course = "Data Science"}
//        };

//        var options = new JsonSerializerOptions { WriteIndented = true };
//        string jsonToFile = JsonSerializer.Serialize(students, options);
//        File.WriteAllText(filePath,jsonToFile);
//        Console.WriteLine("Json Serialized Saved");
//        if(File.Exists(filePath))
//        {
//            string jsonFromFile = File.ReadAllText(filePath);
//            List<Student> loadStudents = JsonSerializer.Deserialize<List<Student>>(jsonFromFile, options);
//            Console.WriteLine("Json Deserialized : ") ;
//            foreach(var st in students)
//            {
//                Console.WriteLine($"id = {st.id}, name = {st.name} , course = {st.course}");
//            }
//        }
//    }
//}

using System;
using System.Text.Json;

public class Employee
{
    public int empId { get; set; }
    public string name { get; set; }
    public string department { get; set; }
}
class Program
{
    public static void Main()
    {
        string filePath = "employee.json";

        int employeeId = 1;

        Console.WriteLine("Enter 1st employee name : ");
        string emp1 = Console.ReadLine();

        Console.WriteLine("Enter 1st employee department name : ");
        string emp_dep_1 = Console.ReadLine();

        Console.WriteLine("Enter 2snd employee name : ");
        string emp2 = Console.ReadLine();

        Console.WriteLine("Enter 2nd employee department name : ");
        string emp_dep_2 = Console.ReadLine();

        List<Employee> employees = new List<Employee>
        {
            new Employee {empId = employeeId,name = emp1,department = emp_dep_1 },
            new Employee {empId = employeeId + 1,name = emp2,department = emp_dep_2}
        };

        var options = new JsonSerializerOptions { WriteIndented = true };
        string jsonToSave = JsonSerializer.Serialize(employees, options);
        File.WriteAllText(filePath, jsonToSave);


        if (File.Exists(filePath))
        {
           string jsonToRead = File.ReadAllText(filePath);
            List<Employee> jsonLoaded = JsonSerializer.Deserialize<List<Employee>>(jsonToRead, options);

            foreach(var emp in jsonLoaded)
            {
                Console.WriteLine($"id : {emp.empId},name : {emp.name},department : {emp.department}");
            }

        }
    }
}