namespace week42
{
    partial class Addorder
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
            this.label1 = new System.Windows.Forms.Label();
            this.cusText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gidtxt = new System.Windows.Forms.TextBox();
            this.gcount = new System.Windows.Forms.TextBox();
            this.gdiscount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.goodsIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsDiscountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oDetailsbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oDetailsbindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "客户ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cusText
            // 
            this.cusText.Location = new System.Drawing.Point(87, 39);
            this.cusText.Name = "cusText";
            this.cusText.Size = new System.Drawing.Size(100, 25);
            this.cusText.TabIndex = 1;
            this.cusText.TextChanged += new System.EventHandler(this.cusText_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "商品ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // gidtxt
            // 
            this.gidtxt.Location = new System.Drawing.Point(87, 88);
            this.gidtxt.Name = "gidtxt";
            this.gidtxt.Size = new System.Drawing.Size(100, 25);
            this.gidtxt.TabIndex = 3;
            this.gidtxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // gcount
            // 
            this.gcount.Location = new System.Drawing.Point(87, 150);
            this.gcount.Name = "gcount";
            this.gcount.Size = new System.Drawing.Size(100, 25);
            this.gcount.TabIndex = 4;
            this.gcount.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // gdiscount
            // 
            this.gdiscount.Location = new System.Drawing.Point(87, 217);
            this.gdiscount.Name = "gdiscount";
            this.gdiscount.Size = new System.Drawing.Size(100, 25);
            this.gdiscount.TabIndex = 5;
            this.gdiscount.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "数量";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "折扣";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cusText);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.gdiscount);
            this.groupBox1.Controls.Add(this.gidtxt);
            this.groupBox1.Controls.Add(this.gcount);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 257);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "newDetail";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.goodsIdDataGridViewTextBoxColumn,
            this.goodsCountDataGridViewTextBoxColumn,
            this.goodsDiscountDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.oDetailsbindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(293, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(433, 242);
            this.dataGridView1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 41);
            this.button1.TabIndex = 10;
            this.button1.Text = "增加商品";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 296);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 41);
            this.button2.TabIndex = 11;
            this.button2.Text = "确认订单";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // goodsIdDataGridViewTextBoxColumn
            // 
            this.goodsIdDataGridViewTextBoxColumn.DataPropertyName = "goodsId";
            this.goodsIdDataGridViewTextBoxColumn.HeaderText = "goodsId";
            this.goodsIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.goodsIdDataGridViewTextBoxColumn.Name = "goodsIdDataGridViewTextBoxColumn";
            this.goodsIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // goodsCountDataGridViewTextBoxColumn
            // 
            this.goodsCountDataGridViewTextBoxColumn.DataPropertyName = "goodsCount";
            this.goodsCountDataGridViewTextBoxColumn.HeaderText = "goodsCount";
            this.goodsCountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.goodsCountDataGridViewTextBoxColumn.Name = "goodsCountDataGridViewTextBoxColumn";
            this.goodsCountDataGridViewTextBoxColumn.Width = 125;
            // 
            // goodsDiscountDataGridViewTextBoxColumn
            // 
            this.goodsDiscountDataGridViewTextBoxColumn.DataPropertyName = "goodsDiscount";
            this.goodsDiscountDataGridViewTextBoxColumn.HeaderText = "goodsDiscount";
            this.goodsDiscountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.goodsDiscountDataGridViewTextBoxColumn.Name = "goodsDiscountDataGridViewTextBoxColumn";
            this.goodsDiscountDataGridViewTextBoxColumn.Width = 125;
            // 
            // oDetailsbindingSource
            // 
            this.oDetailsbindingSource.DataSource = typeof(week3.OrderDetail);
            // 
            // Addorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 360);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Addorder";
            this.Text = "添加订单";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oDetailsbindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cusText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox gidtxt;
        private System.Windows.Forms.TextBox gcount;
        private System.Windows.Forms.TextBox gdiscount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource oDetailsbindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsDiscountDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}