
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
            var payroll = await _payrollShowcasable.ProcessPayrollAsync("HRMasterlist.txt");
            _payrollShowcasable.PresentInformation(payroll);
            _payrollShowcasable.UpdateMonthlyPayoutToMasterList(payroll);
//dependency injection
        }
    }
}