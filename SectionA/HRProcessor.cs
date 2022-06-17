namespace EmployeeFileStorer {
        public class HRProcessor : IReadEmployees
    {

        public HRProcessor(string path)
        {
            Path = path;
        }


        public List<Employee>? ReadTextFile()
        {

            return File.Exists(Path) ? File.ReadAllText(Path).Split(Environment.NewLine).Select(employeeString =>
                {
                    return (Employee)Activator.CreateInstance(typeof(Employee), args: (object[])(employeeString.Split("|")))!;
                }).ToList() : null;


        }

        public string Path { get; set; }








    }
}