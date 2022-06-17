namespace EmployeeFileStorer {
    interface IReadEmployees : ITextReaderConverter<List<Employee>> {
        public List<Employee> ReadTextFile();
    }
}