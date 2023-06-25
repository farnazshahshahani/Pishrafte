namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.x = new System.Windows.Forms.Label();
            this.y = new System.Windows.Forms.Label();
            this.lblx = new System.Windows.Forms.Label();
            this.lbly = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // x
            // 
            this.x.AutoSize = true;
            this.x.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.x.Location = new System.Drawing.Point(202, 122);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(24, 22);
            this.x.TabIndex = 0;
            this.x.Text = "x:";
            this.x.FontChanged += new System.EventHandler(this.label1_Click);
            this.x.Click += new System.EventHandler(this.label1_Click);
            this.x.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // y
            // 
            this.y.AutoSize = true;
            this.y.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.y.Location = new System.Drawing.Point(202, 173);
            this.y.Name = "y";
            this.y.Size = new System.Drawing.Size(24, 22);
            this.y.TabIndex = 1;
            this.y.Text = "y:";
            this.y.Click += new System.EventHandler(this.lbly_Click);
            // 
            // lblx
            // 
            this.lblx.AutoSize = true;
            this.lblx.Location = new System.Drawing.Point(266, 129);
            this.lblx.Name = "lblx";
            this.lblx.Size = new System.Drawing.Size(0, 15);
            this.lblx.TabIndex = 2;
            this.lblx.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lbly
            // 
            this.lbly.AutoSize = true;
            this.lbly.Location = new System.Drawing.Point(266, 173);
            this.lbly.Name = "lbly";
            this.lbly.Size = new System.Drawing.Size(38, 15);
            this.lbly.TabIndex = 3;
            this.lbly.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbly);
            this.Controls.Add(this.lblx);
            this.Controls.Add(this.y);
            this.Controls.Add(this.x);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label x;
        private Label y;
        private Label lblx;
        private Label lbly;
    }
}