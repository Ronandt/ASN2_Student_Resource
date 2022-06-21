using EmployeeFileStorer;
namespace CalculatePayroll {
    class Program {
        public static async Task Main(string[] args) {
            InitalisePayrollOperation initalisePayrollOperation = new InitalisePayrollOperation(new HumanResources());
            await initalisePayrollOperation.Start();

        }
    }
}