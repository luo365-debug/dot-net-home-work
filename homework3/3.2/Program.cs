using System;

namespace _3._2
{
    class Program
    {
        public interface Shape
        {
            public bool IsShape();//确定形状
            public abstract double Area();//求面积
        }
        class Rectangle : Shape
        {
            public double length;//长
            public double width;//宽
            public Rectangle(double l, double w)
            {
                length = l; width = w;
            }
            public bool IsShape()
            {
                if (length > 0 && width > 0) return true;
                else return false;
            }
            public double Area()
            {
                return length * width;
            }

        }
        class Square : Shape
        {
            public double side;
            public Square(double s) { side = s; }//构造函数
            public bool IsShape()
            {
                if (side>0) return true;
                else return false;
            }
            public double Area()
            {
                return side*side;
            }
        }
        class Triangle : Shape
        {
            public double edge1, edge2, edge3;
            public Triangle(int e1, int e2, int e3)//构造函数
            {
                edge1 = e1; edge2 = e2; edge3 = e3;
            }
            public bool IsShape()//判断形状是否合法
            {
                if ((edge1 + edge2) > edge3 && (edge1 + edge3) > edge2 && (edge3 + edge2) > edge1)
                {
                    return true;
                }
                else return false;
            }
            public double Area()//求面积
            {
                double p = (edge1 + edge2 + edge3) / 2;
                return Math.Sqrt(p * (p - edge1) * (p - edge2) * (p - edge3));
            }
        }

        class Factory
        {
            public static Shape GetShape(string Type)
            {
                Shape shape = null;
                Random ran = new Random();
                if (Type.Equals("Rectangle"))
                {
                    shape = new Rectangle(ran.Next(0, 10), ran.Next(0, 10));
                    if (!shape.IsShape()) return null;//长或宽为0
                    else Console.Write("长方形");
                }
                else if (Type.Equals("Square"))
                {
                    shape = new Square(ran.Next(0, 10));
                    if (!shape.IsShape()) return null;//边长为0
                    else Console.Write("正方形");
                }
                else if (Type.Equals("Triangle"))
                {
                    shape = new Triangle(ran.Next(0, 10),ran.Next(0, 10),ran.Next(0, 10));
                    if (!shape.IsShape()) return null;//三边取值不构成三角形
                    else Console.Write("三角形");
                }
                return shape;
            }
        }
        static void Main(string[] args)
        {
            string[] ShapeType = new string[] { "Rectangle", "Square", "Triangle" };
            Random rd = new Random();
            double sum=0;//总面积
            int i = 0;
            while(i<10)
            {
                Shape shape = Factory.GetShape(ShapeType[rd.Next(0, 3)]);//随机创建形状
                if (shape != null)
                {
                    Console.WriteLine(shape.Area());
                    sum = sum + shape.Area();
                    i++;
                }
            }
            Console.WriteLine("总面积为" + sum);
        }
    }
}
