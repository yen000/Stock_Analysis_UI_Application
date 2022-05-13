namespace Stock_Analysis_Application
{
    partial class Landing_page
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.enterprise_name_cbo = new System.Windows.Forms.ComboBox();
            this.enterprise_id_cbo = new System.Windows.Forms.ComboBox();
            this.enterprise_name_radio_box = new System.Windows.Forms.RadioButton();
            this.enterprise_id_radio_box = new System.Windows.Forms.RadioButton();
            this.check_button = new System.Windows.Forms.Button();
            this.Banner = new System.Windows.Forms.PictureBox();
            this.window_exit = new System.Windows.Forms.PictureBox();
            this.window_minimize = new System.Windows.Forms.PictureBox();
            this.window_maximize = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Banner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.window_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.window_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.window_maximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // enterprise_name_cbo
            // 
            this.enterprise_name_cbo.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.enterprise_name_cbo.FormattingEnabled = true;
            this.enterprise_name_cbo.Location = new System.Drawing.Point(160, 66);
            this.enterprise_name_cbo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enterprise_name_cbo.Name = "enterprise_name_cbo";
            this.enterprise_name_cbo.Size = new System.Drawing.Size(121, 27);
            this.enterprise_name_cbo.TabIndex = 0;
            this.enterprise_name_cbo.TextChanged += new System.EventHandler(this.enterprise_name_cbo_TextChanged);
            // 
            // enterprise_id_cbo
            // 
            this.enterprise_id_cbo.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.enterprise_id_cbo.FormattingEnabled = true;
            this.enterprise_id_cbo.Location = new System.Drawing.Point(160, 108);
            this.enterprise_id_cbo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enterprise_id_cbo.Name = "enterprise_id_cbo";
            this.enterprise_id_cbo.Size = new System.Drawing.Size(121, 27);
            this.enterprise_id_cbo.TabIndex = 3;
            this.enterprise_id_cbo.TextChanged += new System.EventHandler(this.enterprise_id_cbo_TextChanged);
            // 
            // enterprise_name_radio_box
            // 
            this.enterprise_name_radio_box.AutoSize = true;
            this.enterprise_name_radio_box.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.enterprise_name_radio_box.Location = new System.Drawing.Point(52, 68);
            this.enterprise_name_radio_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enterprise_name_radio_box.Name = "enterprise_name_radio_box";
            this.enterprise_name_radio_box.Size = new System.Drawing.Size(90, 23);
            this.enterprise_name_radio_box.TabIndex = 4;
            this.enterprise_name_radio_box.TabStop = true;
            this.enterprise_name_radio_box.Text = "公司名稱";
            this.enterprise_name_radio_box.UseVisualStyleBackColor = true;
            this.enterprise_name_radio_box.CheckedChanged += new System.EventHandler(this.enterprise_name_radio_box_CheckedChanged);
            // 
            // enterprise_id_radio_box
            // 
            this.enterprise_id_radio_box.AutoSize = true;
            this.enterprise_id_radio_box.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.enterprise_id_radio_box.Location = new System.Drawing.Point(52, 109);
            this.enterprise_id_radio_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enterprise_id_radio_box.Name = "enterprise_id_radio_box";
            this.enterprise_id_radio_box.Size = new System.Drawing.Size(90, 23);
            this.enterprise_id_radio_box.TabIndex = 5;
            this.enterprise_id_radio_box.TabStop = true;
            this.enterprise_id_radio_box.Text = "股票代碼";
            this.enterprise_id_radio_box.UseVisualStyleBackColor = true;
            this.enterprise_id_radio_box.CheckedChanged += new System.EventHandler(this.enterprise_id_radio_box_CheckedChanged);
            // 
            // check_button
            // 
            this.check_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.check_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.check_button.Font = new System.Drawing.Font("微軟正黑體", 8F);
            this.check_button.ForeColor = System.Drawing.Color.White;
            this.check_button.Location = new System.Drawing.Point(124, 152);
            this.check_button.Margin = new System.Windows.Forms.Padding(0);
            this.check_button.Name = "check_button";
            this.check_button.Size = new System.Drawing.Size(75, 28);
            this.check_button.TabIndex = 6;
            this.check_button.Text = "確認";
            this.check_button.UseVisualStyleBackColor = true;
            this.check_button.Click += new System.EventHandler(this.check_button_Click);
            // 
            // Banner
            // 
            this.Banner.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Banner.Location = new System.Drawing.Point(0, 0);
            this.Banner.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Banner.Name = "Banner";
            this.Banner.Size = new System.Drawing.Size(333, 35);
            this.Banner.TabIndex = 7;
            this.Banner.TabStop = false;
            this.Banner.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Banner_MouseDown);
            this.Banner.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Banner_MouseMove);
            this.Banner.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Banner_MouseUp);
            // 
            // window_exit
            // 
            this.window_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.window_exit.Location = new System.Drawing.Point(11, 10);
            this.window_exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.window_exit.Name = "window_exit";
            this.window_exit.Size = new System.Drawing.Size(19, 18);
            this.window_exit.TabIndex = 8;
            this.window_exit.TabStop = false;
            this.window_exit.Click += new System.EventHandler(this.window_exit_Click);
            // 
            // window_minimize
            // 
            this.window_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.window_minimize.Location = new System.Drawing.Point(35, 10);
            this.window_minimize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.window_minimize.Name = "window_minimize";
            this.window_minimize.Size = new System.Drawing.Size(19, 18);
            this.window_minimize.TabIndex = 9;
            this.window_minimize.TabStop = false;
            this.window_minimize.Click += new System.EventHandler(this.window_minimize_Click);
            // 
            // window_maximize
            // 
            this.window_maximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.window_maximize.Location = new System.Drawing.Point(59, 10);
            this.window_maximize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.window_maximize.Name = "window_maximize";
            this.window_maximize.Size = new System.Drawing.Size(19, 18);
            this.window_maximize.TabIndex = 10;
            this.window_maximize.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(333, 199);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // Landing_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(332, 202);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.window_maximize);
            this.Controls.Add(this.window_minimize);
            this.Controls.Add(this.window_exit);
            this.Controls.Add(this.Banner);
            this.Controls.Add(this.check_button);
            this.Controls.Add(this.enterprise_id_radio_box);
            this.Controls.Add(this.enterprise_name_radio_box);
            this.Controls.Add(this.enterprise_id_cbo);
            this.Controls.Add(this.enterprise_name_cbo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Landing_page";
            this.Text = "SAA";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Banner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.window_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.window_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.window_maximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox enterprise_name_cbo;
        private System.Windows.Forms.ComboBox enterprise_id_cbo;
        private System.Windows.Forms.RadioButton enterprise_name_radio_box;
        private System.Windows.Forms.RadioButton enterprise_id_radio_box;
        private System.Windows.Forms.PictureBox Banner;
        private System.Windows.Forms.PictureBox window_exit;
        private System.Windows.Forms.PictureBox window_minimize;
        private System.Windows.Forms.Button check_button;
        private System.Windows.Forms.PictureBox window_maximize;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

