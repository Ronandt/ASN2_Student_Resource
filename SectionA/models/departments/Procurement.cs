namespace EmployeeFileStorer {

    class Procurement : Department{
        public static void GenerateInfo(List<Employee> content) {
            string contentSelected = String.Join("\n", content.Select(x => x.Procurement()).ToList());
            Department.WriteToTextFile("Procurement.txt", contentSelected);
        }
    }
}
