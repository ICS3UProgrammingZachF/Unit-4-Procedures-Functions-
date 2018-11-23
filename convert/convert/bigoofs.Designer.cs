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
            this.txt = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncovernt
            // 
            this.btncovernt.Location = new System.Drawing.Point(86, 176);
            this.btncovernt.Name = "btncovernt";
            this.btncovernt.Size = new System.Drawing.Size(75, 23);
            this.btncovernt.TabIndex = 0;
            this.btncovernt.Text = "convert";
            this.btncovernt.UseVisualStyleBackColor = true;
            this.btncovernt.Click += new System.EventHandler(this.btncovernt_Click);
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(74, 56);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(100, 20);
            this.txt.TabIndex = 1;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(97, 116);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(51, 20);
            this.lbl.TabIndex = 2;
            this.lbl.Text = "label1";
            // 
            // bigoofs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 236);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.btncovernt);
            this.Name = "bigoofs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncovernt;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Label lbl;
    }
}

