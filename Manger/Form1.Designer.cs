namespace Manger
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExcl = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.chkall = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabpageNow = new System.Windows.Forms.TabPage();
            this.gvwNow = new System.Windows.Forms.DataGridView();
            this.TabpageAll = new System.Windows.Forms.TabPage();
            this.chkhour = new System.Windows.Forms.CheckBox();
            this.chkday = new System.Windows.Forms.CheckBox();
            this.btnnSearch = new System.Windows.Forms.Button();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkSearchByDate = new System.Windows.Forms.CheckBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxProjectName = new System.Windows.Forms.ComboBox();
            this.comboBoxDevice_Code = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chBoxAllDevice = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.radAll = new System.Windows.Forms.RadioButton();
            this.radNew = new System.Windows.Forms.RadioButton();
            this.gvwAll = new System.Windows.Forms.DataGridView();
            this.TabpageConstrution = new System.Windows.Forms.TabPage();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.gvwConstrution = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnnow = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.TabpageNow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvwNow)).BeginInit();
            this.TabpageAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwAll)).BeginInit();
            this.TabpageConstrution.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvwConstrution)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnnow);
            this.panel1.Controls.Add(this.btnExcl);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.chkall);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(907, 57);
            this.panel1.TabIndex = 0;
            // 
            // btnExcl
            // 
            this.btnExcl.Enabled = false;
            this.btnExcl.Location = new System.Drawing.Point(203, 17);
            this.btnExcl.Name = "btnExcl";
            this.btnExcl.Size = new System.Drawing.Size(75, 23);
            this.btnExcl.TabIndex = 1;
            this.btnExcl.Text = "导出excl";
            this.btnExcl.UseVisualStyleBackColor = true;
            this.btnExcl.Click += new System.EventHandler(this.btnExcl_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(104, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "查看图表";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // chkall
            // 
            this.chkall.AutoSize = true;
            this.chkall.Location = new System.Drawing.Point(12, 21);
            this.chkall.Name = "chkall";
            this.chkall.Size = new System.Drawing.Size(72, 16);
            this.chkall.TabIndex = 4;
            this.chkall.Text = "查看全部";
            this.chkall.UseVisualStyleBackColor = true;
            this.chkall.CheckedChanged += new System.EventHandler(this.chkall_CheckedChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(402, 125);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.TabpageNow);
            this.tabControl1.Controls.Add(this.TabpageAll);
            this.tabControl1.Controls.Add(this.TabpageConstrution);
            this.tabControl1.Location = new System.Drawing.Point(0, 57);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(907, 387);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // TabpageNow
            // 
            this.TabpageNow.AutoScroll = true;
            this.TabpageNow.Controls.Add(this.gvwNow);
            this.TabpageNow.Location = new System.Drawing.Point(4, 22);
            this.TabpageNow.Name = "TabpageNow";
            this.TabpageNow.Padding = new System.Windows.Forms.Padding(3);
            this.TabpageNow.Size = new System.Drawing.Size(899, 361);
            this.TabpageNow.TabIndex = 0;
            this.TabpageNow.Text = "实时数据";
            this.TabpageNow.UseVisualStyleBackColor = true;
            // 
            // gvwNow
            // 
            this.gvwNow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvwNow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gvwNow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvwNow.Location = new System.Drawing.Point(0, 0);
            this.gvwNow.Name = "gvwNow";
            this.gvwNow.RowTemplate.Height = 23;
            this.gvwNow.Size = new System.Drawing.Size(897, 335);
            this.gvwNow.TabIndex = 0;
            this.gvwNow.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.gvwNow_CellPainting);
            // 
            // TabpageAll
            // 
            this.TabpageAll.AutoScroll = true;
            this.TabpageAll.Controls.Add(this.chkhour);
            this.TabpageAll.Controls.Add(this.chkday);
            this.TabpageAll.Controls.Add(this.btnnSearch);
            this.TabpageAll.Controls.Add(this.dateTimePicker4);
            this.TabpageAll.Controls.Add(this.dateTimePicker3);
            this.TabpageAll.Controls.Add(this.label5);
            this.TabpageAll.Controls.Add(this.label1);
            this.TabpageAll.Controls.Add(this.chkSearchByDate);
            this.TabpageAll.Controls.Add(this.dateTimePicker2);
            this.TabpageAll.Controls.Add(this.comboBoxProjectName);
            this.TabpageAll.Controls.Add(this.comboBoxDevice_Code);
            this.TabpageAll.Controls.Add(this.btnSearch);
            this.TabpageAll.Controls.Add(this.label4);
            this.TabpageAll.Controls.Add(this.numericUpDown1);
            this.TabpageAll.Controls.Add(this.label3);
            this.TabpageAll.Controls.Add(this.label2);
            this.TabpageAll.Controls.Add(this.chBoxAllDevice);
            this.TabpageAll.Controls.Add(this.dateTimePicker1);
            this.TabpageAll.Controls.Add(this.radAll);
            this.TabpageAll.Controls.Add(this.radNew);
            this.TabpageAll.Controls.Add(this.gvwAll);
            this.TabpageAll.Location = new System.Drawing.Point(4, 22);
            this.TabpageAll.Name = "TabpageAll";
            this.TabpageAll.Padding = new System.Windows.Forms.Padding(3);
            this.TabpageAll.Size = new System.Drawing.Size(899, 361);
            this.TabpageAll.TabIndex = 1;
            this.TabpageAll.Text = "统计数据";
            this.TabpageAll.UseVisualStyleBackColor = true;
            // 
            // chkhour
            // 
            this.chkhour.AutoSize = true;
            this.chkhour.Checked = true;
            this.chkhour.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkhour.Location = new System.Drawing.Point(813, 5);
            this.chkhour.Name = "chkhour";
            this.chkhour.Size = new System.Drawing.Size(60, 16);
            this.chkhour.TabIndex = 25;
            this.chkhour.Text = "按小时";
            this.chkhour.UseVisualStyleBackColor = true;
            this.chkhour.Visible = false;
            this.chkhour.CheckedChanged += new System.EventHandler(this.chkhour_CheckedChanged);
            // 
            // chkday
            // 
            this.chkday.AutoSize = true;
            this.chkday.Location = new System.Drawing.Point(714, 5);
            this.chkday.Name = "chkday";
            this.chkday.Size = new System.Drawing.Size(48, 16);
            this.chkday.TabIndex = 24;
            this.chkday.Text = "按天";
            this.chkday.UseVisualStyleBackColor = true;
            this.chkday.Visible = false;
            this.chkday.CheckedChanged += new System.EventHandler(this.chkday_CheckedChanged);
            // 
            // btnnSearch
            // 
            this.btnnSearch.Location = new System.Drawing.Point(773, 31);
            this.btnnSearch.Name = "btnnSearch";
            this.btnnSearch.Size = new System.Drawing.Size(59, 23);
            this.btnnSearch.TabIndex = 23;
            this.btnnSearch.Text = "查询";
            this.btnnSearch.UseVisualStyleBackColor = true;
            this.btnnSearch.Visible = false;
            this.btnnSearch.Click += new System.EventHandler(this.btnnSearch_Click);
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Enabled = false;
            this.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker4.Location = new System.Drawing.Point(594, 4);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.ShowUpDown = true;
            this.dateTimePicker4.Size = new System.Drawing.Size(94, 21);
            this.dateTimePicker4.TabIndex = 22;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Enabled = false;
            this.dateTimePicker3.Location = new System.Drawing.Point(488, 4);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(100, 21);
            this.dateTimePicker3.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(429, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 20;
            this.label5.Text = "截止时间";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 19;
            this.label1.Text = "开始时间:";
            // 
            // chkSearchByDate
            // 
            this.chkSearchByDate.AutoSize = true;
            this.chkSearchByDate.Location = new System.Drawing.Point(85, 4);
            this.chkSearchByDate.Name = "chkSearchByDate";
            this.chkSearchByDate.Size = new System.Drawing.Size(72, 16);
            this.chkSearchByDate.TabIndex = 18;
            this.chkSearchByDate.Text = "时间查找";
            this.chkSearchByDate.UseVisualStyleBackColor = true;
            this.chkSearchByDate.CheckedChanged += new System.EventHandler(this.chkSearchByDate_CheckedChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Enabled = false;
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(349, 3);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(74, 21);
            this.dateTimePicker2.TabIndex = 17;
            this.dateTimePicker2.Value = new System.DateTime(2018, 11, 15, 10, 1, 0, 0);
            // 
            // comboBoxProjectName
            // 
            this.comboBoxProjectName.FormattingEnabled = true;
            this.comboBoxProjectName.Location = new System.Drawing.Point(445, 30);
            this.comboBoxProjectName.Name = "comboBoxProjectName";
            this.comboBoxProjectName.Size = new System.Drawing.Size(180, 20);
            this.comboBoxProjectName.TabIndex = 16;
            // 
            // comboBoxDevice_Code
            // 
            this.comboBoxDevice_Code.FormattingEnabled = true;
            this.comboBoxDevice_Code.Location = new System.Drawing.Point(228, 32);
            this.comboBoxDevice_Code.Name = "comboBoxDevice_Code";
            this.comboBoxDevice_Code.Size = new System.Drawing.Size(152, 20);
            this.comboBoxDevice_Code.TabIndex = 15;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(838, 30);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(58, 24);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(631, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "最大数据量";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(702, 28);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(65, 21);
            this.numericUpDown1.TabIndex = 10;
            this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(386, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "工地名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "设备编号";
            // 
            // chBoxAllDevice
            // 
            this.chBoxAllDevice.AutoSize = true;
            this.chBoxAllDevice.Location = new System.Drawing.Point(85, 30);
            this.chBoxAllDevice.Name = "chBoxAllDevice";
            this.chBoxAllDevice.Size = new System.Drawing.Size(72, 16);
            this.chBoxAllDevice.TabIndex = 5;
            this.chBoxAllDevice.Text = "所有设备";
            this.chBoxAllDevice.UseVisualStyleBackColor = true;
            this.chBoxAllDevice.CheckedChanged += new System.EventHandler(this.chBoxAllDevice_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(228, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(115, 21);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // radAll
            // 
            this.radAll.AutoSize = true;
            this.radAll.Location = new System.Drawing.Point(8, 28);
            this.radAll.Name = "radAll";
            this.radAll.Size = new System.Drawing.Size(71, 16);
            this.radAll.TabIndex = 2;
            this.radAll.TabStop = true;
            this.radAll.Text = "统计数据";
            this.radAll.UseVisualStyleBackColor = true;
            this.radAll.CheckedChanged += new System.EventHandler(this.radAll_CheckedChanged);
            // 
            // radNew
            // 
            this.radNew.AutoSize = true;
            this.radNew.Checked = true;
            this.radNew.Location = new System.Drawing.Point(8, 6);
            this.radNew.Name = "radNew";
            this.radNew.Size = new System.Drawing.Size(71, 16);
            this.radNew.TabIndex = 1;
            this.radNew.TabStop = true;
            this.radNew.Text = "实时数据";
            this.radNew.UseVisualStyleBackColor = true;
            this.radNew.CheckedChanged += new System.EventHandler(this.radNew_CheckedChanged);
            // 
            // gvwAll
            // 
            this.gvwAll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvwAll.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gvwAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvwAll.Location = new System.Drawing.Point(0, 60);
            this.gvwAll.Name = "gvwAll";
            this.gvwAll.RowTemplate.Height = 23;
            this.gvwAll.Size = new System.Drawing.Size(894, 312);
            this.gvwAll.TabIndex = 0;
            this.gvwAll.SelectionChanged += new System.EventHandler(this.gvwAll_SelectionChanged);
            // 
            // TabpageConstrution
            // 
            this.TabpageConstrution.AutoScroll = true;
            this.TabpageConstrution.Controls.Add(this.btnCancel);
            this.TabpageConstrution.Controls.Add(this.btnSave);
            this.TabpageConstrution.Controls.Add(this.btnAdd);
            this.TabpageConstrution.Controls.Add(this.btnUpdate);
            this.TabpageConstrution.Controls.Add(this.gvwConstrution);
            this.TabpageConstrution.Location = new System.Drawing.Point(4, 22);
            this.TabpageConstrution.Name = "TabpageConstrution";
            this.TabpageConstrution.Padding = new System.Windows.Forms.Padding(3);
            this.TabpageConstrution.Size = new System.Drawing.Size(899, 361);
            this.TabpageConstrution.TabIndex = 2;
            this.TabpageConstrution.Text = "工地清单";
            this.TabpageConstrution.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.Location = new System.Drawing.Point(515, 317);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消数据";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.Location = new System.Drawing.Point(414, 317);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "保存数据";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.Location = new System.Drawing.Point(297, 317);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "增加数据";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdate.Location = new System.Drawing.Point(184, 317);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "修改数据";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // gvwConstrution
            // 
            this.gvwConstrution.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvwConstrution.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gvwConstrution.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvwConstrution.Location = new System.Drawing.Point(0, 3);
            this.gvwConstrution.Name = "gvwConstrution";
            this.gvwConstrution.RowTemplate.Height = 23;
            this.gvwConstrution.Size = new System.Drawing.Size(898, 313);
            this.gvwConstrution.TabIndex = 0;
            this.gvwConstrution.DoubleClick += new System.EventHandler(this.gvwConstrution_DoubleClick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4});
            this.statusStrip1.Location = new System.Drawing.Point(0, 422);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(907, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(104, 17);
            this.toolStripStatusLabel1.Text = "在线设备设备数量";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(80, 17);
            this.toolStripStatusLabel2.Text = "断线设备数量";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(92, 17);
            this.toolStripStatusLabel3.Text = "粉尘仪故障数量";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(92, 17);
            this.toolStripStatusLabel4.Text = "声级计故障数量";
            // 
            // btnnow
            // 
            this.btnnow.Location = new System.Drawing.Point(312, 17);
            this.btnnow.Name = "btnnow";
            this.btnnow.Size = new System.Drawing.Size(75, 23);
            this.btnnow.TabIndex = 1;
            this.btnnow.Text = "刷新";
            this.btnnow.UseVisualStyleBackColor = true;
            this.btnnow.Click += new System.EventHandler(this.btnnow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 444);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "龙象环保建筑颗粒物及噪声在线检测巡检系统";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.TabpageNow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvwNow)).EndInit();
            this.TabpageAll.ResumeLayout(false);
            this.TabpageAll.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwAll)).EndInit();
            this.TabpageConstrution.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvwConstrution)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabpageNow;
        private System.Windows.Forms.TabPage TabpageAll;
        private System.Windows.Forms.TabPage TabpageConstrution;
        private System.Windows.Forms.DataGridView gvwNow;
        private System.Windows.Forms.DataGridView gvwAll;
        private System.Windows.Forms.DataGridView gvwConstrution;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chBoxAllDevice;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton radAll;
        private System.Windows.Forms.RadioButton radNew;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox comboBoxDevice_Code;
        private System.Windows.Forms.ComboBox comboBoxProjectName;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.CheckBox chkSearchByDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkall;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnExcl;
        private System.Windows.Forms.Button btnnSearch;
        private System.Windows.Forms.CheckBox chkhour;
        private System.Windows.Forms.CheckBox chkday;
        private System.Windows.Forms.Button btnnow;
    }
}

