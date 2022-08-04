using EmployeeFileStorer;
namespace CalculatePayroll
{
    interface IManagePayroll
    {
        public List<Employee>? ProcessPayroll(List<Employee> employeesList);

        public Task<List<Employee>?> ProcessPayrollAsync(List<Employee> employeesList);

        public void UpdateMonthlyPayoutToMasterList(List<Employee> employee);

    }
}
