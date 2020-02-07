using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            // ---------------------------------- Problem 1 ---------------------------------------------------------
            ThWords thWords = new ThWords();
            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathmatics" };
            List<string> ThWordsList = words.FindAll(w => w.Contains("th"));
            foreach (var word in ThWordsList)
            {
                Console.WriteLine(word);

            }
            Console.ReadLine();

            // ---------------------------------- Problem 2 ---------------------------------------------------------

             RemoveDuplicate rdList = new RemoveDuplicate();
             List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
             var RemoveDuplicateNames = names.Distinct();
            foreach (var name in RemoveDuplicateNames)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();

            // ---------------------------------- Problem 3 ---------------------------------------------------------




            // ---------------------------------- Problem 4 ---------------------------------------------------------
        }

    }
}
