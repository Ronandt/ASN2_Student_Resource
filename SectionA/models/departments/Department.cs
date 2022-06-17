namespace EmployeeFileStorer
{
    class Department : ITextWriter
    {
        public static void WriteToFile(string writeFilePath, string content)
        {
            if (!File.Exists(writeFilePath))
            {
                using (StreamWriter sw = File.CreateText(writeFilePath))
                {
                    sw.WriteLine(content);
                }
            }
        }
    }
}