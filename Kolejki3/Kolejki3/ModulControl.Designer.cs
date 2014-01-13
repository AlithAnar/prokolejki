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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.connector1 = new System.Windows.Forms.Button();
            this.connector2 = new System.Windows.Forms.Button();
            this.connector3 = new System.Windows.Forms.Button();
            this.connector4 = new System.Windows.Forms.Button();
            this.labeId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Maszyny:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Długość kolejki:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Obecnie w kolejce:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Obecnie w maszynie:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Reguła:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "M:";
            // 
            // connector1
            // 
            this.connector1.Location = new System.Drawing.Point(74, -3);
            this.connector1.Name = "connector1";
            this.connector1.Size = new System.Drawing.Size(21, 23);
            this.connector1.TabIndex = 6;
            this.connector1.UseVisualStyleBackColor = true;
            // 
            // connector2
            // 
            this.connector2.Location = new System.Drawing.Point(146, 62);
            this.connector2.Name = "connector2";
            this.connector2.Size = new System.Drawing.Size(21, 23);
            this.connector2.TabIndex = 7;
            this.connector2.UseVisualStyleBackColor = true;
            // 
            // connector3
            // 
            this.connector3.Location = new System.Drawing.Point(74, 124);
            this.connector3.Name = "connector3";
            this.connector3.Size = new System.Drawing.Size(21, 23);
            this.connector3.TabIndex = 8;
            this.connector3.UseVisualStyleBackColor = true;
            // 
            // connector4
            // 
            this.connector4.Location = new System.Drawing.Point(-2, 62);
            this.connector4.Name = "connector4";
            this.connector4.Size = new System.Drawing.Size(21, 23);
            this.connector4.TabIndex = 9;
            this.connector4.UseVisualStyleBackColor = true;
            // 
            // labeId
            // 
            this.labeId.AutoSize = true;
            this.labeId.Location = new System.Drawing.Point(25, 23);
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
            this.Controls.Add(this.connector4);
            this.Controls.Add(this.connector3);
            this.Controls.Add(this.connector2);
            this.Controls.Add(this.connector1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "ModulControl";
            this.Size = new System.Drawing.Size(165, 145);
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button connector1;
        public System.Windows.Forms.Button connector2;
        public System.Windows.Forms.Button connector3;
        public System.Windows.Forms.Button connector4;
        private System.Windows.Forms.Label labeId;

        }
    }
