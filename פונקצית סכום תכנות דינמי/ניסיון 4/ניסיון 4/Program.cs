using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ניסיון_4
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine( "הכנס את הסכום הרצוי");
            int sum=Console.Read();
            Console.WriteLine("הכנס את הגודל הרצוי");
            int size=Console.Read();*/
            int sum = 3;
            int size = 3;
            List<List<int>> metrix= getfunc(sum , size);

            for (int i = 0; i < metrix.Count; i++)
            {
                for (int j = 0; j < metrix[i].Count; j++)
                {
                    Console.Write(metrix[i][j]+"," );
                }
                Console.WriteLine( );
            }
            Console.ReadLine();
        }
        public static List<List<int>> getfunc(int sum, int size)
        {
            List<List<int>>[][] metrix = new List<List<int>>[sum + 1][];
            for (int i = 0; i < sum+1; i++)
            {
                metrix[i] = new List<List<int>>[size + 1];
                for (int j = 0; j < size+1; j++)
                {
                    metrix[i][j] = new List<List<int>>();
                }
            }
            for (int i = 1; i < sum + 1; i++)
            {

                for (int j = 1; j < size + 1; j++)
                {


                    if (j == 1)

                        metrix[i][j].Add(new List<int> { i });

                    else
                    {
                        for(int k=i-1,l=j-1; k>=1&&l>=1; k--,l--)
                        {
                            foreach (List<int> item in metrix[k][l])
                            {
                                foreach (List<int> item2 in metrix[i - k][j - l])
                                {
                                    List<int> lst = new List<int>();
                                    lst.AddRange(item);
                                    lst.AddRange(item2);
                                    metrix[i][j].Add(lst);
                                }
                            }
                        }
                    }
                }
            }

            return metrix[sum][size];

        }


        
    }
}
