using System;

namespace Toeplitz_matrix
{
    class Program
    {

        static bool Toeplitz(int M,int N,int[,] matrix)
        {
            for(int n = 0; n < (Math.Min(M, N)-1); n++)
            {
                if (matrix[n,n] != matrix[n + 1,n + 1]) return false;
                else n += 1;
            }
            return true ;
        }
        static void Main(string[] args)
        {
            //int M = Int32.Parse(Console.ReadLine());//行
            //int N = Int32.Parse(Console.ReadLine());//列
            int M = 3, N = 4;

            int[,] matrix ={
                { 1,2,3,4 },
                { 5,1,2,3 },
                { 9,5,1,2 }
            };
            /*for (int i = 0; i < M; i++)
                {
                    for(int j = 0; j < N; j++)
                    {
                        matrix[i,j] = Int32.Parse(Console.ReadLine());
                    }
                }*/
            bool isToeplitz = Toeplitz(M, N, matrix);
            Console.Write(isToeplitz);
        }
    }
}
