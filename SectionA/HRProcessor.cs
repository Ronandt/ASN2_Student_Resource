namespace EmployeeFileStorer {
        public class HRProcessor : ITextConvertToEmployees
    {

        public HRProcessor(string path)
        {
            Path = path;
        }


        public List<Employee>? ReadTextFileConverter()
        {
            return File.Exists(Path) ? File.ReadAllText(Path).Split(Environment.NewLine).Select(employeeString => {  return (Employee)Activator.CreateInstance(typeof(Employee), args: (object[])(employeeString.Split("|")))!; }).ToList() : null;
        }

        public string Path { get; set; }








    }
}