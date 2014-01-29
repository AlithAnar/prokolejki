namespace Kolejki3
    {
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLambda = new System.Windows.Forms.TextBox();
            this.akcjeBox = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszUstawieniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wczytajUstawieniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakończToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMain = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxMi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDownMachineCount = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownQueueSize = new System.Windows.Forms.NumericUpDown();
            this.comboBoxTypes = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.relativePerf = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.absPerf = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.aqt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.aio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMachineCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQueueSize)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "λ";
            // 
            // textBoxLambda
            // 
            this.textBoxLambda.Location = new System.Drawing.Point(24, 30);
            this.textBoxLambda.Name = "textBoxLambda";
            this.textBoxLambda.Size = new System.Drawing.Size(41, 20);
            this.textBoxLambda.TabIndex = 1;
            this.textBoxLambda.Text = "0,0083";
            // 
            // akcjeBox
            // 
            this.akcjeBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.akcjeBox.FormattingEnabled = true;
            this.akcjeBox.Location = new System.Drawing.Point(781, 246);
            this.akcjeBox.Name = "akcjeBox";
            this.akcjeBox.Size = new System.Drawing.Size(203, 316);
            this.akcjeBox.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(996, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zapiszUstawieniaToolStripMenuItem,
            this.wczytajUstawieniaToolStripMenuItem,
            this.zakończToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // zapiszUstawieniaToolStripMenuItem
            // 
            this.zapiszUstawieniaToolStripMenuItem.Name = "zapiszUstawieniaToolStripMenuItem";
            this.zapiszUstawieniaToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.zapiszUstawieniaToolStripMenuItem.Text = "Zapisz ustawienia";
            // 
            // wczytajUstawieniaToolStripMenuItem
            // 
            this.wczytajUstawieniaToolStripMenuItem.Name = "wczytajUstawieniaToolStripMenuItem";
            this.wczytajUstawieniaToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.wczytajUstawieniaToolStripMenuItem.Text = "Wczytaj ustawienia";
            // 
            // zakończToolStripMenuItem
            // 
            this.zakończToolStripMenuItem.Name = "zakończToolStripMenuItem";
            this.zakończToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.zakończToolStripMenuItem.Text = "Zakończ";
            // 
            // panelMain
            // 
            this.panelMain.AllowDrop = true;
            this.panelMain.BackColor = System.Drawing.Color.Linen;
            this.panelMain.Location = new System.Drawing.Point(203, 62);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(562, 500);
            this.panelMain.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(203, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Dodaj moduł";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.createModule);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.textBoxMi);
            this.groupBox1.Controls.Add(this.textBoxLambda);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 196);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 93);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Właściwości systemu";
            // 
            // textBoxMi
            // 
            this.textBoxMi.Location = new System.Drawing.Point(24, 56);
            this.textBoxMi.Name = "textBoxMi";
            this.textBoxMi.Size = new System.Drawing.Size(41, 20);
            this.textBoxMi.TabIndex = 15;
            this.textBoxMi.Text = "0,0167";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "M:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.numericUpDownMachineCount);
            this.groupBox2.Controls.Add(this.numericUpDownQueueSize);
            this.groupBox2.Controls.Add(this.comboBoxTypes);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(185, 163);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Właściwości modułu:";
            // 
            // numericUpDownMachineCount
            // 
            this.numericUpDownMachineCount.Location = new System.Drawing.Point(102, 100);
            this.numericUpDownMachineCount.Name = "numericUpDownMachineCount";
            this.numericUpDownMachineCount.Size = new System.Drawing.Size(50, 20);
            this.numericUpDownMachineCount.TabIndex = 14;
            this.numericUpDownMachineCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownQueueSize
            // 
            this.numericUpDownQueueSize.Location = new System.Drawing.Point(103, 59);
            this.numericUpDownQueueSize.Name = "numericUpDownQueueSize";
            this.numericUpDownQueueSize.Size = new System.Drawing.Size(49, 20);
            this.numericUpDownQueueSize.TabIndex = 13;
            this.numericUpDownQueueSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBoxTypes
            // 
            this.comboBoxTypes.DisplayMember = "FIFO";
            this.comboBoxTypes.FormattingEnabled = true;
            this.comboBoxTypes.Items.AddRange(new object[] {
            "FIFO",
            "LIFO"});
            this.comboBoxTypes.Location = new System.Drawing.Point(102, 23);
            this.comboBoxTypes.Name = "comboBoxTypes";
            this.comboBoxTypes.Size = new System.Drawing.Size(72, 21);
            this.comboBoxTypes.TabIndex = 12;
            this.comboBoxTypes.Text = "FIFO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ilość maszyn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Długość kolejki:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Typ:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(310, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Start";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.simStart);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 305);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(174, 264);
            this.listBox1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Polaczenia";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.relativePerf);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.absPerf);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.aqt);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.aio);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(781, 62);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 168);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Statystyki";
            // 
            // relativePerf
            // 
            this.relativePerf.Location = new System.Drawing.Point(119, 149);
            this.relativePerf.Name = "relativePerf";
            this.relativePerf.Size = new System.Drawing.Size(74, 20);
            this.relativePerf.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 152);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Wydajnosc wzgl";
            // 
            // absPerf
            // 
            this.absPerf.Location = new System.Drawing.Point(120, 116);
            this.absPerf.Name = "absPerf";
            this.absPerf.Size = new System.Drawing.Size(74, 20);
            this.absPerf.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Wydajnosc bezwzgl";
            // 
            // aqt
            // 
            this.aqt.Location = new System.Drawing.Point(120, 62);
            this.aqt.Name = "aqt";
            this.aqt.Size = new System.Drawing.Size(74, 20);
            this.aqt.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Średni czas w kolejce";
            // 
            // aio
            // 
            this.aio.Location = new System.Drawing.Point(120, 24);
            this.aio.Name = "aio";
            this.aio.Size = new System.Drawing.Size(74, 20);
            this.aio.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Średni czas I/O";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(391, 33);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Stop";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(473, 32);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "Usun";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(670, 32);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(95, 23);
            this.button5.TabIndex = 18;
            this.button5.Text = "Reset systemu";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 580);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.akcjeBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Kolejki";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMachineCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQueueSize)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLambda;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszUstawieniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wczytajUstawieniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakończToolStripMenuItem;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxMi;
        private System.Windows.Forms.NumericUpDown numericUpDownMachineCount;
        private System.Windows.Forms.NumericUpDown numericUpDownQueueSize;
        private System.Windows.Forms.ComboBox comboBoxTypes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.ListBox akcjeBox;
        public System.Windows.Forms.TextBox aqt;
        public System.Windows.Forms.TextBox aio;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        public System.Windows.Forms.TextBox absPerf;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox relativePerf;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button5;
        }
    }

