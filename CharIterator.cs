using System;
using System.Collections.Generic;


namespace csharp_text_analyser_Adrian_Pacholarz
{
    public class CharIterator : Iterator
    {

        private FileContent _fileContent;
        private int _position;

        public CharIterator(FileContent fileContent)
        {
            this._fileContent = fileContent;
            this._position = -1;

        }
        public bool HasNext()
        {
            if (_position + 1 == _fileContent.CountCharaters())
            {
                return false;
            }
            return true;
        }

        public string MoveNext()
        {
            do
            {
            _position += 1;
            }
            while(!char.IsLetter(_fileContent[_position]) && HasNext());

            return _fileContent[_position].ToString();
        }

        public void Reset()
        {
            this._position = -1;
        }
    }
}
