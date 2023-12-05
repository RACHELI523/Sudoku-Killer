using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    // תוכנית C# לספור את כל קבוצות המשנה עם סכום נתון.

    public class SubSet_sum_problem
    {
        //הגדרת מטריצה בולנית סטיטית 
        // dp[i][j] עומד לאחסן אמת אם סכום j הוא
        // אפשרי עם רכיבי מערך מ-0 עד i.
        static bool[,] dp;

        // פונקציה מדפיסה את הערכים ברשימה V
        static void display(List<int> v)
        {
            if (v.Count == 0)
            {
                // אם הרשימה ריקה, אז הדפס שורת ריק
                Console.WriteLine();
                return;
            }



            foreach (var i in v) Console.Write(i + " ");
            Console.WriteLine();
        }


        // פונקציה רקורסיבית להדפסת כל קבוצות המשנה עם ה-
        // עזרה של dp[][]. וקטור p[] מאחסן תת-קבוצה נוכחית.

        static void printSubsetsRec(int[] arr, int i, int sum,
                                    List<int> p)
        {
            // אם הגענו לסוף והסכום אינו אפס. אנחנו מדפיסים
            // p[] רק אם arr[0] שווה לסכום או dp[0][sum]
            // נכון.
            if (i == 0 && sum != 0 && dp[0, sum] )
            {
                if (sum == arr[i])
                {
                   p.Add(arr[i]);
                   display(p);
                   p.Clear();
                   return;
                }
               
            }

            // אם הסכום הופך ל-0
            if (i == 0 && sum == 0)
            {
                display(p);
                p.Clear();
                return;
            }

            // אם נתון ניתן להשיג סכום לאחר התעלמות
            // אלמנט נוכחי.
            if (dp[i - 1, sum])
            {
                // צור וקטור חדש לאחסון נתיב
                List<int> b = new List<int>();
                b.AddRange(p);
                printSubsetsRec(arr, i - 1, sum, b);
            }

            // אם ניתן סכום נתון ניתן להשיג לאחר שקילה
            // אלמנט נוכחי.
            if (sum >= arr[i] && dp[i - 1, sum - arr[i]])
            {
                if (sum - arr[i]==0)
                {
                    p.Add(arr[i]);
                    display(p);
                    p.Clear();
                    return;
                }
                p.Add(arr[i]);
                printSubsetsRec(arr, i - 1, sum - arr[i], p);
            }
           

            // הדפס את התת-קבוצה הנוכחית
            foreach (var w in p)
            {
                Console.Write("{0} ", w);
            }

            // הדפס שורת קו חדשה
            Console.WriteLine();
        }

        // מדפיס את כל קבוצות המשנה של arr[0..n-1] עם סכום 0.
        static void printAllSubsets(int[] arr, int n, int sum)
        {

            if (sum == 0)
            {
                // אם סכום הכלוב הוא 0, אז יש רק תת-קבוצה אחת אפשרית, שהיא התת-קבוצה הריקה
                Console.WriteLine("התת-קבוצה היחידה היא: {}", Enumerable.Empty<int>());
                return;
            }

            if (n == 0 || sum < 0)
                return;

            // סכום 0 תמיד ניתן להשיג עם 0 אלמנטים
            dp = new bool[n, sum + 1];
            for (int i = 0; i < n; ++i)
            {
                dp[i, 0] = true;
            }

            // Sum arr[0] ניתן להשיג עם אלמנט בודד
            if (arr[0] <= sum)
                dp[0, arr[0]] = true;

            // מלא את שאר הערכים ב-dp[][]
            for (int i = 1; i < n; ++i)
                for (int j = 0; j < sum + 1; ++j)
                    dp[i, j] = (arr[i] <= j)
                    ? (dp[i - 1, j]
                    || dp[i - 1, j - arr[i]])
                    : dp[i - 1, j];
            if (dp[n - 1, sum] == false)
            {
                Console.WriteLine("There are no subsets with"
                                    + " sum " + sum);
               
                return;
            }

            // כעת חצו באופן רקורסיבי dp[][] כדי למצוא הכל
            // נתיבים מ-dp[n-1][sum]
            List<int> p = new List<int>();
            printSubsetsRec(arr, n - 1, sum, p);
        }

        // תוכנית מנהלי התקן לבדיקת הפונקציות לעיל
        public static void Main(string[] args)
        {
            Console.WriteLine("הכנס את סכום הכלוב:");
            int sum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("הכנס את הגודל של הכלוב:");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int n = arr.Length;
            printAllSubsets(arr,n, sum);
            Console.ReadLine();


        }
    }
    // קוד זה נתרם על ידי phasing17
}


