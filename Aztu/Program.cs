using System;

namespace Aztu
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr =
            {
                {1,2,-2},
                {5,10,8},
                {2,5,-1}
            };


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine(new string('-', 50));

            for (int i = 0; i < 3; i++)
            {
                int min = int.MaxValue;
                for (int j = 0; j < 3; j++)
                {
                    if (arr[j, i] < min)
                    {
                        min = arr[j, i];
                    }
                }
                arr[i, i] = min;
                Console.WriteLine(min);
            }
            Console.WriteLine(new string('-', 50));

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }

            #region
            //int n = 3, m = 3;
            //int[,] mat = {{2, 1, 7},
            //       {3, 7, 2},
            //      {5, 4, 9}};

            //Console.Write("Minimum element of " +
            //                     "each row is ");
            //smallestInRow(mat, n, m);
            #endregion
        }
        static void smallestInRow(int[,] mat,
                                      int n, int m)
        {
            Console.Write(" { ");

            for (int i = 0; i < n; i++)
            {

                int minm = mat[i, 0];

                for (int j = 1; j < m; j++)
                {

                    // check if any element is smaller
                    // than the minimum element of the
                    // row and replace it
                    if (mat[i, j] < minm)
                    {
                        minm = mat[i, j];

                        //for (i = 0; i < mat.GetLength(0); i++)
                        //{
                        //    for (j = 0; j < mat.GetLength(1); j++)
                        //    {
                        //        Console.WriteLine(mat[i, j]);
                        //    }
                        //}
                    }
                }

                // print the smallest element
                // of the row
                Console.Write(minm + ", ");
            }
            Console.WriteLine("}");
        }
    }
}
