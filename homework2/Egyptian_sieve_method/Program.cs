using System;

namespace Egyptian_sieve_method
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num ;
            num = new int[101];
            for (int i = 2; i <= 100; i++) num[i] = i;//2~100由数组表示

            int minPrime = 2;//当前最小素数
            int tempMin = minPrime;//暂存最小素数

            while (minPrime <= Math.Sqrt(100))//当前最小素数的平方大于序列最大数时结束
            {
                bool first = true;
                for (int j = minPrime+1; j < 101; j++)//遍历数字2~100
                {

                    if (num[j] % minPrime == 0 )//能被当前最小素数整除
                    {
                        num[j] = 0;//num[j]=0即被筛除
                    }
                    else if (first && num[j] != 0)//第一个小于当前最小素数且未被筛除
                    {
                        tempMin = num[j];//暂存最小素数
                        first = false;
                    }
                }
                minPrime = tempMin;//更新最小素数
            }
            for (int i = 0; i < 101; i++)
            {
                if(num[i]!=0)
                    Console.Write(num[i] + " ");
            }
        }
    }
}
