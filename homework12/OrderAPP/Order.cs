using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;//details.Sum

namespace 订单管理
{
    [Serializable]
    public class Order:IComparable<Order>//订单
    {
        public int ID { get; set; }//订单号
        public DateTime Creat { get; set; }//订单创建时间

        public List<OrderDetails> Details { get; set; } = new List<OrderDetails>();//订单明细,包含货物名、单价、数量
        public Client Customer { get; set; }//客户信息
        public double Amount//总金额
        {
            get => Details.Sum(d => d.Value);
        }

        public Order() { }
        public Order(int id, Client customer)
        {
            this.ID = id;
            this.Customer = customer;
            Creat = DateTime.Now;
        }

        public void AddDetails(OrderDetails obj)//新增订单细节，包括货物名，数量
        {
            bool isExist = false;
            foreach (var data in Details)
            {
                //if (obj.Equals(data))
                if(obj.Good.Name==data.Good.Name)
                {
                    isExist = true;//该类货品已存在
                    throw new ApplicationException($"待添加货品{obj.Good.Name}已存在");
                }
            }
            if (!isExist)//符合条件可以添加
            {
                Details.Add(obj);
            }
        }

        public void SubDetails(OrderDetails obj)
        {

        }
        public override string ToString()//用于显示订单信息
        {
            string order = $"Order 订单号:{ID} 客户:{Customer} 总金额:{Amount}";
            Details.ForEach(d => order += "\n\t" + d);
            return order;
        }
        public override bool Equals(object obj)//确保添加订单不重复
        {
            Order ord = obj as Order;
            return ord!=null
                &&ord.ID==ID&&ord.Details==Details&&ord.Customer == Customer &&ord.Amount==Amount;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public int CompareTo(Order other)
        {
            if (other == null) return 1;
            return ID - other.ID;
        }
    }
}
