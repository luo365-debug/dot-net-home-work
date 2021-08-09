using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;//orderList.where()
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
//using Sean.Core.SnowFlake;


namespace 订单管理
{
    public class OrderService//订单服务
    {
        //一个list表示所有已有订单信息
        public List<Order> OrderList = new List<Order>();//readonly声明只读字段

        //使用数据库记录所有订单信息
        public OrderService()
        {
            try
            {
                using (var OrderList = new Context())
                {
                    if (OrderList.Goods.Count() == 0)//数据库为空则添加数据
                    {
                        OrderList.Goods.Add(new Goods("apple", 2.1));
                        OrderList.Goods.Add(new Goods("egg", 5));
                        OrderList.Goods.Add(new Goods("milk", 15.6));
                        OrderList.Goods.Add(new Goods("rice", 2.5));
                        OrderList.Goods.Add(new Goods("pear", 2.7));
                        OrderList.SaveChanges();
                    }
                    if (OrderList.Customers.Count() == 0)
                    {
                        OrderList.Customers.Add(new Client("赵", "BeiJing"));
                        OrderList.Customers.Add(new Client("钱", "WuHan"));
                        OrderList.Customers.Add(new Client("孙", "ShangHai"));
                        OrderList.Customers.Add(new Client("李", "Shenzhen"));
                        OrderList.SaveChanges();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("添加失败!");
                Console.WriteLine(e.Message);
            }
        }
        


        //OrderService提供排序方法对保存的订单进行排序。默认按照订单号排序，也可以使用Lambda表达式进行自定义排序。
        public void AddOrder(Order node)//新增订单
        {
            using (var OrderList = new Context())
            {
                var order = OrderList.Orders.FirstOrDefault(p => p.ID == node.ID);//遍历
                if (order != null)//该订单号存在
                {
                    throw new ApplicationException($"待添加订单{node.ID}已存在");
                }
                else
                {
                    OrderList.Orders.Add(node);
                    OrderList.SaveChanges();
                }
            }
        }
        public void SubOrder(int id)//删除订单
        {
            using (var OrderList = new Context())
            {
                var order = OrderList.Orders.FirstOrDefault(p => p.ID == id);//遍历
                if (order != null)//该订单号存在
                {
                    OrderList.Orders.Remove(order);
                    return OrderList.SaveChanges();
                }
                else
                {
                    throw new ApplicationException($"待删订单{id}不存在"); //报异常，待删订单不存在
                }
            }
        }
        public void ModifyOrder(Order order)//修改订单信息
        {
            using (var OrderList = new Context())
            {
                var curOrder = OrderList.Orders.FirstOrDefault(p => p.ID == order.ID);

                if (curOrder != null)
                {
                    OrderList.Orders.Remove(curOrder);
                    OrderList.Orders.Add(order);
                    return OrderList.SaveChanges();
                }
                else
                {
                    throw new ApplicationException($"待修改订单{order.ID}不存在");
                }
            }
        }

        //查询订单（按照订单号、商品名称、客户、订单金额等进行查询）
        //public List<Order> Query()
        //{
        //    return OrderList;
        //}
        public List<Order> QueryByID(int id)//依照订单号查询
        {
            using (var dbo = new Context())
            {
                var queryList=dbo.Where(o => o.OrderId == id);
                return queryList.ToList();
            }
        }
        public List<Order> QueryByGoodsName(string goodsname)//依照商品名查询
        {
            using (var dbo = new Context())
            {
                var queryList = dbo.Where(o => o.Details.Any(d => d.Good.Name == goodsname));//List<OrderDetails>
                return queryList.ToList();
            }
            
        }
        public List<Order> QueryByClientName(string clientname)//依照客户名查询
        {
            using (var dbo = new Context())
            {
                var queryList = dbo.Where(o => o.Customer.Name == clientname);
                return queryList.ToList();
            }

        }
        public List<Order> QueryByAmount(double amount)//依照订单总金额查询
        {
            using (var dbo = new Context())
            {
                var queryList = dbo.Where(o => o.Amount == amount);
                return queryList.ToList();
            }

        }



        public void Export(string filename)//可以将所有的订单序列化为XML文件
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                xmlSerializer.Serialize(fs, OrderList);
            }
        }
        public void Import(string filePath)//方法可以从XML文件中载入订单
        {
            if (filePath != null)
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
                using (FileStream fs = new FileStream(filePath, FileMode.Open))
                {
                    OrderList = (List<Order>)xmlSerializer.Deserialize(fs);
                    OrderList.ForEach(
                        o =>
                        {
                            if (!OrderList.Contains(o)) { OrderList.Add(o); }//判断OrderList内是否有重复
                        }
                        );
                }
            }
        }

    }
        
}
