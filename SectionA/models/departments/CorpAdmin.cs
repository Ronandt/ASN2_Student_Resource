namespace EmployeeFileStorer
{
    class CorpAdmin
    {
        public static void GenerateInfoForCorpAdmin(List<Employee> content)
        {
            string contentSelected = String.Join("\n", content.Select(x => x.CorpAdminString()).ToList());
            FileProcessor.WriteToTextFile("CorporateAdmin.txt", contentSelected);
        }
    }

}
