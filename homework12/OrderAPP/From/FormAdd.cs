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
    public partial class FormAdd : Form
    {
        OrderService Orders = new OrderService();//主界面订单序列
        List<Client> testClient=new List<Client>();
        public Order newOrder = new Order();//当前界面生成的订单
        bool isExist;//已存在为修改，未存在为添加

        public FormAdd(OrderService testService,Order o,bool enable)
        {
            InitializeComponent();

            this.Orders = testService;

            textBox_ID.Text = o.ID.ToString();
            textBox_ID.Enabled = enable;

            isExist = !enable;

            newOrder = o;
            bds_Order.DataSource = newOrder;

            testClient.Add(new Client("赵", "BeiJing"));
            testClient.Add(new Client("钱", "WuHan"));
            testClient.Add(new Client("孙", "ShangHai"));
            testClient.Add(new Client("李", "Shenzhen"));
            bds_Clients.DataSource = testClient;

            label_Creat.Text = DateTime.Now.ToString();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            newOrder.Creat = DateTime.Now;
            newOrder.Customer = new Client(comboBox_clientName.Text, comboBox_Address.Text);

            if (!isExist) { Orders.AddOrder(newOrder); }//新订单号使用添加
            else//订单号已存在，替换原订单
            {
                Orders.ModifyOrder(newOrder);
            }
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            FormDetails det = new FormDetails(true,new OrderDetails(),newOrder);
            det.ShowDialog();
            newOrder.AddDetails(det.myDetails);//此时det.myDetails为0 0 {}，检验能添加后进入}
            bds_Order.DataSource = newOrder;
            bds_Details.DataSource = newOrder.Details;
            bds_Order.ResetBindings(false);
            bds_Details.ResetBindings(false);
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            OrderDetails det = bds_Details.Current as OrderDetails;
            if (det == null)
            {
                MessageBox.Show("未选中待删除明细");
                return;
            }
            newOrder.Details.Remove(det);
            bds_Details.DataSource = newOrder.Details;
            bds_Details.ResetBindings(false);
        }

        private void btn_count_Click(object sender, EventArgs e)
        {
            OrderDetails ordet = bds_Details.Current as OrderDetails;
            FormDetails det = new FormDetails(false, ordet, newOrder);
            det.ShowDialog();
            bds_Details.DataSource = newOrder.Details;
            bds_Details.ResetBindings(false);
        }

        private void btn_esc_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
