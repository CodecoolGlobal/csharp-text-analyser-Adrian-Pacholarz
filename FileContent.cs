using System.IO;
using System;

namespace csharp_text_analyser_Adrian_Pacholarz
{
    public class FileContent : IterableText
    {
        private char[] _file;
        private string _fileName;
        public char this[int itemIndex]
        {
            get
            {
                return _file[itemIndex];
            }
        }
        public FileContent(string file)
        {
            this._fileName = file;
            try
            {
            this._file = File.ReadAllText(_fileName).ToLower().ToCharArray();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"{_fileName} not found");
            }

        }
        public Iterator CharIterator()
        {
            return new CharIterator(this);
        }

        public Iterator WordIterator()
        {
            return new WordIterator(this);
        }

        public string GetFileName()
        {
            return Path.GetFileName(_fileName);
        }

        public int CountCharaters()
        {
            return _file.Length;
        }

        public bool IsFileLoaded()
        {
            if(_file is null)
            {
                return false;
            }
            return true;
        }
    }
}