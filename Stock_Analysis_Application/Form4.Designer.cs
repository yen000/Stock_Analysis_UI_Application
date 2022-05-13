namespace Stock_Analysis_Application
{
    partial class Form4
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
            this.enterprise_name_radio_box4 = new System.Windows.Forms.RadioButton();
            this.enterprise_id_radio_box4 = new System.Windows.Forms.RadioButton();
            this.enterprise_name_cbo4 = new System.Windows.Forms.ComboBox();
            this.enterprise_id_cbo4 = new System.Windows.Forms.ComboBox();
            this.check_button4 = new System.Windows.Forms.Button();
            this.window_minimize = new System.Windows.Forms.PictureBox();
            this.window_exit = new System.Windows.Forms.PictureBox();
            this.Banner = new System.Windows.Forms.PictureBox();
            this.window_maximize = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.window_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.window_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Banner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.window_maximize)).BeginInit();
            this.SuspendLayout();
            // 
            // enterprise_name_radio_box4
            // 
            this.enterprise_name_radio_box4.AutoSize = true;
            this.enterprise_name_radio_box4.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.enterprise_name_radio_box4.Location = new System.Drawing.Point(39, 54);
            this.enterprise_name_radio_box4.Name = "enterprise_name_radio_box4";
            this.enterprise_name_radio_box4.Size = new System.Drawing.Size(74, 20);
            this.enterprise_name_radio_box4.TabIndex = 0;
            this.enterprise_name_radio_box4.TabStop = true;
            this.enterprise_name_radio_box4.Text = "公司名稱";
            this.enterprise_name_radio_box4.UseVisualStyleBackColor = true;
            this.enterprise_name_radio_box4.CheckedChanged += new System.EventHandler(this.Enterprise_name_radio_box4_CheckedChanged);
            // 
            // enterprise_id_radio_box4
            // 
            this.enterprise_id_radio_box4.AutoSize = true;
            this.enterprise_id_radio_box4.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.enterprise_id_radio_box4.Location = new System.Drawing.Point(39, 87);
            this.enterprise_id_radio_box4.Name = "enterprise_id_radio_box4";
            this.enterprise_id_radio_box4.Size = new System.Drawing.Size(74, 20);
            this.enterprise_id_radio_box4.TabIndex = 1;
            this.enterprise_id_radio_box4.TabStop = true;
            this.enterprise_id_radio_box4.Text = "股票代碼";
            this.enterprise_id_radio_box4.UseVisualStyleBackColor = true;
            this.enterprise_id_radio_box4.CheckedChanged += new System.EventHandler(this.Enterprise_id_radio_box4_CheckedChanged);
            // 
            // enterprise_name_cbo4
            // 
            this.enterprise_name_cbo4.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.enterprise_name_cbo4.FormattingEnabled = true;
            this.enterprise_name_cbo4.Location = new System.Drawing.Point(120, 53);
            this.enterprise_name_cbo4.Name = "enterprise_name_cbo4";
            this.enterprise_name_cbo4.Size = new System.Drawing.Size(92, 24);
            this.enterprise_name_cbo4.TabIndex = 2;
            this.enterprise_name_cbo4.TextChanged += new System.EventHandler(this.Enterprise_name_cbo4_TextChanged);
            // 
            // enterprise_id_cbo4
            // 
            this.enterprise_id_cbo4.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.enterprise_id_cbo4.FormattingEnabled = true;
            this.enterprise_id_cbo4.Location = new System.Drawing.Point(120, 86);
            this.enterprise_id_cbo4.Name = "enterprise_id_cbo4";
            this.enterprise_id_cbo4.Size = new System.Drawing.Size(92, 24);
            this.enterprise_id_cbo4.TabIndex = 3;
            this.enterprise_id_cbo4.TextChanged += new System.EventHandler(this.Enterprise_id_cbo4_TextChanged);
            // 
            // check_button4
            // 
            this.check_button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.check_button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.check_button4.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.check_button4.ForeColor = System.Drawing.Color.White;
            this.check_button4.Location = new System.Drawing.Point(97, 123);
            this.check_button4.Name = "check_button4";
            this.check_button4.Size = new System.Drawing.Size(56, 22);
            this.check_button4.TabIndex = 4;
            this.check_button4.Text = "確認";
            this.check_button4.UseVisualStyleBackColor = true;
            this.check_button4.Click += new System.EventHandler(this.Check_button4_Click);
            // 
            // window_minimize
            // 
            this.window_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.window_minimize.Location = new System.Drawing.Point(26, 8);
            this.window_minimize.Margin = new System.Windows.Forms.Padding(2);
            this.window_minimize.Name = "window_minimize";
            this.window_minimize.Size = new System.Drawing.Size(14, 14);
            this.window_minimize.TabIndex = 12;
            this.window_minimize.TabStop = false;
            this.window_minimize.Click += new System.EventHandler(this.window_minimize_Click);
            // 
            // window_exit
            // 
            this.window_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.window_exit.Location = new System.Drawing.Point(8, 8);
            this.window_exit.Margin = new System.Windows.Forms.Padding(2);
            this.window_exit.Name = "window_exit";
            this.window_exit.Size = new System.Drawing.Size(14, 14);
            this.window_exit.TabIndex = 11;
            this.window_exit.TabStop = false;
            this.window_exit.Click += new System.EventHandler(this.window_exit_Click);
            // 
            // Banner
            // 
            this.Banner.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Banner.Location = new System.Drawing.Point(0, 0);
            this.Banner.Margin = new System.Windows.Forms.Padding(2);
            this.Banner.Name = "Banner";
            this.Banner.Size = new System.Drawing.Size(250, 28);
            this.Banner.TabIndex = 10;
            this.Banner.TabStop = false;
            this.Banner.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Banner_MouseDown);
            this.Banner.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Banner_MouseMove);
            this.Banner.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Banner_MouseUp);
            // 
            // window_maximize
            // 
            this.window_maximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.window_maximize.Location = new System.Drawing.Point(44, 8);
            this.window_maximize.Margin = new System.Windows.Forms.Padding(2);
            this.window_maximize.Name = "window_maximize";
            this.window_maximize.Size = new System.Drawing.Size(14, 14);
            this.window_maximize.TabIndex = 13;
            this.window_maximize.TabStop = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(249, 162);
            this.Controls.Add(this.window_maximize);
            this.Controls.Add(this.window_minimize);
            this.Controls.Add(this.window_exit);
            this.Controls.Add(this.Banner);
            this.Controls.Add(this.check_button4);
            this.Controls.Add(this.enterprise_id_cbo4);
            this.Controls.Add(this.enterprise_name_cbo4);
            this.Controls.Add(this.enterprise_id_radio_box4);
            this.Controls.Add(this.enterprise_name_radio_box4);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.window_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.window_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Banner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.window_maximize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton enterprise_name_radio_box4;
        private System.Windows.Forms.RadioButton enterprise_id_radio_box4;
        private System.Windows.Forms.ComboBox enterprise_name_cbo4;
        private System.Windows.Forms.ComboBox enterprise_id_cbo4;
        private System.Windows.Forms.Button check_button4;
        private System.Windows.Forms.PictureBox window_minimize;
        private System.Windows.Forms.PictureBox window_exit;
        private System.Windows.Forms.PictureBox Banner;
        private System.Windows.Forms.PictureBox window_maximize;
    }
}