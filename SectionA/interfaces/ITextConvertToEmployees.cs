namespace EmployeeFileStorer {
    interface ITextConvertToEmployees : ITextReaderConverter<List<Employee>> {
        public List<Employee> ReadTextFileConverter();
    }
}