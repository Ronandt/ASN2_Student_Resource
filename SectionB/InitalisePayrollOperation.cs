
namespace CalculatePayroll
{
    class InitalisePayrollOperation
    {

        private readonly IPayrollShowcasable _payrollShowcasable;

        public InitalisePayrollOperation(IPayrollShowcasable payrollShowcasable) {
            _payrollShowcasable = payrollShowcasable;
        }
        public async Task Start()
        {
            var payroll = await _payrollShowcasable.ProcessPayrollAsync(EmployeeFileStorer.Program.ReadHRMasterList()); //Classes with the possibility of Async should implmenet Synchronous and Asynchronous methods in both cases. Methods with async should put "Async" behind the method name
            _payrollShowcasable.PresentInformation(payroll);
            _payrollShowcasable.UpdateMonthlyPayoutToMasterList(payroll);
//strategy pattern/Depdency injeciton
        }
    }
}