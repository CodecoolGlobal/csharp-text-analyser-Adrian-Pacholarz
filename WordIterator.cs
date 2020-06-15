namespace csharp_text_analyser_Adrian_Pacholarz
{
    public class WordIterator : Iterator
    {
        private FileContent _fileContent;
        private int _position;
        public WordIterator(FileContent fileContent)
        {
            this._fileContent = fileContent;
            this._position = -1;
        }
        public bool HasNext()
        {
            throw new System.NotImplementedException();
        }

        public string MoveNext()
        {
            throw new System.NotImplementedException();
        }

    }
}
