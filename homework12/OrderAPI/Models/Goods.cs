using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace OrderManage.Models
{
    [Serializable]
    public class Goods//货物信息
    {
        [Key]
        public string Name{ get; set; }//货物名称
        public double Price{ get; set; }//货物单价

        public Goods() { }
        public Goods(string name,double price)
        {
            if(price<0)
            {
                Console.WriteLine("price should >=0");

            }
            else
            {
                this.Name = name;
                this.Price = price;
            }
        }
        public override bool Equals(object obj)
        {
            Goods goods = obj as Goods;
            return goods != null
                && goods.Name == Name && goods.Price == Price;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()//作用：把对象用字符串表示
        {
            return $"{Name}";
        }
    }
}
