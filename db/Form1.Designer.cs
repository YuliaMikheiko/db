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
            this.txtCpuTitle = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCpuAdd = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbCpuFrequency = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.nudCpuPower = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbCpuIsDelete = new System.Windows.Forms.CheckBox();
            this.cmbCpuArchetype = new System.Windows.Forms.ComboBox();
            this.cmbCpuSocket = new System.Windows.Forms.ComboBox();
            this.cmbCpuMonufacturer = new System.Windows.Forms.ComboBox();
            this.dgvCPU = new System.Windows.Forms.DataGridView();
            this.cpuDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cbVideoCardDelete = new System.Windows.Forms.CheckBox();
            this.btnVideoCardAdd = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtVideoCardTitle = new System.Windows.Forms.TextBox();
            this.cmbVideoCardVolume = new System.Windows.Forms.ComboBox();
            this.cmbVideoCardPower = new System.Windows.Forms.ComboBox();
            this.cmbVideoCardFrequency = new System.Windows.Forms.ComboBox();
            this.cmbVideoCardMemory = new System.Windows.Forms.ComboBox();
            this.cmbVideoCardGCPU = new System.Windows.Forms.ComboBox();
            this.cmbVideoCardManufacturer = new System.Windows.Forms.ComboBox();
            this.dgvVideoCard = new System.Windows.Forms.DataGridView();
            this.vcDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.cbPowerBlockDelete = new System.Windows.Forms.CheckBox();
            this.btnPowerBlock = new System.Windows.Forms.Button();
            this.txtPowerBlockTitle = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.cmbPowerBlockManufacturer = new System.Windows.Forms.ComboBox();
            this.cmbPowerBlockPower = new System.Windows.Forms.ComboBox();
            this.dgvPowerBlock = new System.Windows.Forms.DataGridView();
            this.dgvPowerBlockDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btnStorageAdd = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtStorageTitle = new System.Windows.Forms.TextBox();
            this.cmbStorageRead = new System.Windows.Forms.ComboBox();
            this.cmbStorageWrite = new System.Windows.Forms.ComboBox();
            this.cmbStorageType = new System.Windows.Forms.ComboBox();
            this.cmbStorageVolume = new System.Windows.Forms.ComboBox();
            this.cmbStorageManufacturer = new System.Windows.Forms.ComboBox();
            this.cbStorageDelete = new System.Windows.Forms.CheckBox();
            this.dgvStorage = new System.Windows.Forms.DataGridView();
            this.storageDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.dgvRam = new System.Windows.Forms.DataGridView();
            this.cbRamDelete = new System.Windows.Forms.CheckBox();
            this.cmbRamManufacturer = new System.Windows.Forms.ComboBox();
            this.cmbRamVolume = new System.Windows.Forms.ComboBox();
            this.cmbRamFrenquency = new System.Windows.Forms.ComboBox();
            this.cmbRamType = new System.Windows.Forms.ComboBox();
            this.txtRamTitle = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.btnRamAdd = new System.Windows.Forms.Button();
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
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gCPUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volumeMemoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeMemoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frequencyMemoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.powerDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.videoCardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.powerDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.powerBlockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voluneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speedOfWriteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speedOfReadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rAMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeMemoryDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frequencyDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voluneDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerDataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ramDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMotherBoard)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCpuPower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCPU)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVideoCard)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPowerBlock)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStorage)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motherBoardBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoCardBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.powerBlockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rAMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
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
            // txtCpuTitle
            // 
            this.txtCpuTitle.Location = new System.Drawing.Point(974, 378);
            this.txtCpuTitle.Name = "txtCpuTitle";
            this.txtCpuTitle.Size = new System.Drawing.Size(146, 20);
            this.txtCpuTitle.TabIndex = 14;
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(999, 292);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Тактовая частота";
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(993, 233);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Энергопотребление";
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1012, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Архитектура";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1004, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Производитель";
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
            // cmbCpuArchetype
            // 
            this.cmbCpuArchetype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCpuArchetype.FormattingEnabled = true;
            this.cmbCpuArchetype.Location = new System.Drawing.Point(974, 199);
            this.cmbCpuArchetype.Name = "cmbCpuArchetype";
            this.cmbCpuArchetype.Size = new System.Drawing.Size(146, 21);
            this.cmbCpuArchetype.TabIndex = 3;
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
            // cmbCpuMonufacturer
            // 
            this.cmbCpuMonufacturer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCpuMonufacturer.FormattingEnabled = true;
            this.cmbCpuMonufacturer.Location = new System.Drawing.Point(974, 79);
            this.cmbCpuMonufacturer.Name = "cmbCpuMonufacturer";
            this.cmbCpuMonufacturer.Size = new System.Drawing.Size(146, 21);
            this.cmbCpuMonufacturer.TabIndex = 1;
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
            // cpuDelete
            // 
            this.cpuDelete.HeaderText = "Удаление";
            this.cpuDelete.Name = "cpuDelete";
            this.cpuDelete.ReadOnly = true;
            this.cpuDelete.Text = "Удалить";
            this.cpuDelete.UseColumnTextForButtonValue = true;
            this.cpuDelete.Visible = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.cbVideoCardDelete);
            this.tabPage3.Controls.Add(this.btnVideoCardAdd);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.txtVideoCardTitle);
            this.tabPage3.Controls.Add(this.cmbVideoCardVolume);
            this.tabPage3.Controls.Add(this.cmbVideoCardPower);
            this.tabPage3.Controls.Add(this.cmbVideoCardFrequency);
            this.tabPage3.Controls.Add(this.cmbVideoCardMemory);
            this.tabPage3.Controls.Add(this.cmbVideoCardGCPU);
            this.tabPage3.Controls.Add(this.cmbVideoCardManufacturer);
            this.tabPage3.Controls.Add(this.dgvVideoCard);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1233, 496);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Видеокарта";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cbVideoCardDelete
            // 
            this.cbVideoCardDelete.AutoSize = true;
            this.cbVideoCardDelete.Location = new System.Drawing.Point(1028, 3);
            this.cbVideoCardDelete.Name = "cbVideoCardDelete";
            this.cbVideoCardDelete.Size = new System.Drawing.Size(125, 17);
            this.cbVideoCardDelete.TabIndex = 16;
            this.cbVideoCardDelete.Text = "Включить удаление";
            this.cbVideoCardDelete.UseVisualStyleBackColor = true;
            this.cbVideoCardDelete.CheckedChanged += new System.EventHandler(this.cbVideoCardDelete_CheckedChanged);
            // 
            // btnVideoCardAdd
            // 
            this.btnVideoCardAdd.Location = new System.Drawing.Point(1044, 426);
            this.btnVideoCardAdd.Name = "btnVideoCardAdd";
            this.btnVideoCardAdd.Size = new System.Drawing.Size(89, 35);
            this.btnVideoCardAdd.TabIndex = 15;
            this.btnVideoCardAdd.Text = "Добавить";
            this.btnVideoCardAdd.UseVisualStyleBackColor = true;
            this.btnVideoCardAdd.Click += new System.EventHandler(this.btnVideoCardAdd_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(1060, 359);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(57, 13);
            this.label18.TabIndex = 14;
            this.label18.Text = "Название";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(1047, 303);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(82, 13);
            this.label17.TabIndex = 13;
            this.label17.Text = "Объем памяти";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1020, 247);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(137, 13);
            this.label16.TabIndex = 12;
            this.label16.Text = "Потребляемая мощность";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1064, 191);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 13);
            this.label15.TabIndex = 11;
            this.label15.Text = "Частота";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1055, 135);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "Тип памяти";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1038, 79);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Графическое ядро";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1045, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Производитель";
            // 
            // txtVideoCardTitle
            // 
            this.txtVideoCardTitle.Location = new System.Drawing.Point(1028, 383);
            this.txtVideoCardTitle.Name = "txtVideoCardTitle";
            this.txtVideoCardTitle.Size = new System.Drawing.Size(121, 20);
            this.txtVideoCardTitle.TabIndex = 7;
            // 
            // cmbVideoCardVolume
            // 
            this.cmbVideoCardVolume.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVideoCardVolume.FormattingEnabled = true;
            this.cmbVideoCardVolume.Location = new System.Drawing.Point(1028, 327);
            this.cmbVideoCardVolume.Name = "cmbVideoCardVolume";
            this.cmbVideoCardVolume.Size = new System.Drawing.Size(121, 21);
            this.cmbVideoCardVolume.TabIndex = 6;
            // 
            // cmbVideoCardPower
            // 
            this.cmbVideoCardPower.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVideoCardPower.FormattingEnabled = true;
            this.cmbVideoCardPower.Location = new System.Drawing.Point(1028, 271);
            this.cmbVideoCardPower.Name = "cmbVideoCardPower";
            this.cmbVideoCardPower.Size = new System.Drawing.Size(121, 21);
            this.cmbVideoCardPower.TabIndex = 5;
            // 
            // cmbVideoCardFrequency
            // 
            this.cmbVideoCardFrequency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVideoCardFrequency.FormattingEnabled = true;
            this.cmbVideoCardFrequency.Location = new System.Drawing.Point(1028, 215);
            this.cmbVideoCardFrequency.Name = "cmbVideoCardFrequency";
            this.cmbVideoCardFrequency.Size = new System.Drawing.Size(121, 21);
            this.cmbVideoCardFrequency.TabIndex = 4;
            // 
            // cmbVideoCardMemory
            // 
            this.cmbVideoCardMemory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVideoCardMemory.FormattingEnabled = true;
            this.cmbVideoCardMemory.Location = new System.Drawing.Point(1028, 159);
            this.cmbVideoCardMemory.Name = "cmbVideoCardMemory";
            this.cmbVideoCardMemory.Size = new System.Drawing.Size(121, 21);
            this.cmbVideoCardMemory.TabIndex = 3;
            // 
            // cmbVideoCardGCPU
            // 
            this.cmbVideoCardGCPU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVideoCardGCPU.FormattingEnabled = true;
            this.cmbVideoCardGCPU.Location = new System.Drawing.Point(1028, 103);
            this.cmbVideoCardGCPU.Name = "cmbVideoCardGCPU";
            this.cmbVideoCardGCPU.Size = new System.Drawing.Size(121, 21);
            this.cmbVideoCardGCPU.TabIndex = 2;
            // 
            // cmbVideoCardManufacturer
            // 
            this.cmbVideoCardManufacturer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVideoCardManufacturer.FormattingEnabled = true;
            this.cmbVideoCardManufacturer.Location = new System.Drawing.Point(1028, 47);
            this.cmbVideoCardManufacturer.Name = "cmbVideoCardManufacturer";
            this.cmbVideoCardManufacturer.Size = new System.Drawing.Size(121, 21);
            this.cmbVideoCardManufacturer.TabIndex = 1;
            // 
            // dgvVideoCard
            // 
            this.dgvVideoCard.AllowUserToAddRows = false;
            this.dgvVideoCard.AutoGenerateColumns = false;
            this.dgvVideoCard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVideoCard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn2,
            this.gCPUDataGridViewTextBoxColumn,
            this.volumeMemoryDataGridViewTextBoxColumn,
            this.typeMemoryDataGridViewTextBoxColumn,
            this.frequencyMemoryDataGridViewTextBoxColumn,
            this.powerDataGridViewTextBoxColumn1,
            this.titleDataGridViewTextBoxColumn2,
            this.manufacturerDataGridViewTextBoxColumn2,
            this.vcDelete});
            this.dgvVideoCard.DataSource = this.videoCardBindingSource;
            this.dgvVideoCard.Location = new System.Drawing.Point(3, 3);
            this.dgvVideoCard.Name = "dgvVideoCard";
            this.dgvVideoCard.ReadOnly = true;
            this.dgvVideoCard.Size = new System.Drawing.Size(955, 490);
            this.dgvVideoCard.TabIndex = 0;
            this.dgvVideoCard.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVideoCard_CellContentClick);
            // 
            // vcDelete
            // 
            this.vcDelete.HeaderText = "Удаление";
            this.vcDelete.Name = "vcDelete";
            this.vcDelete.ReadOnly = true;
            this.vcDelete.Text = "Удалить";
            this.vcDelete.UseColumnTextForButtonValue = true;
            this.vcDelete.Visible = false;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.cbPowerBlockDelete);
            this.tabPage4.Controls.Add(this.btnPowerBlock);
            this.tabPage4.Controls.Add(this.txtPowerBlockTitle);
            this.tabPage4.Controls.Add(this.label21);
            this.tabPage4.Controls.Add(this.label20);
            this.tabPage4.Controls.Add(this.label19);
            this.tabPage4.Controls.Add(this.cmbPowerBlockManufacturer);
            this.tabPage4.Controls.Add(this.cmbPowerBlockPower);
            this.tabPage4.Controls.Add(this.dgvPowerBlock);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1233, 496);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Блок питания";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // cbPowerBlockDelete
            // 
            this.cbPowerBlockDelete.AutoSize = true;
            this.cbPowerBlockDelete.Location = new System.Drawing.Point(643, 43);
            this.cbPowerBlockDelete.Name = "cbPowerBlockDelete";
            this.cbPowerBlockDelete.Size = new System.Drawing.Size(125, 17);
            this.cbPowerBlockDelete.TabIndex = 9;
            this.cbPowerBlockDelete.Text = "Включить удаление";
            this.cbPowerBlockDelete.UseVisualStyleBackColor = true;
            this.cbPowerBlockDelete.CheckedChanged += new System.EventHandler(this.cbPowerBlockDelete_CheckedChanged);
            // 
            // btnPowerBlock
            // 
            this.btnPowerBlock.Location = new System.Drawing.Point(850, 216);
            this.btnPowerBlock.Name = "btnPowerBlock";
            this.btnPowerBlock.Size = new System.Drawing.Size(83, 38);
            this.btnPowerBlock.TabIndex = 8;
            this.btnPowerBlock.Text = "Добавить";
            this.btnPowerBlock.UseVisualStyleBackColor = true;
            this.btnPowerBlock.Click += new System.EventHandler(this.btnPowerBlock_Click);
            // 
            // txtPowerBlockTitle
            // 
            this.txtPowerBlockTitle.Location = new System.Drawing.Point(831, 172);
            this.txtPowerBlockTitle.Name = "txtPowerBlockTitle";
            this.txtPowerBlockTitle.Size = new System.Drawing.Size(121, 20);
            this.txtPowerBlockTitle.TabIndex = 7;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(863, 147);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(57, 13);
            this.label21.TabIndex = 6;
            this.label21.Text = "Название";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(848, 89);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(86, 13);
            this.label20.TabIndex = 5;
            this.label20.Text = "Производитель";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(861, 31);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(60, 13);
            this.label19.TabIndex = 4;
            this.label19.Text = "Мощность";
            // 
            // cmbPowerBlockManufacturer
            // 
            this.cmbPowerBlockManufacturer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPowerBlockManufacturer.FormattingEnabled = true;
            this.cmbPowerBlockManufacturer.Location = new System.Drawing.Point(831, 114);
            this.cmbPowerBlockManufacturer.Name = "cmbPowerBlockManufacturer";
            this.cmbPowerBlockManufacturer.Size = new System.Drawing.Size(121, 21);
            this.cmbPowerBlockManufacturer.TabIndex = 2;
            // 
            // cmbPowerBlockPower
            // 
            this.cmbPowerBlockPower.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPowerBlockPower.FormattingEnabled = true;
            this.cmbPowerBlockPower.Location = new System.Drawing.Point(831, 56);
            this.cmbPowerBlockPower.Name = "cmbPowerBlockPower";
            this.cmbPowerBlockPower.Size = new System.Drawing.Size(121, 21);
            this.cmbPowerBlockPower.TabIndex = 1;
            // 
            // dgvPowerBlock
            // 
            this.dgvPowerBlock.AllowUserToAddRows = false;
            this.dgvPowerBlock.AutoGenerateColumns = false;
            this.dgvPowerBlock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPowerBlock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn3,
            this.powerDataGridViewTextBoxColumn2,
            this.titleDataGridViewTextBoxColumn3,
            this.manufacturerDataGridViewTextBoxColumn3,
            this.dgvPowerBlockDelete});
            this.dgvPowerBlock.DataSource = this.powerBlockBindingSource;
            this.dgvPowerBlock.Location = new System.Drawing.Point(3, 3);
            this.dgvPowerBlock.Name = "dgvPowerBlock";
            this.dgvPowerBlock.ReadOnly = true;
            this.dgvPowerBlock.Size = new System.Drawing.Size(578, 490);
            this.dgvPowerBlock.TabIndex = 0;
            this.dgvPowerBlock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPowerBlock_CellContentClick);
            // 
            // dgvPowerBlockDelete
            // 
            this.dgvPowerBlockDelete.HeaderText = "Удаление";
            this.dgvPowerBlockDelete.Name = "dgvPowerBlockDelete";
            this.dgvPowerBlockDelete.ReadOnly = true;
            this.dgvPowerBlockDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPowerBlockDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvPowerBlockDelete.Text = "Удалить";
            this.dgvPowerBlockDelete.UseColumnTextForButtonValue = true;
            this.dgvPowerBlockDelete.Visible = false;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.btnStorageAdd);
            this.tabPage5.Controls.Add(this.label27);
            this.tabPage5.Controls.Add(this.label26);
            this.tabPage5.Controls.Add(this.label25);
            this.tabPage5.Controls.Add(this.label24);
            this.tabPage5.Controls.Add(this.label23);
            this.tabPage5.Controls.Add(this.label22);
            this.tabPage5.Controls.Add(this.txtStorageTitle);
            this.tabPage5.Controls.Add(this.cmbStorageRead);
            this.tabPage5.Controls.Add(this.cmbStorageWrite);
            this.tabPage5.Controls.Add(this.cmbStorageType);
            this.tabPage5.Controls.Add(this.cmbStorageVolume);
            this.tabPage5.Controls.Add(this.cmbStorageManufacturer);
            this.tabPage5.Controls.Add(this.cbStorageDelete);
            this.tabPage5.Controls.Add(this.dgvStorage);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1233, 496);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "ПЗУ";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btnStorageAdd
            // 
            this.btnStorageAdd.Location = new System.Drawing.Point(989, 372);
            this.btnStorageAdd.Name = "btnStorageAdd";
            this.btnStorageAdd.Size = new System.Drawing.Size(86, 41);
            this.btnStorageAdd.TabIndex = 14;
            this.btnStorageAdd.Text = "Добавить";
            this.btnStorageAdd.UseVisualStyleBackColor = true;
            this.btnStorageAdd.Click += new System.EventHandler(this.btnStorageAdd_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(1004, 310);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(57, 13);
            this.label27.TabIndex = 13;
            this.label27.Text = "Название";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(985, 260);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(94, 13);
            this.label26.TabIndex = 12;
            this.label26.Text = "Скорость записи";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(985, 210);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(94, 13);
            this.label25.TabIndex = 11;
            this.label25.Text = "Скорость записи";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(1019, 160);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(26, 13);
            this.label24.TabIndex = 10;
            this.label24.Text = "Тип";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(1011, 110);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(42, 13);
            this.label23.TabIndex = 9;
            this.label23.Text = "Объем";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(989, 60);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(86, 13);
            this.label22.TabIndex = 8;
            this.label22.Text = "Производитель";
            // 
            // txtStorageTitle
            // 
            this.txtStorageTitle.Location = new System.Drawing.Point(972, 331);
            this.txtStorageTitle.Name = "txtStorageTitle";
            this.txtStorageTitle.Size = new System.Drawing.Size(121, 20);
            this.txtStorageTitle.TabIndex = 7;
            // 
            // cmbStorageRead
            // 
            this.cmbStorageRead.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStorageRead.FormattingEnabled = true;
            this.cmbStorageRead.Location = new System.Drawing.Point(972, 281);
            this.cmbStorageRead.Name = "cmbStorageRead";
            this.cmbStorageRead.Size = new System.Drawing.Size(121, 21);
            this.cmbStorageRead.TabIndex = 6;
            // 
            // cmbStorageWrite
            // 
            this.cmbStorageWrite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStorageWrite.FormattingEnabled = true;
            this.cmbStorageWrite.Location = new System.Drawing.Point(972, 231);
            this.cmbStorageWrite.Name = "cmbStorageWrite";
            this.cmbStorageWrite.Size = new System.Drawing.Size(121, 21);
            this.cmbStorageWrite.TabIndex = 5;
            // 
            // cmbStorageType
            // 
            this.cmbStorageType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStorageType.FormattingEnabled = true;
            this.cmbStorageType.Location = new System.Drawing.Point(972, 181);
            this.cmbStorageType.Name = "cmbStorageType";
            this.cmbStorageType.Size = new System.Drawing.Size(121, 21);
            this.cmbStorageType.TabIndex = 4;
            // 
            // cmbStorageVolume
            // 
            this.cmbStorageVolume.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStorageVolume.FormattingEnabled = true;
            this.cmbStorageVolume.Location = new System.Drawing.Point(972, 131);
            this.cmbStorageVolume.Name = "cmbStorageVolume";
            this.cmbStorageVolume.Size = new System.Drawing.Size(121, 21);
            this.cmbStorageVolume.TabIndex = 3;
            // 
            // cmbStorageManufacturer
            // 
            this.cmbStorageManufacturer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStorageManufacturer.FormattingEnabled = true;
            this.cmbStorageManufacturer.Location = new System.Drawing.Point(972, 81);
            this.cmbStorageManufacturer.Name = "cmbStorageManufacturer";
            this.cmbStorageManufacturer.Size = new System.Drawing.Size(121, 21);
            this.cmbStorageManufacturer.TabIndex = 2;
            // 
            // cbStorageDelete
            // 
            this.cbStorageDelete.AutoSize = true;
            this.cbStorageDelete.Location = new System.Drawing.Point(970, 26);
            this.cbStorageDelete.Name = "cbStorageDelete";
            this.cbStorageDelete.Size = new System.Drawing.Size(125, 17);
            this.cbStorageDelete.TabIndex = 1;
            this.cbStorageDelete.Text = "Включить удаление";
            this.cbStorageDelete.UseVisualStyleBackColor = true;
            this.cbStorageDelete.CheckedChanged += new System.EventHandler(this.cbStorageDelete_CheckedChanged);
            // 
            // dgvStorage
            // 
            this.dgvStorage.AllowUserToAddRows = false;
            this.dgvStorage.AutoGenerateColumns = false;
            this.dgvStorage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStorage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn4,
            this.voluneDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.speedOfWriteDataGridViewTextBoxColumn,
            this.speedOfReadDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn4,
            this.manufacturerDataGridViewTextBoxColumn4,
            this.storageDelete});
            this.dgvStorage.DataSource = this.storageBindingSource;
            this.dgvStorage.Location = new System.Drawing.Point(3, 3);
            this.dgvStorage.Name = "dgvStorage";
            this.dgvStorage.ReadOnly = true;
            this.dgvStorage.Size = new System.Drawing.Size(852, 490);
            this.dgvStorage.TabIndex = 0;
            this.dgvStorage.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStorage_CellContentClick);
            // 
            // storageDelete
            // 
            this.storageDelete.HeaderText = "Удаление";
            this.storageDelete.Name = "storageDelete";
            this.storageDelete.ReadOnly = true;
            this.storageDelete.Text = "Удалить";
            this.storageDelete.UseColumnTextForButtonValue = true;
            this.storageDelete.Visible = false;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.btnRamAdd);
            this.tabPage6.Controls.Add(this.label32);
            this.tabPage6.Controls.Add(this.label31);
            this.tabPage6.Controls.Add(this.label30);
            this.tabPage6.Controls.Add(this.label29);
            this.tabPage6.Controls.Add(this.label28);
            this.tabPage6.Controls.Add(this.txtRamTitle);
            this.tabPage6.Controls.Add(this.cmbRamType);
            this.tabPage6.Controls.Add(this.cmbRamFrenquency);
            this.tabPage6.Controls.Add(this.cmbRamVolume);
            this.tabPage6.Controls.Add(this.cmbRamManufacturer);
            this.tabPage6.Controls.Add(this.cbRamDelete);
            this.tabPage6.Controls.Add(this.dgvRam);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1233, 496);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "ОЗУ";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // dgvRam
            // 
            this.dgvRam.AllowUserToAddRows = false;
            this.dgvRam.AutoGenerateColumns = false;
            this.dgvRam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn5,
            this.typeMemoryDataGridViewTextBoxColumn1,
            this.frequencyDataGridViewTextBoxColumn1,
            this.voluneDataGridViewTextBoxColumn1,
            this.titleDataGridViewTextBoxColumn5,
            this.manufacturerDataGridViewTextBoxColumn5,
            this.ramDelete});
            this.dgvRam.DataSource = this.rAMBindingSource;
            this.dgvRam.Location = new System.Drawing.Point(3, 3);
            this.dgvRam.Name = "dgvRam";
            this.dgvRam.ReadOnly = true;
            this.dgvRam.Size = new System.Drawing.Size(741, 490);
            this.dgvRam.TabIndex = 0;
            this.dgvRam.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRam_CellContentClick);
            // 
            // cbRamDelete
            // 
            this.cbRamDelete.AutoSize = true;
            this.cbRamDelete.Location = new System.Drawing.Point(910, 27);
            this.cbRamDelete.Name = "cbRamDelete";
            this.cbRamDelete.Size = new System.Drawing.Size(125, 17);
            this.cbRamDelete.TabIndex = 1;
            this.cbRamDelete.Text = "Включить удаление";
            this.cbRamDelete.UseVisualStyleBackColor = true;
            this.cbRamDelete.CheckedChanged += new System.EventHandler(this.cbRamDelete_CheckedChanged);
            // 
            // cmbRamManufacturer
            // 
            this.cmbRamManufacturer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRamManufacturer.FormattingEnabled = true;
            this.cmbRamManufacturer.Location = new System.Drawing.Point(913, 80);
            this.cmbRamManufacturer.Name = "cmbRamManufacturer";
            this.cmbRamManufacturer.Size = new System.Drawing.Size(121, 21);
            this.cmbRamManufacturer.TabIndex = 2;
            // 
            // cmbRamVolume
            // 
            this.cmbRamVolume.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRamVolume.FormattingEnabled = true;
            this.cmbRamVolume.Location = new System.Drawing.Point(913, 136);
            this.cmbRamVolume.Name = "cmbRamVolume";
            this.cmbRamVolume.Size = new System.Drawing.Size(121, 21);
            this.cmbRamVolume.TabIndex = 3;
            // 
            // cmbRamFrenquency
            // 
            this.cmbRamFrenquency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRamFrenquency.FormattingEnabled = true;
            this.cmbRamFrenquency.Location = new System.Drawing.Point(913, 192);
            this.cmbRamFrenquency.Name = "cmbRamFrenquency";
            this.cmbRamFrenquency.Size = new System.Drawing.Size(121, 21);
            this.cmbRamFrenquency.TabIndex = 4;
            // 
            // cmbRamType
            // 
            this.cmbRamType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRamType.FormattingEnabled = true;
            this.cmbRamType.Location = new System.Drawing.Point(913, 248);
            this.cmbRamType.Name = "cmbRamType";
            this.cmbRamType.Size = new System.Drawing.Size(121, 21);
            this.cmbRamType.TabIndex = 5;
            // 
            // txtRamTitle
            // 
            this.txtRamTitle.Location = new System.Drawing.Point(912, 304);
            this.txtRamTitle.Name = "txtRamTitle";
            this.txtRamTitle.Size = new System.Drawing.Size(122, 20);
            this.txtRamTitle.TabIndex = 6;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(930, 56);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(86, 13);
            this.label28.TabIndex = 7;
            this.label28.Text = "Производитель";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(932, 112);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(82, 13);
            this.label29.TabIndex = 8;
            this.label29.Text = "Объем памяти";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(949, 168);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(49, 13);
            this.label30.TabIndex = 9;
            this.label30.Text = "Частота";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(960, 224);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(26, 13);
            this.label31.TabIndex = 10;
            this.label31.Text = "Тип";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(945, 280);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(57, 13);
            this.label32.TabIndex = 11;
            this.label32.Text = "Название";
            // 
            // btnRamAdd
            // 
            this.btnRamAdd.Location = new System.Drawing.Point(924, 344);
            this.btnRamAdd.Name = "btnRamAdd";
            this.btnRamAdd.Size = new System.Drawing.Size(99, 45);
            this.btnRamAdd.TabIndex = 12;
            this.btnRamAdd.Text = "Добавить";
            this.btnRamAdd.UseVisualStyleBackColor = true;
            this.btnRamAdd.Click += new System.EventHandler(this.btnRamAdd_Click);
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
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "id";
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            this.idDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // gCPUDataGridViewTextBoxColumn
            // 
            this.gCPUDataGridViewTextBoxColumn.DataPropertyName = "GCPU";
            this.gCPUDataGridViewTextBoxColumn.HeaderText = "Графический CPU";
            this.gCPUDataGridViewTextBoxColumn.Name = "gCPUDataGridViewTextBoxColumn";
            this.gCPUDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // volumeMemoryDataGridViewTextBoxColumn
            // 
            this.volumeMemoryDataGridViewTextBoxColumn.DataPropertyName = "volumeMemory";
            this.volumeMemoryDataGridViewTextBoxColumn.HeaderText = "Объем памяти";
            this.volumeMemoryDataGridViewTextBoxColumn.Name = "volumeMemoryDataGridViewTextBoxColumn";
            this.volumeMemoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeMemoryDataGridViewTextBoxColumn
            // 
            this.typeMemoryDataGridViewTextBoxColumn.DataPropertyName = "typeMemory";
            this.typeMemoryDataGridViewTextBoxColumn.HeaderText = "Тип памяти";
            this.typeMemoryDataGridViewTextBoxColumn.Name = "typeMemoryDataGridViewTextBoxColumn";
            this.typeMemoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frequencyMemoryDataGridViewTextBoxColumn
            // 
            this.frequencyMemoryDataGridViewTextBoxColumn.DataPropertyName = "frequencyMemory";
            this.frequencyMemoryDataGridViewTextBoxColumn.HeaderText = "Частота памяти";
            this.frequencyMemoryDataGridViewTextBoxColumn.Name = "frequencyMemoryDataGridViewTextBoxColumn";
            this.frequencyMemoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // powerDataGridViewTextBoxColumn1
            // 
            this.powerDataGridViewTextBoxColumn1.DataPropertyName = "power";
            this.powerDataGridViewTextBoxColumn1.HeaderText = "Мощность";
            this.powerDataGridViewTextBoxColumn1.Name = "powerDataGridViewTextBoxColumn1";
            this.powerDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn2
            // 
            this.titleDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.titleDataGridViewTextBoxColumn2.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn2.HeaderText = "Название";
            this.titleDataGridViewTextBoxColumn2.Name = "titleDataGridViewTextBoxColumn2";
            this.titleDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // manufacturerDataGridViewTextBoxColumn2
            // 
            this.manufacturerDataGridViewTextBoxColumn2.DataPropertyName = "manufacturer";
            this.manufacturerDataGridViewTextBoxColumn2.HeaderText = "Производитель";
            this.manufacturerDataGridViewTextBoxColumn2.Name = "manufacturerDataGridViewTextBoxColumn2";
            this.manufacturerDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // videoCardBindingSource
            // 
            this.videoCardBindingSource.DataSource = typeof(db.Classes.VideoCard);
            // 
            // idDataGridViewTextBoxColumn3
            // 
            this.idDataGridViewTextBoxColumn3.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn3.HeaderText = "id";
            this.idDataGridViewTextBoxColumn3.Name = "idDataGridViewTextBoxColumn3";
            this.idDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // powerDataGridViewTextBoxColumn2
            // 
            this.powerDataGridViewTextBoxColumn2.DataPropertyName = "power";
            this.powerDataGridViewTextBoxColumn2.HeaderText = "Мощность";
            this.powerDataGridViewTextBoxColumn2.Name = "powerDataGridViewTextBoxColumn2";
            this.powerDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn3
            // 
            this.titleDataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.titleDataGridViewTextBoxColumn3.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn3.HeaderText = "Название";
            this.titleDataGridViewTextBoxColumn3.Name = "titleDataGridViewTextBoxColumn3";
            this.titleDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // manufacturerDataGridViewTextBoxColumn3
            // 
            this.manufacturerDataGridViewTextBoxColumn3.DataPropertyName = "manufacturer";
            this.manufacturerDataGridViewTextBoxColumn3.HeaderText = "Производитель";
            this.manufacturerDataGridViewTextBoxColumn3.Name = "manufacturerDataGridViewTextBoxColumn3";
            this.manufacturerDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // powerBlockBindingSource
            // 
            this.powerBlockBindingSource.DataSource = typeof(db.Classes.PowerBlock);
            // 
            // idDataGridViewTextBoxColumn4
            // 
            this.idDataGridViewTextBoxColumn4.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn4.HeaderText = "id";
            this.idDataGridViewTextBoxColumn4.Name = "idDataGridViewTextBoxColumn4";
            this.idDataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // voluneDataGridViewTextBoxColumn
            // 
            this.voluneDataGridViewTextBoxColumn.DataPropertyName = "volune";
            this.voluneDataGridViewTextBoxColumn.HeaderText = "Объем";
            this.voluneDataGridViewTextBoxColumn.Name = "voluneDataGridViewTextBoxColumn";
            this.voluneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Тип памяти";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // speedOfWriteDataGridViewTextBoxColumn
            // 
            this.speedOfWriteDataGridViewTextBoxColumn.DataPropertyName = "speedOfWrite";
            this.speedOfWriteDataGridViewTextBoxColumn.HeaderText = "Скорость записи";
            this.speedOfWriteDataGridViewTextBoxColumn.Name = "speedOfWriteDataGridViewTextBoxColumn";
            this.speedOfWriteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // speedOfReadDataGridViewTextBoxColumn
            // 
            this.speedOfReadDataGridViewTextBoxColumn.DataPropertyName = "speedOfRead";
            this.speedOfReadDataGridViewTextBoxColumn.HeaderText = "Скорость чтения";
            this.speedOfReadDataGridViewTextBoxColumn.Name = "speedOfReadDataGridViewTextBoxColumn";
            this.speedOfReadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn4
            // 
            this.titleDataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.titleDataGridViewTextBoxColumn4.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn4.HeaderText = "Название";
            this.titleDataGridViewTextBoxColumn4.Name = "titleDataGridViewTextBoxColumn4";
            this.titleDataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // manufacturerDataGridViewTextBoxColumn4
            // 
            this.manufacturerDataGridViewTextBoxColumn4.DataPropertyName = "manufacturer";
            this.manufacturerDataGridViewTextBoxColumn4.HeaderText = "Производитель";
            this.manufacturerDataGridViewTextBoxColumn4.Name = "manufacturerDataGridViewTextBoxColumn4";
            this.manufacturerDataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // storageBindingSource
            // 
            this.storageBindingSource.DataSource = typeof(db.Classes.Storage);
            // 
            // rAMBindingSource
            // 
            this.rAMBindingSource.DataSource = typeof(db.Classes.RAM);
            // 
            // idDataGridViewTextBoxColumn5
            // 
            this.idDataGridViewTextBoxColumn5.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn5.HeaderText = "id";
            this.idDataGridViewTextBoxColumn5.Name = "idDataGridViewTextBoxColumn5";
            this.idDataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // typeMemoryDataGridViewTextBoxColumn1
            // 
            this.typeMemoryDataGridViewTextBoxColumn1.DataPropertyName = "typeMemory";
            this.typeMemoryDataGridViewTextBoxColumn1.HeaderText = "Тип памяти";
            this.typeMemoryDataGridViewTextBoxColumn1.Name = "typeMemoryDataGridViewTextBoxColumn1";
            this.typeMemoryDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // frequencyDataGridViewTextBoxColumn1
            // 
            this.frequencyDataGridViewTextBoxColumn1.DataPropertyName = "frequency";
            this.frequencyDataGridViewTextBoxColumn1.HeaderText = "Частота";
            this.frequencyDataGridViewTextBoxColumn1.Name = "frequencyDataGridViewTextBoxColumn1";
            this.frequencyDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // voluneDataGridViewTextBoxColumn1
            // 
            this.voluneDataGridViewTextBoxColumn1.DataPropertyName = "volune";
            this.voluneDataGridViewTextBoxColumn1.HeaderText = "Объем";
            this.voluneDataGridViewTextBoxColumn1.Name = "voluneDataGridViewTextBoxColumn1";
            this.voluneDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn5
            // 
            this.titleDataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.titleDataGridViewTextBoxColumn5.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn5.HeaderText = "Название";
            this.titleDataGridViewTextBoxColumn5.Name = "titleDataGridViewTextBoxColumn5";
            this.titleDataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // manufacturerDataGridViewTextBoxColumn5
            // 
            this.manufacturerDataGridViewTextBoxColumn5.DataPropertyName = "manufacturer";
            this.manufacturerDataGridViewTextBoxColumn5.HeaderText = "Производитель";
            this.manufacturerDataGridViewTextBoxColumn5.Name = "manufacturerDataGridViewTextBoxColumn5";
            this.manufacturerDataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // ramDelete
            // 
            this.ramDelete.HeaderText = "Удаление";
            this.ramDelete.Name = "ramDelete";
            this.ramDelete.ReadOnly = true;
            this.ramDelete.Text = "Удаление";
            this.ramDelete.UseColumnTextForButtonValue = true;
            this.ramDelete.Visible = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.nudCpuPower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCPU)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVideoCard)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPowerBlock)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStorage)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motherBoardBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoCardBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.powerBlockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rAMBindingSource)).EndInit();
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
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtVideoCardTitle;
        private System.Windows.Forms.ComboBox cmbVideoCardVolume;
        private System.Windows.Forms.ComboBox cmbVideoCardPower;
        private System.Windows.Forms.ComboBox cmbVideoCardFrequency;
        private System.Windows.Forms.ComboBox cmbVideoCardMemory;
        private System.Windows.Forms.ComboBox cmbVideoCardGCPU;
        private System.Windows.Forms.ComboBox cmbVideoCardManufacturer;
        private System.Windows.Forms.DataGridView dgvVideoCard;
        private System.Windows.Forms.BindingSource videoCardBindingSource;
        private System.Windows.Forms.CheckBox cbVideoCardDelete;
        private System.Windows.Forms.Button btnVideoCardAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn gCPUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn volumeMemoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeMemoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn frequencyMemoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn powerDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewButtonColumn vcDelete;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.CheckBox cbPowerBlockDelete;
        private System.Windows.Forms.Button btnPowerBlock;
        private System.Windows.Forms.TextBox txtPowerBlockTitle;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cmbPowerBlockManufacturer;
        private System.Windows.Forms.ComboBox cmbPowerBlockPower;
        private System.Windows.Forms.DataGridView dgvPowerBlock;
        private System.Windows.Forms.BindingSource powerBlockBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn powerDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewButtonColumn dgvPowerBlockDelete;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.CheckBox cbStorageDelete;
        private System.Windows.Forms.DataGridView dgvStorage;
        private System.Windows.Forms.BindingSource storageBindingSource;
        private System.Windows.Forms.Button btnStorageAdd;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtStorageTitle;
        private System.Windows.Forms.ComboBox cmbStorageRead;
        private System.Windows.Forms.ComboBox cmbStorageWrite;
        private System.Windows.Forms.ComboBox cmbStorageType;
        private System.Windows.Forms.ComboBox cmbStorageVolume;
        private System.Windows.Forms.ComboBox cmbStorageManufacturer;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn voluneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn speedOfWriteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn speedOfReadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewButtonColumn storageDelete;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.CheckBox cbRamDelete;
        private System.Windows.Forms.DataGridView dgvRam;
        private System.Windows.Forms.BindingSource rAMBindingSource;
        private System.Windows.Forms.Button btnRamAdd;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtRamTitle;
        private System.Windows.Forms.ComboBox cmbRamType;
        private System.Windows.Forms.ComboBox cmbRamFrenquency;
        private System.Windows.Forms.ComboBox cmbRamVolume;
        private System.Windows.Forms.ComboBox cmbRamManufacturer;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeMemoryDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn frequencyDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn voluneDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerDataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewButtonColumn ramDelete;
    }
}

