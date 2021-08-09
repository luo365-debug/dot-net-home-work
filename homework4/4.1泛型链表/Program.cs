using System;

namespace _4._1泛型链表
{
    //泛型节点
    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }
        public Node(T t){   Next=null;  Data=t; }
    }

    //泛型链表类
    public class GenericList<T>
    {
        private Node<T> head, tail;
        public GenericList() { tail = head = null; }//无参构造函数
        public Node<T> Head { get => head; }
        public void Add(T t)//添加节点
        {
            Node<T> n = new Node<T>(t);
            if (tail == null) head = tail = n;//当前为空链表
            else
            {
                tail.Next = n;//尾插
                tail = n;
            }
        }
        public void ForEach(Action<T> action)
        {
            for(Node<T> i = head; i != null; i = i.Next)
            {
                action(i.Data);
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<double> list = new GenericList<double>();//创建空链表
            for(int i = 0; i < 5; i++)//链表赋值
            {
                double a = Double.Parse(Console.ReadLine());
                list.Add(a);
            }

            double sum = 0, min=list.Head.Data, max=list.Head.Data;
            Action<double> action = m => {
                Console.Write(m + " "); 
                sum += m;
                max=max > m ? max : m;
                min = min < m ? min : m;

            };
            list.ForEach(action);
            Console.WriteLine("总和" + sum + " 最大值" + max + " 最小值" + min);
        }
    }
}
