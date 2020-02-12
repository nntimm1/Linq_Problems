using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblems
{
    class GradeAverage
    {
        // -------------------------------- Member Variable -------------------------------



        // -------------------------------- Constructor -----------------------------------




        // -------------------------------- Member Method ---------------------------------
        public void AverageGradesMethod()
        {
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
        }
    }
}
