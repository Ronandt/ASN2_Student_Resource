namespace EmployeeFileStorer {
    interface ITextReaderConverter<T> {
        public T ReadTextFile ();
    }
}