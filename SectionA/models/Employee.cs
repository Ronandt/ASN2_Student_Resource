
namespace EmployeeFileStorer
{
    public class Employee
    {
        public Employee(string nric, string fullName, string salutation, string startDate, string designation, string department, string mobileNo, string hireType, string salary)
        {
            Nric = nric;
            FullName = fullName;
            Salutation = salutation;
            StartDate = DateTime.ParseExact(startDate, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            Designation = designation;
            Department = department;
            MobileNo = mobileNo;
            HireType = hireType;
            Salary = salary;
      
        }

        public string? Nric { get; set; }
        public string? FullName { get; set; }

        public string? Salutation { get; set; }

        public DateTime StartDate { get; set; }
        public string? Designation { get; set; }
        public string? Department { get; set; }
        public string? MobileNo { get; set; }

        public string? HireType { get; set; }
        public string? Salary { get; set; }
        public double MonthlyPayout { get; set; }

        public string CorpAdmin()
        {

            return $"{this.FullName},{this.Designation},{this.Department}";
        }

        public string Procurement()
        {
            return $"{this.Salutation},{this.FullName},{this.MobileNo},{this.Designation},{this.Department}";
        }

        public string ITDepartment()
        {
            return $"{this.Nric},{this.FullName},{this.StartDate},{this.Department},{this.MobileNo}";
        }








    }
}