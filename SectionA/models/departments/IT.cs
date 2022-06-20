namespace EmployeeFileStorer
{

    class IT : Department
    {
        public static void GenerateInfoForITDepartment(List<Employee> content)
        {
            string contentSelected = String.Join("\n", content.Select(x => x.ITString()).ToList());
            FileProcessor.WriteToTextFile("ITDepartment.txt", contentSelected);
        }
    }
}