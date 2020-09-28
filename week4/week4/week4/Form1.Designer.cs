namespace week4
{
    partial class tree
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
            this.btnDraw = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.n = new System.Windows.Forms.TextBox();
            this.leng = new System.Windows.Forms.TextBox();
            this.per1t = new System.Windows.Forms.TextBox();
            this.per2t = new System.Windows.Forms.TextBox();
            this.th1t = new System.Windows.Forms.TextBox();
            this.th2t = new System.Windows.Forms.TextBox();
            this.lb1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(597, 415);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(75, 23);
            this.btnDraw.TabIndex = 0;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(449, 373);
            this.panel1.TabIndex = 1;
            // 
            // n
            // 
            this.n.Location = new System.Drawing.Point(488, 71);
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(100, 25);
            this.n.TabIndex = 2;
            this.n.Text = "10";
            // 
            // leng
            // 
            this.leng.Location = new System.Drawing.Point(488, 141);
            this.leng.Name = "leng";
            this.leng.Size = new System.Drawing.Size(100, 25);
            this.leng.TabIndex = 3;
            this.leng.Text = "100";
            // 
            // per1t
            // 
            this.per1t.Location = new System.Drawing.Point(488, 203);
            this.per1t.Name = "per1t";
            this.per1t.Size = new System.Drawing.Size(100, 25);
            this.per1t.TabIndex = 4;
            this.per1t.Text = "0.6";
            // 
            // per2t
            // 
            this.per2t.Location = new System.Drawing.Point(488, 264);
            this.per2t.Name = "per2t";
            this.per2t.Size = new System.Drawing.Size(100, 25);
            this.per2t.TabIndex = 5;
            this.per2t.Text = "0.7";
            // 
            // th1t
            // 
            this.th1t.Location = new System.Drawing.Point(488, 324);
            this.th1t.Name = "th1t";
            this.th1t.Size = new System.Drawing.Size(100, 25);
            this.th1t.TabIndex = 6;
            this.th1t.Text = "94";
            // 
            // th2t
            // 
            this.th2t.Location = new System.Drawing.Point(488, 379);
            this.th2t.Name = "th2t";
            this.th2t.Size = new System.Drawing.Size(100, 25);
            this.th2t.TabIndex = 7;
            this.th2t.Text = "62.83";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(488, 50);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(67, 15);
            this.lb1.TabIndex = 8;
            this.lb1.Text = "递归深度";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(488, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "主干长度";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(488, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "右分支长度比";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(488, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "左分支长度比";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(488, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "右分支角度";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(488, 361);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "左分支角度";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(455, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "ChangeColor";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnCclor_Click);
            // 
            // tree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.th2t);
            this.Controls.Add(this.th1t);
            this.Controls.Add(this.per2t);
            this.Controls.Add(this.per1t);
            this.Controls.Add(this.leng);
            this.Controls.Add(this.n);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDraw);
            this.Name = "tree";
            this.Text = "DrawTree";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox n;
        private System.Windows.Forms.TextBox leng;
        private System.Windows.Forms.TextBox per1t;
        private System.Windows.Forms.TextBox per2t;
        private System.Windows.Forms.TextBox th1t;
        private System.Windows.Forms.TextBox th2t;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button2;
    }
}

