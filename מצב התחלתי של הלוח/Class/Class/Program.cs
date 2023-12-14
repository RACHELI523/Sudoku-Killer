using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class Program
    {
        static void Main(string[] args)
        {

            int sum = 5;
            int size = 3;
            List<List<int>> combinations = FindCombinations(sum, size);

            foreach (List<int> combination in combinations)
            {
                foreach(int s in combination)
                    Console.WriteLine(string.Join(",",s));
               // Console.WriteLine(string.Join(", ", combination));
            }
            Console.ReadLine();

            int[,] mockMat = [[1, 2, 2],[]];
            //לעשות מילון עם הסכום של הכלוב והמםתח של 
            Board board=new Board(mockMat);

        }
      
            public static List<List<int>> FindCombinations(int sum, int size)
            {
                // Create a matrix to store the combinations
                List<List<int>>[,] matrix = new List<List<int>>[sum + 1, size + 1];

                // Initialize the first column of the matrix
                for (int i = 0; i <= sum; i++)
                {
                    matrix[i, 0] = new List<List<int>>();
                }

                // Populate the matrix using dynamic programming
                for (int i = 1; i <= sum; i++)
                {
                    for (int j = 1; j <= size; j++)
                    {
                        if (i < j)
                        {
                            matrix[i, j] = matrix[i, j - 1];
                        }
                        else
                        {
                            matrix[i, j] = new List<List<int>>();
                        
                            foreach (List<int> combination in matrix[i,j])
                            {
                                List<int> newCombination = new List<int>();
                                //newCombination.Add(newCombination);
                                List<int> sortedCombination = newCombination.OrderBy(item => item).ToList();
                                if (!matrix[i, j].Contains(sortedCombination))
                                {
                                    matrix[i, j].Add(sortedCombination);
                                }
                            }
                        }
                    }
                }

            foreach (List<int> combination in matrix[sum, size])
            {
                foreach (int s in combination)
                    Console.WriteLine(string.Join(",", s));
                // Console.WriteLine(string.Join(", ", combination));
            }

            return matrix[sum, size]; 


            }


        }
    }


