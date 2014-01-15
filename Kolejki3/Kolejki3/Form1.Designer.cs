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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxMi = new System.Windows.Forms.TextBox();
            this.numericUpDownMachineCount = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownQueueSize = new System.Windows.Forms.NumericUpDown();
            this.comboBoxTypes = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMachineCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQueueSize)).BeginInit();
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
            // 
            // akcjeBox
            // 
            this.akcjeBox.FormattingEnabled = true;
            this.akcjeBox.Location = new System.Drawing.Point(781, 38);
            this.akcjeBox.Name = "akcjeBox";
            this.akcjeBox.Size = new System.Drawing.Size(203, 524);
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
            this.panelMain.Location = new System.Drawing.Point(203, 91);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(557, 478);
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
            // textBoxMi
            // 
            this.textBoxMi.Location = new System.Drawing.Point(24, 56);
            this.textBoxMi.Name = "textBoxMi";
            this.textBoxMi.Size = new System.Drawing.Size(41, 20);
            this.textBoxMi.TabIndex = 15;
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
            this.comboBoxTypes.FormattingEnabled = true;
            this.comboBoxTypes.Items.AddRange(new object[] {
            "FIFO",
            "LIFO"});
            this.comboBoxTypes.Location = new System.Drawing.Point(102, 23);
            this.comboBoxTypes.Name = "comboBoxTypes";
            this.comboBoxTypes.Size = new System.Drawing.Size(72, 21);
            this.comboBoxTypes.TabIndex = 12;
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
            this.button2.Location = new System.Drawing.Point(203, 62);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 580);
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
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLambda;
        private System.Windows.Forms.ListBox akcjeBox;
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
        }
    }

