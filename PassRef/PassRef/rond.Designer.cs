namespace PassRef
{
    partial class PassByref
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
            this.txtrond = new System.Windows.Forms.TextBox();
            this.rond = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nudrond = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudrond)).BeginInit();
            this.SuspendLayout();
            // 
            // txtrond
            // 
            this.txtrond.Location = new System.Drawing.Point(251, 79);
            this.txtrond.Name = "txtrond";
            this.txtrond.Size = new System.Drawing.Size(100, 20);
            this.txtrond.TabIndex = 0;
            // 
            // rond
            // 
            this.rond.Location = new System.Drawing.Point(276, 233);
            this.rond.Name = "rond";
            this.rond.Size = new System.Drawing.Size(75, 23);
            this.rond.TabIndex = 1;
            this.rond.Text = "rond";
            this.rond.UseVisualStyleBackColor = true;
            this.rond.Click += new System.EventHandler(this.rond_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "enter number to rond here";
            // 
            // nudrond
            // 
            this.nudrond.Location = new System.Drawing.Point(443, 161);
            this.nudrond.Name = "nudrond";
            this.nudrond.Size = new System.Drawing.Size(120, 20);
            this.nudrond.TabIndex = 3;
            // 
            // PassByref
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 509);
            this.Controls.Add(this.nudrond);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rond);
            this.Controls.Add(this.txtrond);
            this.Name = "PassByref";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudrond)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtrond;
        private System.Windows.Forms.Button rond;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudrond;
    }
}

