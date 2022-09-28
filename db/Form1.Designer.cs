namespace db
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMotherBoardAdd = new System.Windows.Forms.Button();
            this.txtMBtitle = new System.Windows.Forms.TextBox();
            this.cmbMBmonufacturer = new System.Windows.Forms.ComboBox();
            this.cmbMBram = new System.Windows.Forms.ComboBox();
            this.cmbMBGCPU = new System.Windows.Forms.ComboBox();
            this.cmbMBSocket = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMotherBoard = new System.Windows.Forms.CheckBox();
            this.dgvMotherBoard = new System.Windows.Forms.DataGridView();
            this.mbDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvCPU = new System.Windows.Forms.DataGridView();
            this.cmbCpuMonufacturer = new System.Windows.Forms.ComboBox();
            this.cmbCpuSocket = new System.Windows.Forms.ComboBox();
            this.cmbCpuArchetype = new System.Windows.Forms.ComboBox();
            this.cbCpuIsDelete = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nudCpuPower = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbCpuFrequency = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCpuAdd = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.cpuDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtCpuTitle = new System.Windows.Forms.TextBox();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.socketDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.gCPUtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.rAMtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.motherBoardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frequencyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.powerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.socketDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.archetypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMotherBoard)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCpuPower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motherBoardBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPUBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1241, 522);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.cbMotherBoard);
            this.tabPage1.Controls.Add(this.dgvMotherBoard);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1233, 496);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Материнская плата";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMotherBoardAdd);
            this.panel1.Controls.Add(this.txtMBtitle);
            this.panel1.Controls.Add(this.cmbMBmonufacturer);
            this.panel1.Controls.Add(this.cmbMBram);
            this.panel1.Controls.Add(this.cmbMBGCPU);
            this.panel1.Controls.Add(this.cmbMBSocket);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(801, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 340);
            this.panel1.TabIndex = 2;
            // 
            // btnMotherBoardAdd
            // 
            this.btnMotherBoardAdd.Location = new System.Drawing.Point(75, 256);
            this.btnMotherBoardAdd.Name = "btnMotherBoardAdd";
            this.btnMotherBoardAdd.Size = new System.Drawing.Size(85, 32);
            this.btnMotherBoardAdd.TabIndex = 10;
            this.btnMotherBoardAdd.Text = "Добавить";
            this.btnMotherBoardAdd.UseVisualStyleBackColor = true;
            this.btnMotherBoardAdd.Click += new System.EventHandler(this.btnMotherBoardAdd_Click);
            // 
            // txtMBtitle
            // 
            this.txtMBtitle.Location = new System.Drawing.Point(57, 229);
            this.txtMBtitle.Name = "txtMBtitle";
            this.txtMBtitle.Size = new System.Drawing.Size(121, 20);
            this.txtMBtitle.TabIndex = 9;
            // 
            // cmbMBmonufacturer
            // 
            this.cmbMBmonufacturer.FormattingEnabled = true;
            this.cmbMBmonufacturer.Location = new System.Drawing.Point(57, 181);
            this.cmbMBmonufacturer.Name = "cmbMBmonufacturer";
            this.cmbMBmonufacturer.Size = new System.Drawing.Size(121, 21);
            this.cmbMBmonufacturer.TabIndex = 8;
            // 
            // cmbMBram
            // 
            this.cmbMBram.FormattingEnabled = true;
            this.cmbMBram.Location = new System.Drawing.Point(57, 133);
            this.cmbMBram.Name = "cmbMBram";
            this.cmbMBram.Size = new System.Drawing.Size(121, 21);
            this.cmbMBram.TabIndex = 7;
            // 
            // cmbMBGCPU
            // 
            this.cmbMBGCPU.FormattingEnabled = true;
            this.cmbMBGCPU.Location = new System.Drawing.Point(57, 85);
            this.cmbMBGCPU.Name = "cmbMBGCPU";
            this.cmbMBGCPU.Size = new System.Drawing.Size(121, 21);
            this.cmbMBGCPU.TabIndex = 6;
            // 
            // cmbMBSocket
            // 
            this.cmbMBSocket.FormattingEnabled = true;
            this.cmbMBSocket.Location = new System.Drawing.Point(57, 37);
            this.cmbMBSocket.Name = "cmbMBSocket";
            this.cmbMBSocket.Size = new System.Drawing.Size(121, 21);
            this.cmbMBSocket.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Название";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Производитель";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ОЗУ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Видеокарта";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сокет";
            // 
            // cbMotherBoard
            // 
            this.cbMotherBoard.AutoSize = true;
            this.cbMotherBoard.Location = new System.Drawing.Point(846, 20);
            this.cbMotherBoard.Name = "cbMotherBoard";
            this.cbMotherBoard.Size = new System.Drawing.Size(161, 17);
            this.cbMotherBoard.TabIndex = 1;
            this.cbMotherBoard.Text = "Включить редактирование";
            this.cbMotherBoard.UseVisualStyleBackColor = true;
            this.cbMotherBoard.CheckedChanged += new System.EventHandler(this.cbMotherBoard_CheckedChanged);
            // 
            // dgvMotherBoard
            // 
            this.dgvMotherBoard.AllowUserToAddRows = false;
            this.dgvMotherBoard.AutoGenerateColumns = false;
            this.dgvMotherBoard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMotherBoard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.socketDataGridViewTextBoxColumn,
            this.gCPUtypeDataGridViewTextBoxColumn,
            this.rAMtypeDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.manufacturerDataGridViewTextBoxColumn,
            this.mbDelete});
            this.dgvMotherBoard.DataSource = this.motherBoardBindingSource;
            this.dgvMotherBoard.Location = new System.Drawing.Point(6, 6);
            this.dgvMotherBoard.Name = "dgvMotherBoard";
            this.dgvMotherBoard.Size = new System.Drawing.Size(753, 471);
            this.dgvMotherBoard.TabIndex = 0;
            this.dgvMotherBoard.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvMotherBoard_CellBeginEdit);
            this.dgvMotherBoard.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMotherBoard_CellContentClick);
            this.dgvMotherBoard.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMotherBoard_CellEndEdit);
            this.dgvMotherBoard.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.tableValidating);
            // 
            // mbDelete
            // 
            this.mbDelete.HeaderText = "Удаление";
            this.mbDelete.Name = "mbDelete";
            this.mbDelete.Text = "Удалить";
            this.mbDelete.UseColumnTextForButtonValue = true;
            this.mbDelete.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtCpuTitle);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.btnCpuAdd);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.cmbCpuFrequency);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.nudCpuPower);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.cbCpuIsDelete);
            this.tabPage2.Controls.Add(this.cmbCpuArchetype);
            this.tabPage2.Controls.Add(this.cmbCpuSocket);
            this.tabPage2.Controls.Add(this.cmbCpuMonufacturer);
            this.tabPage2.Controls.Add(this.dgvCPU);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1233, 496);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Процессор";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvCPU
            // 
            this.dgvCPU.AllowUserToAddRows = false;
            this.dgvCPU.AutoGenerateColumns = false;
            this.dgvCPU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCPU.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.frequencyDataGridViewTextBoxColumn,
            this.powerDataGridViewTextBoxColumn,
            this.socketDataGridViewTextBoxColumn1,
            this.archetypeDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn1,
            this.manufacturerDataGridViewTextBoxColumn1,
            this.cpuDelete});
            this.dgvCPU.DataSource = this.cPUBindingSource;
            this.dgvCPU.Location = new System.Drawing.Point(17, 6);
            this.dgvCPU.Name = "dgvCPU";
            this.dgvCPU.ReadOnly = true;
            this.dgvCPU.Size = new System.Drawing.Size(839, 469);
            this.dgvCPU.TabIndex = 0;
            this.dgvCPU.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCPU_CellContentClick);
            // 
            // cmbCpuMonufacturer
            // 
            this.cmbCpuMonufacturer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCpuMonufacturer.FormattingEnabled = true;
            this.cmbCpuMonufacturer.Location = new System.Drawing.Point(974, 79);
            this.cmbCpuMonufacturer.Name = "cmbCpuMonufacturer";
            this.cmbCpuMonufacturer.Size = new System.Drawing.Size(146, 21);
            this.cmbCpuMonufacturer.TabIndex = 1;
            // 
            // cmbCpuSocket
            // 
            this.cmbCpuSocket.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCpuSocket.FormattingEnabled = true;
            this.cmbCpuSocket.Location = new System.Drawing.Point(974, 139);
            this.cmbCpuSocket.Name = "cmbCpuSocket";
            this.cmbCpuSocket.Size = new System.Drawing.Size(146, 21);
            this.cmbCpuSocket.TabIndex = 2;
            // 
            // cmbCpuArchetype
            // 
            this.cmbCpuArchetype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCpuArchetype.FormattingEnabled = true;
            this.cmbCpuArchetype.Location = new System.Drawing.Point(974, 199);
            this.cmbCpuArchetype.Name = "cmbCpuArchetype";
            this.cmbCpuArchetype.Size = new System.Drawing.Size(146, 21);
            this.cmbCpuArchetype.TabIndex = 3;
            // 
            // cbCpuIsDelete
            // 
            this.cbCpuIsDelete.AutoSize = true;
            this.cbCpuIsDelete.Location = new System.Drawing.Point(974, 20);
            this.cbCpuIsDelete.Name = "cbCpuIsDelete";
            this.cbCpuIsDelete.Size = new System.Drawing.Size(125, 17);
            this.cbCpuIsDelete.TabIndex = 4;
            this.cbCpuIsDelete.Text = "Включить удаление";
            this.cbCpuIsDelete.UseVisualStyleBackColor = true;
            this.cbCpuIsDelete.CheckedChanged += new System.EventHandler(this.cbCpuIsDelete_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1004, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Производитель";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1029, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Сокет";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1012, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Архитектура";
            // 
            // nudCpuPower
            // 
            this.nudCpuPower.Location = new System.Drawing.Point(974, 259);
            this.nudCpuPower.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.nudCpuPower.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudCpuPower.Name = "nudCpuPower";
            this.nudCpuPower.Size = new System.Drawing.Size(146, 20);
            this.nudCpuPower.TabIndex = 8;
            this.nudCpuPower.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(993, 233);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Энергопотребление";
            // 
            // cmbCpuFrequency
            // 
            this.cmbCpuFrequency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCpuFrequency.FormattingEnabled = true;
            this.cmbCpuFrequency.Location = new System.Drawing.Point(974, 318);
            this.cmbCpuFrequency.Name = "cmbCpuFrequency";
            this.cmbCpuFrequency.Size = new System.Drawing.Size(146, 21);
            this.cmbCpuFrequency.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(999, 292);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Тактовая частота";
            // 
            // btnCpuAdd
            // 
            this.btnCpuAdd.Location = new System.Drawing.Point(987, 417);
            this.btnCpuAdd.Name = "btnCpuAdd";
            this.btnCpuAdd.Size = new System.Drawing.Size(114, 46);
            this.btnCpuAdd.TabIndex = 12;
            this.btnCpuAdd.Text = "Добавить";
            this.btnCpuAdd.UseVisualStyleBackColor = true;
            this.btnCpuAdd.Click += new System.EventHandler(this.btnCpuAdd_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1019, 352);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Название";
            // 
            // cpuDelete
            // 
            this.cpuDelete.HeaderText = "Удаление";
            this.cpuDelete.Name = "cpuDelete";
            this.cpuDelete.ReadOnly = true;
            this.cpuDelete.Text = "Удалить";
            this.cpuDelete.UseColumnTextForButtonValue = true;
            this.cpuDelete.Visible = false;
            // 
            // txtCpuTitle
            // 
            this.txtCpuTitle.Location = new System.Drawing.Point(974, 378);
            this.txtCpuTitle.Name = "txtCpuTitle";
            this.txtCpuTitle.Size = new System.Drawing.Size(146, 20);
            this.txtCpuTitle.TabIndex = 14;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // socketDataGridViewTextBoxColumn
            // 
            this.socketDataGridViewTextBoxColumn.DataPropertyName = "socket";
            this.socketDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.socketDataGridViewTextBoxColumn.FillWeight = 26.19114F;
            this.socketDataGridViewTextBoxColumn.HeaderText = "Сокет";
            this.socketDataGridViewTextBoxColumn.Items.AddRange(new object[] {
            "Socket 8",
            "Socket 370",
            "Socket 423",
            "Socket 478",
            "LGA 775",
            "LGA 771",
            "LGA 1366",
            "LGA 1156",
            "LGA 1567",
            "LGA 1155",
            "LGA 2011",
            "LGA 1356",
            "LGA 1150",
            "LGA2011-3",
            "LGA 1151;",
            "LGA 3647",
            "LGA 2066",
            "LGA 1200",
            "LGA 1700",
            "Super Socket 7",
            "Slot A",
            "Socket A",
            "Socket 754",
            "Socket 940",
            "Socket 939",
            "Socket S1",
            "Socket AM2",
            "Socket F",
            "Socket AM2+",
            " Socket AM3",
            "Socket G3",
            "Socket C32",
            "Socket AM3+",
            "Socket FM1",
            "Socket FS1",
            "Socket FM2",
            "Socket FM2+",
            "Socket AM1",
            "АМ4",
            "Socket SP3",
            "Socket TR4",
            "Socket sTRX4"});
            this.socketDataGridViewTextBoxColumn.Name = "socketDataGridViewTextBoxColumn";
            this.socketDataGridViewTextBoxColumn.ReadOnly = true;
            this.socketDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.socketDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.socketDataGridViewTextBoxColumn.Width = 70;
            // 
            // gCPUtypeDataGridViewTextBoxColumn
            // 
            this.gCPUtypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.gCPUtypeDataGridViewTextBoxColumn.DataPropertyName = "GCPUtype";
            this.gCPUtypeDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.gCPUtypeDataGridViewTextBoxColumn.FillWeight = 18.3338F;
            this.gCPUtypeDataGridViewTextBoxColumn.HeaderText = "Поддерживаемые видеокарты";
            this.gCPUtypeDataGridViewTextBoxColumn.Items.AddRange(new object[] {
            "GeForce series",
            "GeForce 100 serie",
            "GeForce 200 series",
            "GeForce 300 series",
            "GeForce 400 series",
            "GeForce 500 series",
            "GeForce 600 series",
            "GeForce 700 series",
            "GeForce 800 series",
            "GeForce 900 series",
            "GeForce 2 series",
            "GeForce 3 series",
            "GeForce 4 series",
            "GeForce 5 series",
            "GeForce 6 series",
            "GeForce 7 series",
            "GeForce 8 series",
            "GeForce 9 series",
            "GeForce 10 series",
            "GeForce 16 series",
            "GeForce 20 series",
            "Radeon R100",
            "Radeon R200",
            "Radeon R300",
            "Radeon R400",
            "Radeon R500",
            "Radeon R600",
            "Radeon R700",
            "Radeon R800"});
            this.gCPUtypeDataGridViewTextBoxColumn.Name = "gCPUtypeDataGridViewTextBoxColumn";
            this.gCPUtypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.gCPUtypeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // rAMtypeDataGridViewTextBoxColumn
            // 
            this.rAMtypeDataGridViewTextBoxColumn.DataPropertyName = "RAMtype";
            this.rAMtypeDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.rAMtypeDataGridViewTextBoxColumn.FillWeight = 26.19114F;
            this.rAMtypeDataGridViewTextBoxColumn.HeaderText = "Тип поддерживаемой RAM";
            this.rAMtypeDataGridViewTextBoxColumn.Items.AddRange(new object[] {
            "DDR1",
            "DDR2",
            "DDR3",
            "DDR4"});
            this.rAMtypeDataGridViewTextBoxColumn.Name = "rAMtypeDataGridViewTextBoxColumn";
            this.rAMtypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.rAMtypeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.rAMtypeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.rAMtypeDataGridViewTextBoxColumn.Width = 70;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn.FillWeight = 26.19114F;
            this.titleDataGridViewTextBoxColumn.HeaderText = "Название";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            this.titleDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // manufacturerDataGridViewTextBoxColumn
            // 
            this.manufacturerDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.manufacturerDataGridViewTextBoxColumn.DataPropertyName = "manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.manufacturerDataGridViewTextBoxColumn.FillWeight = 373.0928F;
            this.manufacturerDataGridViewTextBoxColumn.HeaderText = "Производитель";
            this.manufacturerDataGridViewTextBoxColumn.Items.AddRange(new object[] {
            "ASRock",
            "MSI",
            "ASUS",
            "Gigabyte"});
            this.manufacturerDataGridViewTextBoxColumn.Name = "manufacturerDataGridViewTextBoxColumn";
            this.manufacturerDataGridViewTextBoxColumn.ReadOnly = true;
            this.manufacturerDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.manufacturerDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // motherBoardBindingSource
            // 
            this.motherBoardBindingSource.DataSource = typeof(db.Classes.MotherBoard);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // frequencyDataGridViewTextBoxColumn
            // 
            this.frequencyDataGridViewTextBoxColumn.DataPropertyName = "frequency";
            this.frequencyDataGridViewTextBoxColumn.HeaderText = "Тактовая частота";
            this.frequencyDataGridViewTextBoxColumn.Name = "frequencyDataGridViewTextBoxColumn";
            this.frequencyDataGridViewTextBoxColumn.ReadOnly = true;
            this.frequencyDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // powerDataGridViewTextBoxColumn
            // 
            this.powerDataGridViewTextBoxColumn.DataPropertyName = "power";
            this.powerDataGridViewTextBoxColumn.HeaderText = "Энергопотребление";
            this.powerDataGridViewTextBoxColumn.Name = "powerDataGridViewTextBoxColumn";
            this.powerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // socketDataGridViewTextBoxColumn1
            // 
            this.socketDataGridViewTextBoxColumn1.DataPropertyName = "socket";
            this.socketDataGridViewTextBoxColumn1.HeaderText = "Сокет";
            this.socketDataGridViewTextBoxColumn1.Name = "socketDataGridViewTextBoxColumn1";
            this.socketDataGridViewTextBoxColumn1.ReadOnly = true;
            this.socketDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // archetypeDataGridViewTextBoxColumn
            // 
            this.archetypeDataGridViewTextBoxColumn.DataPropertyName = "archetype";
            this.archetypeDataGridViewTextBoxColumn.HeaderText = "Архитектура";
            this.archetypeDataGridViewTextBoxColumn.Name = "archetypeDataGridViewTextBoxColumn";
            this.archetypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.archetypeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // titleDataGridViewTextBoxColumn1
            // 
            this.titleDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.titleDataGridViewTextBoxColumn1.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn1.HeaderText = "Название";
            this.titleDataGridViewTextBoxColumn1.Name = "titleDataGridViewTextBoxColumn1";
            this.titleDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // manufacturerDataGridViewTextBoxColumn1
            // 
            this.manufacturerDataGridViewTextBoxColumn1.DataPropertyName = "manufacturer";
            this.manufacturerDataGridViewTextBoxColumn1.HeaderText = "Производитель";
            this.manufacturerDataGridViewTextBoxColumn1.Name = "manufacturerDataGridViewTextBoxColumn1";
            this.manufacturerDataGridViewTextBoxColumn1.ReadOnly = true;
            this.manufacturerDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // cPUBindingSource
            // 
            this.cPUBindingSource.DataSource = typeof(db.Classes.CPU);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 546);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMotherBoard)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCpuPower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motherBoardBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPUBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvMotherBoard;
        private System.Windows.Forms.BindingSource motherBoardBindingSource;
        private System.Windows.Forms.CheckBox cbMotherBoard;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn socketDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn gCPUtypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn rAMtypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn manufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn mbDelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMotherBoardAdd;
        private System.Windows.Forms.TextBox txtMBtitle;
        private System.Windows.Forms.ComboBox cmbMBmonufacturer;
        private System.Windows.Forms.ComboBox cmbMBram;
        private System.Windows.Forms.ComboBox cmbMBGCPU;
        private System.Windows.Forms.ComboBox cmbMBSocket;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCPU;
        private System.Windows.Forms.BindingSource cPUBindingSource;
        private System.Windows.Forms.ComboBox cmbCpuArchetype;
        private System.Windows.Forms.ComboBox cmbCpuSocket;
        private System.Windows.Forms.ComboBox cmbCpuMonufacturer;
        private System.Windows.Forms.CheckBox cbCpuIsDelete;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbCpuFrequency;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nudCpuPower;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCpuTitle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnCpuAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn frequencyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn powerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn socketDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn archetypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn cpuDelete;
    }
}

