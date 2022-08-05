using EmployeeFileStorer;
namespace CalculatePayroll
{
    interface IManagePayroll
    {
        public List<Employee>? ProcessPayroll(List<Employee> employeesList);

        public Task<List<Employee>?> ProcessPayrollAsync(List<Employee> employeesList); //Classes with the possibility of Async should implmenet Synchronous and Asynchronous methods in both cases. Methods with async should put "Async" behind the method name

        public void UpdateMonthlyPayoutToMasterList(List<Employee> employee); //All capitalised instead of update in order to follow naming convensions of c#

    }
}
