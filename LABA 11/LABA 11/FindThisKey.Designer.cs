namespace LABA_11
{
    partial class FindThisKey
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
            this.TBKey = new System.Windows.Forms.TextBox();
            this.BTFind = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TBOutput = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTFind);
            this.groupBox1.Controls.Add(this.TBKey);
            this.groupBox1.Location = new System.Drawing.Point(22, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 229);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // TBKey
            // 
            this.TBKey.Location = new System.Drawing.Point(7, 33);
            this.TBKey.Name = "TBKey";
            this.TBKey.Size = new System.Drawing.Size(100, 20);
            this.TBKey.TabIndex = 0;
            // 
            // BTFind
            // 
            this.BTFind.Location = new System.Drawing.Point(7, 60);
            this.BTFind.Name = "BTFind";
            this.BTFind.Size = new System.Drawing.Size(75, 23);
            this.BTFind.TabIndex = 1;
            this.BTFind.Text = "button1";
            this.BTFind.UseVisualStyleBackColor = true;
            this.BTFind.Click += new System.EventHandler(this.BTFind_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TBOutput);
            this.groupBox2.Location = new System.Drawing.Point(176, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(366, 229);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // TBOutput
            // 
            this.TBOutput.Location = new System.Drawing.Point(7, 20);
            this.TBOutput.Name = "TBOutput";
            this.TBOutput.Size = new System.Drawing.Size(353, 102);
            this.TBOutput.TabIndex = 0;
            this.TBOutput.Text = "";
            // 
            // FindThisKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 587);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FindThisKey";
            this.Text = "FindThisKey";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BTFind;
        private System.Windows.Forms.TextBox TBKey;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox TBOutput;
    }
}