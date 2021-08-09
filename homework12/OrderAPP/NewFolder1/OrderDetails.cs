using System;
using System.Collections.Generic;
using System.Text;

namespace 订单管理
{
    [Serializable]
    public class OrderDetails//订单明细
    {
        public Goods Good { get; set; }
        public int Count { get; set; }//订货数量
        public double Value { get => Good.Price * Count; }//该类货物总价

        public OrderDetails() { this.Good = new Goods(); this.Count = 0; }
        public OrderDetails (Goods good,int count)
        {
            this.Good = good;
            this.Count = count;
        }
        public override string ToString()
        {
            return $"订单明细 货物信息:{Good} 数量:{Count}";
        }
        public override bool Equals(object obj)
        {
            OrderDetails details = obj as OrderDetails;
            return details != null
                && details.Good==Good&& details.Count==Count;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
