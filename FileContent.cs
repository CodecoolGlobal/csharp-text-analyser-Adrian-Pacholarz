using System.IO;
using System;

namespace csharp_text_analyser_Adrian_Pacholarz
{
    public class FileContent : IterableText
    {
        private string _file;
        public string this[int itemIndex]
        {
            get
            {
                return _file.ToLower()[itemIndex].ToString();
            }
        }
        public FileContent(string file)
        {
            this._file = File.ReadAllText(file);

        }
        public Iterator CharIterator()
        {
            return new CharIterator(this);
        }

        public Iterator WordIterator()
        {
            throw new System.NotImplementedException();
        }

        public string GetFileName()
        {
            throw new System.NotImplementedException();
        }

        public int CountCharaters()
        {
            return _file.Length;
        }
    }
}