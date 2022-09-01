namespace CHEXC
{
    partial class frmEmpInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpInfo));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolSave = new System.Windows.Forms.ToolStripButton();
            this.toolCancel = new System.Windows.Forms.ToolStripButton();
            this.toolAdd = new System.Windows.Forms.ToolStripButton();
            this.toolAmend = new System.Windows.Forms.ToolStripButton();
            this.toolDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.labCondation = new System.Windows.Forms.ToolStripLabel();
            this.cbxCondition = new System.Windows.Forms.ToolStripComboBox();
            this.txtKeyWord = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.txtOK = new System.Windows.Forms.ToolStripButton();
            this.labK = new System.Windows.Forms.ToolStripLabel();
            this.toolExit = new System.Windows.Forms.ToolStripButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.txtEmpLoginName = new System.Windows.Forms.TextBox();
            this.txtEmpPhoneM = new System.Windows.Forms.TextBox();
            this.txtEmpAddress = new System.Windows.Forms.TextBox();
            this.txtEmpPhone = new System.Windows.Forms.TextBox();
            this.txtEmpLoginPwd = new System.Windows.Forms.TextBox();
            this.daEmpBirthday = new System.Windows.Forms.DateTimePicker();
            this.cmbEmpDept = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.cmbEmpPost = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column6,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(91, 291);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(821, 330);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "员工编号";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 110;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "姓名";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "性别";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "部门";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "职位";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "电话";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolSave,
            this.toolCancel,
            this.toolAdd,
            this.toolAmend,
            this.toolDelete,
            this.toolStripSeparator1,
            this.labCondation,
            this.cbxCondition,
            this.txtKeyWord,
            this.toolStripSeparator2,
            this.txtOK,
            this.labK,
            this.toolExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(928, 31);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolSave
            // 
            this.toolSave.Enabled = false;
            this.toolSave.Image = ((System.Drawing.Image)(resources.GetObject("toolSave.Image")));
            this.toolSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSave.Name = "toolSave";
            this.toolSave.Size = new System.Drawing.Size(63, 28);
            this.toolSave.Tag = "1";
            this.toolSave.Text = "保存";
            this.toolSave.Click += new System.EventHandler(this.toolSave_Click);
            // 
            // toolCancel
            // 
            this.toolCancel.Enabled = false;
            this.toolCancel.Image = ((System.Drawing.Image)(resources.GetObject("toolCancel.Image")));
            this.toolCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolCancel.Name = "toolCancel";
            this.toolCancel.Size = new System.Drawing.Size(63, 25);
            this.toolCancel.Tag = "2";
            this.toolCancel.Text = "取消";
            this.toolCancel.Click += new System.EventHandler(this.toolCancel_Click);
            // 
            // toolAdd
            // 
            this.toolAdd.Image = ((System.Drawing.Image)(resources.GetObject("toolAdd.Image")));
            this.toolAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAdd.Name = "toolAdd";
            this.toolAdd.Size = new System.Drawing.Size(63, 25);
            this.toolAdd.Tag = "3";
            this.toolAdd.Text = "添加";
            this.toolAdd.Click += new System.EventHandler(this.toolAdd_Click);
            // 
            // toolAmend
            // 
            this.toolAmend.Image = ((System.Drawing.Image)(resources.GetObject("toolAmend.Image")));
            this.toolAmend.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAmend.Name = "toolAmend";
            this.toolAmend.Size = new System.Drawing.Size(63, 25);
            this.toolAmend.Tag = "4";
            this.toolAmend.Text = "修改";
            this.toolAmend.Click += new System.EventHandler(this.toolAmend_Click);
            // 
            // toolDelete
            // 
            this.toolDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolDelete.Image")));
            this.toolDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolDelete.Name = "toolDelete";
            this.toolDelete.Size = new System.Drawing.Size(63, 25);
            this.toolDelete.Text = "删除";
            this.toolDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolDelete.Click += new System.EventHandler(this.toolDelete_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // labCondation
            // 
            this.labCondation.Name = "labCondation";
            this.labCondation.Size = new System.Drawing.Size(73, 25);
            this.labCondation.Text = "查询条件:";
            // 
            // cbxCondition
            // 
            this.cbxCondition.Items.AddRange(new object[] {
            "员工姓名",
            "员工性别",
            "所属部门",
            "员工职位"});
            this.cbxCondition.Name = "cbxCondition";
            this.cbxCondition.Size = new System.Drawing.Size(99, 28);
            // 
            // txtKeyWord
            // 
            this.txtKeyWord.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.txtKeyWord.Name = "txtKeyWord";
            this.txtKeyWord.Size = new System.Drawing.Size(132, 28);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // txtOK
            // 
            this.txtOK.Image = ((System.Drawing.Image)(resources.GetObject("txtOK.Image")));
            this.txtOK.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.txtOK.Name = "txtOK";
            this.txtOK.Size = new System.Drawing.Size(63, 25);
            this.txtOK.Tag = "6";
            this.txtOK.Text = "查找";
            this.txtOK.Click += new System.EventHandler(this.txtOK_Click);
            // 
            // labK
            // 
            this.labK.Name = "labK";
            this.labK.Size = new System.Drawing.Size(25, 25);
            this.labK.Text = "    ";
            // 
            // toolExit
            // 
            this.toolExit.Image = ((System.Drawing.Image)(resources.GetObject("toolExit.Image")));
            this.toolExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolExit.Name = "toolExit";
            this.toolExit.Size = new System.Drawing.Size(63, 25);
            this.toolExit.Tag = "7";
            this.toolExit.Text = "退出";
            this.toolExit.Click += new System.EventHandler(this.toolExit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 51);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "姓名：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 148);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "电话：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 100);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 15);
            this.label9.TabIndex = 7;
            this.label9.Text = "登录名：";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 189);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 15);
            this.label10.TabIndex = 8;
            this.label10.Text = "地址：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(675, 49);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 15);
            this.label11.TabIndex = 9;
            this.label11.Text = "性别：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(336, 48);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 15);
            this.label12.TabIndex = 10;
            this.label12.Text = "出生日期：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(336, 108);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 15);
            this.label13.TabIndex = 11;
            this.label13.Text = "密码：";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(675, 104);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 15);
            this.label14.TabIndex = 12;
            this.label14.Text = "职位：";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(336, 148);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 15);
            this.label15.TabIndex = 13;
            this.label15.Text = "QQ号：";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(675, 155);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 15);
            this.label17.TabIndex = 15;
            this.label17.Text = "部门：";
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(104, 48);
            this.txtEmpName.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmpName.MaxLength = 30;
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(201, 25);
            this.txtEmpName.TabIndex = 16;
            // 
            // txtEmpLoginName
            // 
            this.txtEmpLoginName.Location = new System.Drawing.Point(104, 96);
            this.txtEmpLoginName.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmpLoginName.MaxLength = 30;
            this.txtEmpLoginName.Name = "txtEmpLoginName";
            this.txtEmpLoginName.Size = new System.Drawing.Size(201, 25);
            this.txtEmpLoginName.TabIndex = 17;
            // 
            // txtEmpPhoneM
            // 
            this.txtEmpPhoneM.Location = new System.Drawing.Point(104, 136);
            this.txtEmpPhoneM.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmpPhoneM.MaxLength = 15;
            this.txtEmpPhoneM.Name = "txtEmpPhoneM";
            this.txtEmpPhoneM.Size = new System.Drawing.Size(201, 25);
            this.txtEmpPhoneM.TabIndex = 18;
            // 
            // txtEmpAddress
            // 
            this.txtEmpAddress.Location = new System.Drawing.Point(104, 178);
            this.txtEmpAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmpAddress.MaxLength = 180;
            this.txtEmpAddress.Multiline = true;
            this.txtEmpAddress.Name = "txtEmpAddress";
            this.txtEmpAddress.Size = new System.Drawing.Size(779, 82);
            this.txtEmpAddress.TabIndex = 19;
            // 
            // txtEmpPhone
            // 
            this.txtEmpPhone.Location = new System.Drawing.Point(431, 144);
            this.txtEmpPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmpPhone.MaxLength = 12;
            this.txtEmpPhone.Name = "txtEmpPhone";
            this.txtEmpPhone.Size = new System.Drawing.Size(193, 25);
            this.txtEmpPhone.TabIndex = 20;
            // 
            // txtEmpLoginPwd
            // 
            this.txtEmpLoginPwd.Location = new System.Drawing.Point(431, 100);
            this.txtEmpLoginPwd.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmpLoginPwd.MaxLength = 30;
            this.txtEmpLoginPwd.Name = "txtEmpLoginPwd";
            this.txtEmpLoginPwd.PasswordChar = '*';
            this.txtEmpLoginPwd.Size = new System.Drawing.Size(193, 25);
            this.txtEmpLoginPwd.TabIndex = 21;
            // 
            // daEmpBirthday
            // 
            this.daEmpBirthday.Location = new System.Drawing.Point(431, 42);
            this.daEmpBirthday.Margin = new System.Windows.Forms.Padding(4);
            this.daEmpBirthday.Name = "daEmpBirthday";
            this.daEmpBirthday.Size = new System.Drawing.Size(193, 25);
            this.daEmpBirthday.TabIndex = 22;
            // 
            // cmbEmpDept
            // 
            this.cmbEmpDept.FormattingEnabled = true;
            this.cmbEmpDept.Items.AddRange(new object[] {
            "采购部",
            "管理层",
            "销售部",
            "后勤"});
            this.cmbEmpDept.Location = new System.Drawing.Point(769, 138);
            this.cmbEmpDept.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEmpDept.Name = "cmbEmpDept";
            this.cmbEmpDept.Size = new System.Drawing.Size(113, 23);
            this.cmbEmpDept.TabIndex = 23;
            this.cmbEmpDept.SelectedIndexChanged += new System.EventHandler(this.cmbEmpDept_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "男",
            "女"});
            this.comboBox2.Location = new System.Drawing.Point(769, 39);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(113, 23);
            this.comboBox2.TabIndex = 24;
            // 
            // cmbEmpPost
            // 
            this.cmbEmpPost.FormattingEnabled = true;
            this.cmbEmpPost.Items.AddRange(new object[] {
            "经理",
            "采购员",
            "销售员",
            "仓库管理员"});
            this.cmbEmpPost.Location = new System.Drawing.Point(769, 90);
            this.cmbEmpPost.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEmpPost.Name = "cmbEmpPost";
            this.cmbEmpPost.Size = new System.Drawing.Size(113, 23);
            this.cmbEmpPost.TabIndex = 25;
            this.cmbEmpPost.SelectedIndexChanged += new System.EventHandler(this.cmbEmpPost_SelectedIndexChanged);
            // 
            // frmEmpInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 649);
            this.Controls.Add(this.cmbEmpPost);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.cmbEmpDept);
            this.Controls.Add(this.daEmpBirthday);
            this.Controls.Add(this.txtEmpLoginPwd);
            this.Controls.Add(this.txtEmpPhone);
            this.Controls.Add(this.txtEmpAddress);
            this.Controls.Add(this.txtEmpPhoneM);
            this.Controls.Add(this.txtEmpLoginName);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmEmpInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "员工基本信息";
            this.Load += new System.EventHandler(this.frmEmpInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolSave;
        private System.Windows.Forms.ToolStripButton toolCancel;
        private System.Windows.Forms.ToolStripButton toolAdd;
        private System.Windows.Forms.ToolStripButton toolAmend;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel labCondation;
        private System.Windows.Forms.ToolStripComboBox cbxCondition;
        private System.Windows.Forms.ToolStripTextBox txtKeyWord;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton txtOK;
        private System.Windows.Forms.ToolStripLabel labK;
        private System.Windows.Forms.ToolStripButton toolExit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.TextBox txtEmpLoginName;
        private System.Windows.Forms.TextBox txtEmpPhoneM;
        private System.Windows.Forms.TextBox txtEmpAddress;
        private System.Windows.Forms.TextBox txtEmpPhone;
        private System.Windows.Forms.TextBox txtEmpLoginPwd;
        private System.Windows.Forms.DateTimePicker daEmpBirthday;
        private System.Windows.Forms.ComboBox cmbEmpDept;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox cmbEmpPost;
        private System.Windows.Forms.ToolStripButton toolDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}