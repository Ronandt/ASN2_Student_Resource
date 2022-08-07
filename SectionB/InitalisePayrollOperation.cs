
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
            var payroll = await _payrollShowcasable.ProcessPayrollAsync(EmployeeFileStorer.Program.ReadHRMasterList()!); //Classes with the possibility of Async should implmenet Synchronous and Asynchronous methods in both cases. Methods with async should put "Async" behind the method name
            _payrollShowcasable.PresentInformation(payroll!); //my justiciation is SOLID principle, each function has to do one thing and one thing only. This is for printing information only
            _payrollShowcasable.UpdateMonthlyPayoutToMasterList(payroll!); //updating only 
//strategy pattern/Depdency injeciton
        }
    }
}