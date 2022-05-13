namespace Stock_Analysis_Application
{
    partial class Form6
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.button_link = new System.Windows.Forms.Button();
            this.button_step = new System.Windows.Forms.Button();
            this.box = new System.Windows.Forms.PictureBox();
            this.window_maximize = new System.Windows.Forms.PictureBox();
            this.window_minimize = new System.Windows.Forms.PictureBox();
            this.window_exit = new System.Windows.Forms.PictureBox();
            this.Banner = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.line1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.pictureBox_line = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.window_maximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.window_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.window_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Banner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_line)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(77, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "股票漲跌預測";
            // 
            // button_link
            // 
            this.button_link.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_link.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_link.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_link.ForeColor = System.Drawing.Color.White;
            this.button_link.Location = new System.Drawing.Point(195, 351);
            this.button_link.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_link.Name = "button_link";
            this.button_link.Size = new System.Drawing.Size(125, 30);
            this.button_link.TabIndex = 1;
            this.button_link.Text = "台灣股市網";
            this.button_link.UseVisualStyleBackColor = true;
            this.button_link.Click += new System.EventHandler(this.Button_link_Click);
            // 
            // button_step
            // 
            this.button_step.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_step.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_step.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_step.ForeColor = System.Drawing.Color.White;
            this.button_step.Location = new System.Drawing.Point(327, 351);
            this.button_step.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_step.Name = "button_step";
            this.button_step.Size = new System.Drawing.Size(100, 30);
            this.button_step.TabIndex = 2;
            this.button_step.Text = "操作說明";
            this.button_step.UseVisualStyleBackColor = true;
            this.button_step.Click += new System.EventHandler(this.Button_step_Click);
            // 
            // box
            // 
            this.box.BackColor = System.Drawing.Color.White;
            this.box.Location = new System.Drawing.Point(35, 115);
            this.box.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.box.Name = "box";
            this.box.Size = new System.Drawing.Size(392, 218);
            this.box.TabIndex = 3;
            this.box.TabStop = false;
            this.box.DragDrop += new System.Windows.Forms.DragEventHandler(this.Box_DragDrop);
            this.box.DragEnter += new System.Windows.Forms.DragEventHandler(this.Box_DragEnter);
            // 
            // window_maximize
            // 
            this.window_maximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.window_maximize.Location = new System.Drawing.Point(59, 10);
            this.window_maximize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.window_maximize.Name = "window_maximize";
            this.window_maximize.Size = new System.Drawing.Size(19, 18);
            this.window_maximize.TabIndex = 14;
            this.window_maximize.TabStop = false;
            // 
            // window_minimize
            // 
            this.window_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.window_minimize.Location = new System.Drawing.Point(35, 10);
            this.window_minimize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.window_minimize.Name = "window_minimize";
            this.window_minimize.Size = new System.Drawing.Size(19, 18);
            this.window_minimize.TabIndex = 13;
            this.window_minimize.TabStop = false;
            this.window_minimize.Click += new System.EventHandler(this.window_minimize_Click);
            // 
            // window_exit
            // 
            this.window_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.window_exit.Location = new System.Drawing.Point(11, 10);
            this.window_exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.window_exit.Name = "window_exit";
            this.window_exit.Size = new System.Drawing.Size(19, 18);
            this.window_exit.TabIndex = 12;
            this.window_exit.TabStop = false;
            this.window_exit.Click += new System.EventHandler(this.window_exit_Click);
            // 
            // Banner
            // 
            this.Banner.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Banner.Location = new System.Drawing.Point(0, 0);
            this.Banner.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Banner.Name = "Banner";
            this.Banner.Size = new System.Drawing.Size(475, 35);
            this.Banner.TabIndex = 11;
            this.Banner.TabStop = false;
            this.Banner.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Banner_MouseDown);
            this.Banner.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Banner_MouseMove);
            this.Banner.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Banner_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(35, 58);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(57, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(57, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "label3";
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.White;
            this.line1.Location = new System.Drawing.Point(53, 182);
            this.line1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(355, 26);
            this.line1.TabIndex = 38;
            this.line1.Text = "-----------------------------------------------------------------------------";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(175, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 19);
            this.label4.TabIndex = 39;
            this.label4.Text = "label4";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(285, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 19);
            this.label5.TabIndex = 40;
            this.label5.Text = "label5";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(57, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 19);
            this.label6.TabIndex = 41;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(175, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 19);
            this.label7.TabIndex = 42;
            this.label7.Text = "label7";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(285, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 19);
            this.label8.TabIndex = 43;
            this.label8.Text = "label8";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(53, 224);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(355, 26);
            this.label9.TabIndex = 44;
            this.label9.Text = "-----------------------------------------------------------------------------";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(57, 248);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 19);
            this.label10.TabIndex = 45;
            this.label10.Text = "label10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(175, 248);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 19);
            this.label11.TabIndex = 46;
            this.label11.Text = "label11";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(285, 248);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 19);
            this.label12.TabIndex = 47;
            this.label12.Text = "label12";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(53, 265);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(355, 26);
            this.label13.TabIndex = 48;
            this.label13.Text = "-----------------------------------------------------------------------------";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label14.Location = new System.Drawing.Point(57, 288);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 19);
            this.label14.TabIndex = 49;
            this.label14.Text = "label14";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label15.Location = new System.Drawing.Point(175, 288);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 19);
            this.label15.TabIndex = 50;
            this.label15.Text = "label15";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label16.Location = new System.Drawing.Point(285, 288);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 19);
            this.label16.TabIndex = 51;
            this.label16.Text = "label16";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pictureBox_line
            // 
            this.pictureBox_line.BackColor = System.Drawing.Color.White;
            this.pictureBox_line.Location = new System.Drawing.Point(35, 115);
            this.pictureBox_line.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_line.Name = "pictureBox_line";
            this.pictureBox_line.Size = new System.Drawing.Size(392, 218);
            this.pictureBox_line.TabIndex = 52;
            this.pictureBox_line.TabStop = false;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 408);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.window_maximize);
            this.Controls.Add(this.window_minimize);
            this.Controls.Add(this.window_exit);
            this.Controls.Add(this.Banner);
            this.Controls.Add(this.box);
            this.Controls.Add(this.button_step);
            this.Controls.Add(this.button_link);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox_line);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.window_maximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.window_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.window_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Banner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_line)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_link;
        private System.Windows.Forms.Button button_step;
        private System.Windows.Forms.PictureBox box;
        private System.Windows.Forms.PictureBox window_maximize;
        private System.Windows.Forms.PictureBox window_minimize;
        private System.Windows.Forms.PictureBox window_exit;
        private System.Windows.Forms.PictureBox Banner;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label line1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox pictureBox_line;
    }
}