namespace Stock_Analysis_Application
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.Banner = new System.Windows.Forms.PictureBox();
            this.background = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Banner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(156, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Banner
            // 
            this.Banner.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Banner.Location = new System.Drawing.Point(-1, -1);
            this.Banner.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Banner.Name = "Banner";
            this.Banner.Size = new System.Drawing.Size(469, 35);
            this.Banner.TabIndex = 32;
            this.Banner.TabStop = false;
            this.Banner.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Banner_MouseDown);
            this.Banner.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Banner_MouseMove);
            this.Banner.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Banner_MouseUp);
            // 
            // background
            // 
            this.background.BackColor = System.Drawing.Color.Transparent;
            this.background.Location = new System.Drawing.Point(49, 55);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(364, 142);
            this.background.TabIndex = 33;
            this.background.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(468, 246);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.background);
            this.Controls.Add(this.Banner);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Activated += new System.EventHandler(this.Form3_Activated);
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Banner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Banner;
        private System.Windows.Forms.PictureBox background;
    }
}