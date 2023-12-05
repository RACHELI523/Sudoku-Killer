using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // קלט מהמשתמש
            Console.WriteLine("אנא הזן את סכום הכלוב:");
            int sum = int.Parse(Console.ReadLine());

            Console.WriteLine("אנא הזן את גודל הכלוב:");
            int slots = int.Parse(Console.ReadLine());

            // צור שילובים
            List<List<int>> combinations = GenerateCombinations(sum, slots);

            // שילובי הדפסה
            foreach (List<int> combination in combinations)
            {
                Console.WriteLine(string.Join(", ", combination));
            }
           Console.ReadLine();
        }
       
        static List<List<int>> GenerateCombinations(int sum, int slots)
        {
            List<List<int>> results = new List<List<int>>();
            GenerateCombinationsHelper(sum, slots, new List<int>(), results);
            return results;
        }

        static void GenerateCombinationsHelper(int remainingSum, int remainingSlots, List<int> currentCombination, List<List<int>> results)
        {
            // מקרה בסיס: כל המשבצות מולאו
            if (remainingSlots == 0)
            {
                // בדוק אם הסכום הנותר שווה ל-0
                if (remainingSum == 0)
                {
                    results.Add(new List<int>(currentCombination));
                }
                return;
            }
            // מקרה בסיס: סכום הקופסה הנותר הוא 0
            if (remainingSum == 0)
            {
                //results.Add(new List<int>(currentCombination));
                return;
            }

            //חזור על כל הערכים האפשריים עבור המשבצת הנוכחית
            for (int i = 1; i <= remainingSum; i++)
            {
                if (i > 9)
                {
                    return;
                }
                currentCombination.Add(i);
                // קריאה רקורסיבית למילוי המשבצת הבאה
                GenerateCombinationsHelper(remainingSum - i, remainingSlots - 1, currentCombination, results);
                currentCombination.RemoveAt(currentCombination.Count - 1);
            }
            
        }
     
    }

  
}



//GenerateCombinationsHelper-עוזר יצירת שילובים
//combinations -שילובים
