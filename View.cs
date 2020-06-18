using System;
using System.Collections.Generic;

namespace csharp_text_analyser_Adrian_Pacholarz
{
    class View
    {
        public void Print(string text)
        {
            Console.WriteLine(text);
        }

        public void Print(List<string> contentList)
        {
            foreach (string content in contentList)
            {
                Console.WriteLine(content);
            }

        }

        public void Print(ISet<string> contentList)
        {
            foreach (string content in contentList)
            {
                Console.WriteLine(content);
            }

        }

        public void Print(Dictionary<string, int> contentDictionary)
        {
            foreach (string key in contentDictionary.Keys)
            {
                Console.WriteLine($"{key} : {contentDictionary[key]}" );
            }

        }
    }
}