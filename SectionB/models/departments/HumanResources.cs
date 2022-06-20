using EmployeeFileStorer;
namespace CalculatePayroll
{
    class HumanResources : Department
    {
        public List<Employee>? ProcessPayroll()
        {

            var employees = new FileProcessor("HRMasterlist.txt").ReadTextFileConverter().Select(employees => { Enum.TryParse(employees.HireType, out HireTypeMonthlyPayoutPercentage monthlyPayoutPercentage); employees.MonthlyPayout = Int32.Parse(employees.Salary) * (double)monthlyPayoutPercentage / 100; return employees; }).ToList();
           

            return employees;
        }

        public async Task<List<Employee>?> ProcessPayrollAsync() {
            List<Employee>? asyncResult = await Task.Run(() => this.ProcessPayroll());
            return asyncResult;
        }

        public void UpdateMonthlyPayoutToMasterList(List<Employee> employee)
        {
         
            FileProcessor.WriteToTextFile("HRMasterlistB.txt", String.Join("\n", employee.Select(x => x.ToString())));
        }

        public override void PresentInformation(List<Employee> employees) {
    
            employees.ForEach(employee => Console.WriteLine($"{employee.FullName} ({employee.Nric})\n{employee.Designation}\n{employee.HireType} Payout: ${employee.MonthlyPayout}\n{String.Concat(Enumerable.Repeat("-", 20))}"));
            var totalMonthlyPayout = employees.Aggregate(0.0, (totalMonthlyPayout, employee) => employee.MonthlyPayout + totalMonthlyPayout);
            Console.WriteLine($"Total Payroll Amount: ${totalMonthlyPayout} to be paid to {employees.Count()} employees");

            //show payroll stuff here
        }
    }
}