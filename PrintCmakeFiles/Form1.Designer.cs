
namespace PrintCmakeFiles
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
            this.label1 = new System.Windows.Forms.Label();
            this.textPrefix = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.textDir = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textSuffix = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.C = new System.Windows.Forms.GroupBox();
            this.radioBtnN = new System.Windows.Forms.RadioButton();
            this.radioBtnRN = new System.Windows.Forms.RadioButton();
            this.textOutput = new System.Windows.Forms.TextBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.C.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prefix:";
            // 
            // textPrefix
            // 
            this.textPrefix.Location = new System.Drawing.Point(13, 45);
            this.textPrefix.Name = "textPrefix";
            this.textPrefix.Size = new System.Drawing.Size(210, 25);
            this.textPrefix.TabIndex = 1;
            this.textPrefix.Text = "${COMMON}";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBtnRN);
            this.groupBox1.Controls.Add(this.radioBtnN);
            this.groupBox1.Controls.Add(this.btnPrint);
            this.groupBox1.Controls.Add(this.btnSelect);
            this.groupBox1.Controls.Add(this.textDir);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textSuffix);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textPrefix);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 291);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Config";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(13, 250);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(210, 31);
            this.btnPrint.TabIndex = 9;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(150, 170);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(73, 25);
            this.btnSelect.TabIndex = 6;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // textDir
            // 
            this.textDir.Location = new System.Drawing.Point(13, 170);
            this.textDir.Name = "textDir";
            this.textDir.Size = new System.Drawing.Size(134, 25);
            this.textDir.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dir:";
            // 
            // textSuffix
            // 
            this.textSuffix.Location = new System.Drawing.Point(13, 104);
            this.textSuffix.Name = "textSuffix";
            this.textSuffix.Size = new System.Drawing.Size(210, 25);
            this.textSuffix.TabIndex = 3;
            this.textSuffix.Text = "c,cpp,hpp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Suffix:";
            // 
            // C
            // 
            this.C.Controls.Add(this.btnCopy);
            this.C.Controls.Add(this.textOutput);
            this.C.Location = new System.Drawing.Point(255, 13);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(260, 290);
            this.C.TabIndex = 3;
            this.C.TabStop = false;
            this.C.Text = "Output";
            // 
            // radioBtnN
            // 
            this.radioBtnN.AutoSize = true;
            this.radioBtnN.Checked = true;
            this.radioBtnN.Location = new System.Drawing.Point(13, 212);
            this.radioBtnN.Name = "radioBtnN";
            this.radioBtnN.Size = new System.Drawing.Size(44, 19);
            this.radioBtnN.TabIndex = 7;
            this.radioBtnN.TabStop = true;
            this.radioBtnN.Text = "\\n";
            this.radioBtnN.UseVisualStyleBackColor = true;
            // 
            // radioBtnRN
            // 
            this.radioBtnRN.AutoSize = true;
            this.radioBtnRN.Location = new System.Drawing.Point(103, 212);
            this.radioBtnRN.Name = "radioBtnRN";
            this.radioBtnRN.Size = new System.Drawing.Size(60, 19);
            this.radioBtnRN.TabIndex = 8;
            this.radioBtnRN.Text = "\\r\\n";
            this.radioBtnRN.UseVisualStyleBackColor = true;
            // 
            // textOutput
            // 
            this.textOutput.Location = new System.Drawing.Point(10, 26);
            this.textOutput.Multiline = true;
            this.textOutput.Name = "textOutput";
            this.textOutput.Size = new System.Drawing.Size(240, 217);
            this.textOutput.TabIndex = 10;
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(10, 249);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(240, 31);
            this.btnCopy.TabIndex = 10;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 309);
            this.Controls.Add(this.C);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "PrintCmakeFiles v1.0 by MountCloud";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.C.ResumeLayout(false);
            this.C.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textPrefix;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textSuffix;
        private System.Windows.Forms.TextBox textDir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.GroupBox C;
        private System.Windows.Forms.RadioButton radioBtnN;
        private System.Windows.Forms.RadioButton radioBtnRN;
        private System.Windows.Forms.TextBox textOutput;
        private System.Windows.Forms.Button btnCopy;
    }
}

