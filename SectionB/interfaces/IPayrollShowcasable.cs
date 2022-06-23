using EmployeeFileStorer;
namespace CalculatePayroll {
    interface IPayrollShowcasable :  IManagePayroll, IPresentable<List<Employee>> {
        
    }
}