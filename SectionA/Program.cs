using System;
using System.IO;
namespace EmployeeFileStorer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(String.Join("||", HRProcessor.ReadHRMasterList()));
        }
    }

    public class HRProcessor
    {
        public static List<Employee>? ReadHRMasterList()
        {
            string path = @"HRMasterlist.txt";
            return File.Exists(path) ? File.ReadAllText(path).Split(Environment.NewLine).Select(employeeString =>
                {
                    return (Employee)Activator.CreateInstance(typeof(Employee), args: (object[])(employeeString.Split("|")))!;
                }).ToList() : null;


        }

        
    }
}