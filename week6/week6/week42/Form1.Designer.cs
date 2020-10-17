namespace week42
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.functionLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.xmlGroup = new System.Windows.Forms.GroupBox();
            this.XMLoutBtn = new System.Windows.Forms.Button();
            this.XMLinBtn = new System.Windows.Forms.Button();
            this.queryGroup = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.QuerybyIdPage = new System.Windows.Forms.TabPage();
            this.QueryBtnId = new System.Windows.Forms.Button();
            this.QueryLabelId = new System.Windows.Forms.Label();
            this.queryBoxid = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.QueryBtnGid = new System.Windows.Forms.Button();
            this.QueryBoxGid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.QueryBoxResult = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.goodsGroup = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.OrderBtnAdd = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.OrderDetailList = new System.Windows.Forms.DataGridView();
            this.orderDetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.orderDetailbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AllOrderbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.goodsIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsDiscountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderTotalDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderQueryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonAddGoods = new System.Windows.Forms.Button();
            this.functionLayout.SuspendLayout();
            this.xmlGroup.SuspendLayout();
            this.queryGroup.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.QuerybyIdPage.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.QueryBoxResult.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.goodsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDetailList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllOrderbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderQueryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // functionLayout
            // 
            this.functionLayout.BackColor = System.Drawing.SystemColors.ControlDark;
            this.functionLayout.Controls.Add(this.xmlGroup);
            this.functionLayout.Controls.Add(this.queryGroup);
            this.functionLayout.Controls.Add(this.QueryBoxResult);
            this.functionLayout.Dock = System.Windows.Forms.DockStyle.Left;
            this.functionLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.functionLayout.Location = new System.Drawing.Point(0, 0);
            this.functionLayout.Margin = new System.Windows.Forms.Padding(10);
            this.functionLayout.Name = "functionLayout";
            this.functionLayout.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.functionLayout.Size = new System.Drawing.Size(254, 537);
            this.functionLayout.TabIndex = 0;
            // 
            // xmlGroup
            // 
            this.xmlGroup.Controls.Add(this.XMLoutBtn);
            this.xmlGroup.Controls.Add(this.XMLinBtn);
            this.xmlGroup.Location = new System.Drawing.Point(13, 13);
            this.xmlGroup.Name = "xmlGroup";
            this.xmlGroup.Size = new System.Drawing.Size(227, 112);
            this.xmlGroup.TabIndex = 0;
            this.xmlGroup.TabStop = false;
            this.xmlGroup.Text = "XML相关";
            // 
            // XMLoutBtn
            // 
            this.XMLoutBtn.Location = new System.Drawing.Point(6, 71);
            this.XMLoutBtn.Name = "XMLoutBtn";
            this.XMLoutBtn.Size = new System.Drawing.Size(215, 29);
            this.XMLoutBtn.TabIndex = 1;
            this.XMLoutBtn.Text = "导出XML";
            this.XMLoutBtn.UseVisualStyleBackColor = true;
            this.XMLoutBtn.Click += new System.EventHandler(this.XMLoutBtn_Click);
            // 
            // XMLinBtn
            // 
            this.XMLinBtn.Location = new System.Drawing.Point(6, 34);
            this.XMLinBtn.Name = "XMLinBtn";
            this.XMLinBtn.Size = new System.Drawing.Size(215, 31);
            this.XMLinBtn.TabIndex = 0;
            this.XMLinBtn.Text = "导入XML";
            this.XMLinBtn.UseVisualStyleBackColor = true;
            this.XMLinBtn.Click += new System.EventHandler(this.XMLinBtn_Click);
            // 
            // queryGroup
            // 
            this.queryGroup.Controls.Add(this.tabControl1);
            this.queryGroup.Location = new System.Drawing.Point(13, 131);
            this.queryGroup.Name = "queryGroup";
            this.queryGroup.Size = new System.Drawing.Size(227, 190);
            this.queryGroup.TabIndex = 1;
            this.queryGroup.TabStop = false;
            this.queryGroup.Text = "条件查询";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.QuerybyIdPage);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(6, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(215, 153);
            this.tabControl1.TabIndex = 0;
            // 
            // QuerybyIdPage
            // 
            this.QuerybyIdPage.Controls.Add(this.QueryBtnId);
            this.QuerybyIdPage.Controls.Add(this.QueryLabelId);
            this.QuerybyIdPage.Controls.Add(this.queryBoxid);
            this.QuerybyIdPage.Location = new System.Drawing.Point(4, 25);
            this.QuerybyIdPage.Name = "QuerybyIdPage";
            this.QuerybyIdPage.Padding = new System.Windows.Forms.Padding(3);
            this.QuerybyIdPage.Size = new System.Drawing.Size(207, 124);
            this.QuerybyIdPage.TabIndex = 0;
            this.QuerybyIdPage.Text = "根据订单id查询";
            this.QuerybyIdPage.UseVisualStyleBackColor = true;
            this.QuerybyIdPage.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // QueryBtnId
            // 
            this.QueryBtnId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.QueryBtnId.Location = new System.Drawing.Point(110, 89);
            this.QueryBtnId.Name = "QueryBtnId";
            this.QueryBtnId.Size = new System.Drawing.Size(75, 29);
            this.QueryBtnId.TabIndex = 2;
            this.QueryBtnId.Text = "查询";
            this.QueryBtnId.UseVisualStyleBackColor = true;
            this.QueryBtnId.Click += new System.EventHandler(this.QueryBtnId_Click);
            // 
            // QueryLabelId
            // 
            this.QueryLabelId.AutoSize = true;
            this.QueryLabelId.Location = new System.Drawing.Point(7, 15);
            this.QueryLabelId.Name = "QueryLabelId";
            this.QueryLabelId.Size = new System.Drawing.Size(53, 15);
            this.QueryLabelId.TabIndex = 1;
            this.QueryLabelId.Text = "订单id";
            // 
            // queryBoxid
            // 
            this.queryBoxid.Location = new System.Drawing.Point(6, 36);
            this.queryBoxid.Name = "queryBoxid";
            this.queryBoxid.Size = new System.Drawing.Size(180, 25);
            this.queryBoxid.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.QueryBtnGid);
            this.tabPage2.Controls.Add(this.QueryBoxGid);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(207, 124);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "使用商品id查询";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // QueryBtnGid
            // 
            this.QueryBtnGid.Location = new System.Drawing.Point(113, 88);
            this.QueryBtnGid.Name = "QueryBtnGid";
            this.QueryBtnGid.Size = new System.Drawing.Size(75, 30);
            this.QueryBtnGid.TabIndex = 2;
            this.QueryBtnGid.Text = "查询";
            this.QueryBtnGid.UseVisualStyleBackColor = true;
            this.QueryBtnGid.Click += new System.EventHandler(this.QueryBtnGid_Click);
            // 
            // QueryBoxGid
            // 
            this.QueryBoxGid.Location = new System.Drawing.Point(10, 34);
            this.QueryBoxGid.Name = "QueryBoxGid";
            this.QueryBoxGid.Size = new System.Drawing.Size(178, 25);
            this.QueryBoxGid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "商品id";
            // 
            // QueryBoxResult
            // 
            this.QueryBoxResult.Controls.Add(this.textBox1);
            this.QueryBoxResult.ForeColor = System.Drawing.SystemColors.ControlText;
            this.QueryBoxResult.Location = new System.Drawing.Point(13, 327);
            this.QueryBoxResult.Name = "QueryBoxResult";
            this.QueryBoxResult.Size = new System.Drawing.Size(227, 198);
            this.QueryBoxResult.TabIndex = 2;
            this.QueryBoxResult.TabStop = false;
            this.QueryBoxResult.Text = "状态输出";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 25);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(207, 155);
            this.textBox1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flowLayoutPanel1.Controls.Add(this.goodsGroup);
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(254, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(462, 537);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // goodsGroup
            // 
            this.goodsGroup.Controls.Add(this.dataGridView1);
            this.goodsGroup.Location = new System.Drawing.Point(13, 13);
            this.goodsGroup.Name = "goodsGroup";
            this.goodsGroup.Size = new System.Drawing.Size(425, 189);
            this.goodsGroup.TabIndex = 0;
            this.goodsGroup.TabStop = false;
            this.goodsGroup.Text = "商品信息";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.goodsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(402, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Location = new System.Drawing.Point(13, 208);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 317);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询列表";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIdDataGridViewTextBoxColumn,
            this.customIdDataGridViewTextBoxColumn,
            this.orderTotalDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.orderQueryBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(7, 25);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(401, 274);
            this.dataGridView2.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.flowLayoutPanel2.Controls.Add(this.groupBox2);
            this.flowLayoutPanel2.Controls.Add(this.groupBox3);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(716, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(370, 537);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tabControl2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(13, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(348, 132);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "订单相关";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(16, 25);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(317, 87);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonAddGoods);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.OrderBtnAdd);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(309, 58);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "订单";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(130, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "删除订单";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // OrderBtnAdd
            // 
            this.OrderBtnAdd.Location = new System.Drawing.Point(6, 16);
            this.OrderBtnAdd.Name = "OrderBtnAdd";
            this.OrderBtnAdd.Size = new System.Drawing.Size(106, 34);
            this.OrderBtnAdd.TabIndex = 0;
            this.OrderBtnAdd.Text = "增加订单";
            this.OrderBtnAdd.UseVisualStyleBackColor = true;
            this.OrderBtnAdd.Click += new System.EventHandler(this.OrderBtnAdd_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button2);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(309, 58);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "其他";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(18, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "刷新订单";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.OrderDetailList);
            this.groupBox3.Controls.Add(this.dataGridView3);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox3.Location = new System.Drawing.Point(13, 151);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(348, 374);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "订单查看";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.AllOrderbindingSource, "orderId", true));
            this.label2.Location = new System.Drawing.Point(20, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "订单号";
            // 
            // OrderDetailList
            // 
            this.OrderDetailList.AutoGenerateColumns = false;
            this.OrderDetailList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderDetailList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.goodsIdDataGridViewTextBoxColumn,
            this.goodsCountDataGridViewTextBoxColumn,
            this.goodsDiscountDataGridViewTextBoxColumn});
            this.OrderDetailList.DataSource = this.orderDetailsBindingSource1;
            this.OrderDetailList.Location = new System.Drawing.Point(16, 220);
            this.OrderDetailList.Name = "OrderDetailList";
            this.OrderDetailList.RowHeadersWidth = 51;
            this.OrderDetailList.RowTemplate.Height = 27;
            this.OrderDetailList.Size = new System.Drawing.Size(313, 148);
            this.OrderDetailList.TabIndex = 1;
            this.OrderDetailList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderDetailList_CellContentClick);
            // 
            // orderDetailsBindingSource1
            // 
            this.orderDetailsBindingSource1.DataMember = "orderDetails";
            this.orderDetailsBindingSource1.DataSource = this.AllOrderbindingSource;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIdDataGridViewTextBoxColumn1,
            this.customIdDataGridViewTextBoxColumn1,
            this.orderTotalDataGridViewTextBoxColumn1});
            this.dataGridView3.DataSource = this.AllOrderbindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(16, 25);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 27;
            this.dataGridView3.Size = new System.Drawing.Size(313, 151);
            this.dataGridView3.TabIndex = 0;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // orderDetailbindingSource
            // 
            this.orderDetailbindingSource.DataSource = this.AllOrderbindingSource;
            this.orderDetailbindingSource.CurrentChanged += new System.EventHandler(this.orderDetailbindingSource_CurrentChanged);
            // 
            // orderDetailsBindingSource
            // 
            this.orderDetailsBindingSource.DataMember = "orderDetails";
            this.orderDetailsBindingSource.DataSource = this.orderDetailbindingSource;
            // 
            // AllOrderbindingSource
            // 
            this.AllOrderbindingSource.DataSource = typeof(week3.Order);
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
            // orderIdDataGridViewTextBoxColumn1
            // 
            this.orderIdDataGridViewTextBoxColumn1.DataPropertyName = "orderId";
            this.orderIdDataGridViewTextBoxColumn1.HeaderText = "订单号";
            this.orderIdDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.orderIdDataGridViewTextBoxColumn1.Name = "orderIdDataGridViewTextBoxColumn1";
            this.orderIdDataGridViewTextBoxColumn1.Width = 125;
            // 
            // customIdDataGridViewTextBoxColumn1
            // 
            this.customIdDataGridViewTextBoxColumn1.DataPropertyName = "customId";
            this.customIdDataGridViewTextBoxColumn1.HeaderText = "客户ID";
            this.customIdDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.customIdDataGridViewTextBoxColumn1.Name = "customIdDataGridViewTextBoxColumn1";
            this.customIdDataGridViewTextBoxColumn1.Width = 125;
            // 
            // orderTotalDataGridViewTextBoxColumn1
            // 
            this.orderTotalDataGridViewTextBoxColumn1.DataPropertyName = "orderTotal";
            this.orderTotalDataGridViewTextBoxColumn1.HeaderText = "订单总价";
            this.orderTotalDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.orderTotalDataGridViewTextBoxColumn1.Name = "orderTotalDataGridViewTextBoxColumn1";
            this.orderTotalDataGridViewTextBoxColumn1.ReadOnly = true;
            this.orderTotalDataGridViewTextBoxColumn1.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // goodsBindingSource
            // 
            this.goodsBindingSource.DataSource = typeof(week3.good);
            // 
            // orderIdDataGridViewTextBoxColumn
            // 
            this.orderIdDataGridViewTextBoxColumn.DataPropertyName = "orderId";
            this.orderIdDataGridViewTextBoxColumn.HeaderText = "orderId";
            this.orderIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderIdDataGridViewTextBoxColumn.Name = "orderIdDataGridViewTextBoxColumn";
            this.orderIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // customIdDataGridViewTextBoxColumn
            // 
            this.customIdDataGridViewTextBoxColumn.DataPropertyName = "customId";
            this.customIdDataGridViewTextBoxColumn.HeaderText = "customId";
            this.customIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customIdDataGridViewTextBoxColumn.Name = "customIdDataGridViewTextBoxColumn";
            this.customIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderTotalDataGridViewTextBoxColumn
            // 
            this.orderTotalDataGridViewTextBoxColumn.DataPropertyName = "orderTotal";
            this.orderTotalDataGridViewTextBoxColumn.HeaderText = "orderTotal";
            this.orderTotalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderTotalDataGridViewTextBoxColumn.Name = "orderTotalDataGridViewTextBoxColumn";
            this.orderTotalDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderTotalDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderQueryBindingSource
            // 
            this.orderQueryBindingSource.DataSource = typeof(week3.Order);
            // 
            // buttonAddGoods
            // 
            this.buttonAddGoods.Location = new System.Drawing.Point(239, 16);
            this.buttonAddGoods.Name = "buttonAddGoods";
            this.buttonAddGoods.Size = new System.Drawing.Size(75, 34);
            this.buttonAddGoods.TabIndex = 2;
            this.buttonAddGoods.Text = "增加商品";
            this.buttonAddGoods.UseVisualStyleBackColor = true;
            this.buttonAddGoods.Click += new System.EventHandler(this.buttonAddGoods_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 537);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.functionLayout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "货品管理";
            this.functionLayout.ResumeLayout(false);
            this.xmlGroup.ResumeLayout(false);
            this.queryGroup.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.QuerybyIdPage.ResumeLayout(false);
            this.QuerybyIdPage.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.QueryBoxResult.ResumeLayout(false);
            this.QueryBoxResult.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.goodsGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDetailList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllOrderbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderQueryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel functionLayout;
        private System.Windows.Forms.GroupBox xmlGroup;
        private System.Windows.Forms.Button XMLoutBtn;
        private System.Windows.Forms.Button XMLinBtn;
        private System.Windows.Forms.GroupBox queryGroup;
        private System.Windows.Forms.GroupBox QueryBoxResult;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox goodsGroup;
        private System.Windows.Forms.BindingSource goodsBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource orderQueryBindingSource;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView OrderDetailList;
        private System.Windows.Forms.BindingSource AllOrderbindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button OrderBtnAdd;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource orderDetailbindingSource;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage QuerybyIdPage;
        private System.Windows.Forms.Button QueryBtnId;
        private System.Windows.Forms.Label QueryLabelId;
        private System.Windows.Forms.TextBox queryBoxid;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button QueryBtnGid;
        private System.Windows.Forms.TextBox QueryBoxGid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderTotalDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsDiscountDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource orderDetailsBindingSource;
        private System.Windows.Forms.BindingSource orderDetailsBindingSource1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAddGoods;
    }
}

