using System;
using System.IO;
namespace EmployeeFileStorer
{
    public class Program
    {


        public static List<Employee> ReadHRMasterList()
        {
            HRProcessor hrProcessor = new HRProcessor(@"HRMasterlist.txt");
            return hrProcessor.ReadTextFileConverter();
        }

        
  
        public static void Main(string[] args)
        {
            List<Employee> masterList = ReadHRMasterList();
            InvokeGenerateInfoMethods invokeAllGenerateInfoMethods = IT.GenerateInfoForITDepartment;
            invokeAllGenerateInfoMethods += Procurement.GenerateInfoForProcurement;
            invokeAllGenerateInfoMethods += CorpAdmin.GenerateInfoForCorpAdmin;
            invokeAllGenerateInfoMethods.Invoke(masterList);
        }




    }


}