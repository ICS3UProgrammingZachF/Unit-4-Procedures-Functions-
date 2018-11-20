namespace convert
{
    partial class bigoofs
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
            this.btncovernt = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btncovernt
            // 
            this.btncovernt.Location = new System.Drawing.Point(263, 253);
            this.btncovernt.Name = "btncovernt";
            this.btncovernt.Size = new System.Drawing.Size(75, 23);
            this.btncovernt.TabIndex = 0;
            this.btncovernt.Text = "convert";
            this.btncovernt.UseVisualStyleBackColor = true;
            this.btncovernt.Click += new System.EventHandler(this.btncovernt_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(254, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // bigoofs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 474);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btncovernt);
            this.Name = "bigoofs";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncovernt;
        private System.Windows.Forms.TextBox textBox1;
    }
}

