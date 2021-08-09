
namespace OrderAPP
{
    partial class FormDetails
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
            this.lbl_GoodsName = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_count = new System.Windows.Forms.Label();
            this.comboBox_GoodsName = new System.Windows.Forms.ComboBox();
            this.bds_Goods = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox_price = new System.Windows.Forms.ComboBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.textBox_count = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bds_Goods)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_GoodsName
            // 
            this.lbl_GoodsName.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_GoodsName.Location = new System.Drawing.Point(13, 26);
            this.lbl_GoodsName.Name = "lbl_GoodsName";
            this.lbl_GoodsName.Size = new System.Drawing.Size(103, 23);
            this.lbl_GoodsName.TabIndex = 0;
            this.lbl_GoodsName.Text = "货品名：";
            this.lbl_GoodsName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_price
            // 
            this.lbl_price.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_price.Location = new System.Drawing.Point(13, 68);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(103, 23);
            this.lbl_price.TabIndex = 1;
            this.lbl_price.Text = "单价：";
            this.lbl_price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_count
            // 
            this.lbl_count.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_count.Location = new System.Drawing.Point(13, 115);
            this.lbl_count.Name = "lbl_count";
            this.lbl_count.Size = new System.Drawing.Size(103, 23);
            this.lbl_count.TabIndex = 2;
            this.lbl_count.Text = "数量：";
            this.lbl_count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox_GoodsName
            // 
            this.comboBox_GoodsName.DataSource = this.bds_Goods;
            this.comboBox_GoodsName.DisplayMember = "Name";
            this.comboBox_GoodsName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_GoodsName.FormattingEnabled = true;
            this.comboBox_GoodsName.Location = new System.Drawing.Point(123, 28);
            this.comboBox_GoodsName.Name = "comboBox_GoodsName";
            this.comboBox_GoodsName.Size = new System.Drawing.Size(177, 20);
            this.comboBox_GoodsName.TabIndex = 3;
            // 
            // bds_Goods
            // 
            this.bds_Goods.DataSource = typeof(订单管理.Goods);
            // 
            // comboBox_price
            // 
            this.comboBox_price.DataSource = this.bds_Goods;
            this.comboBox_price.DisplayMember = "Price";
            this.comboBox_price.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_price.FormattingEnabled = true;
            this.comboBox_price.Location = new System.Drawing.Point(122, 71);
            this.comboBox_price.Name = "comboBox_price";
            this.comboBox_price.Size = new System.Drawing.Size(177, 20);
            this.comboBox_price.TabIndex = 4;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(90, 182);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(133, 23);
            this.btn_save.TabIndex = 6;
            this.btn_save.Text = "保存";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // textBox_count
            // 
            this.textBox_count.Location = new System.Drawing.Point(122, 116);
            this.textBox_count.Name = "textBox_count";
            this.textBox_count.Size = new System.Drawing.Size(178, 21);
            this.textBox_count.TabIndex = 7;
            // 
            // FormDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 222);
            this.Controls.Add(this.textBox_count);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.comboBox_price);
            this.Controls.Add(this.comboBox_GoodsName);
            this.Controls.Add(this.lbl_count);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_GoodsName);
            this.Name = "FormDetails";
            this.Text = "订单明细";
            ((System.ComponentModel.ISupportInitialize)(this.bds_Goods)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_GoodsName;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_count;
        private System.Windows.Forms.ComboBox comboBox_GoodsName;
        private System.Windows.Forms.ComboBox comboBox_price;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox textBox_count;
        private System.Windows.Forms.BindingSource bds_Goods;
    }
}