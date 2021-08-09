using System;

namespace homework2._2
{
    class Program
    {
        static void function(int[] num, out int max, out int min, out int sum, out double average)
        {
            max = num[0];
            min = num[0];
            sum = 0;
            for (int j = 0; j < num.Length; j++)
            {
                if (num[j] > max) max = num[j];
                if (num[j] < min) min = num[j];
                sum += num[j];
            }
            average = sum / num.Length;
        }
        static void Main(string[] args)
        {
            int[] num;
            Console.Write("数组大小:");
            int size = Int32.Parse(Console.ReadLine());
            num = new int[size];
            for (int i = 0; i < size; i++) //输入数组
                num[i] = Int32.Parse(Console.ReadLine());

            int max, min, sum;
            double average;
            function(num, out max, out min, out sum, out average);
            Console.WriteLine("最大值" + max + " 最小值" + min + " 平均值" + average + " 总和" + sum);
        }
    }
}
