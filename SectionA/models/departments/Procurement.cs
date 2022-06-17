namespace EmployeeFileStorer {

    class Procurement : Department{
        public static void GenerateInfoForProcurement(List<Employee> content) {
            string contentSelected = String.Join("\n", content.Select(x => x.Procurement()).ToList());
            Department.WriteToTextFile("Procurement.txt", contentSelected);
        }
    }
}
