namespace SimpleWindowsApp
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.Panel_Title = new System.Windows.Forms.Panel();
            this.button_Minimize = new System.Windows.Forms.Button();
            this.button_Maximize = new System.Windows.Forms.Button();
            this.label_Title = new System.Windows.Forms.Label();
            this.button_Exit = new System.Windows.Forms.Button();
            this.pictureBox_Calculator = new System.Windows.Forms.PictureBox();
            this.panel_Menu1 = new System.Windows.Forms.Panel();
            this.textBox_MenuCalcTitle = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_Menu = new System.Windows.Forms.Button();
            this.panel_Menu2 = new System.Windows.Forms.Panel();
            this.button_History = new System.Windows.Forms.Button();
            this.textBox_CalcType = new System.Windows.Forms.TextBox();
            this.textBox_Display2 = new System.Windows.Forms.TextBox();
            this.textBox_Display1 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Panel_Spacing = new System.Windows.Forms.Panel();
            this.button_MemoryClear = new System.Windows.Forms.Button();
            this.button_MemoryRecall = new System.Windows.Forms.Button();
            this.button_MemoryAdd = new System.Windows.Forms.Button();
            this.button_MemorySubtract = new System.Windows.Forms.Button();
            this.button_MemoryStore = new System.Windows.Forms.Button();
            this.button_Memory = new System.Windows.Forms.Button();
            this.panel_ShowHistory = new System.Windows.Forms.Panel();
            this.listBox_History = new System.Windows.Forms.ListBox();
            this.button_ClearHistory = new System.Windows.Forms.Button();
            this.roundedButton_CalcScientific = new SimpleWindowsApp.RoundedButton();
            this.roundedButton_CalcStandard = new SimpleWindowsApp.RoundedButton();
            this.roundedButton_Num6 = new SimpleWindowsApp.RoundedButton();
            this.roundedButton_Equals = new SimpleWindowsApp.RoundedButton();
            this.roundedButton_Decimal = new SimpleWindowsApp.RoundedButton();
            this.roundedButton_Num = new SimpleWindowsApp.RoundedButton();
            this.roundedButton_PositiveNegative = new SimpleWindowsApp.RoundedButton();
            this.roundedButton_Addition = new SimpleWindowsApp.RoundedButton();
            this.roundedButton_Num3 = new SimpleWindowsApp.RoundedButton();
            this.roundedButton_Num2 = new SimpleWindowsApp.RoundedButton();
            this.roundedButton_Num1 = new SimpleWindowsApp.RoundedButton();
            this.roundedButton_Subtraction = new SimpleWindowsApp.RoundedButton();
            this.roundedButton_Num5 = new SimpleWindowsApp.RoundedButton();
            this.roundedButton_Num4 = new SimpleWindowsApp.RoundedButton();
            this.roundedButton_Multiplication = new SimpleWindowsApp.RoundedButton();
            this.roundedButton_Num9 = new SimpleWindowsApp.RoundedButton();
            this.roundedButton_Num8 = new SimpleWindowsApp.RoundedButton();
            this.roundedButton_Num7 = new SimpleWindowsApp.RoundedButton();
            this.roundedButton_Division = new SimpleWindowsApp.RoundedButton();
            this.roundedButton_SquareRoot = new SimpleWindowsApp.RoundedButton();
            this.roundedButton_Square = new SimpleWindowsApp.RoundedButton();
            this.roundedButton_DivBy1 = new SimpleWindowsApp.RoundedButton();
            this.roundedButton_Delete = new SimpleWindowsApp.RoundedButton();
            this.roundedButton_Clear = new SimpleWindowsApp.RoundedButton();
            this.roundedButton_ClearEntry = new SimpleWindowsApp.RoundedButton();
            this.roundedButton_Percent = new SimpleWindowsApp.RoundedButton();
            this.Panel_Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Calculator)).BeginInit();
            this.panel_Menu1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_ShowHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Title
            // 
            this.Panel_Title.Controls.Add(this.button_Minimize);
            this.Panel_Title.Controls.Add(this.button_Maximize);
            this.Panel_Title.Controls.Add(this.label_Title);
            this.Panel_Title.Controls.Add(this.button_Exit);
            this.Panel_Title.Controls.Add(this.pictureBox_Calculator);
            this.Panel_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Title.Location = new System.Drawing.Point(0, 0);
            this.Panel_Title.Name = "Panel_Title";
            this.Panel_Title.Size = new System.Drawing.Size(320, 35);
            this.Panel_Title.TabIndex = 0;
            // 
            // button_Minimize
            // 
            this.button_Minimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_Minimize.FlatAppearance.BorderSize = 0;
            this.button_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Minimize.Image = ((System.Drawing.Image)(resources.GetObject("button_Minimize.Image")));
            this.button_Minimize.Location = new System.Drawing.Point(185, 0);
            this.button_Minimize.Margin = new System.Windows.Forms.Padding(0);
            this.button_Minimize.Name = "button_Minimize";
            this.button_Minimize.Size = new System.Drawing.Size(45, 35);
            this.button_Minimize.TabIndex = 4;
            this.button_Minimize.UseVisualStyleBackColor = true;
            this.button_Minimize.Click += new System.EventHandler(this.button_Minimize_Click);
            // 
            // button_Maximize
            // 
            this.button_Maximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_Maximize.FlatAppearance.BorderSize = 0;
            this.button_Maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Maximize.Image = ((System.Drawing.Image)(resources.GetObject("button_Maximize.Image")));
            this.button_Maximize.Location = new System.Drawing.Point(230, 0);
            this.button_Maximize.Margin = new System.Windows.Forms.Padding(0);
            this.button_Maximize.Name = "button_Maximize";
            this.button_Maximize.Size = new System.Drawing.Size(45, 35);
            this.button_Maximize.TabIndex = 3;
            this.button_Maximize.UseVisualStyleBackColor = true;
            this.button_Maximize.Click += new System.EventHandler(this.button_Maximize_Click);
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.ForeColor = System.Drawing.Color.White;
            this.label_Title.Location = new System.Drawing.Point(45, 12);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(61, 16);
            this.label_Title.TabIndex = 1;
            this.label_Title.Text = "Calculator";
            // 
            // button_Exit
            // 
            this.button_Exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_Exit.FlatAppearance.BorderSize = 0;
            this.button_Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.button_Exit.Image = ((System.Drawing.Image)(resources.GetObject("button_Exit.Image")));
            this.button_Exit.Location = new System.Drawing.Point(275, 0);
            this.button_Exit.Margin = new System.Windows.Forms.Padding(0);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(45, 35);
            this.button_Exit.TabIndex = 1;
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // pictureBox_Calculator
            // 
            this.pictureBox_Calculator.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Calculator.Image")));
            this.pictureBox_Calculator.Location = new System.Drawing.Point(21, 12);
            this.pictureBox_Calculator.Name = "pictureBox_Calculator";
            this.pictureBox_Calculator.Size = new System.Drawing.Size(18, 18);
            this.pictureBox_Calculator.TabIndex = 1;
            this.pictureBox_Calculator.TabStop = false;
            // 
            // panel_Menu1
            // 
            this.panel_Menu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.panel_Menu1.Controls.Add(this.roundedButton_CalcScientific);
            this.panel_Menu1.Controls.Add(this.roundedButton_CalcStandard);
            this.panel_Menu1.Controls.Add(this.textBox_MenuCalcTitle);
            this.panel_Menu1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Menu1.Location = new System.Drawing.Point(0, 79);
            this.panel_Menu1.Margin = new System.Windows.Forms.Padding(0);
            this.panel_Menu1.Name = "panel_Menu1";
            this.panel_Menu1.Size = new System.Drawing.Size(2, 421);
            this.panel_Menu1.TabIndex = 41;
            // 
            // textBox_MenuCalcTitle
            // 
            this.textBox_MenuCalcTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.textBox_MenuCalcTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_MenuCalcTitle.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_MenuCalcTitle.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBox_MenuCalcTitle.Location = new System.Drawing.Point(18, 10);
            this.textBox_MenuCalcTitle.Margin = new System.Windows.Forms.Padding(0, 0, 0, 13);
            this.textBox_MenuCalcTitle.Name = "textBox_MenuCalcTitle";
            this.textBox_MenuCalcTitle.ReadOnly = true;
            this.textBox_MenuCalcTitle.Size = new System.Drawing.Size(95, 18);
            this.textBox_MenuCalcTitle.TabIndex = 43;
            this.textBox_MenuCalcTitle.Text = "Calculator";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button_Menu);
            this.panel2.Controls.Add(this.panel_Menu2);
            this.panel2.Controls.Add(this.button_History);
            this.panel2.Controls.Add(this.textBox_CalcType);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(320, 44);
            this.panel2.TabIndex = 4;
            // 
            // button_Menu
            // 
            this.button_Menu.FlatAppearance.BorderSize = 0;
            this.button_Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Menu.Image = ((System.Drawing.Image)(resources.GetObject("button_Menu.Image")));
            this.button_Menu.Location = new System.Drawing.Point(5, 2);
            this.button_Menu.Margin = new System.Windows.Forms.Padding(1);
            this.button_Menu.Name = "button_Menu";
            this.button_Menu.Size = new System.Drawing.Size(40, 40);
            this.button_Menu.TabIndex = 21;
            this.button_Menu.UseVisualStyleBackColor = true;
            this.button_Menu.Click += new System.EventHandler(this.button_Menu_Click);
            // 
            // panel_Menu2
            // 
            this.panel_Menu2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.panel_Menu2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Menu2.Location = new System.Drawing.Point(0, 0);
            this.panel_Menu2.Margin = new System.Windows.Forms.Padding(0);
            this.panel_Menu2.Name = "panel_Menu2";
            this.panel_Menu2.Size = new System.Drawing.Size(2, 44);
            this.panel_Menu2.TabIndex = 42;
            // 
            // button_History
            // 
            this.button_History.FlatAppearance.BorderSize = 0;
            this.button_History.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_History.Image = ((System.Drawing.Image)(resources.GetObject("button_History.Image")));
            this.button_History.Location = new System.Drawing.Point(281, 6);
            this.button_History.Margin = new System.Windows.Forms.Padding(1);
            this.button_History.Name = "button_History";
            this.button_History.Size = new System.Drawing.Size(28, 28);
            this.button_History.TabIndex = 22;
            this.button_History.UseVisualStyleBackColor = true;
            this.button_History.Click += new System.EventHandler(this.button_History_Click);
            // 
            // textBox_CalcType
            // 
            this.textBox_CalcType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.textBox_CalcType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_CalcType.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CalcType.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_CalcType.Location = new System.Drawing.Point(46, 12);
            this.textBox_CalcType.Margin = new System.Windows.Forms.Padding(0);
            this.textBox_CalcType.Name = "textBox_CalcType";
            this.textBox_CalcType.ReadOnly = true;
            this.textBox_CalcType.Size = new System.Drawing.Size(95, 26);
            this.textBox_CalcType.TabIndex = 42;
            this.textBox_CalcType.Text = "Standard";
            // 
            // textBox_Display2
            // 
            this.textBox_Display2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.textBox_Display2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Display2.Font = new System.Drawing.Font("Gadugi", 10F);
            this.textBox_Display2.ForeColor = System.Drawing.Color.Silver;
            this.textBox_Display2.Location = new System.Drawing.Point(-1, 82);
            this.textBox_Display2.Margin = new System.Windows.Forms.Padding(0);
            this.textBox_Display2.Multiline = true;
            this.textBox_Display2.Name = "textBox_Display2";
            this.textBox_Display2.ReadOnly = true;
            this.textBox_Display2.Size = new System.Drawing.Size(307, 25);
            this.textBox_Display2.TabIndex = 6;
            this.textBox_Display2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_Display1
            // 
            this.textBox_Display1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.textBox_Display1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Display1.Font = new System.Drawing.Font("Gadugi", 33F, System.Drawing.FontStyle.Bold);
            this.textBox_Display1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_Display1.Location = new System.Drawing.Point(14, 106);
            this.textBox_Display1.Margin = new System.Windows.Forms.Padding(0);
            this.textBox_Display1.Multiline = true;
            this.textBox_Display1.Name = "textBox_Display1";
            this.textBox_Display1.ReadOnly = true;
            this.textBox_Display1.Size = new System.Drawing.Size(306, 50);
            this.textBox_Display1.TabIndex = 6;
            this.textBox_Display1.Text = "0";
            this.textBox_Display1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(30, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 25);
            this.panel3.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(280, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(29, 25);
            this.panel1.TabIndex = 7;
            // 
            // Panel_Spacing
            // 
            this.Panel_Spacing.Location = new System.Drawing.Point(0, 156);
            this.Panel_Spacing.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_Spacing.Name = "Panel_Spacing";
            this.Panel_Spacing.Size = new System.Drawing.Size(320, 14);
            this.Panel_Spacing.TabIndex = 9;
            // 
            // button_MemoryClear
            // 
            this.button_MemoryClear.FlatAppearance.BorderSize = 0;
            this.button_MemoryClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_MemoryClear.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_MemoryClear.ForeColor = System.Drawing.Color.White;
            this.button_MemoryClear.Location = new System.Drawing.Point(4, 170);
            this.button_MemoryClear.Margin = new System.Windows.Forms.Padding(1);
            this.button_MemoryClear.Name = "button_MemoryClear";
            this.button_MemoryClear.Size = new System.Drawing.Size(50, 30);
            this.button_MemoryClear.TabIndex = 10;
            this.button_MemoryClear.Text = "MC";
            this.button_MemoryClear.UseVisualStyleBackColor = true;
            this.button_MemoryClear.Click += new System.EventHandler(this.button_MemoryClear_Click);
            // 
            // button_MemoryRecall
            // 
            this.button_MemoryRecall.FlatAppearance.BorderSize = 0;
            this.button_MemoryRecall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_MemoryRecall.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_MemoryRecall.ForeColor = System.Drawing.Color.White;
            this.button_MemoryRecall.Location = new System.Drawing.Point(56, 170);
            this.button_MemoryRecall.Margin = new System.Windows.Forms.Padding(1);
            this.button_MemoryRecall.Name = "button_MemoryRecall";
            this.button_MemoryRecall.Size = new System.Drawing.Size(50, 30);
            this.button_MemoryRecall.TabIndex = 11;
            this.button_MemoryRecall.Text = "MR";
            this.button_MemoryRecall.UseVisualStyleBackColor = true;
            this.button_MemoryRecall.Click += new System.EventHandler(this.button_MemoryRecall_Click);
            // 
            // button_MemoryAdd
            // 
            this.button_MemoryAdd.FlatAppearance.BorderSize = 0;
            this.button_MemoryAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_MemoryAdd.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_MemoryAdd.ForeColor = System.Drawing.Color.White;
            this.button_MemoryAdd.Location = new System.Drawing.Point(108, 170);
            this.button_MemoryAdd.Margin = new System.Windows.Forms.Padding(1);
            this.button_MemoryAdd.Name = "button_MemoryAdd";
            this.button_MemoryAdd.Size = new System.Drawing.Size(50, 30);
            this.button_MemoryAdd.TabIndex = 12;
            this.button_MemoryAdd.Text = "M+";
            this.button_MemoryAdd.UseVisualStyleBackColor = true;
            this.button_MemoryAdd.Click += new System.EventHandler(this.button_MemoryAdd_Click);
            // 
            // button_MemorySubtract
            // 
            this.button_MemorySubtract.FlatAppearance.BorderSize = 0;
            this.button_MemorySubtract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_MemorySubtract.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_MemorySubtract.ForeColor = System.Drawing.Color.White;
            this.button_MemorySubtract.Location = new System.Drawing.Point(160, 170);
            this.button_MemorySubtract.Margin = new System.Windows.Forms.Padding(1);
            this.button_MemorySubtract.Name = "button_MemorySubtract";
            this.button_MemorySubtract.Size = new System.Drawing.Size(50, 30);
            this.button_MemorySubtract.TabIndex = 13;
            this.button_MemorySubtract.Text = "M-";
            this.button_MemorySubtract.UseVisualStyleBackColor = true;
            this.button_MemorySubtract.Click += new System.EventHandler(this.button_MemorySubtract_Click);
            // 
            // button_MemoryStore
            // 
            this.button_MemoryStore.FlatAppearance.BorderSize = 0;
            this.button_MemoryStore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_MemoryStore.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_MemoryStore.ForeColor = System.Drawing.Color.White;
            this.button_MemoryStore.Location = new System.Drawing.Point(212, 170);
            this.button_MemoryStore.Margin = new System.Windows.Forms.Padding(1);
            this.button_MemoryStore.Name = "button_MemoryStore";
            this.button_MemoryStore.Size = new System.Drawing.Size(50, 30);
            this.button_MemoryStore.TabIndex = 14;
            this.button_MemoryStore.Text = "MS";
            this.button_MemoryStore.UseVisualStyleBackColor = true;
            this.button_MemoryStore.Click += new System.EventHandler(this.button_MemoryStore_Click);
            // 
            // button_Memory
            // 
            this.button_Memory.FlatAppearance.BorderSize = 0;
            this.button_Memory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Memory.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Memory.ForeColor = System.Drawing.Color.White;
            this.button_Memory.Location = new System.Drawing.Point(264, 170);
            this.button_Memory.Margin = new System.Windows.Forms.Padding(1);
            this.button_Memory.Name = "button_Memory";
            this.button_Memory.Size = new System.Drawing.Size(50, 30);
            this.button_Memory.TabIndex = 15;
            this.button_Memory.Text = "M∨";
            this.button_Memory.UseVisualStyleBackColor = true;
            this.button_Memory.Click += new System.EventHandler(this.button_Memory_Click);
            // 
            // panel_ShowHistory
            // 
            this.panel_ShowHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel_ShowHistory.Controls.Add(this.listBox_History);
            this.panel_ShowHistory.Controls.Add(this.button_ClearHistory);
            this.panel_ShowHistory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_ShowHistory.Location = new System.Drawing.Point(0, 500);
            this.panel_ShowHistory.Margin = new System.Windows.Forms.Padding(0);
            this.panel_ShowHistory.Name = "panel_ShowHistory";
            this.panel_ShowHistory.Size = new System.Drawing.Size(320, 2);
            this.panel_ShowHistory.TabIndex = 10;
            // 
            // listBox_History
            // 
            this.listBox_History.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.listBox_History.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox_History.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBox_History.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_History.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.listBox_History.FormattingEnabled = true;
            this.listBox_History.ItemHeight = 16;
            this.listBox_History.Location = new System.Drawing.Point(0, 0);
            this.listBox_History.Margin = new System.Windows.Forms.Padding(1);
            this.listBox_History.Name = "listBox_History";
            this.listBox_History.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listBox_History.Size = new System.Drawing.Size(320, 256);
            this.listBox_History.TabIndex = 41;
            // 
            // button_ClearHistory
            // 
            this.button_ClearHistory.FlatAppearance.BorderSize = 0;
            this.button_ClearHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ClearHistory.Image = ((System.Drawing.Image)(resources.GetObject("button_ClearHistory.Image")));
            this.button_ClearHistory.Location = new System.Drawing.Point(282, 261);
            this.button_ClearHistory.Margin = new System.Windows.Forms.Padding(1);
            this.button_ClearHistory.Name = "button_ClearHistory";
            this.button_ClearHistory.Size = new System.Drawing.Size(28, 28);
            this.button_ClearHistory.TabIndex = 23;
            this.button_ClearHistory.UseVisualStyleBackColor = true;
            this.button_ClearHistory.Click += new System.EventHandler(this.button_ClearHistory_Click);
            // 
            // roundedButton_CalcScientific
            // 
            this.roundedButton_CalcScientific.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.roundedButton_CalcScientific.BorderRadius = 5;
            this.roundedButton_CalcScientific.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.roundedButton_CalcScientific.FlatAppearance.BorderSize = 0;
            this.roundedButton_CalcScientific.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton_CalcScientific.Font = new System.Drawing.Font("Gadugi", 10F);
            this.roundedButton_CalcScientific.ForeColor = System.Drawing.Color.Transparent;
            this.roundedButton_CalcScientific.Image = ((System.Drawing.Image)(resources.GetObject("roundedButton_CalcScientific.Image")));
            this.roundedButton_CalcScientific.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundedButton_CalcScientific.Location = new System.Drawing.Point(0, 80);
            this.roundedButton_CalcScientific.Margin = new System.Windows.Forms.Padding(1);
            this.roundedButton_CalcScientific.Name = "roundedButton_CalcScientific";
            this.roundedButton_CalcScientific.Size = new System.Drawing.Size(255, 36);
            this.roundedButton_CalcScientific.TabIndex = 44;
            this.roundedButton_CalcScientific.Text = "       Scientific";
            this.roundedButton_CalcScientific.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundedButton_CalcScientific.UseVisualStyleBackColor = false;
            this.roundedButton_CalcScientific.Click += new System.EventHandler(this.roundedButton_CalcScientific_Click);
            // 
            // roundedButton_CalcStandard
            // 
            this.roundedButton_CalcStandard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.roundedButton_CalcStandard.BorderRadius = 5;
            this.roundedButton_CalcStandard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.roundedButton_CalcStandard.FlatAppearance.BorderSize = 0;
            this.roundedButton_CalcStandard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton_CalcStandard.Font = new System.Drawing.Font("Gadugi", 10F);
            this.roundedButton_CalcStandard.ForeColor = System.Drawing.Color.Transparent;
            this.roundedButton_CalcStandard.Image = ((System.Drawing.Image)(resources.GetObject("roundedButton_CalcStandard.Image")));
            this.roundedButton_CalcStandard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundedButton_CalcStandard.Location = new System.Drawing.Point(0, 42);
            this.roundedButton_CalcStandard.Margin = new System.Windows.Forms.Padding(1);
            this.roundedButton_CalcStandard.Name = "roundedButton_CalcStandard";
            this.roundedButton_CalcStandard.Size = new System.Drawing.Size(255, 36);
            this.roundedButton_CalcStandard.TabIndex = 42;
            this.roundedButton_CalcStandard.Text = "       Standard";
            this.roundedButton_CalcStandard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundedButton_CalcStandard.UseVisualStyleBackColor = false;
            this.roundedButton_CalcStandard.Click += new System.EventHandler(this.roundedButton_CalcStandard_Click);
            // 
            // roundedButton_Num6
            // 
            this.roundedButton_Num6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.roundedButton_Num6.BorderRadius = 5;
            this.roundedButton_Num6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.roundedButton_Num6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton_Num6.Font = new System.Drawing.Font("Gadugi", 14F);
            this.roundedButton_Num6.ForeColor = System.Drawing.Color.Transparent;
            this.roundedButton_Num6.Location = new System.Drawing.Point(160, 352);
            this.roundedButton_Num6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.roundedButton_Num6.Name = "roundedButton_Num6";
            this.roundedButton_Num6.Size = new System.Drawing.Size(78, 49);
            this.roundedButton_Num6.TabIndex = 40;
            this.roundedButton_Num6.Text = "6";
            this.roundedButton_Num6.UseVisualStyleBackColor = false;
            this.roundedButton_Num6.Click += new System.EventHandler(this.roundedButton_Num_Click);
            // 
            // roundedButton_Equals
            // 
            this.roundedButton_Equals.BackColor = System.Drawing.SystemColors.Highlight;
            this.roundedButton_Equals.BorderRadius = 5;
            this.roundedButton_Equals.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.roundedButton_Equals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton_Equals.Font = new System.Drawing.Font("Gadugi", 14F);
            this.roundedButton_Equals.ForeColor = System.Drawing.Color.Transparent;
            this.roundedButton_Equals.Location = new System.Drawing.Point(238, 450);
            this.roundedButton_Equals.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.roundedButton_Equals.Name = "roundedButton_Equals";
            this.roundedButton_Equals.Size = new System.Drawing.Size(78, 49);
            this.roundedButton_Equals.TabIndex = 39;
            this.roundedButton_Equals.Text = "=";
            this.roundedButton_Equals.UseVisualStyleBackColor = false;
            this.roundedButton_Equals.Click += new System.EventHandler(this.roundedButton_Equals_Click);
            // 
            // roundedButton_Decimal
            // 
            this.roundedButton_Decimal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.roundedButton_Decimal.BorderRadius = 5;
            this.roundedButton_Decimal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.roundedButton_Decimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton_Decimal.Font = new System.Drawing.Font("Gadugi", 14F);
            this.roundedButton_Decimal.ForeColor = System.Drawing.Color.Transparent;
            this.roundedButton_Decimal.Location = new System.Drawing.Point(160, 450);
            this.roundedButton_Decimal.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.roundedButton_Decimal.Name = "roundedButton_Decimal";
            this.roundedButton_Decimal.Size = new System.Drawing.Size(78, 49);
            this.roundedButton_Decimal.TabIndex = 38;
            this.roundedButton_Decimal.Text = ".";
            this.roundedButton_Decimal.UseVisualStyleBackColor = false;
            this.roundedButton_Decimal.Click += new System.EventHandler(this.roundedButton_Decimal_Click);
            // 
            // roundedButton_Num
            // 
            this.roundedButton_Num.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.roundedButton_Num.BorderRadius = 5;
            this.roundedButton_Num.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.roundedButton_Num.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton_Num.Font = new System.Drawing.Font("Gadugi", 14F);
            this.roundedButton_Num.ForeColor = System.Drawing.Color.Transparent;
            this.roundedButton_Num.Location = new System.Drawing.Point(82, 450);
            this.roundedButton_Num.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.roundedButton_Num.Name = "roundedButton_Num";
            this.roundedButton_Num.Size = new System.Drawing.Size(78, 49);
            this.roundedButton_Num.TabIndex = 37;
            this.roundedButton_Num.Text = "0";
            this.roundedButton_Num.UseVisualStyleBackColor = false;
            this.roundedButton_Num.Click += new System.EventHandler(this.roundedButton_Num_Click);
            // 
            // roundedButton_PositiveNegative
            // 
            this.roundedButton_PositiveNegative.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.roundedButton_PositiveNegative.BorderRadius = 5;
            this.roundedButton_PositiveNegative.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.roundedButton_PositiveNegative.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton_PositiveNegative.Font = new System.Drawing.Font("Gadugi", 14F);
            this.roundedButton_PositiveNegative.ForeColor = System.Drawing.Color.Transparent;
            this.roundedButton_PositiveNegative.Location = new System.Drawing.Point(4, 450);
            this.roundedButton_PositiveNegative.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.roundedButton_PositiveNegative.Name = "roundedButton_PositiveNegative";
            this.roundedButton_PositiveNegative.Size = new System.Drawing.Size(78, 49);
            this.roundedButton_PositiveNegative.TabIndex = 36;
            this.roundedButton_PositiveNegative.Text = "±";
            this.roundedButton_PositiveNegative.UseVisualStyleBackColor = false;
            this.roundedButton_PositiveNegative.Click += new System.EventHandler(this.roundedButton_PositiveNegative_Click);
            // 
            // roundedButton_Addition
            // 
            this.roundedButton_Addition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.roundedButton_Addition.BorderRadius = 5;
            this.roundedButton_Addition.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.roundedButton_Addition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton_Addition.Font = new System.Drawing.Font("Gadugi", 14F);
            this.roundedButton_Addition.ForeColor = System.Drawing.Color.Transparent;
            this.roundedButton_Addition.Location = new System.Drawing.Point(238, 401);
            this.roundedButton_Addition.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.roundedButton_Addition.Name = "roundedButton_Addition";
            this.roundedButton_Addition.Size = new System.Drawing.Size(78, 49);
            this.roundedButton_Addition.TabIndex = 35;
            this.roundedButton_Addition.Text = "+";
            this.roundedButton_Addition.UseVisualStyleBackColor = false;
            this.roundedButton_Addition.Click += new System.EventHandler(this.roundedButton_Operation_Click);
            // 
            // roundedButton_Num3
            // 
            this.roundedButton_Num3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.roundedButton_Num3.BorderRadius = 5;
            this.roundedButton_Num3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.roundedButton_Num3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton_Num3.Font = new System.Drawing.Font("Gadugi", 14F);
            this.roundedButton_Num3.ForeColor = System.Drawing.Color.Transparent;
            this.roundedButton_Num3.Location = new System.Drawing.Point(160, 401);
            this.roundedButton_Num3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.roundedButton_Num3.Name = "roundedButton_Num3";
            this.roundedButton_Num3.Size = new System.Drawing.Size(78, 49);
            this.roundedButton_Num3.TabIndex = 34;
            this.roundedButton_Num3.Text = "3";
            this.roundedButton_Num3.UseVisualStyleBackColor = false;
            this.roundedButton_Num3.Click += new System.EventHandler(this.roundedButton_Num_Click);
            // 
            // roundedButton_Num2
            // 
            this.roundedButton_Num2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.roundedButton_Num2.BorderRadius = 5;
            this.roundedButton_Num2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.roundedButton_Num2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton_Num2.Font = new System.Drawing.Font("Gadugi", 14F);
            this.roundedButton_Num2.ForeColor = System.Drawing.Color.Transparent;
            this.roundedButton_Num2.Location = new System.Drawing.Point(82, 401);
            this.roundedButton_Num2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.roundedButton_Num2.Name = "roundedButton_Num2";
            this.roundedButton_Num2.Size = new System.Drawing.Size(78, 49);
            this.roundedButton_Num2.TabIndex = 33;
            this.roundedButton_Num2.Text = "2";
            this.roundedButton_Num2.UseVisualStyleBackColor = false;
            this.roundedButton_Num2.Click += new System.EventHandler(this.roundedButton_Num_Click);
            // 
            // roundedButton_Num1
            // 
            this.roundedButton_Num1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.roundedButton_Num1.BorderRadius = 5;
            this.roundedButton_Num1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.roundedButton_Num1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton_Num1.Font = new System.Drawing.Font("Gadugi", 14F);
            this.roundedButton_Num1.ForeColor = System.Drawing.Color.Transparent;
            this.roundedButton_Num1.Location = new System.Drawing.Point(4, 401);
            this.roundedButton_Num1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.roundedButton_Num1.Name = "roundedButton_Num1";
            this.roundedButton_Num1.Size = new System.Drawing.Size(78, 49);
            this.roundedButton_Num1.TabIndex = 32;
            this.roundedButton_Num1.Text = "1";
            this.roundedButton_Num1.UseVisualStyleBackColor = false;
            this.roundedButton_Num1.Click += new System.EventHandler(this.roundedButton_Num_Click);
            // 
            // roundedButton_Subtraction
            // 
            this.roundedButton_Subtraction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.roundedButton_Subtraction.BorderRadius = 5;
            this.roundedButton_Subtraction.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.roundedButton_Subtraction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton_Subtraction.Font = new System.Drawing.Font("Gadugi", 14F);
            this.roundedButton_Subtraction.ForeColor = System.Drawing.Color.Transparent;
            this.roundedButton_Subtraction.Location = new System.Drawing.Point(238, 352);
            this.roundedButton_Subtraction.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.roundedButton_Subtraction.Name = "roundedButton_Subtraction";
            this.roundedButton_Subtraction.Size = new System.Drawing.Size(78, 49);
            this.roundedButton_Subtraction.TabIndex = 31;
            this.roundedButton_Subtraction.Text = "-";
            this.roundedButton_Subtraction.UseVisualStyleBackColor = false;
            this.roundedButton_Subtraction.Click += new System.EventHandler(this.roundedButton_Operation_Click);
            // 
            // roundedButton_Num5
            // 
            this.roundedButton_Num5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.roundedButton_Num5.BorderRadius = 5;
            this.roundedButton_Num5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.roundedButton_Num5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton_Num5.Font = new System.Drawing.Font("Gadugi", 14F);
            this.roundedButton_Num5.ForeColor = System.Drawing.Color.Transparent;
            this.roundedButton_Num5.Location = new System.Drawing.Point(82, 352);
            this.roundedButton_Num5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.roundedButton_Num5.Name = "roundedButton_Num5";
            this.roundedButton_Num5.Size = new System.Drawing.Size(78, 49);
            this.roundedButton_Num5.TabIndex = 29;
            this.roundedButton_Num5.Text = "5";
            this.roundedButton_Num5.UseVisualStyleBackColor = false;
            this.roundedButton_Num5.Click += new System.EventHandler(this.roundedButton_Num_Click);
            // 
            // roundedButton_Num4
            // 
            this.roundedButton_Num4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.roundedButton_Num4.BorderRadius = 5;
            this.roundedButton_Num4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.roundedButton_Num4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton_Num4.Font = new System.Drawing.Font("Gadugi", 14F);
            this.roundedButton_Num4.ForeColor = System.Drawing.Color.Transparent;
            this.roundedButton_Num4.Location = new System.Drawing.Point(4, 352);
            this.roundedButton_Num4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.roundedButton_Num4.Name = "roundedButton_Num4";
            this.roundedButton_Num4.Size = new System.Drawing.Size(78, 49);
            this.roundedButton_Num4.TabIndex = 28;
            this.roundedButton_Num4.Text = "4";
            this.roundedButton_Num4.UseVisualStyleBackColor = false;
            this.roundedButton_Num4.Click += new System.EventHandler(this.roundedButton_Num_Click);
            // 
            // roundedButton_Multiplication
            // 
            this.roundedButton_Multiplication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.roundedButton_Multiplication.BorderRadius = 5;
            this.roundedButton_Multiplication.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.roundedButton_Multiplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton_Multiplication.Font = new System.Drawing.Font("Gadugi", 14F);
            this.roundedButton_Multiplication.ForeColor = System.Drawing.Color.Transparent;
            this.roundedButton_Multiplication.Location = new System.Drawing.Point(238, 303);
            this.roundedButton_Multiplication.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.roundedButton_Multiplication.Name = "roundedButton_Multiplication";
            this.roundedButton_Multiplication.Size = new System.Drawing.Size(78, 49);
            this.roundedButton_Multiplication.TabIndex = 27;
            this.roundedButton_Multiplication.Text = "×";
            this.roundedButton_Multiplication.UseVisualStyleBackColor = false;
            this.roundedButton_Multiplication.Click += new System.EventHandler(this.roundedButton_Operation_Click);
            // 
            // roundedButton_Num9
            // 
            this.roundedButton_Num9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.roundedButton_Num9.BorderRadius = 5;
            this.roundedButton_Num9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.roundedButton_Num9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton_Num9.Font = new System.Drawing.Font("Gadugi", 14F);
            this.roundedButton_Num9.ForeColor = System.Drawing.Color.Transparent;
            this.roundedButton_Num9.Location = new System.Drawing.Point(160, 303);
            this.roundedButton_Num9.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.roundedButton_Num9.Name = "roundedButton_Num9";
            this.roundedButton_Num9.Size = new System.Drawing.Size(78, 49);
            this.roundedButton_Num9.TabIndex = 26;
            this.roundedButton_Num9.Text = "9";
            this.roundedButton_Num9.UseVisualStyleBackColor = false;
            this.roundedButton_Num9.Click += new System.EventHandler(this.roundedButton_Num_Click);
            // 
            // roundedButton_Num8
            // 
            this.roundedButton_Num8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.roundedButton_Num8.BorderRadius = 5;
            this.roundedButton_Num8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.roundedButton_Num8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton_Num8.Font = new System.Drawing.Font("Gadugi", 14F);
            this.roundedButton_Num8.ForeColor = System.Drawing.Color.Transparent;
            this.roundedButton_Num8.Location = new System.Drawing.Point(82, 303);
            this.roundedButton_Num8.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.roundedButton_Num8.Name = "roundedButton_Num8";
            this.roundedButton_Num8.Size = new System.Drawing.Size(78, 49);
            this.roundedButton_Num8.TabIndex = 25;
            this.roundedButton_Num8.Text = "8";
            this.roundedButton_Num8.UseVisualStyleBackColor = false;
            this.roundedButton_Num8.Click += new System.EventHandler(this.roundedButton_Num_Click);
            // 
            // roundedButton_Num7
            // 
            this.roundedButton_Num7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.roundedButton_Num7.BorderRadius = 5;
            this.roundedButton_Num7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.roundedButton_Num7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton_Num7.Font = new System.Drawing.Font("Gadugi", 14F);
            this.roundedButton_Num7.ForeColor = System.Drawing.Color.Transparent;
            this.roundedButton_Num7.Location = new System.Drawing.Point(4, 303);
            this.roundedButton_Num7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.roundedButton_Num7.Name = "roundedButton_Num7";
            this.roundedButton_Num7.Size = new System.Drawing.Size(78, 49);
            this.roundedButton_Num7.TabIndex = 24;
            this.roundedButton_Num7.Text = "7";
            this.roundedButton_Num7.UseVisualStyleBackColor = false;
            this.roundedButton_Num7.Click += new System.EventHandler(this.roundedButton_Num_Click);
            // 
            // roundedButton_Division
            // 
            this.roundedButton_Division.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.roundedButton_Division.BorderRadius = 5;
            this.roundedButton_Division.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.roundedButton_Division.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton_Division.Font = new System.Drawing.Font("Gadugi", 14F);
            this.roundedButton_Division.ForeColor = System.Drawing.Color.Transparent;
            this.roundedButton_Division.Location = new System.Drawing.Point(238, 254);
            this.roundedButton_Division.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.roundedButton_Division.Name = "roundedButton_Division";
            this.roundedButton_Division.Size = new System.Drawing.Size(78, 49);
            this.roundedButton_Division.TabIndex = 23;
            this.roundedButton_Division.Text = "÷";
            this.roundedButton_Division.UseVisualStyleBackColor = false;
            this.roundedButton_Division.Click += new System.EventHandler(this.roundedButton_Operation_Click);
            // 
            // roundedButton_SquareRoot
            // 
            this.roundedButton_SquareRoot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.roundedButton_SquareRoot.BorderRadius = 5;
            this.roundedButton_SquareRoot.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.roundedButton_SquareRoot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton_SquareRoot.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButton_SquareRoot.ForeColor = System.Drawing.Color.Transparent;
            this.roundedButton_SquareRoot.Location = new System.Drawing.Point(160, 254);
            this.roundedButton_SquareRoot.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.roundedButton_SquareRoot.Name = "roundedButton_SquareRoot";
            this.roundedButton_SquareRoot.Size = new System.Drawing.Size(78, 49);
            this.roundedButton_SquareRoot.TabIndex = 22;
            this.roundedButton_SquareRoot.Text = "√x";
            this.roundedButton_SquareRoot.UseVisualStyleBackColor = false;
            this.roundedButton_SquareRoot.Click += new System.EventHandler(this.roundedButton_SquareRoot_Click);
            // 
            // roundedButton_Square
            // 
            this.roundedButton_Square.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.roundedButton_Square.BorderRadius = 5;
            this.roundedButton_Square.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.roundedButton_Square.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton_Square.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButton_Square.ForeColor = System.Drawing.Color.Transparent;
            this.roundedButton_Square.Location = new System.Drawing.Point(82, 254);
            this.roundedButton_Square.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.roundedButton_Square.Name = "roundedButton_Square";
            this.roundedButton_Square.Size = new System.Drawing.Size(78, 49);
            this.roundedButton_Square.TabIndex = 21;
            this.roundedButton_Square.Text = "x²";
            this.roundedButton_Square.UseVisualStyleBackColor = false;
            this.roundedButton_Square.Click += new System.EventHandler(this.roundedButton_Square_Click);
            // 
            // roundedButton_DivBy1
            // 
            this.roundedButton_DivBy1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.roundedButton_DivBy1.BorderRadius = 5;
            this.roundedButton_DivBy1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.roundedButton_DivBy1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton_DivBy1.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButton_DivBy1.ForeColor = System.Drawing.Color.Transparent;
            this.roundedButton_DivBy1.Location = new System.Drawing.Point(4, 254);
            this.roundedButton_DivBy1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.roundedButton_DivBy1.Name = "roundedButton_DivBy1";
            this.roundedButton_DivBy1.Size = new System.Drawing.Size(78, 49);
            this.roundedButton_DivBy1.TabIndex = 20;
            this.roundedButton_DivBy1.Text = "⅟x";
            this.roundedButton_DivBy1.UseVisualStyleBackColor = false;
            this.roundedButton_DivBy1.Click += new System.EventHandler(this.roundedButton_DivBy1_Click);
            // 
            // roundedButton_Delete
            // 
            this.roundedButton_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.roundedButton_Delete.BorderRadius = 5;
            this.roundedButton_Delete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.roundedButton_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton_Delete.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButton_Delete.ForeColor = System.Drawing.Color.Transparent;
            this.roundedButton_Delete.Image = ((System.Drawing.Image)(resources.GetObject("roundedButton_Delete.Image")));
            this.roundedButton_Delete.Location = new System.Drawing.Point(238, 205);
            this.roundedButton_Delete.Margin = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.roundedButton_Delete.Name = "roundedButton_Delete";
            this.roundedButton_Delete.Size = new System.Drawing.Size(78, 49);
            this.roundedButton_Delete.TabIndex = 19;
            this.roundedButton_Delete.UseVisualStyleBackColor = false;
            this.roundedButton_Delete.Click += new System.EventHandler(this.roundedButton_Delete_Click);
            // 
            // roundedButton_Clear
            // 
            this.roundedButton_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.roundedButton_Clear.BorderRadius = 5;
            this.roundedButton_Clear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.roundedButton_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton_Clear.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButton_Clear.ForeColor = System.Drawing.Color.Transparent;
            this.roundedButton_Clear.Location = new System.Drawing.Point(160, 205);
            this.roundedButton_Clear.Margin = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.roundedButton_Clear.Name = "roundedButton_Clear";
            this.roundedButton_Clear.Size = new System.Drawing.Size(78, 49);
            this.roundedButton_Clear.TabIndex = 18;
            this.roundedButton_Clear.Text = "C";
            this.roundedButton_Clear.UseVisualStyleBackColor = false;
            this.roundedButton_Clear.Click += new System.EventHandler(this.roundedButton_Clear_Click);
            // 
            // roundedButton_ClearEntry
            // 
            this.roundedButton_ClearEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.roundedButton_ClearEntry.BorderRadius = 5;
            this.roundedButton_ClearEntry.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.roundedButton_ClearEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton_ClearEntry.Font = new System.Drawing.Font("Gadugi", 10F);
            this.roundedButton_ClearEntry.ForeColor = System.Drawing.Color.Transparent;
            this.roundedButton_ClearEntry.Location = new System.Drawing.Point(82, 205);
            this.roundedButton_ClearEntry.Margin = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.roundedButton_ClearEntry.Name = "roundedButton_ClearEntry";
            this.roundedButton_ClearEntry.Size = new System.Drawing.Size(78, 49);
            this.roundedButton_ClearEntry.TabIndex = 17;
            this.roundedButton_ClearEntry.Text = "CE";
            this.roundedButton_ClearEntry.UseVisualStyleBackColor = false;
            this.roundedButton_ClearEntry.Click += new System.EventHandler(this.roundedButton_ClearEntry_Click);
            // 
            // roundedButton_Percent
            // 
            this.roundedButton_Percent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.roundedButton_Percent.BorderRadius = 5;
            this.roundedButton_Percent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.roundedButton_Percent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton_Percent.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButton_Percent.ForeColor = System.Drawing.Color.Transparent;
            this.roundedButton_Percent.Location = new System.Drawing.Point(4, 205);
            this.roundedButton_Percent.Margin = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.roundedButton_Percent.Name = "roundedButton_Percent";
            this.roundedButton_Percent.Size = new System.Drawing.Size(78, 49);
            this.roundedButton_Percent.TabIndex = 16;
            this.roundedButton_Percent.Text = "%";
            this.roundedButton_Percent.UseVisualStyleBackColor = false;
            this.roundedButton_Percent.Click += new System.EventHandler(this.roundedButton_Percent_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(320, 502);
            this.Controls.Add(this.panel_Menu1);
            this.Controls.Add(this.panel_ShowHistory);
            this.Controls.Add(this.roundedButton_Num6);
            this.Controls.Add(this.roundedButton_Equals);
            this.Controls.Add(this.roundedButton_Decimal);
            this.Controls.Add(this.roundedButton_Num);
            this.Controls.Add(this.roundedButton_PositiveNegative);
            this.Controls.Add(this.roundedButton_Addition);
            this.Controls.Add(this.roundedButton_Num3);
            this.Controls.Add(this.roundedButton_Num2);
            this.Controls.Add(this.roundedButton_Num1);
            this.Controls.Add(this.roundedButton_Subtraction);
            this.Controls.Add(this.roundedButton_Num5);
            this.Controls.Add(this.roundedButton_Num4);
            this.Controls.Add(this.roundedButton_Multiplication);
            this.Controls.Add(this.roundedButton_Num9);
            this.Controls.Add(this.roundedButton_Num8);
            this.Controls.Add(this.roundedButton_Num7);
            this.Controls.Add(this.roundedButton_Division);
            this.Controls.Add(this.roundedButton_SquareRoot);
            this.Controls.Add(this.roundedButton_Square);
            this.Controls.Add(this.roundedButton_DivBy1);
            this.Controls.Add(this.roundedButton_Delete);
            this.Controls.Add(this.roundedButton_Clear);
            this.Controls.Add(this.roundedButton_ClearEntry);
            this.Controls.Add(this.roundedButton_Percent);
            this.Controls.Add(this.button_Memory);
            this.Controls.Add(this.button_MemoryStore);
            this.Controls.Add(this.button_MemorySubtract);
            this.Controls.Add(this.button_MemoryAdd);
            this.Controls.Add(this.button_MemoryRecall);
            this.Controls.Add(this.button_MemoryClear);
            this.Controls.Add(this.Panel_Spacing);
            this.Controls.Add(this.textBox_Display2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox_Display1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Panel_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Calculator";
            this.Text = "   Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.Panel_Title.ResumeLayout(false);
            this.Panel_Title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Calculator)).EndInit();
            this.panel_Menu1.ResumeLayout(false);
            this.panel_Menu1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel_ShowHistory.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Title;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.PictureBox pictureBox_Calculator;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Button button_Minimize;
        private System.Windows.Forms.Button button_Maximize;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox_Display2;
        private System.Windows.Forms.TextBox textBox_Display1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Panel_Spacing;
        private System.Windows.Forms.Button button_Menu;
        private System.Windows.Forms.Button button_History;
        private System.Windows.Forms.Button button_MemoryClear;
        private System.Windows.Forms.Button button_MemoryRecall;
        private System.Windows.Forms.Button button_MemoryAdd;
        private System.Windows.Forms.Button button_MemorySubtract;
        private System.Windows.Forms.Button button_MemoryStore;
        private System.Windows.Forms.Button button_Memory;
        private RoundedButton roundedButton_Percent;
        private RoundedButton roundedButton_ClearEntry;
        private RoundedButton roundedButton_Clear;
        private RoundedButton roundedButton_Delete;
        private RoundedButton roundedButton_Division;
        private RoundedButton roundedButton_SquareRoot;
        private RoundedButton roundedButton_Square;
        private RoundedButton roundedButton_DivBy1;
        private RoundedButton roundedButton_Multiplication;
        private RoundedButton roundedButton_Num9;
        private RoundedButton roundedButton_Num8;
        private RoundedButton roundedButton_Num7;
        private RoundedButton roundedButton_Subtraction;
        private RoundedButton roundedButton_Num5;
        private RoundedButton roundedButton_Num4;
        private RoundedButton roundedButton_Addition;
        private RoundedButton roundedButton_Num3;
        private RoundedButton roundedButton_Num2;
        private RoundedButton roundedButton_Num1;
        private RoundedButton roundedButton_Equals;
        private RoundedButton roundedButton_Decimal;
        private RoundedButton roundedButton_Num;
        private RoundedButton roundedButton_PositiveNegative;
        private RoundedButton roundedButton_Num6;
        private System.Windows.Forms.Panel panel_ShowHistory;
        private System.Windows.Forms.Button button_ClearHistory;
        private System.Windows.Forms.ListBox listBox_History;
        private System.Windows.Forms.Panel panel_Menu1;
        private System.Windows.Forms.Panel panel_Menu2;
        private System.Windows.Forms.TextBox textBox_CalcType;
        private System.Windows.Forms.TextBox textBox_MenuCalcTitle;
        private RoundedButton roundedButton_CalcStandard;
        private RoundedButton roundedButton_CalcScientific;
    }
}

