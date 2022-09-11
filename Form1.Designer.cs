
namespace Benchmark_testing
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
            this.gbxStore = new System.Windows.Forms.GroupBox();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.btnStore = new System.Windows.Forms.Button();
            this.tbxInputAnnualSalary = new System.Windows.Forms.TextBox();
            this.tbxInputEmail = new System.Windows.Forms.TextBox();
            this.tbxInputName = new System.Windows.Forms.TextBox();
            this.tbxInputStaffID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxLoadSort = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lbxStaff = new System.Windows.Forms.ListBox();
            this.btnZA = new System.Windows.Forms.Button();
            this.btnAZ = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.gbxSearchSave = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.lbxSearchResults = new System.Windows.Forms.ListBox();
            this.lblStaffID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAnnualSalary = new System.Windows.Forms.Label();
            this.tbxStaffID = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxDateOfBirth = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxAnnualSalary = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.mnsMenu = new System.Windows.Forms.MenuStrip();
            this.storeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loadAndSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortAZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortZAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAndSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stsStatus = new System.Windows.Forms.StatusStrip();
            this.tslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.ttpToolTips = new System.Windows.Forms.ToolTip(this.components);
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gbxStore.SuspendLayout();
            this.gbxLoadSort.SuspendLayout();
            this.gbxSearchSave.SuspendLayout();
            this.mnsMenu.SuspendLayout();
            this.stsStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxStore
            // 
            this.gbxStore.Controls.Add(this.dtpBirthday);
            this.gbxStore.Controls.Add(this.btnStore);
            this.gbxStore.Controls.Add(this.tbxInputAnnualSalary);
            this.gbxStore.Controls.Add(this.tbxInputEmail);
            this.gbxStore.Controls.Add(this.tbxInputName);
            this.gbxStore.Controls.Add(this.tbxInputStaffID);
            this.gbxStore.Controls.Add(this.label5);
            this.gbxStore.Controls.Add(this.label4);
            this.gbxStore.Controls.Add(this.label3);
            this.gbxStore.Controls.Add(this.label2);
            this.gbxStore.Controls.Add(this.label1);
            this.gbxStore.Location = new System.Drawing.Point(72, 80);
            this.gbxStore.Name = "gbxStore";
            this.gbxStore.Size = new System.Drawing.Size(593, 457);
            this.gbxStore.TabIndex = 0;
            this.gbxStore.TabStop = false;
            this.gbxStore.Text = "Store";
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.CustomFormat = "yyyy-MM-dd";
            this.dtpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBirthday.Location = new System.Drawing.Point(197, 191);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(343, 35);
            this.dtpBirthday.TabIndex = 11;
            this.ttpToolTips.SetToolTip(this.dtpBirthday, "Enter staff date of birth");
            // 
            // btnStore
            // 
            this.btnStore.Location = new System.Drawing.Point(161, 384);
            this.btnStore.Name = "btnStore";
            this.btnStore.Size = new System.Drawing.Size(211, 39);
            this.btnStore.TabIndex = 10;
            this.btnStore.Text = "Store";
            this.ttpToolTips.SetToolTip(this.btnStore, "Store entered staff");
            this.btnStore.UseVisualStyleBackColor = true;
            this.btnStore.Click += new System.EventHandler(this.btnStore_Click);
            // 
            // tbxInputAnnualSalary
            // 
            this.tbxInputAnnualSalary.Location = new System.Drawing.Point(197, 314);
            this.tbxInputAnnualSalary.Name = "tbxInputAnnualSalary";
            this.tbxInputAnnualSalary.Size = new System.Drawing.Size(356, 35);
            this.tbxInputAnnualSalary.TabIndex = 9;
            this.ttpToolTips.SetToolTip(this.tbxInputAnnualSalary, "Enter staff annual salary");
            // 
            // tbxInputEmail
            // 
            this.tbxInputEmail.Location = new System.Drawing.Point(197, 254);
            this.tbxInputEmail.Name = "tbxInputEmail";
            this.tbxInputEmail.Size = new System.Drawing.Size(343, 35);
            this.tbxInputEmail.TabIndex = 8;
            this.ttpToolTips.SetToolTip(this.tbxInputEmail, "Enter staff email");
            // 
            // tbxInputName
            // 
            this.tbxInputName.Location = new System.Drawing.Point(197, 128);
            this.tbxInputName.Name = "tbxInputName";
            this.tbxInputName.Size = new System.Drawing.Size(286, 35);
            this.tbxInputName.TabIndex = 6;
            this.ttpToolTips.SetToolTip(this.tbxInputName, "Enter staff name");
            // 
            // tbxInputStaffID
            // 
            this.tbxInputStaffID.Location = new System.Drawing.Point(197, 62);
            this.tbxInputStaffID.Name = "tbxInputStaffID";
            this.tbxInputStaffID.Size = new System.Drawing.Size(286, 35);
            this.tbxInputStaffID.TabIndex = 5;
            this.ttpToolTips.SetToolTip(this.tbxInputStaffID, "Enter a six-digit staff ID");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Annual Salary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date of Birth";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "StaffID";
            // 
            // gbxLoadSort
            // 
            this.gbxLoadSort.Controls.Add(this.btnDelete);
            this.gbxLoadSort.Controls.Add(this.lbxStaff);
            this.gbxLoadSort.Controls.Add(this.btnZA);
            this.gbxLoadSort.Controls.Add(this.btnAZ);
            this.gbxLoadSort.Controls.Add(this.btnLoad);
            this.gbxLoadSort.Location = new System.Drawing.Point(812, 95);
            this.gbxLoadSort.Name = "gbxLoadSort";
            this.gbxLoadSort.Size = new System.Drawing.Size(613, 442);
            this.gbxLoadSort.TabIndex = 1;
            this.gbxLoadSort.TabStop = false;
            this.gbxLoadSort.Text = "Load and Sort";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(383, 157);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(191, 64);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.ttpToolTips.SetToolTip(this.btnDelete, "Delete the selected staff");
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lbxStaff
            // 
            this.lbxStaff.FormattingEnabled = true;
            this.lbxStaff.ItemHeight = 24;
            this.lbxStaff.Location = new System.Drawing.Point(35, 50);
            this.lbxStaff.Name = "lbxStaff";
            this.lbxStaff.Size = new System.Drawing.Size(306, 340);
            this.lbxStaff.TabIndex = 3;
            this.ttpToolTips.SetToolTip(this.lbxStaff, "Displays a list of staffs");
            // 
            // btnZA
            // 
            this.btnZA.Location = new System.Drawing.Point(418, 354);
            this.btnZA.Name = "btnZA";
            this.btnZA.Size = new System.Drawing.Size(119, 54);
            this.btnZA.TabIndex = 2;
            this.btnZA.Text = "ZA";
            this.ttpToolTips.SetToolTip(this.btnZA, "Sort staffs ZA");
            this.btnZA.UseVisualStyleBackColor = true;
            this.btnZA.Click += new System.EventHandler(this.btnZA_Click);
            // 
            // btnAZ
            // 
            this.btnAZ.Location = new System.Drawing.Point(417, 265);
            this.btnAZ.Name = "btnAZ";
            this.btnAZ.Size = new System.Drawing.Size(120, 49);
            this.btnAZ.TabIndex = 1;
            this.btnAZ.Text = "AZ";
            this.ttpToolTips.SetToolTip(this.btnAZ, "Sort staffs AZ");
            this.btnAZ.UseVisualStyleBackColor = true;
            this.btnAZ.Click += new System.EventHandler(this.btnAZ_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(381, 63);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(194, 68);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load";
            this.ttpToolTips.SetToolTip(this.btnLoad, "Load a list of Staffs");
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // gbxSearchSave
            // 
            this.gbxSearchSave.Controls.Add(this.btnSearch);
            this.gbxSearchSave.Controls.Add(this.tbxSearch);
            this.gbxSearchSave.Controls.Add(this.lbxSearchResults);
            this.gbxSearchSave.Location = new System.Drawing.Point(72, 578);
            this.gbxSearchSave.Name = "gbxSearchSave";
            this.gbxSearchSave.Size = new System.Drawing.Size(621, 401);
            this.gbxSearchSave.TabIndex = 2;
            this.gbxSearchSave.TabStop = false;
            this.gbxSearchSave.Text = "Search and Save";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(406, 53);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(132, 35);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.ttpToolTips.SetToolTip(this.btnSearch, "Search staffs list");
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(84, 54);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(210, 35);
            this.tbxSearch.TabIndex = 1;
            this.ttpToolTips.SetToolTip(this.tbxSearch, "Enter a search term");
            // 
            // lbxSearchResults
            // 
            this.lbxSearchResults.FormattingEnabled = true;
            this.lbxSearchResults.ItemHeight = 24;
            this.lbxSearchResults.Location = new System.Drawing.Point(58, 113);
            this.lbxSearchResults.Name = "lbxSearchResults";
            this.lbxSearchResults.Size = new System.Drawing.Size(480, 244);
            this.lbxSearchResults.TabIndex = 0;
            this.ttpToolTips.SetToolTip(this.lbxSearchResults, "Displays a list of staffs");
            this.lbxSearchResults.SelectedIndexChanged += new System.EventHandler(this.lbxSearchResults_SelectedIndexChanged);
            // 
            // lblStaffID
            // 
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.Location = new System.Drawing.Point(822, 589);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(106, 24);
            this.lblStaffID.TabIndex = 3;
            this.lblStaffID.Text = "Staff ID";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(843, 642);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(58, 24);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(785, 703);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(166, 24);
            this.lblDateOfBirth.TabIndex = 5;
            this.lblDateOfBirth.Text = "Date of Birth";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(831, 769);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(70, 24);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email";
            // 
            // lblAnnualSalary
            // 
            this.lblAnnualSalary.AutoSize = true;
            this.lblAnnualSalary.Location = new System.Drawing.Point(785, 835);
            this.lblAnnualSalary.Name = "lblAnnualSalary";
            this.lblAnnualSalary.Size = new System.Drawing.Size(166, 24);
            this.lblAnnualSalary.TabIndex = 7;
            this.lblAnnualSalary.Text = "Annual Salary";
            this.lblAnnualSalary.Click += new System.EventHandler(this.lblAnnualSalary_Click);
            // 
            // tbxStaffID
            // 
            this.tbxStaffID.Location = new System.Drawing.Point(989, 586);
            this.tbxStaffID.Name = "tbxStaffID";
            this.tbxStaffID.ReadOnly = true;
            this.tbxStaffID.Size = new System.Drawing.Size(292, 35);
            this.tbxStaffID.TabIndex = 8;
            this.ttpToolTips.SetToolTip(this.tbxStaffID, "ID of selected staff");
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(991, 639);
            this.tbxName.Name = "tbxName";
            this.tbxName.ReadOnly = true;
            this.tbxName.Size = new System.Drawing.Size(288, 35);
            this.tbxName.TabIndex = 9;
            this.ttpToolTips.SetToolTip(this.tbxName, "Name of selected staff");
            // 
            // tbxDateOfBirth
            // 
            this.tbxDateOfBirth.Location = new System.Drawing.Point(991, 700);
            this.tbxDateOfBirth.Name = "tbxDateOfBirth";
            this.tbxDateOfBirth.ReadOnly = true;
            this.tbxDateOfBirth.Size = new System.Drawing.Size(284, 35);
            this.tbxDateOfBirth.TabIndex = 10;
            this.ttpToolTips.SetToolTip(this.tbxDateOfBirth, "Date of birth of selected staff");
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(989, 766);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.ReadOnly = true;
            this.tbxEmail.Size = new System.Drawing.Size(286, 35);
            this.tbxEmail.TabIndex = 11;
            this.ttpToolTips.SetToolTip(this.tbxEmail, "Email of of selected staff");
            // 
            // tbxAnnualSalary
            // 
            this.tbxAnnualSalary.Location = new System.Drawing.Point(989, 832);
            this.tbxAnnualSalary.Name = "tbxAnnualSalary";
            this.tbxAnnualSalary.ReadOnly = true;
            this.tbxAnnualSalary.Size = new System.Drawing.Size(300, 35);
            this.tbxAnnualSalary.TabIndex = 12;
            this.ttpToolTips.SetToolTip(this.tbxAnnualSalary, "Annual Salary of of selected staff");
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(914, 916);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(138, 76);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.ttpToolTips.SetToolTip(this.btnSave, "Save selected staff");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // mnsMenu
            // 
            this.mnsMenu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.mnsMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.mnsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.storeToolStripMenuItem,
            this.loadAndSortToolStripMenuItem,
            this.saveAndSearchToolStripMenuItem});
            this.mnsMenu.Location = new System.Drawing.Point(0, 0);
            this.mnsMenu.Name = "mnsMenu";
            this.mnsMenu.Size = new System.Drawing.Size(1483, 40);
            this.mnsMenu.TabIndex = 14;
            this.mnsMenu.Text = "menuStrip1";
            // 
            // storeToolStripMenuItem
            // 
            this.storeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.storeToolStripMenuItem1,
            this.deleteToolStripMenuItem1});
            this.storeToolStripMenuItem.Name = "storeToolStripMenuItem";
            this.storeToolStripMenuItem.Size = new System.Drawing.Size(90, 36);
            this.storeToolStripMenuItem.Text = "Store";
            this.storeToolStripMenuItem.Click += new System.EventHandler(this.storeToolStripMenuItem_Click);
            // 
            // storeToolStripMenuItem1
            // 
            this.storeToolStripMenuItem1.Name = "storeToolStripMenuItem1";
            this.storeToolStripMenuItem1.Size = new System.Drawing.Size(359, 44);
            this.storeToolStripMenuItem1.Text = "Store";
            this.storeToolStripMenuItem1.Click += new System.EventHandler(this.btnStore_Click);
            // 
            // loadAndSortToolStripMenuItem
            // 
            this.loadAndSortToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.sortAZToolStripMenuItem,
            this.sortZAToolStripMenuItem});
            this.loadAndSortToolStripMenuItem.Name = "loadAndSortToolStripMenuItem";
            this.loadAndSortToolStripMenuItem.Size = new System.Drawing.Size(183, 38);
            this.loadAndSortToolStripMenuItem.Text = "Load and Sort";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(229, 44);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // sortAZToolStripMenuItem
            // 
            this.sortAZToolStripMenuItem.Name = "sortAZToolStripMenuItem";
            this.sortAZToolStripMenuItem.Size = new System.Drawing.Size(229, 44);
            this.sortAZToolStripMenuItem.Text = "Sort AZ";
            this.sortAZToolStripMenuItem.Click += new System.EventHandler(this.btnAZ_Click);
            // 
            // sortZAToolStripMenuItem
            // 
            this.sortZAToolStripMenuItem.Name = "sortZAToolStripMenuItem";
            this.sortZAToolStripMenuItem.Size = new System.Drawing.Size(229, 44);
            this.sortZAToolStripMenuItem.Text = "Sort ZA";
            this.sortZAToolStripMenuItem.Click += new System.EventHandler(this.btnZA_Click);
            // 
            // saveAndSearchToolStripMenuItem
            // 
            this.saveAndSearchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.saveAndSearchToolStripMenuItem.Name = "saveAndSearchToolStripMenuItem";
            this.saveAndSearchToolStripMenuItem.Size = new System.Drawing.Size(210, 38);
            this.saveAndSearchToolStripMenuItem.Text = "Save and Search";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(220, 44);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(220, 44);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // stsStatus
            // 
            this.stsStatus.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.stsStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslStatus});
            this.stsStatus.Location = new System.Drawing.Point(0, 1075);
            this.stsStatus.Name = "stsStatus";
            this.stsStatus.Size = new System.Drawing.Size(1483, 42);
            this.stsStatus.TabIndex = 15;
            this.stsStatus.Text = "statusStrip1";
            // 
            // tslStatus
            // 
            this.tslStatus.Name = "tslStatus";
            this.tslStatus.Size = new System.Drawing.Size(79, 32);
            this.tslStatus.Text = "Ready";
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(359, 44);
            this.deleteToolStripMenuItem1.Text = "Delete";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1483, 1117);
            this.Controls.Add(this.stsStatus);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbxAnnualSalary);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.tbxDateOfBirth);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.tbxStaffID);
            this.Controls.Add(this.lblAnnualSalary);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblDateOfBirth);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblStaffID);
            this.Controls.Add(this.gbxSearchSave);
            this.Controls.Add(this.gbxLoadSort);
            this.Controls.Add(this.gbxStore);
            this.Controls.Add(this.mnsMenu);
            this.MainMenuStrip = this.mnsMenu;
            this.Name = "Form1";
            this.Text = "Benchmark Application";
            this.gbxStore.ResumeLayout(false);
            this.gbxStore.PerformLayout();
            this.gbxLoadSort.ResumeLayout(false);
            this.gbxSearchSave.ResumeLayout(false);
            this.gbxSearchSave.PerformLayout();
            this.mnsMenu.ResumeLayout(false);
            this.mnsMenu.PerformLayout();
            this.stsStatus.ResumeLayout(false);
            this.stsStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxStore;
        private System.Windows.Forms.Button btnStore;
        private System.Windows.Forms.TextBox tbxInputAnnualSalary;
        private System.Windows.Forms.TextBox tbxInputEmail;
        private System.Windows.Forms.TextBox tbxInputName;
        private System.Windows.Forms.TextBox tbxInputStaffID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxLoadSort;
        private System.Windows.Forms.ListBox lbxStaff;
        private System.Windows.Forms.Button btnZA;
        private System.Windows.Forms.Button btnAZ;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.GroupBox gbxSearchSave;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.ListBox lbxSearchResults;
        private System.Windows.Forms.Label lblStaffID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAnnualSalary;
        private System.Windows.Forms.TextBox tbxStaffID;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxDateOfBirth;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxAnnualSalary;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.MenuStrip mnsMenu;
        private System.Windows.Forms.ToolTip ttpToolTips;
        private System.Windows.Forms.ToolStripMenuItem storeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem storeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loadAndSortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortAZToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortZAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAndSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.StatusStrip stsStatus;
        private System.Windows.Forms.ToolStripStatusLabel tslStatus;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
    }
}

