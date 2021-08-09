using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OrderManage.Models
{
    [Serializable]
    public class Client//客户类
    {
        [Key]
        public string Name { get; set; }//客户名字
        public string Address { get; set; }//客户地址

        public Client() { }

        public Client(string name,string address)
        {
            this.Name = name;
            this.Address = address;
        }
        public override bool Equals(object obj)
        {
            Client cli = obj as Client;
            return cli != null 
                && cli.Name == Name && cli.Address == Address;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()//输出
        {
            return $"客户名:{Name}     地址:{Address}";
            //return $"{Name}";
        }
    }
}
