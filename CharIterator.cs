using System;
using System.Collections.Generic;


namespace csharp_text_analyser_Adrian_Pacholarz
{
    public class CharIterator : Iterator
    {

        private FileContent _fileContent;
        private int _position;

        public static List<string> AlphaLetters = new List<string> {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"};

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
            while(!AlphaLetters.Contains(_fileContent[_position]) && HasNext());

            return _fileContent[_position];
        }
    }
}
