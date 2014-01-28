namespace Kolejki3
    {
    partial class ModulControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
            {
            this.label1 = new System.Windows.Forms.Label();
            this.lengthText = new System.Windows.Forms.Label();
            this.currentInBuffer = new System.Windows.Forms.Label();
            this.currentInMachine = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labeId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Maszyny:";
            // 
            // lengthText
            // 
            this.lengthText.AutoSize = true;
            this.lengthText.Location = new System.Drawing.Point(3, 26);
            this.lengthText.Name = "lengthText";
            this.lengthText.Size = new System.Drawing.Size(84, 13);
            this.lengthText.TabIndex = 1;
            this.lengthText.Text = "Długość kolejki:";
            // 
            // currentInBuffer
            // 
            this.currentInBuffer.AutoSize = true;
            this.currentInBuffer.Location = new System.Drawing.Point(3, 39);
            this.currentInBuffer.Name = "currentInBuffer";
            this.currentInBuffer.Size = new System.Drawing.Size(98, 13);
            this.currentInBuffer.TabIndex = 2;
            this.currentInBuffer.Text = "Obecnie w kolejce:";
            // 
            // currentInMachine
            // 
            this.currentInMachine.AutoSize = true;
            this.currentInMachine.Location = new System.Drawing.Point(3, 52);
            this.currentInMachine.Name = "currentInMachine";
            this.currentInMachine.Size = new System.Drawing.Size(107, 13);
            this.currentInMachine.TabIndex = 3;
            this.currentInMachine.Text = "Obecnie w maszynie:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Reguła:";
            // 
            // labeId
            // 
            this.labeId.AutoSize = true;
            this.labeId.Location = new System.Drawing.Point(3, 0);
            this.labeId.Name = "labeId";
            this.labeId.Size = new System.Drawing.Size(24, 13);
            this.labeId.TabIndex = 10;
            this.labeId.Text = "ID: ";
            // 
            // ModulControl
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.labeId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.currentInMachine);
            this.Controls.Add(this.currentInBuffer);
            this.Controls.Add(this.lengthText);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "ModulControl";
            this.Size = new System.Drawing.Size(137, 87);
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lengthText;
        public System.Windows.Forms.Label currentInBuffer;
        public System.Windows.Forms.Label currentInMachine;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labeId;

        }
    }
