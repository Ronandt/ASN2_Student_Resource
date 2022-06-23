

namespace EmployeeFileStorer {
class GenerateAllInformation {
    public static void AllDepartmentInformation(List<Employee> employees) {
            InvokeGenerateInfoMethods invokeAllGenerateInfoMethods = IT.GenerateInfoForITDepartment;
            invokeAllGenerateInfoMethods += Procurement.GenerateInfoForProcurement;
            invokeAllGenerateInfoMethods += CorpAdmin.GenerateInfoForCorpAdmin;
            invokeAllGenerateInfoMethods.Invoke(employees);
    }
}
}