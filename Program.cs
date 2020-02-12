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

            List<string> classGrades = new List<string>() { "80,100,92,89,65", "93,81,78,84,69", "73,88,83,99,64", "98,100,66,74,55" };
            List<double> averageGrade = new List<double>() { };
            double result;
            for (int i = 0; i < classGrades.Count; i++)
            {
                var classGradesConvert = classGrades[i].Split(',');
                var cgOfStringToInt = classGradesConvert.Select(int.Parse).ToList();
                cgOfStringToInt.Remove(cgOfStringToInt.Min());
                result = cgOfStringToInt.Average();
                averageGrade.Add(result);
            }
            Console.WriteLine("Average Grade: " + averageGrade.Average());
            Console.ReadLine();

            // ---------------------------------- Problem 4 ---------------------------------------------------------

            string userInput = "Terrill";
            var letterOrder = userInput.ToList();
            var inOrder = letterOrder.OrderBy(c => c.ToString());

        }
    }
}
