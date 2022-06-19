namespace EmployeeFileStorer
{
    public class FileProcessor : ITextReaderConverter<List<Employee>>, ITextWriter {

        public FileProcessor(string path)
        {
            Path = path;
        }


        public List<Employee>? ReadTextFileConverter()
        {
            return File.Exists(Path) ? File.ReadAllText(Path).Split(Environment.NewLine).Select(employeeString => { return (Employee)Activator.CreateInstance(typeof(Employee), args: (object[])(employeeString.Split("|")))!; }).ToList() : null;
        }
        
            public static void WriteToTextFile(string writeFilePath, string content)
        {
            if (!File.Exists(writeFilePath))
            {
                using (StreamWriter sw = File.CreateText(writeFilePath))
                {
                    sw.WriteLine(content);
                }
            }
        }
        public string Path { get; set; }








    }
}