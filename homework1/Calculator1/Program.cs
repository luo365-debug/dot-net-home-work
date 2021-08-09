using System;

namespace Calculator1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, op, outcome;
            //string nb,op;
            Console.Write("please input the frist integer number:");
            a = int.Parse(Console.ReadLine());
            Console.Write("please input an operator from 1.+ 2.- 3.* 4./ ");
            //nop = Console.ReadLine();
            op = int.Parse(Console.ReadLine());
            Console.Write("please input the second integer number:");
            //nb = Console.ReadLine();
            b = int.Parse(Console.ReadLine());

            if (b == 0 && op == 4) { Console.Write("error1"); return; }
            switch (op)
            {
                case 1:
                    outcome = a + b;
                    Console.WriteLine("{0}+{1}={2}", a, b, outcome);
                    break;
                case 2:
                    outcome = a - b;
                    Console.WriteLine("{0}-{1}={2}", a, b, outcome);
                    break;
                case 3:
                    outcome = a * b;
                    Console.WriteLine("{0}*{1}={2}", a, b, outcome);
                    break;
                case 4:
                    outcome = a / b;
                    Console.WriteLine("{0}/{1}={2}", a, b, outcome);
                    break;
                default:
                    Console.WriteLine("error2");
                    return;
            }
            return;
        }
    }
}
