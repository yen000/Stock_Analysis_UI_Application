using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Markup;
using System.Diagnostics;
using System.Drawing.Drawing2D;

namespace Stock_Analysis_Application
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        public string objective_name;
        public int objective_id;

        // UI-Control

        bool mov;
        int movX, movY;

        private void Form6_Load(object sender, EventArgs e)
        {
            box.Image = new Bitmap("package.png");
            box.SizeMode = PictureBoxSizeMode.StretchImage;
            box.BorderStyle = BorderStyle.None;
            box.AllowDrop = true;

            button_link.Image = new Bitmap("button.png");
            button_link.BackColor = Color.Transparent;
            button_link.FlatAppearance.BorderColor = Color.Gray;

            button_step.Image = new Bitmap("button.png");
            button_step.BackColor = Color.Transparent;
            button_step.FlatAppearance.BorderColor = Color.Gray;

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

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = new Bitmap("analysis.png");


            timer1.Interval = 1000;
            timer1.Enabled = false;

            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;

            line1.Visible = false;
            label9.Visible = false;
            label13.Visible = false;
            pictureBox_line.Visible = false;

            if (File.Exists("result_file.csv")) { File.Delete("result_file.csv"); }
            if (File.Exists("input_file.csv")) { File.Delete("input_file.csv"); }

        }
       

        private void Button_link_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://goodinfo.tw/StockInfo/index.asp");
        }

        private void Button_step_Click(object sender, EventArgs e)
        {
            Form7 step= new Form7();
            step.Visible = true;
        }

        private void Box_DragDrop(object sender, DragEventArgs e)
        {
            string[] filePaths = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            StreamReader original_file = new StreamReader(filePaths[0]);
            StreamWriter cloned_file = new StreamWriter("input_file.csv");

            string input = "";

            while ((input = original_file.ReadLine()) != null)
            {
                cloned_file.WriteLine(input);
            }

            original_file.Close();
            cloned_file.Close();

            Process.Start("C:\\Program Files\\R\\R-3.6.0\\bin\\Rscript.exe", "analysis.R");

            timer1.Enabled = true;

        }

        private void Box_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (File.Exists("result_file.csv"))
            {
                box.Visible = false;

                StreamReader result_file = new StreamReader("result_file.csv");

                string[] read_line = result_file.ReadLine().Split(',');

                for(int i = 0; i < read_line.Length; i++)
                {
                    read_line[i] = read_line[i].Trim('"');
                }

                label2.Text = "Validation(90%): " + read_line[2] + "(" + read_line[1] + ")";


                read_line = result_file.ReadLine().Split(',');

                for (int i = 0; i < read_line.Length; i++)
                {
                    read_line[i] = read_line[i].Trim('"');
                }

                label3.Text = read_line[0];
                label4.Text = read_line[1];
                label5.Text = read_line[2];


                read_line = result_file.ReadLine().Split(',');

                for (int i = 0; i < read_line.Length; i++)
                {
                    read_line[i] = read_line[i].Trim('"');
                }

                label6.Text = read_line[0];
                label7.Text = Math.Round(Double.Parse(read_line[1]), 2).ToString();
                label8.Text = Math.Round(Double.Parse(read_line[2]), 2).ToString();


                read_line = result_file.ReadLine().Split(',');

                for (int i = 0; i < read_line.Length; i++)
                {
                    read_line[i] = read_line[i].Trim('"');
                }

                label10.Text = read_line[0];
                label11.Text = Math.Round(Double.Parse(read_line[1]), 2).ToString();
                label12.Text = Math.Round(Double.Parse(read_line[2]), 2).ToString();


                read_line = result_file.ReadLine().Split(',');

                for (int i = 0; i < read_line.Length; i++)
                {
                    read_line[i] = read_line[i].Trim('"');
                }

                label14.Text = read_line[0];
                label15.Text = Math.Round(Double.Parse(read_line[1]), 2).ToString();
                label16.Text = Math.Round(Double.Parse(read_line[2]), 2).ToString();

                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label10.Visible = true;
                label11.Visible = true;
                label12.Visible = true;
                label14.Visible = true;
                label15.Visible = true;
                label16.Visible = true;

                line1.Visible = true;
                label9.Visible = true;
                label13.Visible = true;

                timer1.Enabled = false;

                pictureBox_line.Image= new Bitmap("outside_line.jpg");
                pictureBox_line.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox_line.Visible = true;

                result_file.Close();
            }
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
