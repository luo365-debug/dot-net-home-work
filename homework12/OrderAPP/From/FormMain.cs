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
    public partial class OrderAPP : Form
    {
        OrderService testService;

        public OrderAPP()
        {
            InitializeComponent();
            //定义三个客户
            Client client1 = new Client("赵", "BeiJing");
            Client client2 = new Client("钱", "WuHan");
            Client client3 = new Client("孙", "ShangHai");
            Client client4 = new Client("李", "Shenzhen");

            //定义五种货物
            Goods apple = new Goods("apple", 2.1);
            Goods egg = new Goods("egg", 5);
            Goods milk = new Goods("milk", 15.6);
            Goods rice = new Goods("rice", 2.5);
            Goods pear = new Goods("pear", 2.7);

            //创建一个订单序列
           testService = new OrderService();

                //创建三个个订单并加入序列
                Order testOrder1, testOrder2, testOrder3;
                testOrder1 = new Order(01, client1);//总金额113.5
                testOrder1.AddDetails(new OrderDetails(apple, 5));
                testOrder1.AddDetails(new OrderDetails(egg, 5));
                testOrder1.AddDetails(new OrderDetails(milk, 5));
                testService.AddOrder(testOrder1);

                testOrder2 = new Order(02, client2);//总金额104.2
                testOrder2.AddDetails(new OrderDetails(apple, 7));
                testOrder2.AddDetails(new OrderDetails(egg, 8));
                testOrder2.AddDetails(new OrderDetails(rice, 9));
                testOrder2.AddDetails(new OrderDetails(pear, 10));
                testService.AddOrder(testOrder2);

                testOrder3 = new Order(03, client3);//总金额108
                testOrder3.AddDetails(new OrderDetails(milk, 5));
                testOrder3.AddDetails(new OrderDetails(rice, 12));
                testService.AddOrder(testOrder3);

            comboBox_query.SelectedIndex = 0;

            bindingSource_Order.DataSource = testService.Query();
        }

        private void button_query_Click(object sender, EventArgs e)
        {
            switch (comboBox_query.SelectedIndex)
            {
                case 0://所有订单
                    bindingSource_Order.DataSource = testService.Query();
                    break;
                case 1://根据ID查询 ID唯一
                    int.TryParse(textBox_query.Text, out int id);
                    bindingSource_Order.DataSource = testService.QueryByID(id);
                    if (testService.QueryByID(id).Count == 0)
                    {
                        MessageBox.Show("该订单号不存在");
                    }
                    break;
                case 2://根据客户名查询
                    bindingSource_Order.DataSource = testService.QueryByClientName(textBox_query.Text);
                    if (testService.QueryByClientName(textBox_query.Text).Count == 0)
                    {
                        MessageBox.Show("该客户未下单");
                    }
                    break;
                case 3://根据货物查询
                    bindingSource_Order.DataSource = testService.QueryByGoodsName(textBox_query.Text);
                    if (testService.QueryByGoodsName(textBox_query.Text).Count == 0)
                    {
                        MessageBox.Show("无客户需求此货品");
                    }
                    break;
                case 4://根据总价格查询
                    float.TryParse(textBox_query.Text, out float totalPrice);
                    bindingSource_Order.DataSource =
                           testService.QueryByAmount(totalPrice);
                    break;
            }
            bindingSource_Order.ResetBindings(false);

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAdd form2 = new FormAdd(testService, new Order(), true);
            form2.ShowDialog();
            bindingSource_Order.DataSource = testService.OrderList;
            //testService.OrderList.Add(form2.newOrder);
            bindingSource_Order.ResetBindings(false);
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            Order order = bindingSource_Order.Current as Order;//当前bds.List属性
            if (order == null)
            {
                MessageBox.Show("系统暂无订单");//提示框
                return;
            }

            testService.SubOrder(order.ID);
            bindingSource_Order.DataSource = testService.OrderList;
            bindingSource_Order.ResetBindings(false);
            //使绑定到 BindingSource 的控件重新读取列表中的所有项，并刷新这些项的显示值。
            //如果数据架构已更改，则为 true；如果只有值发生了更改，则为 false

        }

        private void buttonMod_Click(object sender, EventArgs e)
        {
            Order order = bindingSource_Order.Current as Order;
            if (order == null)
            {
                MessageBox.Show("未选中修改订单");//提示框
                return;
            }
            FormAdd form2 = new FormAdd(testService,order,false);
            form2.ShowDialog();
            bindingSource_Order.DataSource = testService.OrderList;
            bindingSource_Order.ResetBindings(false);
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result.Equals(DialogResult.OK))
            {
                String fileName = openFileDialog1.FileName;
                testService.Import(fileName);
                bindingSource_Order.DataSource = testService.OrderList;
                bindingSource_Order.ResetBindings(false);
            }
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result.Equals(DialogResult.OK))
            {
                String fileName = saveFileDialog1.FileName;
                testService.Export(fileName);
            }
        }
    }
}
