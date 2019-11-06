using System;

namespace fifth
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Write a function that copies given arrayofdouble elements into the array of int elements.
            var arr = new double[] { 4, 5.05, 7, 5, 4, 4.6, 7.2 };
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(arr[i]);
            }
            //Write a function to delete an element at desired position from an array.
            int n;
            n = Convert.ToInt32(Console.ReadLine());

            var arr1 = new int[] { 4, 5, 7, 5, 4, 4, 7 };
            for (int j = n; j < arr1.Length; j++)
            {
                if (arr1[j] != arr1.Length)
                {
                    arr1[j] = arr1[j + 1];
                }
                else
                    arr1[j] = 0;
            }
            /*
            Write a program to print the upper triangular of a given square matrix.
                For example, if the matrix is:
                1 2 3
                4 5 6
                7 8 9

                Thenprint only the elements of upper triangularelements, setting zeros in lower
                triangular matrix:
                1 2 3
                0 5 6
                0 0 9
                */
            int k = 0;
            int[,] matrix = new int[3, 3];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    k++;
                    matrix[i, j] = k;
                    if (i > j)
                    {
                        matrix[i, j] = 0;
                    }
                    Console.Write(matrix[i, j]+" ");
                }
                Console.WriteLine();
            }
                }
            }
        }
        
    

