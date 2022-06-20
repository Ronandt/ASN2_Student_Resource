using CalculatePayroll;
namespace EmployeeFileStorer
{
    public abstract class Department : IPresentable<List<Employee>>
    {
        public virtual void PresentInformation(List<Employee> employees) {
            Console.WriteLine(String.Join("\n", employees.Select(employee => employee.ToString())));
        }
    }
}