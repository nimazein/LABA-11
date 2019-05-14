namespace LABA_11
{
    partial class PrintThisType
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CBType = new System.Windows.Forms.ComboBox();
            this.BTPrint = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TBOutput = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CBType);
            this.groupBox1.Controls.Add(this.BTPrint);
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(145, 96);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // CBType
            // 
            this.CBType.FormattingEnabled = true;
            this.CBType.Items.AddRange(new object[] {
            "Животые",
            "Млекопитающие",
            "Птицы",
            "Парнокопытные"});
            this.CBType.Location = new System.Drawing.Point(6, 28);
            this.CBType.Name = "CBType";
            this.CBType.Size = new System.Drawing.Size(121, 21);
            this.CBType.TabIndex = 2;
            // 
            // BTPrint
            // 
            this.BTPrint.Location = new System.Drawing.Point(6, 55);
            this.BTPrint.Name = "BTPrint";
            this.BTPrint.Size = new System.Drawing.Size(75, 23);
            this.BTPrint.TabIndex = 1;
            this.BTPrint.Text = "button1";
            this.BTPrint.UseVisualStyleBackColor = true;
            this.BTPrint.Click += new System.EventHandler(this.BTPrint_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TBOutput);
            this.groupBox2.Location = new System.Drawing.Point(200, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(770, 400);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // TBOutput
            // 
            this.TBOutput.Location = new System.Drawing.Point(7, 20);
            this.TBOutput.Name = "TBOutput";
            this.TBOutput.Size = new System.Drawing.Size(552, 374);
            this.TBOutput.TabIndex = 0;
            this.TBOutput.Text = "";
            // 
            // PrintThisType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 558);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "PrintThisType";
            this.Text = "PrintThisType";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CBType;
        private System.Windows.Forms.Button BTPrint;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox TBOutput;
    }
}