
namespace CalculatePayroll
{
    class InitalisePayrollOperation
    {
        public async static Task Start(HumanResources HR)
        {
            var payroll = await HR.ProcessPayrollAsync("HRMasterlist.txt");
            HR.PresentInformation(payroll);
            HR.UpdateMonthlyPayoutToMasterList(payroll);

        }
    }
}