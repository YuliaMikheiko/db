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
            this.dgvMotherBoard = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbMotherBoard = new System.Windows.Forms.CheckBox();
            this.mbDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.socketDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.gCPUtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.rAMtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.motherBoardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbMBSocket = new System.Windows.Forms.ComboBox();
            this.cmbMBGCPU = new System.Windows.Forms.ComboBox();
            this.cmbMBram = new System.Windows.Forms.ComboBox();
            this.cmbMBmonufacturer = new System.Windows.Forms.ComboBox();
            this.txtMBtitle = new System.Windows.Forms.TextBox();
            this.btnMotherBoardAdd = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMotherBoard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motherBoardBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(924, 417);
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
            this.tabPage1.Size = new System.Drawing.Size(916, 391);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Материнская плата";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.dgvMotherBoard.Size = new System.Drawing.Size(644, 379);
            this.dgvMotherBoard.TabIndex = 0;
            this.dgvMotherBoard.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvMotherBoard_CellBeginEdit);
            this.dgvMotherBoard.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMotherBoard_CellContentClick);
            this.dgvMotherBoard.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMotherBoard_CellEndEdit);
            this.dgvMotherBoard.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.tableValidating);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(916, 391);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbMotherBoard
            // 
            this.cbMotherBoard.AutoSize = true;
            this.cbMotherBoard.Location = new System.Drawing.Point(712, 22);
            this.cbMotherBoard.Name = "cbMotherBoard";
            this.cbMotherBoard.Size = new System.Drawing.Size(161, 17);
            this.cbMotherBoard.TabIndex = 1;
            this.cbMotherBoard.Text = "Включить редактирование";
            this.cbMotherBoard.UseVisualStyleBackColor = true;
            this.cbMotherBoard.CheckedChanged += new System.EventHandler(this.cbMotherBoard_CheckedChanged);
            // 
            // mbDelete
            // 
            this.mbDelete.HeaderText = "Удаление";
            this.mbDelete.Name = "mbDelete";
            this.mbDelete.Text = "Удалить";
            this.mbDelete.UseColumnTextForButtonValue = true;
            this.mbDelete.Visible = false;
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
            this.panel1.Location = new System.Drawing.Point(676, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 340);
            this.panel1.TabIndex = 2;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Видеокарта";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Производитель";
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
            // cmbMBSocket
            // 
            this.cmbMBSocket.FormattingEnabled = true;
            this.cmbMBSocket.Location = new System.Drawing.Point(57, 37);
            this.cmbMBSocket.Name = "cmbMBSocket";
            this.cmbMBSocket.Size = new System.Drawing.Size(121, 21);
            this.cmbMBSocket.TabIndex = 5;
            // 
            // cmbMBGCPU
            // 
            this.cmbMBGCPU.FormattingEnabled = true;
            this.cmbMBGCPU.Location = new System.Drawing.Point(57, 85);
            this.cmbMBGCPU.Name = "cmbMBGCPU";
            this.cmbMBGCPU.Size = new System.Drawing.Size(121, 21);
            this.cmbMBGCPU.TabIndex = 6;
            // 
            // cmbMBram
            // 
            this.cmbMBram.FormattingEnabled = true;
            this.cmbMBram.Location = new System.Drawing.Point(57, 133);
            this.cmbMBram.Name = "cmbMBram";
            this.cmbMBram.Size = new System.Drawing.Size(121, 21);
            this.cmbMBram.TabIndex = 7;
            // 
            // cmbMBmonufacturer
            // 
            this.cmbMBmonufacturer.FormattingEnabled = true;
            this.cmbMBmonufacturer.Location = new System.Drawing.Point(57, 181);
            this.cmbMBmonufacturer.Name = "cmbMBmonufacturer";
            this.cmbMBmonufacturer.Size = new System.Drawing.Size(121, 21);
            this.cmbMBmonufacturer.TabIndex = 8;
            // 
            // txtMBtitle
            // 
            this.txtMBtitle.Location = new System.Drawing.Point(57, 229);
            this.txtMBtitle.Name = "txtMBtitle";
            this.txtMBtitle.Size = new System.Drawing.Size(121, 20);
            this.txtMBtitle.TabIndex = 9;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMotherBoard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motherBoardBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
    }
}

