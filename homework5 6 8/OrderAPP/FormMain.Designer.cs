
namespace OrderAPP
{
    partial class OrderAPP
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel_control = new System.Windows.Forms.Panel();
            this.buttonExport = new System.Windows.Forms.Button();
            this.buttonImport = new System.Windows.Forms.Button();
            this.buttonMod = new System.Windows.Forms.Button();
            this.buttonSub = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.button_query = new System.Windows.Forms.Button();
            this.textBox_query = new System.Windows.Forms.TextBox();
            this.comboBox_query = new System.Windows.Forms.ComboBox();
            this.panel_order = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView_Order = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource_Order = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView_details = new System.Windows.Forms.DataGridView();
            this.bindingSource_details = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.goodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_control.SuspendLayout();
            this.panel_order.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Order)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_Order)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_details)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_details)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_control
            // 
            this.panel_control.Controls.Add(this.buttonExport);
            this.panel_control.Controls.Add(this.buttonImport);
            this.panel_control.Controls.Add(this.buttonMod);
            this.panel_control.Controls.Add(this.buttonSub);
            this.panel_control.Controls.Add(this.buttonAdd);
            this.panel_control.Controls.Add(this.button_query);
            this.panel_control.Controls.Add(this.textBox_query);
            this.panel_control.Controls.Add(this.comboBox_query);
            this.panel_control.Location = new System.Drawing.Point(1, 1);
            this.panel_control.Name = "panel_control";
            this.panel_control.Size = new System.Drawing.Size(911, 129);
            this.panel_control.TabIndex = 0;
            // 
            // buttonExport
            // 
            this.buttonExport.Location = new System.Drawing.Point(611, 82);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(95, 23);
            this.buttonExport.TabIndex = 7;
            this.buttonExport.Text = "导出订单";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // buttonImport
            // 
            this.buttonImport.Location = new System.Drawing.Point(468, 82);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(95, 23);
            this.buttonImport.TabIndex = 6;
            this.buttonImport.Text = "导入订单";
            this.buttonImport.UseVisualStyleBackColor = true;
            this.buttonImport.Click += new System.EventHandler(this.buttonImport_Click);
            // 
            // buttonMod
            // 
            this.buttonMod.Location = new System.Drawing.Point(310, 82);
            this.buttonMod.Name = "buttonMod";
            this.buttonMod.Size = new System.Drawing.Size(95, 23);
            this.buttonMod.TabIndex = 5;
            this.buttonMod.Text = "修改订单";
            this.buttonMod.UseVisualStyleBackColor = true;
            this.buttonMod.Click += new System.EventHandler(this.buttonMod_Click);
            // 
            // buttonSub
            // 
            this.buttonSub.Location = new System.Drawing.Point(167, 82);
            this.buttonSub.Name = "buttonSub";
            this.buttonSub.Size = new System.Drawing.Size(95, 23);
            this.buttonSub.TabIndex = 4;
            this.buttonSub.Text = "删除订单";
            this.buttonSub.UseVisualStyleBackColor = true;
            this.buttonSub.Click += new System.EventHandler(this.buttonSub_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(20, 82);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(95, 23);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "添加订单";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // button_query
            // 
            this.button_query.Location = new System.Drawing.Point(468, 21);
            this.button_query.Name = "button_query";
            this.button_query.Size = new System.Drawing.Size(75, 23);
            this.button_query.TabIndex = 2;
            this.button_query.Text = "查  询";
            this.button_query.UseVisualStyleBackColor = true;
            this.button_query.Click += new System.EventHandler(this.button_query_Click);
            // 
            // textBox_query
            // 
            this.textBox_query.Location = new System.Drawing.Point(167, 21);
            this.textBox_query.Name = "textBox_query";
            this.textBox_query.Size = new System.Drawing.Size(256, 21);
            this.textBox_query.TabIndex = 1;
            // 
            // comboBox_query
            // 
            this.comboBox_query.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_query.FormattingEnabled = true;
            this.comboBox_query.Items.AddRange(new object[] {
            "全部",
            "ID",
            "客户名",
            "货品名",
            "总金额"});
            this.comboBox_query.Location = new System.Drawing.Point(20, 21);
            this.comboBox_query.Name = "comboBox_query";
            this.comboBox_query.Size = new System.Drawing.Size(121, 20);
            this.comboBox_query.TabIndex = 0;
            // 
            // panel_order
            // 
            this.panel_order.Controls.Add(this.splitContainer1);
            this.panel_order.Location = new System.Drawing.Point(1, 136);
            this.panel_order.Name = "panel_order";
            this.panel_order.Size = new System.Drawing.Size(911, 276);
            this.panel_order.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView_Order);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView_details);
            this.splitContainer1.Size = new System.Drawing.Size(911, 276);
            this.splitContainer1.SplitterDistance = 556;
            this.splitContainer1.TabIndex = 2;
            // 
            // dataGridView_Order
            // 
            this.dataGridView_Order.AllowUserToAddRows = false;
            this.dataGridView_Order.AutoGenerateColumns = false;
            this.dataGridView_Order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Order.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.creatDataGridViewTextBoxColumn,
            this.customerDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn});
            this.dataGridView_Order.DataSource = this.bindingSource_Order;
            this.dataGridView_Order.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView_Order.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Order.Name = "dataGridView_Order";
            this.dataGridView_Order.RowTemplate.Height = 23;
            this.dataGridView_Order.RowTemplate.ReadOnly = true;
            this.dataGridView_Order.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Order.Size = new System.Drawing.Size(556, 276);
            this.dataGridView_Order.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "订单号";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // creatDataGridViewTextBoxColumn
            // 
            this.creatDataGridViewTextBoxColumn.DataPropertyName = "Creat";
            this.creatDataGridViewTextBoxColumn.HeaderText = "创建时间";
            this.creatDataGridViewTextBoxColumn.Name = "creatDataGridViewTextBoxColumn";
            // 
            // customerDataGridViewTextBoxColumn
            // 
            this.customerDataGridViewTextBoxColumn.DataPropertyName = "Customer";
            this.customerDataGridViewTextBoxColumn.HeaderText = "客户信息";
            this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            this.customerDataGridViewTextBoxColumn.Width = 200;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "总金额";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bindingSource_Order
            // 
            this.bindingSource_Order.DataSource = typeof(订单管理.Order);
            // 
            // dataGridView_details
            // 
            this.dataGridView_details.AllowUserToAddRows = false;
            this.dataGridView_details.AutoGenerateColumns = false;
            this.dataGridView_details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_details.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.goodDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn,
            this.valueDataGridViewTextBoxColumn});
            this.dataGridView_details.DataSource = this.bindingSource_details;
            this.dataGridView_details.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView_details.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_details.Name = "dataGridView_details";
            this.dataGridView_details.RowTemplate.Height = 23;
            this.dataGridView_details.Size = new System.Drawing.Size(351, 276);
            this.dataGridView_details.TabIndex = 0;
            // 
            // bindingSource_details
            // 
            this.bindingSource_details.DataMember = "Details";
            this.bindingSource_details.DataSource = this.bindingSource_Order;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Customer";
            this.dataGridViewTextBoxColumn1.HeaderText = "客户信息";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "order";
            this.saveFileDialog1.Filter = "XML Files (*.xml)|*.xml";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "XML Files (*.xml)|*.xml";
            // 
            // goodDataGridViewTextBoxColumn
            // 
            this.goodDataGridViewTextBoxColumn.DataPropertyName = "Good";
            this.goodDataGridViewTextBoxColumn.HeaderText = "货品名";
            this.goodDataGridViewTextBoxColumn.Name = "goodDataGridViewTextBoxColumn";
            this.goodDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "Count";
            this.countDataGridViewTextBoxColumn.HeaderText = "数量";
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            this.countDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valueDataGridViewTextBoxColumn
            // 
            this.valueDataGridViewTextBoxColumn.DataPropertyName = "Value";
            this.valueDataGridViewTextBoxColumn.HeaderText = "总价";
            this.valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
            this.valueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // OrderAPP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 411);
            this.Controls.Add(this.panel_order);
            this.Controls.Add(this.panel_control);
            this.Name = "OrderAPP";
            this.Text = "OrderAPP";
            this.panel_control.ResumeLayout(false);
            this.panel_control.PerformLayout();
            this.panel_order.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Order)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_Order)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_details)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_details)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_control;
        private System.Windows.Forms.Panel panel_order;
        private System.Windows.Forms.ComboBox comboBox_query;
        private System.Windows.Forms.TextBox textBox_query;
        private System.Windows.Forms.Button button_query;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSub;
        private System.Windows.Forms.Button buttonMod;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Button buttonImport;
        private System.Windows.Forms.BindingSource bindingSource_Order;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView_Order;
        private System.Windows.Forms.DataGridView dataGridView_details;
        private System.Windows.Forms.BindingSource bindingSource_details;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
    }
}

