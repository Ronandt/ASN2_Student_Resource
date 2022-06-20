using EmployeeFileStorer;
namespace CalculatePayroll
{
    interface IManagePayroll
    {
        public List<Employee>? ProcessPayroll(string filePath);

        public Task<List<Employee>?> ProcessPayrollAsync(string filePath);

    }
}
