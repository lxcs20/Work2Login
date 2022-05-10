namespace WindowsFormsAppWork2ABCcompny
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnSer1 = new System.Windows.Forms.Button();
            this.btnSer2 = new System.Windows.Forms.Button();
            this.btnSer3 = new System.Windows.Forms.Button();
            this.btnSer4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSer1
            // 
            this.btnSer1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSer1.BackgroundImage")));
            this.btnSer1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSer1.Location = new System.Drawing.Point(105, 186);
            this.btnSer1.Name = "btnSer1";
            this.btnSer1.Size = new System.Drawing.Size(255, 353);
            this.btnSer1.TabIndex = 0;
            this.btnSer1.Text = "1";
            this.btnSer1.UseVisualStyleBackColor = true;
            // 
            // btnSer2
            // 
            this.btnSer2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSer2.BackgroundImage")));
            this.btnSer2.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSer2.Location = new System.Drawing.Point(373, 186);
            this.btnSer2.Name = "btnSer2";
            this.btnSer2.Size = new System.Drawing.Size(255, 353);
            this.btnSer2.TabIndex = 1;
            this.btnSer2.Text = "2";
            this.btnSer2.UseVisualStyleBackColor = true;
            // 
            // btnSer3
            // 
            this.btnSer3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSer3.BackgroundImage")));
            this.btnSer3.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSer3.Location = new System.Drawing.Point(649, 186);
            this.btnSer3.Name = "btnSer3";
            this.btnSer3.Size = new System.Drawing.Size(255, 353);
            this.btnSer3.TabIndex = 2;
            this.btnSer3.Text = "3";
            this.btnSer3.UseVisualStyleBackColor = true;
            this.btnSer3.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSer4
            // 
            this.btnSer4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSer4.BackgroundImage")));
            this.btnSer4.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSer4.Location = new System.Drawing.Point(927, 186);
            this.btnSer4.Name = "btnSer4";
            this.btnSer4.Size = new System.Drawing.Size(255, 353);
            this.btnSer4.TabIndex = 3;
            this.btnSer4.Text = "4";
            this.btnSer4.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnSer4);
            this.Controls.Add(this.btnSer3);
            this.Controls.Add(this.btnSer2);
            this.Controls.Add(this.btnSer1);
            this.Name = "frmMain";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSer1;
        private System.Windows.Forms.Button btnSer2;
        private System.Windows.Forms.Button btnSer3;
        private System.Windows.Forms.Button btnSer4;
    }
}