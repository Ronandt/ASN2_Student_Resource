using EmployeeFileStorer;
namespace CalculatePayroll {
    class Program {
        public static async Task Main(string[] args) {
            HumanResources HR = new HumanResources();
            var payroll = await HR.ProcessPayrollAsync();
            HR.PresentInformation(payroll);
            HR.UpdateMonthlyPayoutToMasterList(payroll);

        }
    }
}