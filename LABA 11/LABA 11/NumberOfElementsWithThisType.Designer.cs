namespace LABA_11
{
    partial class NumberOfElementsWithThisType
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
            this.BTCount = new System.Windows.Forms.Button();
            this.CBType = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CBType);
            this.groupBox1.Controls.Add(this.BTCount);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 291);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // BTCount
            // 
            this.BTCount.Location = new System.Drawing.Point(6, 55);
            this.BTCount.Name = "BTCount";
            this.BTCount.Size = new System.Drawing.Size(75, 23);
            this.BTCount.TabIndex = 1;
            this.BTCount.Text = "button1";
            this.BTCount.UseVisualStyleBackColor = true;
            this.BTCount.Click += new System.EventHandler(this.BTCount_Click);
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
            // NumberOfElementsWithThisType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 580);
            this.Controls.Add(this.groupBox1);
            this.Name = "NumberOfElementsWithThisType";
            this.Text = "NumberOfElementsWithThisType";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CBType;
        private System.Windows.Forms.Button BTCount;
    }
}