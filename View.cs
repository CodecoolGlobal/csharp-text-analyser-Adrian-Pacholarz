using System;
using System.Collections.Generic;

namespace csharp_text_analyser_Adrian_Pacholarz
{
    class View
    {
        public void Print(string label, int number)
        {
            Console.WriteLine($"{label}: {number}");
        }

        public void Print(string label, double number)
        {
            Console.WriteLine($"{label}: {number.ToString("F2")}");
        }

        public void Print(string label, List<string> contentList)
        {
            string contentString = "";
            contentList.Sort();

            foreach (string content in contentList)
            {
                contentString += content + ", ";
            }

            Console.WriteLine($"{label}: [{contentString.TrimEnd(new char[] {',', ' '})}]");

        }

        public void Print(ISet<string> contentList)
        {
            Console.WriteLine("Words that occur more times than provided quantity:");
            foreach (string content in contentList)
            {
                Console.WriteLine($"- {content}");
            }

        }

        public void Print(Dictionary<string, double> contentDictionary)
        {
            foreach (string key in contentDictionary.Keys)
            {
                Console.Write($"[{key} -> {contentDictionary[key].ToString("F2")}] ");
            }
            Console.WriteLine();

        }
    }
}