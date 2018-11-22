namespace VolCylineder
{
    partial class VolOfCylinder
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
            this.btncal = new System.Windows.Forms.Button();
            this.txtradius = new System.Windows.Forms.TextBox();
            this.txthight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblawanser = new System.Windows.Forms.Label();
            this.pic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // btncal
            // 
            this.btncal.Location = new System.Drawing.Point(241, 222);
            this.btncal.Name = "btncal";
            this.btncal.Size = new System.Drawing.Size(75, 23);
            this.btncal.TabIndex = 0;
            this.btncal.Text = "claculate vloume";
            this.btncal.UseVisualStyleBackColor = true;
            this.btncal.Click += new System.EventHandler(this.btncal_Click);
            // 
            // txtradius
            // 
            this.txtradius.Location = new System.Drawing.Point(241, 59);
            this.txtradius.Name = "txtradius";
            this.txtradius.Size = new System.Drawing.Size(100, 20);
            this.txtradius.TabIndex = 1;
            // 
            // txthight
            // 
            this.txthight.Location = new System.Drawing.Point(241, 149);
            this.txthight.Name = "txthight";
            this.txthight.Size = new System.Drawing.Size(100, 20);
            this.txthight.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter radius here:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter hight here:";
            // 
            // lblawanser
            // 
            this.lblawanser.AutoSize = true;
            this.lblawanser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblawanser.Location = new System.Drawing.Point(12, 298);
            this.lblawanser.Name = "lblawanser";
            this.lblawanser.Size = new System.Drawing.Size(150, 24);
            this.lblawanser.TabIndex = 5;
            this.lblawanser.Text = "Enter hight here:";
            // 
            // pic
            // 
            this.pic.Image = global::VolCylineder.Properties.Resources._220px_Cylinder_geometry_svg;
            this.pic.Location = new System.Drawing.Point(396, 12);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(220, 434);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic.TabIndex = 6;
            this.pic.TabStop = false;
            // 
            // VolOfCylinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 476);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.lblawanser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txthight);
            this.Controls.Add(this.txtradius);
            this.Controls.Add(this.btncal);
            this.Name = "VolOfCylinder";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncal;
        private System.Windows.Forms.TextBox txtradius;
        private System.Windows.Forms.TextBox txthight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblawanser;
        private System.Windows.Forms.PictureBox pic;
    }
}

