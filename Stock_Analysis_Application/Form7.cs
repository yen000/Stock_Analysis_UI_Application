using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_Analysis_Application
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        public int page = 1;
        
        // UI-Control

        bool mov;
        int movX, movY;
        private void Form7_Load(object sender, EventArgs e)
        {

            right.Image = new Bitmap("right.png");
            right.SizeMode = PictureBoxSizeMode.StretchImage;
            right.BorderStyle = BorderStyle.None;

            left.Image = new Bitmap("left.png");
            left.SizeMode = PictureBoxSizeMode.StretchImage;
            left.BorderStyle = BorderStyle.None;

            process.Image = new Bitmap("procedure.png");
            process.SizeMode = PictureBoxSizeMode.StretchImage;

            step1.Visible = false;
            step2.Visible = false;
            step3.Visible = false;
            step4.Visible = false;

            step.Text = "操作步驟" + page.ToString();
            step1.Text = "⮩ 請輸入股票名字或代碼";
            pictureBox1.Image = new Bitmap("step1.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.BorderStyle = BorderStyle.None;

            step1.Visible = true;
            pictureBox1.Visible = true;

            step2.Visible = false;
            pictureBox2.Visible = false;

            step3.Visible = false;
            pictureBox3.Visible = false;

            step4.Visible = false;
            pictureBox4.Visible = false;

            left.Visible = false;
            right.Visible = true;


            outside_line.Image = new Bitmap("outside_line.jpg");
            outside_line.SizeMode = PictureBoxSizeMode.StretchImage;
            outside_line.BorderStyle = BorderStyle.None;

            // UI-Conntrol

            this.FormBorderStyle = FormBorderStyle.None;
            Banner.Image = new Bitmap("Banner.png");
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            SetWindowRegion(sender, e);

            window_exit.Parent = Banner;
            window_exit.SizeMode = PictureBoxSizeMode.StretchImage;
            window_exit.BackColor = Color.Transparent;
            window_exit.Image = new Bitmap("window_exit.png");

            window_minimize.Parent = Banner;
            window_minimize.SizeMode = PictureBoxSizeMode.StretchImage;
            window_minimize.BackColor = Color.Transparent;
            window_minimize.Image = new Bitmap("window_minimize.png");

            window_maximize.Parent = Banner;
            window_maximize.SizeMode = PictureBoxSizeMode.StretchImage;
            window_maximize.BackColor = Color.Transparent;
            window_maximize.Image = new Bitmap("window_maximize.png");
        }

        private void Right_Click(object sender, EventArgs e)
        {
            page++;
           
            if (page == 1)
            {
                step.Text = "操作步驟" + page.ToString();
                step1.Text = "⮩ 請輸入股票名字或代碼";
                pictureBox1.Image = new Bitmap("step1.png");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.BorderStyle = BorderStyle.None;

                step1.Visible = true;
                pictureBox1.Visible = true;

                step2.Visible = false;
                pictureBox2.Visible = false;

                step3.Visible = false;
                pictureBox3.Visible = false;

                step4.Visible = false;
                pictureBox4.Visible = false;

                left.Visible = false;
                right.Visible = true;

            }
            if (page == 2)
            {
                step.Text = "操作步驟 " + page.ToString();
                step2.Text = "⮩ 在籌碼分析欄中點選法人買賣";
                pictureBox2.Image = new Bitmap("step2.png");
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox2.BorderStyle = BorderStyle.None;

                step1.Visible = false;
                pictureBox1.Visible = false;

                step2.Visible = true;
                pictureBox2.Visible = true;

                step3.Visible = false;
                pictureBox3.Visible = false;

                step4.Visible = false;
                pictureBox4.Visible = false;
                left.Visible = true;
                right.Visible = true;

            }
            if (page == 3)
            {
                step.Text = "操作步驟 " + page.ToString();
                step3.Text = "⮩ 可以選擇資料顯示範圍";
                pictureBox3.Image = new Bitmap("step3.png");
                pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox3.BorderStyle = BorderStyle.None;

                step1.Visible = false;
                pictureBox1.Visible = false;

                step2.Visible = false;
                pictureBox2.Visible = false;

                step3.Visible = true;
                pictureBox3.Visible = true;

                step4.Visible = false;
                pictureBox4.Visible = false;

                left.Visible = true;
                right.Visible = true;

            }
            if (page == 4)
            {
                step.Text = "操作步驟 " + page.ToString();
                step4.Text = "⮩ 匯出excel檔，並儲存為csv檔";
                pictureBox4.Image = new Bitmap("step4.png");
                pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox4.BorderStyle = BorderStyle.None;

                step1.Visible = false;
                pictureBox1.Visible = false;

                step2.Visible = false;
                pictureBox2.Visible = false;

                step3.Visible = false;
                pictureBox3.Visible = false;

                step4.Visible = true;
                pictureBox4.Visible = true;

                left.Visible = true;
                right.Visible = false;

            }

        }

        private void Left_Click(object sender, EventArgs e)
        {
            page--;
            step.Text = "以下為操作步驟" + page.ToString();

            if (page == 1)
            {
                step.Text = "操作步驟 " + page.ToString();
                step1.Text = "⮩ 請輸入股票名字或代碼";
                pictureBox1.Image = new Bitmap("step1.png");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.BorderStyle = BorderStyle.None;

                step1.Visible = true;
                pictureBox1.Visible = true;

                step2.Visible = false;
                pictureBox2.Visible = false;

                step3.Visible = false;
                pictureBox3.Visible = false;

                step4.Visible = false;
                pictureBox4.Visible = false;

                left.Visible = false;
                right.Visible = true;

            }
            if (page == 2)
            {
                step.Text = "操作步驟 " + page.ToString();
                step2.Text = "⮩ 在籌碼分析欄中點選法人買賣";
                pictureBox2.Image = new Bitmap("step2.png");
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox2.BorderStyle = BorderStyle.None;

                step1.Visible = false;
                pictureBox1.Visible = false;

                step2.Visible = true;
                pictureBox2.Visible = true;

                step3.Visible = false;
                pictureBox3.Visible = false;

                step4.Visible = false;
                pictureBox4.Visible = false;

                left.Visible = true;
                right.Visible = true;

            }
            if (page == 3)
            {
                step.Text = "操作步驟 " + page.ToString();
                step3.Text = "⮩ 可以選擇資料顯示範圍";
                pictureBox3.Image = new Bitmap("step3.png");
                pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox3.BorderStyle = BorderStyle.None;

                step1.Visible = false;
                pictureBox1.Visible = false;

                step2.Visible = false;
                pictureBox2.Visible = false;

                step3.Visible = true;
                pictureBox3.Visible = true;

                step4.Visible = false;
                pictureBox4.Visible = false;

                left.Visible = true;
                right.Visible = true;

            }
            if (page == 4)
            {
                step.Text = "操作步驟 " + page.ToString();
                step4.Text = "⮩ 匯出excel檔，並儲存為csv檔";
                pictureBox4.Image = new Bitmap("step4.png");
                pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox4.BorderStyle = BorderStyle.None;

                step1.Visible = false;
                pictureBox1.Visible = false;

                step2.Visible = false;
                pictureBox2.Visible = false;

                step3.Visible = false;
                pictureBox3.Visible = false;

                step4.Visible = true;
                pictureBox4.Visible = true;

                left.Visible = true;
                right.Visible = false;

            }
        }

        // UI-Control
        public void SetWindowRegion(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath FormPath;
            FormPath = new System.Drawing.Drawing2D.GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
            FormPath = GetRoundedRectPath(rect, 10);
            this.Region = new Region(FormPath);
        }
        private GraphicsPath GetRoundedRectPath(Rectangle rect, int radius)
        {
            int diameter = radius;
            Rectangle arcRect = new Rectangle(rect.Location, new Size(diameter, diameter));
            GraphicsPath path = new GraphicsPath();
            // 左上角
            path.AddArc(arcRect, 180, 90);
            // 右上角
            arcRect.X = rect.Right - diameter;
            path.AddArc(arcRect, 270, 90);
            // 右下角
            arcRect.Y = rect.Bottom - diameter;
            path.AddArc(arcRect, 0, 90);
            // 左下角
            arcRect.X = rect.Left;
            path.AddArc(arcRect, 90, 90);
            //閉合曲線
            path.CloseFigure();
            return path;
        }

        private void Banner_MouseDown(object sender, MouseEventArgs e)
        {
            mov = true; movX = e.X; movY = e.Y;
        }

        private void Banner_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == true)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void Banner_MouseUp(object sender, MouseEventArgs e)
        {
            mov = false;
        }

        private void window_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void window_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
