using EmployeeFileStorer;
namespace CalculatePayroll {
    interface IPayrollShowcasable :  IManagePayroll, IPresentable<List<Employee>>  {
        //Ipresentible is from SectionA to prevent circular dependency 
    }
}