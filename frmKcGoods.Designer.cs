namespace CHEXC
{
    partial class frmKcGoods
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtGoodsSellPrice = new System.Windows.Forms.TextBox();
            this.txtGoodsNum = new System.Windows.Forms.TextBox();
            this.txtGoodsName = new System.Windows.Forms.TextBox();
            this.txtGoodsJhPrice = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(156, 158);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(49, 29);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "设置";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(9, 211);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(629, 168);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "商品编号";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "商品名称";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "仓库名称";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "库存数量";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "报警数量";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // txtGoodsSellPrice
            // 
            this.txtGoodsSellPrice.Enabled = false;
            this.txtGoodsSellPrice.Location = new System.Drawing.Point(483, 68);
            this.txtGoodsSellPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGoodsSellPrice.MaxLength = 10;
            this.txtGoodsSellPrice.Name = "txtGoodsSellPrice";
            this.txtGoodsSellPrice.Size = new System.Drawing.Size(137, 25);
            this.txtGoodsSellPrice.TabIndex = 65;
            // 
            // txtGoodsNum
            // 
            this.txtGoodsNum.Enabled = false;
            this.txtGoodsNum.Location = new System.Drawing.Point(105, 110);
            this.txtGoodsNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGoodsNum.MaxLength = 10;
            this.txtGoodsNum.Name = "txtGoodsNum";
            this.txtGoodsNum.Size = new System.Drawing.Size(124, 25);
            this.txtGoodsNum.TabIndex = 64;
            // 
            // txtGoodsName
            // 
            this.txtGoodsName.Enabled = false;
            this.txtGoodsName.Location = new System.Drawing.Point(483, 14);
            this.txtGoodsName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGoodsName.MaxLength = 20;
            this.txtGoodsName.Name = "txtGoodsName";
            this.txtGoodsName.Size = new System.Drawing.Size(137, 25);
            this.txtGoodsName.TabIndex = 63;
            // 
            // txtGoodsJhPrice
            // 
            this.txtGoodsJhPrice.Enabled = false;
            this.txtGoodsJhPrice.Location = new System.Drawing.Point(105, 60);
            this.txtGoodsJhPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGoodsJhPrice.MaxLength = 10;
            this.txtGoodsJhPrice.Name = "txtGoodsJhPrice";
            this.txtGoodsJhPrice.Size = new System.Drawing.Size(124, 25);
            this.txtGoodsJhPrice.TabIndex = 62;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(388, 79);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(82, 15);
            this.label22.TabIndex = 57;
            this.label22.Text = "销售单价：";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(11, 121);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(82, 15);
            this.label23.TabIndex = 56;
            this.label23.Text = "进货数量：";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(384, 19);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(82, 15);
            this.label19.TabIndex = 52;
            this.label19.Text = "商品名称：";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 71);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 15);
            this.label16.TabIndex = 50;
            this.label16.Text = "进货单价：";
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(105, 11);
            this.txtid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtid.MaxLength = 20;
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(124, 25);
            this.txtid.TabIndex = 74;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 73;
            this.label2.Text = "商品编号：";
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(483, 118);
            this.txtnum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtnum.MaxLength = 10;
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(137, 25);
            this.txtnum.TabIndex = 76;
            this.txtnum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(388, 129);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 75;
            this.label1.Text = "报警数量：";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(539, 158);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(52, 29);
            this.btnExit.TabIndex = 77;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmKcGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 385);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGoodsSellPrice);
            this.Controls.Add(this.txtGoodsNum);
            this.Controls.Add(this.txtGoodsName);
            this.Controls.Add(this.txtGoodsJhPrice);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAdd);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmKcGoods";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "库存警报";
            this.Load += new System.EventHandler(this.frmKcGoods_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtGoodsSellPrice;
        private System.Windows.Forms.TextBox txtGoodsNum;
        private System.Windows.Forms.TextBox txtGoodsName;
        private System.Windows.Forms.TextBox txtGoodsJhPrice;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}