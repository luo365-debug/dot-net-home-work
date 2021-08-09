using Microsoft.VisualStudio.TestTools.UnitTesting;
using 订单管理;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;//List<Order>.Count
using System.IO;//File

namespace 订单管理.OrderServiceTests
{
    [TestClass()]
    public class OrderServiceTests
    {
            //定义三个客户
            Client client1 = new Client("zhao", "BeiJing");
            Client client2 = new Client("qian", "WuHan");
            Client client3 = new Client("sun", "ShangHai");

            //定义五种货物
            Goods apple=new Goods("apple",2.1);
            Goods egg = new Goods("egg", 5);
            Goods milk = new Goods("milk", 15.6);
            Goods rice = new Goods("rice", 2.5);
            Goods pear = new Goods("pear", 2.7);

            //创建一个订单序列
            OrderService testService=new OrderService();

        Order testOrder1, testOrder2, testOrder3,testOrder4;

        [TestInitialize]
        public void Init()
        {
            testService=new OrderService();
            //创建三个个订单并加入序列
            testOrder1=new Order(01, client1);//总金额113.5
            testOrder1.AddDetails(new OrderDetails(apple, 5));
            testOrder1.AddDetails(new OrderDetails(egg, 5));
            testOrder1.AddDetails(new OrderDetails(milk, 5));
            testService.AddOrder(testOrder1);

            testOrder2=new Order(02, client2);
            testOrder2.AddDetails(new OrderDetails(apple, 10));
            testOrder2.AddDetails(new OrderDetails(egg, 10));
            testOrder2.AddDetails(new OrderDetails(rice, 10));
            testService.AddOrder(testOrder2);

            testOrder3=new Order(03, client3);
            testOrder3.AddDetails(new OrderDetails(milk, 5));
            testOrder3.AddDetails(new OrderDetails(egg, 10));
            testOrder3.AddDetails(new OrderDetails(rice, 5));
            testService.AddOrder(testOrder3);

            testOrder4 = new Order(04, client1);//不加入订单序列
            testOrder4.AddDetails(new OrderDetails(apple, 10));
            testOrder4.AddDetails(new OrderDetails(milk, 10));
            testOrder4.AddDetails(new OrderDetails(rice, 10));

            //testService.Export("expectedOrders.xml");
        }


        [TestMethod()]
        public void AddOrderOrderServiceTest()
        {
            testService.AddOrder(testOrder4);//添加新订单
            List<Order> result = testService.Query();
            Assert.AreEqual(4, result.Count);
        }

        [TestMethod()]
        public void SubOrderOrderServiceTest()
        {
            //删除已有订单
            testService.SubOrder(01);
            List<Order> result = testService.Query();
            Assert.AreEqual(2, result.Count);

            //删除订单号不存在
            //testService.SubOrder(05);//报异常
        }

        [TestMethod()]
        public void ModifyOrderOrderServiceTest()
        {
            Order testOrder3_1 = new Order(03, client1);
            testOrder3_1.AddDetails(new OrderDetails(apple, 10));
            testOrder3_1.AddDetails(new OrderDetails(milk, 10));
            testOrder3_1.AddDetails(new OrderDetails(rice, 10));

            testService.ModifyOrder(testOrder3_1);
            List<Order> result = testService.Query();
            Assert.AreEqual(testOrder3_1, result[2]);
        }

        [TestMethod()]
        public void QueryOrderServiceTest()
        {
            List<Order> result = testService.Query();
            Assert.AreEqual(3, result.Count);
            Assert.AreEqual(testOrder1, result[0]);
            Assert.AreEqual(testOrder2, result[1]);
            Assert.AreEqual(testOrder3, result[2]);
        }

        [TestMethod()]
        public void QueryByIDOrderServiceTest()
        {
            //查找
            List<Order> testOrder1_1 =testService.QueryByID(01);
            Assert.AreEqual(testOrder1_1[0], testService.OrderList[0]);//订单号在序列内唯一
        }

        [TestMethod()]
        public void QueryByGoodsNameOrderServiceTest()
        {
            //查找
            List<Order> result=testService.QueryByGoodsName("apple");//已知1 2号订单包含苹果
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(testOrder1, result[0]);
            Assert.AreEqual(testOrder2, result[1]);
        }

        [TestMethod()]
        public void QueryByClientNameOrderServiceTest()
        {
            //查找
            List<Order> result = testService.QueryByClientName("zhao");//client1
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual(testOrder1, result[0]);
        }

        [TestMethod()]
        public void QueryByAmountOrderServiceTest()
        {
            //Assert.AreEqual(1, testService.QueryByAmount(113.5).Count);//订单01
            Assert.AreEqual(testOrder1, testService.QueryByAmount(113.5)[0]);
        }

        [TestMethod()]
        public void ExportOrderServiceTest()
        {
            testService.Export("testService.xml");
            Assert.IsTrue(File.Exists("testService.xml"));

            File.Delete("testService.xml");
        }

        [TestMethod()]
        public void ImportOrderServiceTest()
        {
            List<Order> expect = testService.Query();
            //testService.Import("../../expectedOrders.xml");//缺少文件
            List<Order> result = testService.Query();
            CollectionAssert.Equals(expect, result);
        }
    }

    
    public class OrderServiceOrderServiceTests
    {           }
}