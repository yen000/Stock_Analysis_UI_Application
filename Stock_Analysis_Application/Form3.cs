using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Stock_Analysis_Application
{
    public partial class Form3 : Form
    {

        // UI-Control

        bool mov;
        int movX, movY;

        public Form3()
        {
            InitializeComponent();
        }


        private void Form3_Load(object sender, EventArgs e)
        {
            label1.Text = "Crawling...";
            background.Parent = this;

            background.SizeMode = PictureBoxSizeMode.StretchImage;
            background.Image = new Bitmap("background.png");
            background.BackColor = Color.Transparent;

            // UI-Conntrol

            this.FormBorderStyle = FormBorderStyle.None;
            Banner.Image = new Bitmap("Banner.png");
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            SetWindowRegion(sender, e);

            this.Refresh();

        }
        private void Form3_Activated(object sender, EventArgs e)
        {
            for(int i = 0; i < 60; i++)
            {
                if (i % 3 == 0)
                {
                    label1.Text = "Crawling.";
                }
                else if (i % 3 == 1)
                {
                    label1.Text = "Crawling..";
                }
                else
                {
                    label1.Text = "Crawling...";
                }

                label1.Refresh();
                Thread.Sleep(300);
            }
        }
        public void SetWindowRegion(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath FormPath;
            FormPath = new System.Drawing.Drawing2D.GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
            FormPath = GetRoundedRectPath(rect, 10);
            this.Region = new Region(FormPath);
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



    }
}
