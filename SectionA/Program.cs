using System;
using System.IO;
namespace EmployeeFileStorer
{
    public class Program
    {


        public static List<Employee> ReadHRMasterList()
        {
            HRProcessor hr = new HRProcessor(@"HRMasterlist.txt");
            return hr.ReadTextFile();
        }


        public static void Main(string[] args)
        {
            List<Employee> masterList = ReadHRMasterList();
            IT.GenerateInfo(masterList);
            Procurement.GenerateInfo(masterList);
            CorpAdmin.GenerateInfo(masterList);

        }




    }

    public class HRProcessor : IReadEmployees
    {

        public HRProcessor(string path)
        {
            Path = path;
        }


        public List<Employee>? ReadTextFile()
        {

            return File.Exists(Path) ? File.ReadAllText(Path).Split(Environment.NewLine).Select(employeeString =>
                {
                    return (Employee)Activator.CreateInstance(typeof(Employee), args: (object[])(employeeString.Split("|")))!;
                }).ToList() : null;


        }

        public string Path { get; set; }








    }
}