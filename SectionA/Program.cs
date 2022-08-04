using System;
using System.IO;
namespace EmployeeFileStorer
{
    public class Program
    {


        public static List<Employee>? ReadHRMasterList()
        {
            FileProcessor hrProcessor = new FileProcessor(@"HRMasterlist.txt");
            return hrProcessor.ReadTextFileConverter();
        }

        
  
        public static void Main(string[] args)
        {
            GenerateAllInformation.AllDepartmentInformation(ReadHRMasterList()!);
        }




    }


}