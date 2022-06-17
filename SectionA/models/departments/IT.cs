namespace EmployeeFileStorer
{

    class IT : Department
    {
        public static void GenerateInfo(List<Employee> content)
        {
            string contentSelected = String.Join("\n", content.Select(x => x.ITDepartment()).ToList());
            Department.WriteToTextFile("ITDepartment.txt", contentSelected);
        }
    }
}