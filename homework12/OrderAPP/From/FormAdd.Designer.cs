
namespace OrderAPP
{
    partial class FormAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView_details = new System.Windows.Forms.DataGridView();
            this.bds_Order = new System.Windows.Forms.BindingSource(this.components);
            this.bds_Details = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_esc = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_sub = new System.Windows.Forms.Button();
            this.btn_count = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.bds_Clients = new System.Windows.Forms.BindingSource(this.components);
            this.clientName = new System.Windows.Forms.Label();
            this.comboBox_clientName = new System.Windows.Forms.ComboBox();
            this.comboBox_Address = new System.Windows.Forms.ComboBox();
            this.address = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.label_Creat = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.goodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_details)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_Order)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_Details)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bds_Clients)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView_details);
            this.panel1.Location = new System.Drawing.Point(-8, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(447, 208);
            this.panel1.TabIndex = 6;
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
            this.dataGridView_details.DataSource = this.bds_Details;
            this.dataGridView_details.Location = new System.Drawing.Point(11, 3);
            this.dataGridView_details.Name = "dataGridView_details";
            this.dataGridView_details.ReadOnly = true;
            this.dataGridView_details.RowTemplate.Height = 23;
            this.dataGridView_details.Size = new System.Drawing.Size(433, 205);
            this.dataGridView_details.TabIndex = 1;
            // 
            // bds_Order
            // 
            this.bds_Order.DataSource = typeof(订单管理.Order);
            // 
            // bds_Details
            // 
            this.bds_Details.DataMember = "Details";
            this.bds_Details.DataSource = this.bds_Order;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_esc);
            this.panel2.Controls.Add(this.btn_add);
            this.panel2.Controls.Add(this.btn_sub);
            this.panel2.Controls.Add(this.btn_count);
            this.panel2.Controls.Add(this.btn_save);
            this.panel2.Location = new System.Drawing.Point(445, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(181, 208);
            this.panel2.TabIndex = 7;
            // 
            // btn_esc
            // 
            this.btn_esc.Location = new System.Drawing.Point(34, 135);
            this.btn_esc.Name = "btn_esc";
            this.btn_esc.Size = new System.Drawing.Size(121, 23);
            this.btn_esc.TabIndex = 6;
            this.btn_esc.Text = "取  消";
            this.btn_esc.UseVisualStyleBackColor = true;
            this.btn_esc.Click += new System.EventHandler(this.btn_esc_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(53, 12);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(82, 23);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "添加货品";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_sub
            // 
            this.btn_sub.Location = new System.Drawing.Point(53, 46);
            this.btn_sub.Name = "btn_sub";
            this.btn_sub.Size = new System.Drawing.Size(82, 23);
            this.btn_sub.TabIndex = 4;
            this.btn_sub.Text = "删除货品";
            this.btn_sub.UseVisualStyleBackColor = true;
            this.btn_sub.Click += new System.EventHandler(this.btn_sub_Click);
            // 
            // btn_count
            // 
            this.btn_count.Location = new System.Drawing.Point(53, 81);
            this.btn_count.Name = "btn_count";
            this.btn_count.Size = new System.Drawing.Size(82, 23);
            this.btn_count.TabIndex = 3;
            this.btn_count.Text = "修改数量";
            this.btn_count.UseVisualStyleBackColor = true;
            this.btn_count.Click += new System.EventHandler(this.btn_count_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(34, 173);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(121, 23);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "保  存";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // bds_Clients
            // 
            this.bds_Clients.DataSource = typeof(订单管理.Client);
            // 
            // clientName
            // 
            this.clientName.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.clientName.Location = new System.Drawing.Point(314, 0);
            this.clientName.Name = "clientName";
            this.clientName.Size = new System.Drawing.Size(87, 23);
            this.clientName.TabIndex = 1;
            this.clientName.Text = "客户名：";
            this.clientName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox_clientName
            // 
            this.comboBox_clientName.DataSource = this.bds_Clients;
            this.comboBox_clientName.DisplayMember = "Name";
            this.comboBox_clientName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_clientName.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox_clientName.FormattingEnabled = true;
            this.comboBox_clientName.Location = new System.Drawing.Point(407, 3);
            this.comboBox_clientName.Name = "comboBox_clientName";
            this.comboBox_clientName.Size = new System.Drawing.Size(166, 20);
            this.comboBox_clientName.TabIndex = 10;
            // 
            // comboBox_Address
            // 
            this.comboBox_Address.DataSource = this.bds_Clients;
            this.comboBox_Address.DisplayMember = "Address";
            this.comboBox_Address.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Address.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox_Address.FormattingEnabled = true;
            this.comboBox_Address.Location = new System.Drawing.Point(407, 47);
            this.comboBox_Address.Name = "comboBox_Address";
            this.comboBox_Address.Size = new System.Drawing.Size(166, 20);
            this.comboBox_Address.TabIndex = 11;
            // 
            // address
            // 
            this.address.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.address.Location = new System.Drawing.Point(314, 44);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(87, 23);
            this.address.TabIndex = 2;
            this.address.Text = "客户住址：";
            this.address.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // time
            // 
            this.time.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.time.Location = new System.Drawing.Point(3, 44);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(87, 23);
            this.time.TabIndex = 5;
            this.time.Text = "创建时间：";
            this.time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Creat
            // 
            this.label_Creat.Location = new System.Drawing.Point(96, 44);
            this.label_Creat.Name = "label_Creat";
            this.label_Creat.Size = new System.Drawing.Size(168, 23);
            this.label_Creat.TabIndex = 9;
            this.label_Creat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ID
            // 
            this.ID.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ID.Location = new System.Drawing.Point(3, 0);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(87, 23);
            this.ID.TabIndex = 0;
            this.ID.Text = "订单号：";
            this.ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.Controls.Add(this.ID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.time, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.address, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBox_Address, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBox_clientName, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.clientName, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_Creat, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox_ID, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(623, 88);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // textBox_ID
            // 
            this.textBox_ID.Enabled = false;
            this.textBox_ID.Location = new System.Drawing.Point(96, 3);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(168, 21);
            this.textBox_ID.TabIndex = 12;
            // 
            // goodDataGridViewTextBoxColumn
            // 
            this.goodDataGridViewTextBoxColumn.DataPropertyName = "Good";
            this.goodDataGridViewTextBoxColumn.HeaderText = "Good";
            this.goodDataGridViewTextBoxColumn.Name = "goodDataGridViewTextBoxColumn";
            this.goodDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "Count";
            this.countDataGridViewTextBoxColumn.HeaderText = "Count";
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            this.countDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valueDataGridViewTextBoxColumn
            // 
            this.valueDataGridViewTextBoxColumn.DataPropertyName = "Value";
            this.valueDataGridViewTextBoxColumn.HeaderText = "Value";
            this.valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
            this.valueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 314);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FormAdd";
            this.Text = "新订单信息";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_details)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_Order)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_Details)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bds_Clients)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingSource bds_Clients;
        private System.Windows.Forms.Label clientName;
        private System.Windows.Forms.ComboBox comboBox_clientName;
        private System.Windows.Forms.ComboBox comboBox_Address;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label label_Creat;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_sub;
        private System.Windows.Forms.Button btn_count;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.BindingSource bds_Details;
        private System.Windows.Forms.DataGridView dataGridView_details;
        private System.Windows.Forms.Button btn_esc;
        private System.Windows.Forms.BindingSource bds_Order;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
    }
}