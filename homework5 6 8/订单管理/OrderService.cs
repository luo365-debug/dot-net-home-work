using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;//orderList.where()
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace 订单管理
{
    public class OrderService//订单服务
    {
        //一个list表示所有已有订单信息
        public readonly List<Order> OrderList = new List<Order>();

        //OrderService提供排序方法对保存的订单进行排序。默认按照订单号排序，也可以使用Lambda表达式进行自定义排序。
        public void AddOrder(Order node)//新增订单
        {
            bool isExist = false;
            foreach (var data in OrderList)
            {
                //if (node.Equals(data))//完全一致则不添加
                if(data.ID==node.ID)//订单号一致则不添加
                {
                    isExist = true;//已存在
                    throw new ApplicationException($"待添加订单{node.ID}已存在");//报异常,结束函数使用
                }
            }
            if (!isExist)//符合条件可以添加
            {
                OrderList.Add(node);
            }
        }
        public void SubOrder(int id)//删除订单，操作失败能产生异常的提示信息
        {
            bool isExist = false;
            for (int i = OrderList.Count - 1; i >= 0; i--)//倒序遍历，自动前移
            {
                if (id == OrderList[i].ID)//找到待删订单
                {
                    isExist = true;
                    OrderList.Remove(OrderList[i]);
                }
            }
            if (!isExist)
                throw new ApplicationException($"待删订单{id}不存在"); //报异常，待删订单不存在
        }
        public void ModifyOrder(Order order)//修改订单信息
        {
            bool isExist = false;
            for (int i = 0; i < OrderList.Count; i++)
            {
                if (order.ID == OrderList[i].ID)//找到订单号相同的已有订单
                {
                    isExist = true;
                    OrderList[i] = order;//替换为新订单
                }
            }
            if (!isExist)
                throw new ApplicationException($"待修改订单{order.ID}不存在");
        }

        //使用LINQ语言实现各种查询功能，查询结果按照订单总金额排序返回?
        //查询订单（按照订单号、商品名称、客户、订单金额等进行查询）
        public List<Order> Query()
        {
            return OrderList;
        }
        public List<Order> QueryByID(int id)//依照订单号查询
        {
            var queryList = OrderList.Where(o => o.ID == id);
            return queryList.ToList();
        }
        public List<Order> QueryByGoodsName(string goodsname)//依照商品名查询
        {
            var queryList = OrderList.Where(o => o.Details.Any(d => d.Good.Name == goodsname));//List<OrderDetails>
            return queryList.ToList();
        }
        public List<Order> QueryByClientName(string clientname)//依照客户名查询
        {
            var queryList = OrderList.Where(o => o.Customer.Name == clientname);
            return queryList.ToList();
        }
        public List<Order> QueryByAmount(double amount)//依照订单总金额查询
        {
            var queryList = OrderList.Where(o => o.Amount == amount);
            return queryList.ToList();
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
                    List<Order> result = (List<Order>)xmlSerializer.Deserialize(fs);
                    //orders.ForEach((x) => OrderList.Add(x));
                    result.ForEach(
                        o =>
                        {
                            if (!result.Contains(o)) { result.Add(o); }
                        }
                        );
                }
            }
        }

    }
}
