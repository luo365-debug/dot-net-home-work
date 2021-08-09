using System;
using 订单管理;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderAPP
{
    public partial class FormDetails : Form
    {
        List<Goods> goods = new List<Goods>();
        public OrderDetails myDetails=new OrderDetails();
        Order myOrder = new Order();
        public FormDetails(bool enable, OrderDetails detail,Order order)
        {
            InitializeComponent();

            comboBox_GoodsName.Enabled = enable;
            comboBox_price.Enabled = enable;

            this.myDetails = detail;
            this.myOrder = order;

            //定义五种货物
            Goods apple = new Goods("apple", 2.1);
            Goods egg = new Goods("egg", 5);
            Goods milk = new Goods("milk", 15.6);
            Goods rice = new Goods("rice", 2.5);
            Goods pear = new Goods("pear", 2.7);
            goods.Add(apple);   goods.Add(egg);
            goods.Add(milk);    goods.Add(rice);
            goods.Add(pear);
            bds_Goods.DataSource = goods;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if(comboBox_GoodsName.Enabled)
                myDetails.Good = (Goods)bds_Goods.Current;
            myDetails.Count = int.Parse(textBox_count.Text);

            //myOrder.AddDetails(myDetails);

            this.Close();
        }
    }
}
