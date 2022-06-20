namespace EmployeeFileStorer
{
    public class FileProcessor : ITextReaderConvertable<List<Employee>>, ITextWritable {

        public FileProcessor(string path)
        {
            Path = path;
        }


        public List<Employee>? ReadTextFileConverter()
        {
            if(File.Exists(Path)) {
                return  File.ReadAllText(Path).Split(Environment.NewLine).Select(employeeString => { return (Employee)Activator.CreateInstance(typeof(Employee), args: (object[])(employeeString.Split("|")))!; }).ToList(); 
            }
            throw new FileNotFoundException("Unable to find the file! Please create the file.");
           
        }
        
            public static void WriteToTextFile(string writeFilePath, string content)
        {
            if (!File.Exists(writeFilePath))
            {
                using (StreamWriter sw = File.CreateText(writeFilePath))
                {
                    sw.WriteLine(content);
                }
            } else {
                Console.WriteLine($"{writeFilePath} already exists.");
            }
        }
        public string Path { get; set; }








    }
}