using EmployeeFileStorer;
namespace CalculatePayroll {
    class Program {
        public static async Task Main(string[] args) {
            await InitalisePayrollOperation.Start(new HumanResources());

        }
    }
}