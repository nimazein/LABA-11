namespace LABA_11
{
    partial class LookOverList
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
            this.BTLookOver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTLookOver
            // 
            this.BTLookOver.Location = new System.Drawing.Point(82, 185);
            this.BTLookOver.Name = "BTLookOver";
            this.BTLookOver.Size = new System.Drawing.Size(141, 61);
            this.BTLookOver.TabIndex = 0;
            this.BTLookOver.Text = "button1";
            this.BTLookOver.UseVisualStyleBackColor = true;
            this.BTLookOver.Click += new System.EventHandler(this.BTLookOver_Click);
            // 
            // LookOverList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTLookOver);
            this.Name = "LookOverList";
            this.Text = "LookOverList";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTLookOver;
    }
}