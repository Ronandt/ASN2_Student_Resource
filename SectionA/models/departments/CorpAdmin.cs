namespace EmployeeFileStorer
{
    class CorpAdmin : Department
    {
        public static void GenerateInfo(List<Employee> content)
        {
       string contentSelected = String.Join("\n", content.Select(x => x.CorpAdmin()).ToList());
            Department.WriteToTextFile("CorporateAdmin.txt", contentSelected);
        }
    }

}
