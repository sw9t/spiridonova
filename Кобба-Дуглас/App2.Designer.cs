﻿namespace Кобба_Дуглас
{
    partial class App2
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App2));
            this.U_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ansRTB = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSolutionTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printPreviewTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.printTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAppTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.roundNUD = new System.Windows.Forms.NumericUpDown();
            this.clearBtn = new System.Windows.Forms.Button();
            this.solveBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.q1Tb = new System.Windows.Forms.TextBox();
            this.pTb = new System.Windows.Forms.TextBox();
            this.x2Tb = new System.Windows.Forms.TextBox();
            this.x1Tb = new System.Windows.Forms.TextBox();
            this.A_Tb = new System.Windows.Forms.TextBox();
            this.alphaTb = new System.Windows.Forms.TextBox();
            this.betaTb = new System.Windows.Forms.TextBox();
            this.q2Tb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundNUD)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // U_label
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.OnPrintPage);
            // 
            this.U_label.AutoSize = true;
            this.U_label.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.U_label.Location = new System.Drawing.Point(381, 0);
            this.U_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.U_label.Name = "U_label";
            this.U_label.Size = new System.Drawing.Size(218, 66);
            this.U_label.TabIndex = 1;
            this.U_label.Text = "P = {0}; q1 = {1}; q2 = {2}\r\nx1_0 = {3}; x2_0 = {4}\r\ny = {5}*x1^{6} * x2^{7}";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "R";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.ansRTB);
            this.groupBox3.Location = new System.Drawing.Point(16, 219);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(1009, 458);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Решение задачи";
            // 
            // ansRTB
            // 
            this.ansRTB.BackColor = System.Drawing.SystemColors.Control;
            this.ansRTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ansRTB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ansRTB.Location = new System.Drawing.Point(4, 19);
            this.ansRTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ansRTB.Name = "ansRTB";
            this.ansRTB.ReadOnly = true;
            this.ansRTB.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.ansRTB.Size = new System.Drawing.Size(1001, 435);
            this.ansRTB.TabIndex = 0;
            this.ansRTB.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.HelpMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1045, 28);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileMenu
            // 
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveSolutionTSMI,
            this.toolStripSeparator1,
            this.printPreviewTSMI,
            this.printTSMI,
            this.closeAppTSMI});
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(57, 24);
            this.FileMenu.Text = "Файл";
            // 
            // saveSolutionTSMI
            // 
            this.saveSolutionTSMI.Name = "saveSolutionTSMI";
            this.saveSolutionTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveSolutionTSMI.Size = new System.Drawing.Size(297, 26);
            this.saveSolutionTSMI.Text = "Сохранить решение";
            this.saveSolutionTSMI.Click += new System.EventHandler(this.SaveSolutionTSMI_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(294, 6);
            // 
            // printPreviewTSMI
            // 
            this.printPreviewTSMI.Name = "printPreviewTSMI";
            this.printPreviewTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.P)));
            this.printPreviewTSMI.Size = new System.Drawing.Size(297, 26);
            this.printPreviewTSMI.Text = "Просмотр печати";
            this.printPreviewTSMI.Click += new System.EventHandler(this.printPreviewTSMI_Click);
            // 
            // printTSMI
            // 
            this.printTSMI.Name = "printTSMI";
            this.printTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printTSMI.Size = new System.Drawing.Size(297, 26);
            this.printTSMI.Text = "Печать";
            this.printTSMI.Click += new System.EventHandler(this.printTSMI_Click);
            // 
            // closeAppTSMI
            // 
            this.closeAppTSMI.Name = "closeAppTSMI";
            this.closeAppTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.closeAppTSMI.Size = new System.Drawing.Size(297, 26);
            this.closeAppTSMI.Text = "Закрыть";
            this.closeAppTSMI.Click += new System.EventHandler(this.CloseTSMI_Click);
            // 
            // HelpMenu
            // 
            this.HelpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HelpTSMI,
            this.aboutTSMI});
            this.HelpMenu.Name = "HelpMenu";
            this.HelpMenu.Size = new System.Drawing.Size(79, 24);
            this.HelpMenu.Text = "Справка";
            // 
            // HelpTSMI
            // 
            this.HelpTSMI.Name = "HelpTSMI";
            this.HelpTSMI.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.HelpTSMI.Size = new System.Drawing.Size(213, 26);
            this.HelpTSMI.Text = "Вызов справки";
            this.HelpTSMI.Click += new System.EventHandler(this.HelpTSMI_Click);
            // 
            // aboutTSMI
            // 
            this.aboutTSMI.Name = "aboutTSMI";
            this.aboutTSMI.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.aboutTSMI.Size = new System.Drawing.Size(213, 26);
            this.aboutTSMI.Text = "О программе";
            this.aboutTSMI.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // roundNUD
            // 
            this.roundNUD.Location = new System.Drawing.Point(269, 84);
            this.roundNUD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.roundNUD.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.roundNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.roundNUD.Name = "roundNUD";
            this.roundNUD.Size = new System.Drawing.Size(61, 22);
            this.roundNUD.TabIndex = 8;
            this.roundNUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.roundNUD.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // clearBtn
            // 
            this.clearBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.clearBtn.Location = new System.Drawing.Point(251, 116);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(84, 48);
            this.clearBtn.TabIndex = 10;
            this.clearBtn.Text = "Очистить данные";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // solveBtn
            // 
            this.solveBtn.Location = new System.Drawing.Point(8, 116);
            this.solveBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.solveBtn.Name = "solveBtn";
            this.solveBtn.Size = new System.Drawing.Size(231, 48);
            this.solveBtn.TabIndex = 9;
            this.solveBtn.Text = "Решить";
            this.solveBtn.UseVisualStyleBackColor = true;
            this.solveBtn.Click += new System.EventHandler(this.solveBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(131, 27);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "β";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "q1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(8, 27);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "α";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 87);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "x1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(131, 87);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "x2";
            // 
            // q1Tb
            // 
            this.q1Tb.Location = new System.Drawing.Point(155, 52);
            this.q1Tb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.q1Tb.MaxLength = 5;
            this.q1Tb.Name = "q1Tb";
            this.q1Tb.Size = new System.Drawing.Size(60, 22);
            this.q1Tb.TabIndex = 4;
            this.q1Tb.Text = "11";
            this.q1Tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pTb
            // 
            this.pTb.Location = new System.Drawing.Point(35, 52);
            this.pTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pTb.MaxLength = 5;
            this.pTb.Name = "pTb";
            this.pTb.Size = new System.Drawing.Size(60, 22);
            this.pTb.TabIndex = 3;
            this.pTb.Text = "99";
            this.pTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // x2Tb
            // 
            this.x2Tb.Location = new System.Drawing.Point(155, 84);
            this.x2Tb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.x2Tb.MaxLength = 5;
            this.x2Tb.Name = "x2Tb";
            this.x2Tb.Size = new System.Drawing.Size(60, 22);
            this.x2Tb.TabIndex = 7;
            this.x2Tb.Text = "31";
            this.x2Tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // x1Tb
            // 
            this.x1Tb.Location = new System.Drawing.Point(35, 84);
            this.x1Tb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.x1Tb.MaxLength = 5;
            this.x1Tb.Name = "x1Tb";
            this.x1Tb.Size = new System.Drawing.Size(60, 22);
            this.x1Tb.TabIndex = 6;
            this.x1Tb.Text = "21";
            this.x1Tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // A_Tb
            // 
            this.A_Tb.Location = new System.Drawing.Point(269, 23);
            this.A_Tb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.A_Tb.MaxLength = 5;
            this.A_Tb.Name = "A_Tb";
            this.A_Tb.Size = new System.Drawing.Size(60, 22);
            this.A_Tb.TabIndex = 2;
            this.A_Tb.Text = "2,5";
            this.A_Tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // alphaTb
            // 
            this.alphaTb.Location = new System.Drawing.Point(35, 23);
            this.alphaTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.alphaTb.MaxLength = 5;
            this.alphaTb.Name = "alphaTb";
            this.alphaTb.Size = new System.Drawing.Size(60, 22);
            this.alphaTb.TabIndex = 0;
            this.alphaTb.Text = "0,55";
            this.alphaTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // betaTb
            // 
            this.betaTb.Location = new System.Drawing.Point(155, 23);
            this.betaTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.betaTb.MaxLength = 5;
            this.betaTb.Name = "betaTb";
            this.betaTb.Size = new System.Drawing.Size(60, 22);
            this.betaTb.TabIndex = 1;
            this.betaTb.Text = "0,3";
            this.betaTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // q2Tb
            // 
            this.q2Tb.Location = new System.Drawing.Point(269, 52);
            this.q2Tb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.q2Tb.MaxLength = 5;
            this.q2Tb.Name = "q2Tb";
            this.q2Tb.Size = new System.Drawing.Size(60, 22);
            this.q2Tb.TabIndex = 5;
            this.q2Tb.Text = "8";
            this.q2Tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "p";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Location = new System.Drawing.Point(373, 33);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(652, 178);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Постановка задачи";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 267F));
            this.tableLayoutPanel1.Controls.Add(this.U_label, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 19);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(644, 155);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(4, 4);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(369, 147);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.q1Tb);
            this.groupBox1.Controls.Add(this.roundNUD);
            this.groupBox1.Controls.Add(this.pTb);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.clearBtn);
            this.groupBox1.Controls.Add(this.solveBtn);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.x2Tb);
            this.groupBox1.Controls.Add(this.x1Tb);
            this.groupBox1.Controls.Add(this.A_Tb);
            this.groupBox1.Controls.Add(this.alphaTb);
            this.groupBox1.Controls.Add(this.betaTb);
            this.groupBox1.Controls.Add(this.q2Tb);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(20, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(349, 178);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ввод исходных данных";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(237, 55);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "q2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "A";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // App2
            // 
            this.AcceptButton = this.solveBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.clearBtn;
            this.ClientSize = new System.Drawing.Size(1045, 692);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1061, 728);
            this.Name = "App2";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundNUD)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label U_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox ansRTB;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileMenu;
        private System.Windows.Forms.ToolStripMenuItem saveSolutionTSMI;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem printPreviewTSMI;
        private System.Windows.Forms.ToolStripMenuItem printTSMI;
        private System.Windows.Forms.ToolStripMenuItem closeAppTSMI;
        private System.Windows.Forms.ToolStripMenuItem HelpMenu;
        private System.Windows.Forms.ToolStripMenuItem HelpTSMI;
        private System.Windows.Forms.ToolStripMenuItem aboutTSMI;
        private System.Windows.Forms.NumericUpDown roundNUD;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button solveBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox q1Tb;
        private System.Windows.Forms.TextBox pTb;
        private System.Windows.Forms.TextBox x2Tb;
        private System.Windows.Forms.TextBox x1Tb;
        private System.Windows.Forms.TextBox A_Tb;
        private System.Windows.Forms.TextBox alphaTb;
        private System.Windows.Forms.TextBox betaTb;
        private System.Windows.Forms.TextBox q2Tb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}

