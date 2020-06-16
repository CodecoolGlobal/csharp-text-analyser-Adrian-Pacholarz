using System;

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
            while(!CharIterator.AlphaLetters.Contains(_fileContent[_position]) && HasNext());
            
            string word = "";


            while(CharIterator.AlphaLetters.Contains(_fileContent[_position]))
            {
                word += _fileContent[_position];
                if (HasNext())
                {
                    _position +=1;
                }
                else
                {
                    return word;
                }
            }
            return word;
        }

        public void Reset()
        {
            this._position = -1;
        }

    }
}
