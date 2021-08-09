using System;

namespace _3._1
{
    class Program
    {
        abstract class Shape
        {
            public abstract bool IsShape();//确定形状
            public abstract double Area ();//求面积
        }
        class Rectangle:Shape
        {
            public double length;//长
            public double width;//宽
            public Rectangle(double l, double w)
            {
                length = l; width = w;
            }
            public override bool IsShape()
            {
                if (length > 0 && width > 0) return true;
                else return false;
            }
            public override double Area()
            {
                return length * width;
            }

        }
        class Square : Rectangle
        {
            public Square(double l,double w) : base(l, w){}//构造函数
            public override bool IsShape()
            {
                if (length>0&&width>0&&length == width) return true;
                else return false;
            }
            public override double Area()
            {
                return length * width;
            }
        }
        class Triangle:Shape
        {
            public double edge1, edge2, edge3;
            public Triangle(int e1, int e2, int e3)//构造函数
            {
                edge1 = e1; edge2 = e2; edge3 = e3;
            }
            public override bool IsShape()//判断形状是否合法
            {
                if ((edge1 + edge2) > edge3 && (edge1 + edge3) > edge2 && (edge3 + edge2) > edge1)
                {
                    return true;
                }
                else return false;
            }
            public override double Area()//求面积
            {
                if (IsShape())//判断形状
                {
                    double p = (edge1 + edge2 + edge3) / 2;
                    return Math.Sqrt(p * (p-edge1) * (p- edge2) * (p - edge3));
                }
                else
                {
                    Console.Write("error"); return 0;
                }
            }
        }

        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle(5, 3);
            Console.WriteLine("长方形面积：" + r1.Area());

            Square[] s = { 
                new Square(-1, -1), 
                new Square(2, 3), 
                new Square(5, 5) 
            };
            for(int i = 0; i < 3; i++)
            {
                if (s[i].IsShape()) Console.WriteLine("是正方形且面积为" + s[i].Area());
                else Console.WriteLine("不是正方形");
            }

            Triangle t1 = new Triangle(1, 1, 2);
            Console.WriteLine("三角形面积：" + t1.Area());

            Triangle t2 = new Triangle(1, 2, 3);
            if (t2.IsShape()) Console.WriteLine("三角形面积：" + t2.Area());
            else Console.WriteLine("is not a triangle");

            Triangle t3 = new Triangle(3,4,5);
            Console.WriteLine("三角形面积：" + t3.Area());
        }
    }
}
