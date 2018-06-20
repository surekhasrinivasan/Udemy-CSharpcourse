using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummarizingText
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = "This is going to be a really really really really really long sentence.";
            var summary = StringUtility.SummarizeText(sentence, 30);
            Console.WriteLine(summary);
        }
    }
}
