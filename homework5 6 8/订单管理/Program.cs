using System;
using System.Collections.Generic;//List<Order>

namespace 订单管理
{  
    public class Program
    {
        public static void Main(string[] args) 
        {
            
            //定义两个客户
            Client client1 = new Client("li", "BeiJing");
            Client client2 = new Client("zhao", "WuHan");

            //定义四种货物
            Goods goods1 = new Goods("egg", 5);
            Goods goods2 = new Goods("milk", 15.6);
            Goods goods3 = new Goods("rice", 2.5);
            Goods goods4 = new Goods("apple", 2.3);

            //定义三个订单
            Order order1 = new Order(01, client1);//订单号，客户，自动产生创建时间
            order1.AddDetails(new OrderDetails(goods1, 5));//货物名，个数
            order1.AddDetails(new OrderDetails(goods2, 10));

            Order order2 = new Order(02, client2);
            order2.AddDetails(new OrderDetails(goods1, 6));
            order2.AddDetails(new OrderDetails(goods2, 10));
            order2.AddDetails(new OrderDetails(goods3, 2));

            Order order3 = new Order(03, client2);
            order3.AddDetails(new OrderDetails(goods1, 10));
            //order3.AddDetails(new OrderDetails(goods2, 10));//检测是否能添加同名货物
            order3.AddDetails(new OrderDetails(goods3, 2));

            //订单服务
            OrderService orders = new OrderService();//创建订单序列
            orders.AddOrder(order1);//添加订单
            orders.AddOrder(order2);
            orders.AddOrder(order3);

            Console.WriteLine("\n所有订单：");
            List<Order> allOrder = orders.Query(); 
            allOrder.ForEach (o => Console.WriteLine(o)) ;

            //删除订单
            Console.WriteLine("\n删除ID=01的订单");
            orders.SubOrder(01);
            Console.WriteLine("所有订单：");
            List<Order> allOrder1 = orders.Query();
            allOrder1.ForEach(o => Console.WriteLine(o));

            //修改订单
            Order order2_1 = new Order(02, client2);
            order2_1.AddDetails(new OrderDetails(goods1, 6));
            order2_1.AddDetails(new OrderDetails(goods2, 10));
            orders.ModifyOrder(order2_1);

            Console.WriteLine("\n查询前所有订单：");
            List<Order> OrderXML = orders.Query();
            OrderXML.ForEach(o => Console.WriteLine(o));

            //依照订单号查询
            Console.WriteLine("\n查询订单号02");
            List<Order> QueryOrder = orders.QueryByID(02);
            QueryOrder.ForEach(o => Console.WriteLine(o));
            

            //依照商品名查询
            Console.WriteLine("\n包含rice的订单");
            List<Order> OrderByGN = orders.QueryByGoodsName("rice");
            OrderByGN.ForEach(o => Console.WriteLine(o));
            Console.WriteLine("\n包含apple的订单");
            List<Order> OrderByGN_1 = orders.QueryByGoodsName("apple");
            OrderByGN_1.ForEach(o => Console.WriteLine(o));

            //依照客户名查询
            Console.WriteLine("\n查询客户zhao");
            QueryOrder = orders.QueryByClientName("zhao");
            QueryOrder.ForEach(o => Console.WriteLine(o));

            //依照订单总金额查询
            Console.WriteLine("\n查询总金额186");
            QueryOrder = orders.QueryByAmount(186);
            QueryOrder.ForEach(o => Console.WriteLine(o));

            //序列化
            Console.WriteLine("\n订单序列化为XML文件");
            orders.Export("OrderService.xml");

            //文件读入
            Console.WriteLine("\n载入XML文件");
            orders.Import("OrderList.xml");

            Console.WriteLine("\n所有订单：");
            //List<Order> Order_2 = orders.Query();
            orders.OrderList.ForEach(o => Console.WriteLine(o));
        }
    }
}
